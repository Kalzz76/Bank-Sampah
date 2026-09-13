using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BankSampah
{
    public partial class FormVideoPlayer : Form
    {
        private string currentVideoPath = "";

        public FormVideoPlayer()
        {
            InitializeComponent();
        }

        private void FormVideoPlayer_Load(object sender, EventArgs e)
        {
            UIHelper.MakeRounded(this, 16);
            UIHelper.MakeRounded(btnClose, 8);
            UIHelper.MakeRounded(btnChooseVideo, 8);
            UIHelper.MakeRounded(btnDeleteVideo, 8);

            EnsureVideoFolder();
            LoadDefaultVideo();
        }

        private void EnsureVideoFolder()
        {
            string dir = Path.Combine(Application.StartupPath, "Assets", "Video");
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
        }

        private void LoadDefaultVideo()
        {
            string dir = Path.Combine(Application.StartupPath, "Assets", "Video");
            string[] files = Directory.GetFiles(dir, "*.mp4");

            if (files.Length > 0)
            {
                PlayVideo(files[0]);
            }
            else
            {
                RenderNoVideoHtml();
            }
        }

        private void PlayVideo(string filePath)
        {
            try
            {
                currentVideoPath = filePath;
                string videoFileName = Path.GetFileName(filePath);
                lblVideoStatus.Text = "STATUS: MEMUTAR " + videoFileName;

                string html = string.Format(@"<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8' />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <style>
        * {{ box-sizing: border-box; margin: 0; padding: 0; }}
        body {{ background-color: #090d16; color: #ffffff; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; display: flex; flex-direction: column; align-items: center; justify-content: center; height: 100vh; overflow: hidden; }}
        video {{ width: 94%; max-height: 78vh; border-radius: 12px; box-shadow: 0 20px 40px rgba(0,0,0,0.8); border: 2px solid #10b981; }}
        .info {{ margin-top: 12px; font-size: 14px; color: #10b981; font-weight: bold; text-align: center; }}
        .subtext {{ font-size: 12px; color: #94a3b8; font-weight: normal; margin-top: 4px; }}
    </style>
</head>
<body>
    <video controls autoplay loop src='file:///{0}'></video>
    <div class='info'>PEMUTAR VIDEO MULTIMEDIA - BANK SAMPAH DIGITAL</div>
    <div class='subtext'>Judul Video: {1}</div>
</body>
</html>", filePath.Replace("\\", "/"), videoFileName);

                string tempHtmlPath = Path.Combine(Application.StartupPath, "Assets", "Video", "player.html");
                File.WriteAllText(tempHtmlPath, html, Encoding.UTF8);
                webBrowser.Navigate(tempHtmlPath);
                btnDeleteVideo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat video: " + ex.Message, "Error Video", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderNoVideoHtml()
        {
            currentVideoPath = "";
            lblVideoStatus.Text = "BELUM ADA VIDEO TUTORIAL / PROFIL";
            btnDeleteVideo.Enabled = false;

            string html = @"<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8' />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <style>
        body { background-color: #0f172a; color: #ffffff; font-family: 'Segoe UI', sans-serif; display: flex; flex-direction: column; align-items: center; justify-content: center; height: 100vh; text-align: center; margin: 0; padding: 0; }
        .card { background: #1e293b; padding: 36px 40px; border-radius: 16px; border: 1px solid #334155; max-width: 520px; box-shadow: 0 10px 30px rgba(0,0,0,0.5); }
        h2 { color: #10b981; margin-bottom: 14px; font-size: 20px; }
        p { color: #cbd5e1; line-height: 1.6; margin-bottom: 24px; font-size: 14px; }
        .badge { background: #064e3b; color: #6ee7b7; padding: 8px 18px; border-radius: 20px; font-weight: bold; font-size: 13px; display: inline-block; border: 1px solid #10b981; }
    </style>
</head>
<body>
    <div class='card'>
        <h2>Pemutar Video Multimedia</h2>
        <p>Belum ada file video MP4 di folder <b>Assets/Video/</b>.<br><br>Klik tombol <b>'UPLOAD / GANTI VIDEO'</b> di bawah untuk mengunggah video tutorial atau profil Bank Sampah dari komputer Anda!</p>
        <span class='badge'>Status: Siap Menerima Video (.MP4 / .WEBM)</span>
    </div>
</body>
</html>";

            string tempHtmlPath = Path.Combine(Application.StartupPath, "Assets", "Video", "player.html");
            File.WriteAllText(tempHtmlPath, html, Encoding.UTF8);
            webBrowser.Navigate(tempHtmlPath);
        }

        private void btnChooseVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Video Files (*.mp4; *.webm)|*.mp4;*.webm";
                ofd.Title = "Pilih Video Tutorial Bank Sampah";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string dir = Path.Combine(Application.StartupPath, "Assets", "Video");
                        if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                        // Hapus file video lama di folder
                        string[] oldFiles = Directory.GetFiles(dir, "*.mp4");
                        foreach (string old in oldFiles)
                        {
                            try { File.Delete(old); } catch { }
                        }

                        string safeFileName = Path.GetFileName(ofd.FileName);
                        string targetPath = Path.Combine(dir, safeFileName);
                        File.Copy(ofd.FileName, targetPath, true);

                        PlayVideo(targetPath);
                        SoundHelper.PlaySaveSound();
                        MessageBox.Show("Video Berhasil Diunggah & Dimuat di Pemutar Aplikasi!", "Sukses Upload Video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        SoundHelper.PlayAlertSound();
                        MessageBox.Show("Gagal mengunggah video: " + ex.Message, "Error Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteVideo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentVideoPath) || !File.Exists(currentVideoPath))
            {
                MessageBox.Show("Tidak ada video yang dapat dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus video tutorial saat ini secara permanen?", "Konfirmasi Hapus Video", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string fileToDelete = currentVideoPath;
                    RenderNoVideoHtml(); // Alihkan WebBrowser ke halaman kosong agar file tidak terikat handle

                    if (!string.IsNullOrEmpty(fileToDelete) && File.Exists(fileToDelete))
                    {
                        File.Delete(fileToDelete);
                    }

                    // Juga bersihkan file video mp4 lainnya jika ada
                    string dir = Path.Combine(Application.StartupPath, "Assets", "Video");
                    if (Directory.Exists(dir))
                    {
                        string[] files = Directory.GetFiles(dir, "*.mp4");
                        foreach (string f in files)
                        {
                            try { File.Delete(f); } catch { }
                        }
                    }

                    SoundHelper.PlaySaveSound();
                    MessageBox.Show("Video Berhasil Dihapus Permanen dari Sistem!", "Sukses Hapus Video", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    SoundHelper.PlayAlertSound();
                    MessageBox.Show("Gagal menghapus file video: " + ex.Message, "Error Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
