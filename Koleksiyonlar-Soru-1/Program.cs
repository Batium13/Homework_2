using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sayiListe = new ArrayList();
            ArrayList normalSayilar = new ArrayList();
            ArrayList asalSayilar = new ArrayList();

            Ortalama ortalama = new Ortalama();

            Console.WriteLine("Lütfen 20 adet pozitif tam sayı giriniz: ");

            int sayiAdedi=21;
            
                try{
                    for (int i = 1; i < sayiAdedi; i++){
                        Console.WriteLine("{0}. pozitif tam sayı değeriniz: ",i);
                        int tamSayi = Convert.ToInt32(Console.ReadLine());
                        if (tamSayi <=0){
                                Console.WriteLine("Negatif veya sayısal olmayan bir değer girdiniz...");
                                return;
                        }
                        sayiListe.Add(tamSayi);                  
                    }

                }
                catch (Exception){
                    Console.WriteLine("Lütfen pozitif bir sayı değeri giriniz...");
                }
                Console.WriteLine("*****************************************");
            foreach (int item in sayiListe)
            {
                if (item == 1)
                {
                    normalSayilar.Add(item);
                }else if (item == 2)
                {
                    asalSayilar.Add(item);
                }else
                {
                    int sayac = 0;
                    for (int i = 2; i < item; i++)
                    {
                        if (item % i == 0) 
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        asalSayilar.Add(item);
                    }else
                    {
                        normalSayilar.Add(item);
                    }
                }
            }
           
            asalSayilar.Sort();
            asalSayilar.Reverse();
            normalSayilar.Sort();
            normalSayilar.Reverse();
            
            Console.WriteLine("Asal sayıların adedi: ");
            Console.WriteLine(asalSayilar.Count);
            Console.WriteLine("Normal sayıların adedi: ");
            Console.WriteLine(normalSayilar.Count);

            Console.WriteLine("Asal sayıların büyükten küçüğe doğru sıralanışı: ");
            foreach (var item in asalSayilar)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine("\nNormal sayıların büyükten küçüğe doğru sıralanışı: ");
            foreach (var item in normalSayilar)
            {  
                Console.Write(item+" ");
            }

            Console.WriteLine("\nAsal sayıların ortalaması: ");
            Console.WriteLine(ortalama.Average(asalSayilar));
            Console.WriteLine("Normal sayıların ortalaması: ");
            Console.WriteLine(ortalama.Average(normalSayilar));
        }

    }

    class Ortalama{

        public ArrayList Average(ArrayList arr)
        {
            int toplam = 0;
            foreach (int item in arr)
            {
                toplam += item;
            }
            int ort = toplam / arr.Count;
            Console.WriteLine("Ortalama:" + ort);
            return arr;
        }
    }
}
