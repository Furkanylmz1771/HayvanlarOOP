using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanÖzllikler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek= new Kopek();

            kopek.ad = "Pati";
            kopek.cinsi = "Kangal";
            kopek.setBoy(4);
            kopek.setKilo(40);

            Console.WriteLine("Kopek objesine ait bilgiler");

            Console.WriteLine("Köpek adı : "+  kopek.ad);
            Console.WriteLine("Köpek cinsi :" + kopek.cinsi);
            Console.WriteLine("Köpek boyu : " + kopek.getBoy());
            Console.WriteLine("Köpek kilosu :" + kopek.getKilo());
            kopek.Sesver();




            Kedi kedi1 = new Kedi();

           kedi1.ad = "Narins";
           kedi1.cinsi = "Van";
           kedi1.setBoy(5);
            kedi1.setKilo(30);

            Console.WriteLine("Kedi objesine ait bilgiler");

            Console.WriteLine("Kedi adı : " + kedi1.ad);
            Console.WriteLine("Kedi cinsi :" + kedi1.cinsi);
            Console.WriteLine("Kedi boyu : " + kedi1.getBoy());
            Console.WriteLine("Kedi kilosu :" + kedi1.getKilo());
            kedi1.Sesver();




            kuş kuş1 = new kuş();
            kuş1.ad = "Sarı";
           kuş1.cinsi = "Civciv";
           kuş1.setBoy(2);
           kuş1.setKilo(14);

            Console.WriteLine("Kuş objesine ait bilgiler");

            Console.WriteLine("Kuş adı : " + kuş1.ad);
            Console.WriteLine("Kuş cinsi :" +kuş1.cinsi);
            Console.WriteLine("Kuş boyu : " +kuş1.getBoy());
            Console.WriteLine("Kuş kilosu :" + kuş1.getKilo());
            kuş1.Sesver();                    

        }
    }
}
