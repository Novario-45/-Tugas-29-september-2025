using System;

namespace HitungNilai
{
    class Hitungan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("      PREVALUASI KELULUSAN TEKNIK MESIN ITS       ");
            Console.WriteLine("==================================================");

            Console.WriteLine("---JALUR 1: Seleksi Prestasi---");

            Console.WriteLine("---Nilai Matematika---");
            double NilaiMTK = 85;
            Console.WriteLine(NilaiMTK);

            Console.WriteLine("---Nilai Bahasa Ingris---");
            double NilaiBing = 85;
            Console.WriteLine(NilaiBing);
            Console.WriteLine("---Nilai Mata Pelajaran Pilihan---");
            double NilaiPil = 80;
            Console.WriteLine(NilaiPil);

            double TotalTKA = NilaiMTK + NilaiBing + NilaiPil;
            Console.WriteLine($"\nTotal Nilai TKA Anda: {TotalTKA}  (Min. 280)");

            if (TotalTKA >= 280)
            {
                Console.WriteLine("Selamat Anda Diterima");
            }
            else if (TotalTKA < 280)
            {
                Console.WriteLine("Maaaf Kaamu Nilaai mu kuuurang");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("---JALUR 2: Seleksi UTBK---");

            double TargetKelulusan = 600;
            double KontriBusiTKA = 0.30 * TotalTKA;
            double TargetUTBK = TargetKelulusan - KontriBusiTKA;

            Console.WriteLine($"\nBerdasarkan Total TKA Anda ({TotalTKA}):");
            Console.WriteLine($"> Kontribusi 30% Nilai TKA : {KontriBusiTKA}");
            Console.WriteLine($"> Target Skor Kelulusan     : {TargetKelulusan}");

            if (TargetUTBK <= 0)
            {
                Console.WriteLine("Status Jalur UTBK: Nilai TKA Anda sudah sangat tinggi! Target UTBK Anda adalah 0 (Otomatis Lolos jika ikut tes).");
            }
            else
            {
                Console.WriteLine($"Untuk Lolos Jalur UTBK, minimal nilai UTBK yang harus Anda kejar adalah: {TargetUTBK:F2}");
            }

        }
    }
}


