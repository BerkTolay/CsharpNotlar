using System;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-)Sınıfın Nesnesini Temsil Eder
            //ilgili sınıftan oluşturulan nesneyi sınıf modellemesinde temsil etmemizi sağlar
            MyClass m1 = new MyClass();
            MyClass m2 = new MyClass();
            m1.X();
            m2.X();




            #endregion

            #region 2-)Aynı İsimdeki Field ile Metot parametrelerini Ayıramk İçin Kullanılır
            //this keywordu ilgili class yapılanmasının o anki nesnesine karşılık gelir fakat this kullanmak zorunda değiliz.
            //bir metotun içerisinden propertye metota field'a erişebiliyoruz, complier otomatik this kullanıyor
            //aynı isim olduğunda problem olacağı için this ile belirtiriz


            #endregion

            #region 3-)Bir Constructer'dan Başka Bir Constructer'ı Çağırmak için Kullanılır



            #endregion
        }
    }

    class MyClass
    { 
        public void X()
        {
            this.X(); //MyClass'tan bir nesne üretildiğinde, üretilen nesneden X i çağırdığımızda, o anki nesnenin X'ini bir daha çağıracaktır, recursive
        }

        private int a;

        public void Y(int a)
        {
           // this.a //fieldtaki a'yı temsil eder
           //a //parametre olan a'yı temsil eder

        }
    }
}
