# Tugas PBO - Sistem Pengelolaan Rumah Sakit

Proyek ini dibuat menggunakan **C# (Visual Studio / .NET)** untuk memenuhi instruksi tugas PBO (Pemrograman Berorientasi Objek).

## Struktur File
- **`Program.cs`**: Berisi seluruh implementasi kelas dan method sesuai instruksi:
  - Kelas `Orang` (Base class dengan properti `Nama`, `Umur`, method `Aktivitas()`, `InfoOrang()`)
  - Kelas `Pasien` (Mewarisi `Orang`, properti `Keluhan`, method `CekKeluhan()`)
  - Kelas `PasienAnak` (Mewarisi `Pasien`, method `Menangis()`)
  - Kelas `PasienDewasa` (Mewarisi `Pasien`, method `Konsultasi()`)
  - Kelas `TenagaMedis` (Mewarisi `Orang`, properti `Spesialisasi`, method `CekSpesialis()`)
  - Kelas `Dokter` (Mewarisi `TenagaMedis`, method `Diagnosa()`)
  - Kelas `Perawat` (Mewarisi `TenagaMedis`, method `CekPasien()`)
  - Kelas `RumahSakit` (Koleksi `List<Orang>`, method `TambahOrang()`, `DaftarOrang()`)
  - Method `Main()`: Inisialisasi objek, penambahan ke rumah sakit, demonstrasi Polymorphism, dan pemanggilan method khusus.
- **`TASKPBO.csproj`**: File project Visual Studio (.NET).

## Cara Menjalankan

### Melalui Visual Studio:
1. Buka Visual Studio.
2. Pilih **Open a project or solution**.
3. Arahkan ke file [`TASKPBO.csproj`](file:///c:/Users/ASPIRE%205/OneDrive/Desktop/TASKPBO/TASKPBO.csproj).
4. Tekan **F5** atau klik tombol **Start**.

### Melalui Terminal / Command Prompt:
```bash
dotnet run
```
