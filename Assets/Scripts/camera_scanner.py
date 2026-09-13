# -*- coding: utf-8 -*-
"""
SIMBAS - Modul Scanner Kamera & Gambar KTA Nasabah
Digunakan oleh FormPortalPetugas untuk membaca Barcode/QR Code via Webcam atau File Gambar.
"""

import sys
import os
import time

def scan_from_file(image_path):
    try:
        import cv2
    except ImportError:
        print("ERROR:Modul OpenCV (cv2) belum terpasang di Python.", flush=True)
        return

    if not os.path.exists(image_path):
        print(f"ERROR:File tidak ditemukan: {image_path}", flush=True)
        return

    img = cv2.imread(image_path)
    if img is None:
        print(f"ERROR:Gagal membaca format gambar: {image_path}", flush=True)
        return

    detector = cv2.QRCodeDetector()
    val, bbox, _ = detector.detectAndDecode(img)
    if val and val.strip():
        print(f"RESULT:{val.strip()}", flush=True)
    else:
        # Coba perbesar jika gambar kecil atau resolusi tinggi
        gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
        val2, _, _ = detector.detectAndDecode(gray)
        if val2 and val2.strip():
            print(f"RESULT:{val2.strip()}", flush=True)
        else:
            print("ERROR:Tidak ditemukan QR Code yang valid pada gambar tersebut.", flush=True)

def scan_from_webcam(camera_index=0):
    try:
        import cv2
    except ImportError:
        print("ERROR:Modul OpenCV (cv2) belum terpasang di Python.", flush=True)
        return

    cap = cv2.VideoCapture(camera_index)
    if not cap.isOpened():
        print("ERROR_NO_CAMERA:Kamera webcam tidak terdeteksi atau sedang digunakan aplikasi lain.", flush=True)
        return

    # Atur resolusi kamera
    cap.set(cv2.CAP_PROP_FRAME_WIDTH, 640)
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 480)

    detector = cv2.QRCodeDetector()
    window_name = "SIMBAS - Scanner QR KTA Nasabah (Tekan ESC untuk Batal)"
    cv2.namedWindow(window_name, cv2.WINDOW_AUTOSIZE)

    start_time = time.time()
    found_code = None

    while True:
        ret, frame = cap.read()
        if not ret:
            break

        # Mirror tampilan agar natural bagi pengguna
        frame = cv2.flip(frame, 1)
        h, w = frame.shape[:2]

        # Coba deteksi QR Code
        data, bbox, _ = detector.detectAndDecode(frame)
        if data and data.strip():
            found_code = data.strip()
            # Gambar kotak hijau penanda sukses
            if bbox is not None and len(bbox) > 0:
                pts = bbox.astype(int).reshape((-1, 1, 2))
                cv2.polylines(frame, [pts], True, (0, 255, 0), 4)

            cv2.rectangle(frame, (0, 0), (w, 60), (22, 38, 31), -1)
            cv2.putText(frame, f"KTA TERDETEKSI: {found_code}", (20, 40),
                        cv2.FONT_HERSHEY_SIMPLEX, 0.85, (0, 255, 120), 2)
            cv2.imshow(window_name, frame)
            cv2.waitKey(400)
            break

        # Gambar Bingkai Viewfinder Pemindaian
        box_size = int(min(h, w) * 0.65)
        x1 = (w - box_size) // 2
        y1 = (h - box_size) // 2
        x2 = x1 + box_size
        y2 = y1 + box_size

        # Sudut siku-siku (Corner Accents)
        col = (59, 122, 94)  # Forest Green
        thick = 3
        clen = 28

        # Sudut kiri atas
        cv2.line(frame, (x1, y1), (x1 + clen, y1), col, thick)
        cv2.line(frame, (x1, y1), (x1, y1 + clen), col, thick)
        # Sudut kanan atas
        cv2.line(frame, (x2, y1), (x2 - clen, y1), col, thick)
        cv2.line(frame, (x2, y1), (x2, y1 + clen), col, thick)
        # Sudut kiri bawah
        cv2.line(frame, (x1, y2), (x1 + clen, y2), col, thick)
        cv2.line(frame, (x1, y2), (x1, y2 - clen), col, thick)
        # Sudut kanan bawah
        cv2.line(frame, (x2, y2), (x2 - clen, y2), col, thick)
        cv2.line(frame, (x2, y2), (x2, y2 - clen), col, thick)

        # Animasi Garis Laser Pemindai (Scan Line)
        elapsed = time.time() - start_time
        laser_y = int(y1 + ((elapsed * 160) % box_size))
        cv2.line(frame, (x1 + 6, laser_y), (x2 - 6, laser_y), (0, 230, 115), 2)

        # Header Info Petugas
        cv2.rectangle(frame, (0, 0), (w, 42), (22, 38, 31), -1)
        cv2.putText(frame, "SIMBAS SCANNER - Arahkan QR KTA ke Kotak", (16, 28),
                    cv2.FONT_HERSHEY_SIMPLEX, 0.6, (255, 255, 255), 1)

        # Petunjuk di bawah
        cv2.rectangle(frame, (0, h - 35), (w, h), (22, 38, 31), -1)
        cv2.putText(frame, "Tekan ESC atau 'Q' untuk membatalkan", (16, h - 12),
                    cv2.FONT_HERSHEY_SIMPLEX, 0.5, (200, 210, 205), 1)

        cv2.imshow(window_name, frame)
        key = cv2.waitKey(25) & 0xFF
        if key == 27 or key == ord('q') or key == ord('Q'):
            break

    cap.release()
    cv2.destroyAllWindows()

    if found_code:
        print(f"RESULT:{found_code}", flush=True)
    else:
        print("CANCELLED", flush=True)

if __name__ == "__main__":
    if len(sys.argv) > 2 and sys.argv[1] == "--file":
        scan_from_file(sys.argv[2])
    else:
        scan_from_webcam()
