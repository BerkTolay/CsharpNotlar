using System;

namespace Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Destructor/Finalizer
            //nesnede en son tetiklenecek fonksiyondur
            //nesne imha edilirken otomatik çağrılan metottur
            //C#'da destructor sadece class yapılanmasında kullanılabilir ve bir class sadece bir tane destructor tanımlanabilir
            //Destructor parametre almaz

            //Nesne herhangi bir referans tarafından işaretlenmiyorsa GC tarafından imha edilir
            //Nesne artık kullanılmayacaksa GC imha eder


            //GC C#'da bellek optimizasyonu üstlenen bir yapılanmadır
            //nesne imha edilirken destructor fonksiyon devreye girer ve son işlemleri yapar



            #region Destructor Yapılanması
            //~Myclass()
            //{
            // işlemler
            //}
            //Bir sınıf içerisinde sadece 1 tane olabilir
            //Sınıf ismiyle aynı olmalıdır

            X(); //NESNE üretildi
            GC.Collect();//son anda destructor tetikleniyor
            Console.WriteLine();

            #endregion

            #region Ornek

            int sayi =5;
            while (sayi>=1)
            {
                new MyClass2(sayi--);
            }
            Console.WriteLine("*********");
            GC.Collect();

            Console.ReadLine();

            #endregion
        }

        static void X() //static yapılarda sadece static yapılar kullanılabilir
        {
            MyClass m = new MyClass();
        }
    }

    class MyClass
    {
        public MyClass() //constructor
        {
            Console.WriteLine("nesne üretildi");
        }

        ~MyClass() //destructor
        {
            Console.WriteLine("imha ediliyor");
        }
    }

    class MyClass2
    {
        private int no;
        public MyClass2(int no)
        {
            this.no = no;
            Console.WriteLine($"{no}. nesne üretildi");
        }

        ~MyClass2()
        {
            Console.WriteLine($"{no}. nesne imha edildi");// nesne varken son anda bu yapılanma tetiklenir ekrana yazar ve nesne daha sonra imha edilir
        }

    }
}
