using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanÖzllikler
{
     class Hayvanlar
    {
        protected int boy;          // Miras alan sınıf erişeceği için protected
        protected int kilo;

        public string ad;
        public  void Sesver()
        {
            Console.WriteLine("Sesleniyorum");
        }

        
    };




    class Kopek : Hayvanlar {

        public void Sesver()        // Metodu kendine özgü uyarladı     Polimorfizm
        {
            Console.WriteLine("Hav");
        }
        public void setBoy(int a)
        {
            boy = a;
        }
        public int getBoy()
        {
            return boy;
        }

        public void setKilo(int a)
        {
            kilo = a;
        }
        public int getKilo()
        {
            return boy;
        }

        public string cinsi;

    
    };





    class Kedi : Hayvanlar {

        public string rengi;
        public string cinsi;

        public void Sesver()        // Metodu kendine özgü uyarladı     Polimorfizm
        {
            Console.WriteLine("Miyav");
        }
        public void setBoy(int a)
        {
            boy = a;
        }
        public int getBoy()
        {
            return boy;
        }

        public void setKilo(int a)
        {
            kilo = a;
        }
        public int getKilo()
        {
            return boy;
        }
    };





    class kuş : Hayvanlar {

        public string hızı;
        public string cinsi;
        public new void Sesver()        // Metodu kendine özgü uyarladı     Polimorfizm
        {
            Console.WriteLine("Cik");
        }

        public void setBoy(int a)
        {
            boy = a;
        }
        public int getBoy()
        {
            return boy;
        }

        public void setKilo(int a)
        {
            boy = a;
        }
        public int getKilo()
        {
            return boy;
        }


    };


};
