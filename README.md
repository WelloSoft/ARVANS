# ARVANS
ARVANS - Automated Removal of Virus and Nasty-Script for Windows

ARVANS adalah Anti-virus sederhana yang berjalan secara independen, ringan dan tanpa akses Resource PC yang berlebihan.
Tidak seperti Antivirus lainnya, ARVANS tidak mempunyai fitur Scan ataupun Update, karena fungsi Utama dari antivirus ini adalah melihat sekilas Aplikasi yang berjalan dan ancaman keamanan dari setiap Flashdisk/Device External yang sering dialami oleh Pengguna.

---

# Cara penggunaan
[Download aplikasinya](https://github.com/WelloSoft/ARVANS/raw/build/ARVANS.exe) melalui Branch Build di repository ini, lalu buka aplikasinya untuk memulainya secara langsung. Versi saat ini adalah versi Portable, sehingga tidak butuh install kedalam program sistem.

# Fungsi Utama ARVANS
### Pindai Aplikasi yang mempunyai Ciri-ciri yang Mencurigakan
Ciri-ciri Aplikasi yang akan dideteksi oleh ANVANS diantaranya:
- Tersembunyi
- Mempunyai Extensi yang aneh (selain \*.exe)
- Memuat Script \*.vbe dan \*.vbs

### Pindai dan Perbaiki Kerentanan Konten Flashdisk/Device External
Hal-hal yang akan dilakukan ARVANS ketika Device External dimasukkan :
- Cek dan hapus file *autorun.inf*
- Cek dan hapus shortcuts di root device
- Cek dan perbaiki File & Folder tersembunyi di root device
- Cek dan hapus file \*.vbs dan \*.vbe (script external) di root device

---


# Rencana Kedepan
ARVANS akan direncanakan untuk selalu dikembangkan hingga mencapai beberapa target berikut:
- Menghapus Aplikasi mencurigakan yang selalu aktif di Windows
- Meng-Internasionalisasi Aplikasi agar dapat digunakan secara global
- Bisa berjalan otomatis tanpa mengaktifkan aplikasi secara Manual
- Mempunyai Penataan Script yang mudah dimengerti oleh setiap Programmer

# Kontribusi
** Siapapun dapat Membantu mengembangkan Aplikasi ini **
### Jika anda adalah Developer
Antivirus ARVANS dibuat berdasarkan bahasa C#, platform .NET dan Software Engine *Visual Studio 2015*. Anda dapat Fork project ini, Clone, Edit, Commit, lalu gunakan Pull Request diatas untuk menerapkan kontribusi anda diproject ini. Kami akan meninjau secara positif setiap perubahan kode yang anda berikan pada kami.

### Jika anda bukan Developer (Namun Terdaftar di GitHub)
Anda dapat memfavoritkan (Star) project ini, atau berikan saran melalui Tab Issues. Kami akan mencoba untuk merespon secara cepat. Anda juga dapat membagikan project ini pada orang lain untuk menambah komunitas pengguna ARVANS

# Lisensi
ARVANS dirilis dengan lisensi Apache 2.0. Lihat file LICENSE untuk lebih lanjut.

# Catatan Rilis
ARVANS adalah bagian dari Projek Hobi, dan pengembangannya sudah dimulai sejak tahun 2015 hingga saat ini.

#### V1.0 - 7/2/2017 - Rilis Pertama
- Pertama kali ARVANS (Sebelumnya VBEBlock) dirilis secara open-source




