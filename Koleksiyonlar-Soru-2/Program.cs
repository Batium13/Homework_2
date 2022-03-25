using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
            int girisAdedi = 20;
            int toplamBuyuk = 0;
            int toplamKucuk = 0;
            int ortBuyuk = 0;
            int ortKucuk = 0;
            int ortToplam = 0;
            int[] sayilar = new int[girisAdedi];

            try
            {
                for (int i = 0; i < girisAdedi; i++)
                {
                    Console.WriteLine("{0}. pozitif sayı: ",i+1);
                    int tamSayi = int.Parse(Console.ReadLine());
                    sayilar[i] = tamSayi;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen sadece tam sayı giriniz !!!");
            }

            Array.Sort(sayilar);

            Console.WriteLine("Dizinin en küçük 3 sayısı: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(sayilar[i]+" ");
                toplamKucuk += sayilar[i];
                
            }

            Array.Reverse(sayilar);

            Console.WriteLine("\nDizinin en büyük 3 sayısı: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(sayilar[i]+" "); 
                toplamBuyuk += sayilar[i];
                
            }
            ortBuyuk = toplamBuyuk / 3;
            ortKucuk = toplamKucuk / 3;
            ortToplam = ortBuyuk + ortKucuk;

            Console.WriteLine("\nKüçük sayıların ortalması: "+ortKucuk);
            Console.WriteLine("Büyük sayıların ortalması: "+ortBuyuk);
            Console.WriteLine("Büyük ve Küçük sayıların ortalama toplamları: "+ortToplam);
                       

        }
    }
}
