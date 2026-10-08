using System;
using System.Collections.Generic;

namespace TASKPBO
{
    // =========================================================================
    // 2.a & 3. KELAS BASE: Orang
    // =========================================================================
    public class Orang
    {
        // Properti nama dan umur
        public string Nama { get; set; }
        public int Umur { get; set; }

        public Orang(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        // 3.a & 4. Method Aktivitas() (virtual agar dapat di-override)
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang berada di lingkungan rumah sakit.");
        }

        // 3.b. Method InfoOrang()
        public virtual void InfoOrang()
        {
            Console.WriteLine($"[Orang] Nama: {Nama}, Umur: {Umur} tahun");
        }
    }

    // =========================================================================
    // 2.b. KELAS Pasien (Mewarisi Orang)
    // =========================================================================
    public class Pasien : Orang
    {
        // Properti tambahan keluhan
        public string Keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            Keluhan = keluhan;
        }

        // Method CekKeluhan()
        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan pasien {Nama}: {Keluhan}");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien {Nama} sedang menunggu giliran pemeriksaan.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Pasien] Nama: {Nama}, Umur: {Umur} tahun, Keluhan: {Keluhan}");
        }
    }

    // =========================================================================
    // 2.e. KELAS PasienAnak (Mewarisi Pasien)
    // =========================================================================
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {
        }

        // Method khusus: Menangis()
        public void Menangis()
        {
            Console.WriteLine($"Pasien anak {Nama} sedang menangis karena takut disuntik!");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien anak {Nama} sedang bermain di ruang bermain anak.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Pasien Anak] Nama: {Nama}, Umur: {Umur} tahun, Keluhan: {Keluhan}");
        }
    }

    // =========================================================================
    // 2.e. KELAS PasienDewasa (Mewarisi Pasien)
    // =========================================================================
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {
        }

        // Method khusus: Konsultasi()
        public void Konsultasi()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang berkonsultasi mengenai keluhan '{Keluhan}' dengan dokter.");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang membaca hasil rekam medis dan menunggu obat.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Pasien Dewasa] Nama: {Nama}, Umur: {Umur} tahun, Keluhan: {Keluhan}");
        }
    }

    // =========================================================================
    // 2.c. KELAS TenagaMedis (Mewarisi Orang)
    // =========================================================================
    public class TenagaMedis : Orang
    {
        // Properti tambahan spesialisasi
        public string Spesialisasi { get; set; }

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            Spesialisasi = spesialisasi;
        }

        // Method CekSpesialis()
        public void CekSpesialis()
        {
            Console.WriteLine($"Spesialisasi tenaga medis {Nama}: {Spesialisasi}");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Tenaga medis {Nama} sedang bertugas di unit {Spesialisasi}.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Tenaga Medis] Nama: {Nama}, Umur: {Umur} tahun, Spesialisasi: {Spesialisasi}");
        }
    }

    // =========================================================================
    // 2.d. KELAS Dokter (Mewarisi TenagaMedis)
    // =========================================================================
    public class Dokter : TenagaMedis
    {
        public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
        {
        }

        // Method khusus: Diagnosa()
        public void Diagnosa()
        {
            Console.WriteLine($"Dokter {Nama} spesialis {Spesialisasi} sedang mendiagnosa kondisi pasien.");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Dokter {Nama} sedang melakukan pemeriksaan pasien di ruang poli.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Dokter] Nama: {Nama}, Umur: {Umur} tahun, Spesialisasi: {Spesialisasi}");
        }
    }

    // =========================================================================
    // 2.d. KELAS Perawat (Mewarisi TenagaMedis)
    // =========================================================================
    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
        {
        }

        // Method khusus: CekPasien()
        public void CekPasien()
        {
            Console.WriteLine($"Perawat {Nama} sedang memeriksa tanda-tanda vital pasien (tensi, suhu tubuh).");
        }

        // 4. Override method Aktivitas()
        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat {Nama} sedang mengantar obat dan merawat pasien di ruang rawat.");
        }

        public override void InfoOrang()
        {
            Console.WriteLine($"[Perawat] Nama: {Nama}, Umur: {Umur} tahun, Spesialisasi: {Spesialisasi}");
        }
    }

    // =========================================================================
    // 2.f & 5. KELAS RumahSakit
    // =========================================================================
    public class RumahSakit
    {
        public string NamaRumahSakit { get; set; }
        // Koleksi Orang
        private List<Orang> koleksiOrang;

        public RumahSakit(string namaRumahSakit)
        {
            NamaRumahSakit = namaRumahSakit;
            koleksiOrang = new List<Orang>();
        }

        // 5.a. Method TambahOrang(Orang orang)
        public void TambahOrang(Orang orang)
        {
            koleksiOrang.Add(orang);
            Console.WriteLine($"> Berhasil menambahkan: {orang.Nama} ke {NamaRumahSakit}.");
        }

        // 5.b. Method DaftarOrang()
        public void DaftarOrang()
        {
            Console.WriteLine($"\n=======================================================");
            Console.WriteLine($"         DAFTAR ORANG DI {NamaRumahSakit.ToUpper()}");
            Console.WriteLine($"=======================================================");
            if (koleksiOrang.Count == 0)
            {
                Console.WriteLine("Belum ada data orang di rumah sakit.");
                return;
            }

            int nomor = 1;
            foreach (var orang in koleksiOrang)
            {
                Console.Write($"{nomor++}. ");
                orang.InfoOrang();
            }
            Console.WriteLine("=======================================================\n");
        }

        // Getter untuk demonstrasi polymorphism di Main()
        public List<Orang> GetKoleksiOrang()
        {
            return koleksiOrang;
        }
    }

    // =========================================================================
    // 6. METHOD Main()
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            // 6.a. Buat objek rumah sakit
            Console.WriteLine("--- 6.a Membuat Objek Rumah Sakit ---");
            RumahSakit rs = new RumahSakit("RS Medika Sejahtera");
            Console.WriteLine($"Objek {rs.NamaRumahSakit} berhasil dibuat.\n");

            // 6.b. Buat beberapa objek orang
            Console.WriteLine("--- 6.b Membuat Beberapa Objek Orang ---");
            Dokter dokter1 = new Dokter("dr. Andi Wicaksono, Sp.A", 40, "Spesialis Anak");
            Perawat perawat1 = new Perawat("Ns. Siti Rahma", 28, "Rawat Inap");
            PasienAnak pasienAnak1 = new PasienAnak("Kenzo", 6, "Demam tinggi dan batuk");
            PasienDewasa pasienDewasa1 = new PasienDewasa("Pak Budi Santoso", 48, "Nyeri dada dan hipertensi");
            Console.WriteLine("Semua objek (Dokter, Perawat, Pasien Anak, Pasien Dewasa) berhasil dibuat.\n");

            // 6.c. Tambahkan ke rumah sakit
            Console.WriteLine("--- 6.c Menambahkan Orang ke Rumah Sakit ---");
            rs.TambahOrang(dokter1);
            rs.TambahOrang(perawat1);
            rs.TambahOrang(pasienAnak1);
            rs.TambahOrang(pasienDewasa1);

            // 6.d. Tampilkan semua data
            Console.WriteLine("\n--- 6.d Menampilkan Semua Data ---");
            rs.DaftarOrang();

            // 6.e. Demonstrasikan polymorphism
            Console.WriteLine("--- 6.e Demonstrasi Polymorphism (Method Aktivitas()) ---");
            Console.WriteLine("Memanggil method Aktivitas() melalui referensi koleksi Orang:");
            foreach (Orang o in rs.GetKoleksiOrang())
            {
                // Dynamic dispatch / Polymorphism: memanggil override method sesuai jenis objek aslinya
                o.Aktivitas();
            }
            Console.WriteLine();

            // 6.f. Panggil method khusus masing-masing subclass
            Console.WriteLine("--- 6.f Memanggil Method Khusus ---");

            // Method khusus Dokter
            Console.WriteLine("[Dokter]");
            dokter1.Diagnosa();
            dokter1.CekSpesialis(); // Mewarisi dari TenagaMedis

            // Method khusus Perawat
            Console.WriteLine("\n[Perawat]");
            perawat1.CekPasien();
            perawat1.CekSpesialis(); // Mewarisi dari TenagaMedis

            // Method khusus PasienAnak
            Console.WriteLine("\n[Pasien Anak]");
            pasienAnak1.Menangis();
            pasienAnak1.CekKeluhan(); // Mewarisi dari Pasien

            // Method khusus PasienDewasa
            Console.WriteLine("\n[Pasien Dewasa]");
            pasienDewasa1.Konsultasi();
            pasienDewasa1.CekKeluhan(); // Mewarisi dari Pasien

            Console.WriteLine("\n=======================================================");
            Console.WriteLine("Program selesai dieksekusi. Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
