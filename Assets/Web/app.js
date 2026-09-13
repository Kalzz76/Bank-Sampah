/**
 * SIMBAS Warga - Client-Side App Logic
 * Connects directly to WargaWebServer REST APIs (SQL Server db_banksampah)
 */

(function () {
  'use strict';

  // API Base URL (relative or dynamic port)
  const API_BASE = window.location.origin;

  // App State
  let state = {
    currentNasabahId: null,
    nasabahList: [],
    profile: null,
    leaderboard: [],
    sampahList: [],
    pickups: [],
    transaksiList: [],
    selectedWasteChips: new Set(),
    activeFilter: 'all'
  };

  // DOM Elements Cache
  const el = {
    // Header
    headerAvatar: document.getElementById('headerAvatar'),
    headerNama: document.getElementById('headerNama'),
    headerKode: document.getElementById('headerKode'),
    btnOpenAccountModal: document.getElementById('btnOpenAccountModal'),
    accountModal: document.getElementById('accountModal'),
    btnCloseAccountModal: document.getElementById('btnCloseAccountModal'),
    modalNasabahList: document.getElementById('modalNasabahList'),

    // Home
    homeNamaUser: document.getElementById('homeNamaUser'),
    homeSaldo: document.getElementById('homeSaldo'),
    homeKodeNasabah: document.getElementById('homeKodeNasabah'),
    homeBadgeTitle: document.getElementById('homeBadgeTitle'),
    homeBadgeIcon: document.getElementById('homeBadgeIcon'),
    homeProgressDesc: document.getElementById('homeProgressDesc'),
    homeNextBadge: document.getElementById('homeNextBadge'),
    homeProgressFill: document.getElementById('homeProgressFill'),
    homeProgressHint: document.getElementById('homeProgressHint'),
    ecoCo2: document.getElementById('ecoCo2'),
    ecoTrees: document.getElementById('ecoTrees'),
    ecoEnergy: document.getElementById('ecoEnergy'),
    ecoWater: document.getElementById('ecoWater'),
    homeRecentList: document.getElementById('homeRecentList'),
    btnQuickJemput: document.getElementById('btnQuickJemput'),
    btnQuickPeringkat: document.getElementById('btnQuickPeringkat'),

    // Leaderboard
    myRankNum: document.getElementById('myRankNum'),
    myRankName: document.getElementById('myRankName'),
    myRankStat: document.getElementById('myRankStat'),
    myRankBadge: document.getElementById('myRankBadge'),
    p1Avatar: document.getElementById('p1Avatar'),
    p1Name: document.getElementById('p1Name'),
    p1Badge: document.getElementById('p1Badge'),
    p1Kg: document.getElementById('p1Kg'),
    p2Avatar: document.getElementById('p2Avatar'),
    p2Name: document.getElementById('p2Name'),
    p2Badge: document.getElementById('p2Badge'),
    p2Kg: document.getElementById('p2Kg'),
    p3Avatar: document.getElementById('p3Avatar'),
    p3Name: document.getElementById('p3Name'),
    p3Badge: document.getElementById('p3Badge'),
    p3Kg: document.getElementById('p3Kg'),
    leaderboardFullList: document.getElementById('leaderboardFullList'),
    leaderboardTotalCount: document.getElementById('leaderboardTotalCount'),

    // Jemput
    wasteChipsContainer: document.getElementById('wasteChipsContainer'),
    txtEstimasiKg: document.getElementById('txtEstimasiKg'),
    selWaktuJemput: document.getElementById('selWaktuJemput'),
    txtAlamatJemput: document.getElementById('txtAlamatJemput'),
    txtNoHpJemput: document.getElementById('txtNoHpJemput'),
    txtCatatanJemput: document.getElementById('txtCatatanJemput'),
    btnSubmitBooking: document.getElementById('btnSubmitBooking'),
    pickupMyList: document.getElementById('pickupMyList'),
    pickupBadgeCount: document.getElementById('pickupBadgeCount'),

    // Tabungan
    btnSubMutasi: document.getElementById('btnSubMutasi'),
    btnSubKatalog: document.getElementById('btnSubKatalog'),
    subpaneMutasi: document.getElementById('subpane-mutasi'),
    subpaneKatalog: document.getElementById('subpane-katalog'),
    transaksiList: document.getElementById('transaksiList'),
    katalogGrid: document.getElementById('katalogGrid'),

    // Toast
    appToast: document.getElementById('appToast')
  };

  // Helper Formatter Rupiah & Angka
  function formatRupiah(num) {
    return 'Rp ' + Number(num || 0).toLocaleString('id-ID');
  }

  function getInitials(name) {
    if (!name) return '??';
    const parts = name.trim().split(' ');
    if (parts.length >= 2) {
      return (parts[0][0] + parts[1][0]).toUpperCase();
    }
    return name.slice(0, 2).toUpperCase();
  }

  function showToast(message) {
    if (!el.appToast) return;
    el.appToast.textContent = message;
    el.appToast.classList.add('show');
    setTimeout(() => {
      el.appToast.classList.remove('show');
    }, 2800);
  }

  // Switch Tabs
  function setupNavigation() {
    const navItems = document.querySelectorAll('.nav-item');
    navItems.forEach(item => {
      item.addEventListener('click', () => {
        const targetTabId = item.getAttribute('data-tab');
        navItems.forEach(n => n.classList.remove('active'));
        item.classList.add('active');

        document.querySelectorAll('.tab-pane').forEach(pane => {
          pane.classList.remove('active');
        });
        const targetPane = document.getElementById(targetTabId);
        if (targetPane) targetPane.classList.add('active');

        window.scrollTo({ top: 0, behavior: 'smooth' });
      });
    });

    // Quick Actions on Home
    if (el.btnQuickJemput) {
      el.btnQuickJemput.addEventListener('click', () => {
        switchTab('tab-jemput');
      });
    }

    if (el.btnQuickPeringkat) {
      el.btnQuickPeringkat.addEventListener('click', () => {
        switchTab('tab-peringkat');
      });
    }

    // Sub-tab Tabungan vs Katalog
    if (el.btnSubMutasi && el.btnSubKatalog) {
      el.btnSubMutasi.addEventListener('click', () => {
        el.btnSubMutasi.classList.add('active');
        el.btnSubKatalog.classList.remove('active');
        el.subpaneMutasi.classList.add('active');
        el.subpaneKatalog.classList.remove('active');
      });

      el.btnSubKatalog.addEventListener('click', () => {
        el.btnSubKatalog.classList.add('active');
        el.btnSubMutasi.classList.remove('active');
        el.subpaneKatalog.classList.add('active');
        el.subpaneMutasi.classList.remove('active');
      });
    }

    // Filter Chips Mutasi
    document.querySelectorAll('.filter-chip').forEach(chip => {
      chip.addEventListener('click', () => {
        document.querySelectorAll('.filter-chip').forEach(c => c.classList.remove('active'));
        chip.classList.add('active');
        state.activeFilter = chip.getAttribute('data-filter');
        renderTransactions();
      });
    });

    // Account Switcher Modal
    if (el.btnOpenAccountModal) {
      el.btnOpenAccountModal.addEventListener('click', () => {
        renderAccountModal();
        el.accountModal.classList.add('show');
      });
    }

    if (el.btnCloseAccountModal) {
      el.btnCloseAccountModal.addEventListener('click', () => {
        el.accountModal.classList.remove('show');
      });
    }

    // Close modal on click outside
    window.addEventListener('click', (e) => {
      if (e.target === el.accountModal) {
        el.accountModal.classList.remove('show');
      }
    });

    // Booking Submit
    if (el.btnSubmitBooking) {
      el.btnSubmitBooking.addEventListener('click', handleBookingSubmit);
    }
  }

  function switchTab(tabId) {
    const navBtn = document.querySelector(`.nav-item[data-tab="${tabId}"]`);
    if (navBtn) navBtn.click();
  }

  // Fetch Nasabah List (Initial & Switcher)
  async function loadNasabahList() {
    try {
      const res = await fetch(`${API_BASE}/api/nasabah`);
      const json = await res.json();
      if (json.success && Array.isArray(json.data)) {
        state.nasabahList = json.data;

        // Tentukan nasabah aktif
        const savedId = localStorage.getItem('simbas_warga_id');
        let initialId = savedId ? parseInt(savedId, 10) : null;

        if (!initialId || !state.nasabahList.some(n => n.id_nasabah === initialId)) {
          if (state.nasabahList.length > 0) {
            initialId = state.nasabahList[0].id_nasabah;
          }
        }

        if (initialId) {
          switchNasabah(initialId);
        }
      }
    } catch (err) {
      console.error('Error fetching nasabah:', err);
    }
  }

  // Switch Nasabah
  function switchNasabah(id) {
    state.currentNasabahId = id;
    localStorage.setItem('simbas_warga_id', id);

    // Muat data spesifik nasabah
    loadProfile(id);
    loadLeaderboard();
    loadTransactions(id);
    loadPickups(id);
    loadSampahCatalog();

    if (el.accountModal) {
      el.accountModal.classList.remove('show');
    }
  }

  // Render Account Modal List
  function renderAccountModal() {
    if (!el.modalNasabahList) return;
    if (state.nasabahList.length === 0) {
      el.modalNasabahList.innerHTML = '<div class="empty-state">Tidak ada nasabah terdaftar di database.</div>';
      return;
    }

    let html = '';
    state.nasabahList.forEach(n => {
      const isSel = n.id_nasabah === state.currentNasabahId;
      const initials = getInitials(n.nama);
      html += `
        <div class="nasabah-option-card ${isSel ? 'selected' : ''}" data-id="${n.id_nasabah}">
          <div class="opt-left">
            <div class="opt-avatar">${initials}</div>
            <div>
              <div class="opt-name">${n.nama}</div>
              <div class="opt-code">${n.kode_nasabah} • ${formatRupiah(n.saldo)}</div>
            </div>
          </div>
          <div class="opt-badge">${n.badge}</div>
        </div>
      `;
    });

    el.modalNasabahList.innerHTML = html;

    // Attach click events
    el.modalNasabahList.querySelectorAll('.nasabah-option-card').forEach(card => {
      card.addEventListener('click', () => {
        const id = parseInt(card.getAttribute('data-id'), 10);
        switchNasabah(id);
        showToast('Berhasil beralih ke akun ' + card.querySelector('.opt-name').textContent);
      });
    });
  }

  // Load Profile & Eco-Impact
  async function loadProfile(id) {
    try {
      const res = await fetch(`${API_BASE}/api/profile?id=${id}`);
      const json = await res.json();
      if (json.success && json.data) {
        state.profile = json.data;
        renderProfileUI(json.data);
      }
    } catch (err) {
      console.error('Error loading profile:', err);
    }
  }

  function renderProfileUI(p) {
    const initials = getInitials(p.nama);

    // Header
    if (el.headerAvatar) el.headerAvatar.textContent = initials;
    if (el.headerNama) el.headerNama.textContent = p.nama;
    if (el.headerKode) el.headerKode.textContent = p.kode_nasabah;

    // Home
    if (el.homeNamaUser) el.homeNamaUser.textContent = p.nama + ' 👋';
    if (el.homeSaldo) el.homeSaldo.textContent = formatRupiah(p.saldo);
    if (el.homeKodeNasabah) el.homeKodeNasabah.textContent = p.kode_nasabah;

    // Badge Title & Icon
    let badgeIcon = '🌱';
    if (p.badge.includes('Pahlawan')) badgeIcon = '👑';
    else if (p.badge.includes('Hijau')) badgeIcon = '🌳';
    else if (p.badge.includes('Peduli')) badgeIcon = '🌿';

    if (el.homeBadgeTitle) el.homeBadgeTitle.textContent = p.badge;
    if (el.homeBadgeIcon) el.homeBadgeIcon.textContent = badgeIcon;

    // Progress Leveling
    if (el.homeProgressDesc) {
      el.homeProgressDesc.textContent = `Terkumpul ${Number(p.total_kg).toLocaleString('id-ID')} kg`;
    }
    if (el.homeNextBadge) {
      el.homeNextBadge.textContent = p.next_badge ? `Menuju: ${p.next_badge}` : 'Level Maksimal 👑';
    }
    if (el.homeProgressFill) {
      el.homeProgressFill.style.width = `${Math.min(100, Math.max(0, p.progress_pct))}%`;
    }
    if (el.homeProgressHint) {
      if (p.remaining_kg > 0) {
        el.homeProgressHint.textContent = `Kumpulkan ${p.remaining_kg} kg lagi untuk naik ke gelar ${p.next_badge}!`;
      } else {
        el.homeProgressHint.textContent = 'Luar biasa! Anda telah mencapai gelar kehormatan tertinggi!';
      }
    }

    // Eco Impact
    if (p.eco_impact) {
      if (el.ecoCo2) el.ecoCo2.textContent = `${p.eco_impact.co2e_kg} kg`;
      if (el.ecoTrees) el.ecoTrees.textContent = `${p.eco_impact.trees_saved}`;
      if (el.ecoEnergy) el.ecoEnergy.textContent = `${p.eco_impact.energy_kwh} kWh`;
      if (el.ecoWater) el.ecoWater.textContent = `${p.eco_impact.water_liter} L`;
    }

    // My Rank Banner on Leaderboard Tab
    if (el.myRankNum) el.myRankNum.textContent = `#${p.my_rank}`;
    if (el.myRankName) el.myRankName.textContent = p.nama;
    if (el.myRankStat) el.myRankStat.textContent = `${Number(p.total_kg).toLocaleString('id-ID')} kg • ${p.kode_nasabah}`;
    if (el.myRankBadge) el.myRankBadge.textContent = p.badge;

    // Pre-fill Jemput Form with Nasabah details
    if (el.txtAlamatJemput && !el.txtAlamatJemput.value) {
      el.txtAlamatJemput.value = p.alamat || '';
    }
    if (el.txtNoHpJemput && !el.txtNoHpJemput.value) {
      el.txtNoHpJemput.value = p.no_hp || '';
    }
  }

  // Load Leaderboard & Gelar Nasabah
  async function loadLeaderboard() {
    try {
      const res = await fetch(`${API_BASE}/api/leaderboard`);
      const json = await res.json();
      if (json.success && Array.isArray(json.data)) {
        state.leaderboard = json.data;
        renderLeaderboardUI(json.data);
      }
    } catch (err) {
      console.error('Error loading leaderboard:', err);
    }
  }

  function renderLeaderboardUI(lb) {
    if (el.leaderboardTotalCount) {
      el.leaderboardTotalCount.textContent = `${lb.length} Warga Aktif`;
    }

    // Podium 3 Besar
    const p1 = lb[0] || null;
    const p2 = lb[1] || null;
    const p3 = lb[2] || null;

    // Render Rank 1
    if (p1) {
      if (el.p1Name) el.p1Name.textContent = p1.nama;
      if (el.p1Avatar) el.p1Avatar.textContent = getInitials(p1.nama);
      if (el.p1Badge) el.p1Badge.textContent = p1.badge;
      if (el.p1Kg) el.p1Kg.textContent = `${Number(p1.total_berat).toLocaleString('id-ID')} kg`;
    }

    // Render Rank 2
    if (p2) {
      if (el.p2Name) el.p2Name.textContent = p2.nama;
      if (el.p2Avatar) el.p2Avatar.textContent = getInitials(p2.nama);
      if (el.p2Badge) el.p2Badge.textContent = p2.badge;
      if (el.p2Kg) el.p2Kg.textContent = `${Number(p2.total_berat).toLocaleString('id-ID')} kg`;
    }

    // Render Rank 3
    if (p3) {
      if (el.p3Name) el.p3Name.textContent = p3.nama;
      if (el.p3Avatar) el.p3Avatar.textContent = getInitials(p3.nama);
      if (el.p3Badge) el.p3Badge.textContent = p3.badge;
      if (el.p3Kg) el.p3Kg.textContent = `${Number(p3.total_berat).toLocaleString('id-ID')} kg`;
    }

    // Full List Rows
    if (!el.leaderboardFullList) return;
    if (lb.length === 0) {
      el.leaderboardFullList.innerHTML = '<div class="empty-state">Belum ada transaksi setoran yang tercatat.</div>';
      return;
    }

    let html = '';
    lb.forEach(row => {
      const isMe = row.id_nasabah === state.currentNasabahId;
      const initials = getInitials(row.nama);
      const medalOrRank = row.rank === 1 ? '🥇' : (row.rank === 2 ? '🥈' : (row.rank === 3 ? '🥉' : `#${row.rank}`));

      html += `
        <div class="lb-row ${isMe ? 'active-user' : ''}">
          <div class="lb-rank">${medalOrRank}</div>
          <div class="lb-avatar">${initials}</div>
          <div class="lb-info">
            <div class="lb-name">${row.nama} ${isMe ? '<span style="color:#10B981; font-size:10px;">(Anda)</span>' : ''}</div>
            <div class="lb-badge">${row.badge} • ${row.kode_nasabah}</div>
          </div>
          <div class="lb-stat">
            <div class="lb-kg">${Number(row.total_berat).toLocaleString('id-ID')} kg</div>
            <div class="lb-money">${formatRupiah(row.total_setoran)}</div>
          </div>
        </div>
      `;
    });

    el.leaderboardFullList.innerHTML = html;
  }

  // Load Waste Catalog (tb_sampah)
  async function loadSampahCatalog() {
    try {
      const res = await fetch(`${API_BASE}/api/sampah`);
      const json = await res.json();
      if (json.success && Array.isArray(json.data)) {
        state.sampahList = json.data;
        renderWasteChips(json.data);
        renderKatalogGrid(json.data);
      }
    } catch (err) {
      console.error('Error loading sampah:', err);
    }
  }

  function renderWasteChips(items) {
    if (!el.wasteChipsContainer) return;
    let html = '';
    items.forEach(item => {
      html += `
        <button type="button" class="waste-chip" data-name="${item.nama_sampah}">
          ${item.nama_sampah}
        </button>
      `;
    });
    el.wasteChipsContainer.innerHTML = html;

    // Attach click listeners for toggle selection
    el.wasteChipsContainer.querySelectorAll('.waste-chip').forEach(chip => {
      chip.addEventListener('click', () => {
        const name = chip.getAttribute('data-name');
        if (state.selectedWasteChips.has(name)) {
          state.selectedWasteChips.delete(name);
          chip.classList.remove('selected');
        } else {
          state.selectedWasteChips.add(name);
          chip.classList.add('selected');
        }
      });
    });
  }

  function renderKatalogGrid(items) {
    if (!el.katalogGrid) return;
    if (items.length === 0) {
      el.katalogGrid.innerHTML = '<div class="empty-state">Katalog komoditas kosong.</div>';
      return;
    }

    let html = '';
    items.forEach(it => {
      html += `
        <div class="katalog-card">
          <span class="katalog-tag">${it.kategori} • ${it.jenis_sampah}</span>
          <div class="katalog-nama">${it.nama_sampah}</div>
          <div class="katalog-harga">${formatRupiah(it.harga_per_kg)} <span class="katalog-unit">/kg</span></div>
        </div>
      `;
    });
    el.katalogGrid.innerHTML = html;
  }

  // Load Transactions
  async function loadTransactions(id) {
    try {
      const res = await fetch(`${API_BASE}/api/transaksi?id=${id}`);
      const json = await res.json();
      if (json.success && Array.isArray(json.data)) {
        state.transaksiList = json.data;
        renderTransactions();
        renderRecentActivity();
      }
    } catch (err) {
      console.error('Error loading transaksi:', err);
    }
  }

  function renderTransactions() {
    if (!el.transaksiList) return;
    let filtered = state.transaksiList;

    if (state.activeFilter !== 'all') {
      filtered = filtered.filter(t => t.jenis_transaksi === state.activeFilter);
    }

    if (filtered.length === 0) {
      el.transaksiList.innerHTML = '<div class="empty-state">Belum ada mutasi transaksi untuk kategori ini.</div>';
      return;
    }

    let html = '';
    filtered.forEach(t => {
      const isSetor = t.jenis_transaksi === 'Setor';
      const icon = isSetor ? '📦' : '💸';
      const sign = isSetor ? '+' : '-';
      const colorClass = isSetor ? 'plus' : 'minus';

      html += `
        <div class="activity-card">
          <div class="activity-left">
            <div class="activity-icon ${isSetor ? 'setor' : 'tarik'}">${icon}</div>
            <div class="activity-info">
              <h4>${isSetor ? (t.nama_sampah || 'Setor Sampah') : 'Tarik Tunai Saldo'}</h4>
              <p>${t.tanggal} ${isSetor && t.berat_kg > 0 ? `• ${t.berat_kg} kg` : ''}</p>
            </div>
          </div>
          <div class="activity-amount">
            <div class="amount-val ${colorClass}">${sign} ${formatRupiah(t.total_harga)}</div>
            <span style="font-size:10px; color:#64748B;">${t.kode_transaksi}</span>
          </div>
        </div>
      `;
    });

    el.transaksiList.innerHTML = html;
  }

  // Load Pickups (tb_penjemputan)
  async function loadPickups(id) {
    try {
      const res = await fetch(`${API_BASE}/api/penjemputan?id=${id}`);
      const json = await res.json();
      if (json.success && Array.isArray(json.data)) {
        state.pickups = json.data;
        renderPickupsUI(json.data);
        renderRecentActivity();
      }
    } catch (err) {
      console.error('Error loading pickups:', err);
    }
  }

  function renderPickupsUI(list) {
    if (el.pickupBadgeCount) {
      el.pickupBadgeCount.textContent = `${list.length} Pesanan`;
    }

    if (!el.pickupMyList) return;
    if (list.length === 0) {
      el.pickupMyList.innerHTML = '<div class="empty-state">Belum ada pemesanan penjemputan armada.</div>';
      return;
    }

    let html = '';
    list.forEach(p => {
      let statusClass = 'status-menunggu';
      if (p.status === 'Dalam Penjemputan') statusClass = 'status-jalan';
      else if (p.status === 'Selesai') statusClass = 'status-selesai';

      html += `
        <div class="pickup-card">
          <div class="pickup-header">
            <span class="pickup-code">${p.kode_booking}</span>
            <span class="pickup-status-badge ${statusClass}">${p.status}</span>
          </div>
          <div class="pickup-detail">
            <strong>Komoditas:</strong> ${p.estimasi_sampah} (${p.estimasi_berat} kg)<br>
            <strong>Jadwal:</strong> ${p.tanggal_jemput} • ${p.waktu_jemput}<br>
            <strong>Petugas:</strong> ${p.armada_petugas}<br>
            <strong>Alamat:</strong> ${p.alamat_jemput}
            ${p.catatan ? `<br><em>"${p.catatan}"</em>` : ''}
          </div>
        </div>
      `;
    });

    el.pickupMyList.innerHTML = html;
  }

  // Render Recent Activity on Home Tab
  function renderRecentActivity() {
    if (!el.homeRecentList) return;

    const activities = [];

    // Add recent pickups
    state.pickups.slice(0, 2).forEach(p => {
      activities.push({
        type: 'jemput',
        title: `Jemput Sampah: ${p.status}`,
        subtitle: `${p.tanggal_jemput} • ${p.estimasi_sampah}`,
        amount: `${p.estimasi_berat} kg`,
        color: 'jemput'
      });
    });

    // Add recent transactions
    state.transaksiList.slice(0, 3).forEach(t => {
      const isSetor = t.jenis_transaksi === 'Setor';
      activities.push({
        type: isSetor ? 'setor' : 'tarik',
        title: isSetor ? (t.nama_sampah || 'Setor Sampah') : 'Tarik Saldo',
        subtitle: `${t.tanggal} ${isSetor && t.berat_kg > 0 ? `• ${t.berat_kg} kg` : ''}`,
        amount: `${isSetor ? '+' : '-'} ${formatRupiah(t.total_harga)}`,
        color: isSetor ? 'plus' : 'minus'
      });
    });

    if (activities.length === 0) {
      el.homeRecentList.innerHTML = '<div class="empty-state">Belum ada aktivitas transaksi atau pemesanan.</div>';
      return;
    }

    let html = '';
    activities.slice(0, 4).forEach(act => {
      const icon = act.type === 'jemput' ? '🚚' : (act.type === 'setor' ? '📦' : '💸');
      html += `
        <div class="activity-card">
          <div class="activity-left">
            <div class="activity-icon ${act.type}">${icon}</div>
            <div class="activity-info">
              <h4>${act.title}</h4>
              <p>${act.subtitle}</p>
            </div>
          </div>
          <div class="activity-amount">
            <div class="amount-val ${act.color}">${act.amount}</div>
          </div>
        </div>
      `;
    });

    el.homeRecentList.innerHTML = html;
  }

  // Handle Booking Form Submit
  async function handleBookingSubmit(e) {
    e.preventDefault();

    if (!state.currentNasabahId) {
      showToast('Pilih akun nasabah terlebih dahulu.');
      return;
    }

    const berat = parseFloat(el.txtEstimasiKg.value);
    if (isNaN(berat) || berat <= 0) {
      showToast('Masukkan perkiraan berat sampah yang valid!');
      el.txtEstimasiKg.focus();
      return;
    }

    const alamat = el.txtAlamatJemput.value.trim();
    if (!alamat) {
      showToast('Alamat penjemputan harus diisi!');
      el.txtAlamatJemput.focus();
      return;
    }

    const noHp = el.txtNoHpJemput.value.trim();
    if (!noHp) {
      showToast('Nomor HP/WhatsApp harus diisi!');
      el.txtNoHpJemput.focus();
      return;
    }

    let sampahStr = Array.from(state.selectedWasteChips).join(', ');
    if (!sampahStr) {
      sampahStr = 'Sampah Campur Terpilah';
    }

    const payload = {
      id_nasabah: state.currentNasabahId,
      alamat: alamat,
      no_hp: noHp,
      waktu_jemput: el.selWaktuJemput.value,
      estimasi_sampah: sampahStr,
      estimasi_berat: berat,
      catatan: el.txtCatatanJemput.value.trim() || 'Booking mandiri via Portal Warga'
    };

    el.btnSubmitBooking.disabled = true;
    el.btnSubmitBooking.textContent = 'Mengirim Pesanan...';

    try {
      const res = await fetch(`${API_BASE}/api/penjemputan`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });

      const json = await res.json();
      if (json.success) {
        showToast('Pesanan Berhasil! Kode: ' + json.kode_booking);
        // Reset form fields
        el.txtEstimasiKg.value = '';
        el.txtCatatanJemput.value = '';
        state.selectedWasteChips.clear();
        document.querySelectorAll('.waste-chip').forEach(c => c.classList.remove('selected'));

        // Refresh pickups
        await loadPickups(state.currentNasabahId);
      } else {
        showToast('Gagal: ' + (json.message || 'Terjadi kesalahan'));
      }
    } catch (err) {
      console.error('Error booking penjemputan:', err);
      showToast('Gagal terhubung ke server');
    } finally {
      el.btnSubmitBooking.disabled = false;
      el.btnSubmitBooking.textContent = '🚀 Kirim Pesanan Penjemputan';
    }
  }

  // Auto-refresh timer (every 15s to sync with desktop app)
  function startAutoRefresh() {
    setInterval(() => {
      if (state.currentNasabahId) {
        loadProfile(state.currentNasabahId);
        loadLeaderboard();
        loadPickups(state.currentNasabahId);
      }
    }, 15000);
  }

  // Initial Boot
  function init() {
    setupNavigation();
    loadNasabahList();
    startAutoRefresh();
  }

  // Run when DOM ready
  if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', init);
  } else {
    init();
  }
})();
