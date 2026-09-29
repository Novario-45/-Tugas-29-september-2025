using System;
 
namespace Tugas
{
   class Home
    {
        static void Main(string[] args)
        {
            int Buku1 = 100;
            int Buku2 = 200;
            int Buku3 = 300;

            int Pulpen = 500;
            int JumlahPulpen = 2;
            int TotalPulpen = 1000;
            int TotalBelanjaan = 1600;
            double diskon = 0;
            double potonganHarga = 320;
            double totalBayar = 1280;

            if (TotalBelanjaan >= 700 && TotalBelanjaan < 1000)
            {
                diskon = 0.10;
            }
            else if(TotalBelanjaan >= 1000)
            {
                diskon = 0.20;
            }


            Console.WriteLine("========== RINCIAN BELANJA ==========");
            Console.WriteLine($"Total Belanja Awal : {TotalBelanjaan}");
            Console.WriteLine($"Persentase Diskon  : {diskon * 100}%");
            Console.WriteLine($"Potongan Harga     : {potonganHarga}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Total Akhir Bayar  : {totalBayar}");
            Console.WriteLine("=====================================");


        }
        
    }
}
