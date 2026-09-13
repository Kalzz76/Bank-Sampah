using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using QRCoder;

namespace BankSampah
{
    public static class QRCodeHelper
    {
        // Standard ISO/IEC 18004 QR code generator backed by QRCoder
        public static Bitmap GenerateQrCodeBitmap(string text, int pixelSize, Color? darkColor = null)
        {
            try
            {
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.M);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Color fg = darkColor ?? Color.FromArgb(22, 38, 31);
                        int modules = qrCodeData.ModuleMatrix.Count;
                        int scale = Math.Max(2, pixelSize / (modules + 8));
                        Bitmap raw = qrCode.GetGraphic(scale, fg, Color.White, true);
                        if (raw.Width == pixelSize && raw.Height == pixelSize)
                        {
                            return raw;
                        }

                        // Resize to exact requested pixelSize with crisp pixels
                        Bitmap scaled = new Bitmap(pixelSize, pixelSize);
                        using (Graphics g = Graphics.FromImage(scaled))
                        {
                            g.InterpolationMode = InterpolationMode.NearestNeighbor;
                            g.PixelOffsetMode = PixelOffsetMode.Half;
                            g.DrawImage(raw, 0, 0, pixelSize, pixelSize);
                        }
                        raw.Dispose();
                        return scaled;
                    }
                }
            }
            catch
            {
                Bitmap fallback = new Bitmap(pixelSize, pixelSize);
                using (Graphics g = Graphics.FromImage(fallback))
                {
                    g.Clear(Color.White);
                    using (Font f = new Font("Segoe UI", 8F, FontStyle.Bold))
                    {
                        g.DrawString(text, f, Brushes.Black, 2, 2);
                    }
                }
                return fallback;
            }
        }

        // ==========================================
        // VIP DIGITAL MEMBER CARD RENDERER (KTA)
        // ==========================================
        public static Bitmap GenerateMemberCard(string nama, string kodeNasabah, string badge, decimal totalKg, decimal saldo, string fotoPath)
        {
            int cardW = 640;
            int cardH = 390;
            Bitmap card = new Bitmap(cardW, cardH);

            using (Graphics g = Graphics.FromImage(card))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                // 1. Background Gradient (Deep Forest Pine)
                using (LinearGradientBrush bgBrush = new LinearGradientBrush(
                    new Rectangle(0, 0, cardW, cardH),
                    Color.FromArgb(16, 32, 24),
                    Color.FromArgb(28, 56, 42),
                    45f))
                {
                    g.FillRectangle(bgBrush, 0, 0, cardW, cardH);
                }

                // Decorative wave arcs
                using (Pen decPen = new Pen(Color.FromArgb(30, 201, 151, 31), 1.5f))
                {
                    g.DrawEllipse(decPen, -100, -100, 450, 450);
                    g.DrawEllipse(decPen, 350, 150, 400, 400);
                }

                // Gold Accent Card Border
                using (Pen borderPen = new Pen(Color.FromArgb(201, 151, 31), 2.5f))
                {
                    g.DrawRectangle(borderPen, 1, 1, cardW - 3, cardH - 3);
                }

                // 2. Header Bar
                using (SolidBrush goldBrush = new SolidBrush(Color.FromArgb(201, 151, 31)))
                {
                    g.FillRectangle(goldBrush, 24, 22, 34, 34);
                }
                using (Font logoFont = new Font("Segoe UI", 13, FontStyle.Bold))
                using (SolidBrush darkBrush = new SolidBrush(Color.FromArgb(36, 26, 2)))
                {
                    g.DrawString("♻", logoFont, darkBrush, 28, 25);
                }

                using (Font h1Font = new Font("Segoe UI", 11F, FontStyle.Bold))
                using (SolidBrush wBrush = new SolidBrush(Color.White))
                {
                    g.DrawString("SIMBAS BANK SAMPAH", h1Font, wBrush, 66, 20);
                }
                using (Font h2Font = new Font("Segoe UI", 8F, FontStyle.Bold))
                using (SolidBrush goldText = new SolidBrush(Color.FromArgb(201, 151, 31)))
                {
                    g.DrawString("KARTU TANDA ANGGOTA (KTA) DIGITAL • RESMI", h2Font, goldText, 66, 38);
                }

                // Smart Chip graphic on right of header
                using (SolidBrush chipBrush = new SolidBrush(Color.FromArgb(218, 165, 32)))
                {
                    g.FillRectangle(chipBrush, cardW - 85, 24, 45, 32);
                }
                using (Pen chipLine = new Pen(Color.FromArgb(160, 120, 20), 1f))
                {
                    g.DrawRectangle(chipLine, cardW - 85, 24, 45, 32);
                    g.DrawLine(chipLine, cardW - 65, 24, cardW - 65, 56);
                    g.DrawLine(chipLine, cardW - 85, 40, cardW - 40, 40);
                }

                // 3. Member Avatar
                Image avatar = UIHelper.GetCircularAvatar(fotoPath, nama, 78);
                g.DrawImage(avatar, 26, 80, 78, 78);
                using (Pen avBorder = new Pen(Color.FromArgb(201, 151, 31), 2f))
                {
                    g.DrawEllipse(avBorder, 26, 80, 78, 78);
                }

                // 4. Member Info
                using (Font nameFont = new Font("Segoe UI", 14F, FontStyle.Bold))
                using (SolidBrush wBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(nama, nameFont, wBrush, 118, 80);
                }

                using (Font codeFont = new Font("Segoe UI", 10F, FontStyle.Bold))
                using (SolidBrush goldText = new SolidBrush(Color.FromArgb(201, 151, 31)))
                {
                    g.DrawString("NO. ANGGOTA: " + kodeNasabah, codeFont, goldText, 118, 108);
                }

                // Badge level pill
                using (SolidBrush pillBg = new SolidBrush(Color.FromArgb(42, 74, 56)))
                {
                    g.FillRectangle(pillBg, 118, 134, 230, 26);
                }
                using (Pen pillBorder = new Pen(Color.FromArgb(52, 211, 153), 1f))
                {
                    g.DrawRectangle(pillBorder, 118, 134, 230, 26);
                }
                using (Font badgeFont = new Font("Segoe UI", 8.5F, FontStyle.Bold))
                using (SolidBrush badgeBrush = new SolidBrush(Color.FromArgb(52, 211, 153)))
                {
                    g.DrawString(badge, badgeFont, badgeBrush, 126, 139);
                }

                // 5. Balance & Deposit Info Bar
                using (SolidBrush boxBg = new SolidBrush(Color.FromArgb(22, 42, 32)))
                {
                    g.FillRectangle(boxBg, 24, 180, 390, 75);
                }
                using (Pen boxBorder = new Pen(Color.FromArgb(45, 80, 60), 1f))
                {
                    g.DrawRectangle(boxBorder, 24, 180, 390, 75);
                }

                using (Font lblSmall = new Font("Segoe UI", 8F))
                using (SolidBrush mut = new SolidBrush(Color.FromArgb(170, 190, 180)))
                {
                    g.DrawString("SALDO TABUNGAN", lblSmall, mut, 36, 190);
                    g.DrawString("TOTAL SAMPAH TERKUMPUL", lblSmall, mut, 220, 190);
                }

                using (Font valFont = new Font("Segoe UI", 13F, FontStyle.Bold))
                using (SolidBrush wBrush = new SolidBrush(Color.White))
                {
                    g.DrawString(string.Format("Rp {0:N0}", saldo), valFont, wBrush, 36, 212);
                    g.DrawString(string.Format("{0:N2} kg", totalKg), valFont, wBrush, 220, 212);
                }

                // 6. QR Code Box (Right Side)
                int qrBoxX = 445;
                int qrBoxY = 80;
                int qrBoxSize = 170;

                using (SolidBrush qrBoxBg = new SolidBrush(Color.White))
                {
                    g.FillRectangle(qrBoxBg, qrBoxX, qrBoxY, qrBoxSize, qrBoxSize);
                }
                using (Pen qrBoxBorder = new Pen(Color.FromArgb(201, 151, 31), 2f))
                {
                    g.DrawRectangle(qrBoxBorder, qrBoxX, qrBoxY, qrBoxSize, qrBoxSize);
                }

                // Render QR code inside box
                Bitmap qrCodeBmp = GenerateQrCodeBitmap(kodeNasabah, 135);
                g.DrawImage(qrCodeBmp, qrBoxX + 17, qrBoxY + 10, 135, 135);

                using (Font qrLblFont = new Font("Segoe UI", 7.5F, FontStyle.Bold))
                using (SolidBrush darkBrush = new SolidBrush(Color.FromArgb(22, 38, 31)))
                {
                    string scanTxt = "SCAN UNTUK TRANSAKSI";
                    SizeF sf = g.MeasureString(scanTxt, qrLblFont);
                    g.DrawString(scanTxt, qrLblFont, darkBrush, qrBoxX + (qrBoxSize - sf.Width) / 2, qrBoxY + 148);
                }

                // 7. Footer Information
                using (Font footFont = new Font("Segoe UI", 7.5F))
                using (SolidBrush footBrush = new SolidBrush(Color.FromArgb(154, 176, 162)))
                {
                    g.DrawString("Tunjukkan kartu ini kepada petugas loket/armada untuk transaksi setor & tarik saldo.", footFont, footBrush, 24, 275);
                    g.DrawString("Diterbitkan resmi oleh Sistem Informasi Manajemen Bank Sampah (SIMBAS) • SMKN 13 Bandung", footFont, footBrush, 24, 292);
                }

                // Barcode simulation line at bottom
                using (Pen goldBar = new Pen(Color.FromArgb(201, 151, 31), 2f))
                {
                    g.DrawLine(goldBar, 24, 320, cardW - 24, 320);
                }

                using (Font serialFont = new Font("Segoe UI", 8F, FontStyle.Bold))
                using (SolidBrush goldText = new SolidBrush(Color.FromArgb(201, 151, 31)))
                {
                    g.DrawString("VALID DIGITALLY • AUTHENTICATED BY SSMS SQL SERVER", serialFont, goldText, 24, 335);
                    g.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), serialFont, goldText, cardW - 100, 335);
                }
            }

            return card;
        }
    }
}
