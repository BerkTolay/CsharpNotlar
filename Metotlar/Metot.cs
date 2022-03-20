using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace Metotlar
{
    class Metot
    {
        #region Metot Genel Tanımlama


        /*
                Erişim belirleyici + geri dönüş değeri + metot adı()    -> İMZA
          {
                                                                        //GÖVDE
          }
         */
        // ()-> dışarıdan değer almasını ve bu değerleri metot içerisinde kullanılmasını sağlar
        #endregion

        #region İşlevine Göre Metot Türleri
        //Yapıalcak işleme göre 4 farklı türde oluşturabilir

        #region 1-)Geride Değer döndürmeyen Parametre almayan

        private void Metot1()
        {
            Console.WriteLine("1");
        }

        #endregion

        #region 2-)Geride Değer döndürmeyen Parametre alan

        public void Metot2(int a,bool b, char c)
        {
            Console.WriteLine(a++);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        #endregion

        #region 3-)Geride Değer döndüren Parametre Almayan

        public int Metot3()
        {
            int a = 5;
            return a;
        }

        private char Metot4()
        {
            return 'a';
        }

        #endregion

        #region 4-)Geride Değer döndüren Parametre alan

        public bool Metot5(int x)
        {
            //return true;
            return Convert.ToBoolean(x);
        }

        #endregion

        #endregion

        #region Faktöriyel Metot

        static int Faktoriyel(int sayi)
        {
            if (sayi>1)
            {
                return sayi * Faktoriyel(--sayi);
            }

            return sayi;
        }

        #endregion

        static void Main(string[] args)
        {
            #region TryCatch

            //Console.WriteLine("lütfen sayi1 değerini giriniz");
            //try
            //{
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("lütfen sayi2 değerini gir");
            //    int sayi2 = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("hatali giris");

            //}

            #endregion

            #region DateTime Örnek
            //DateTime dt = Convert.ToDateTime(Console.ReadLine());
            //DateTime bugun = DateTime.Now;
            //int yas = bugun.Year - dt.Year;

            //if (dt > bugun.AddYears(-yas))
            //{
            //    yas--;
            //}
            //Console.WriteLine(yas);

            #endregion

            Console.WriteLine(Faktoriyel(5));




        }
    }
}
