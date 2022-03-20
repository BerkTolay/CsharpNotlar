using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    class Program
    {
        //sınıflara özel bir niteliktir
        //sadece sınıftan bir kalıtım alınabilir
        //RECORD'lar sadece kendi aralarında kalıtım alabilmektedir
        
        static void Main(string[] args)
        {

            #region Ornek 1
            Muhasebeci muhasebeci = new();
            Mudur mudur = new();
            mudur.MedeniHal = true;
            Yazilimci yazilimci = new Yazilimci();
            //yazilimci.KullandigiDiller


            #endregion

            //Kalıtım veren sınıfa Base/Parent class
            //kalıtım alana Derived/Child class denir
            //Bir sınıfın sadece tek bir base class'ı olabilir

            #region Kalıtımda Nesne Üretim Sırası
            //Bir sınıftan nesns üretimi yapılırken kalıtım aldığı üst sınıflar varsa önce o sınıflardan sırayla nesne üretilir
            //A, B'nin base classı, C ise B'nin derived class'ı olsun. new C(); dediğimizde Sırasıyla A-B-C 'den nesne üretilecektir
            new C();

            Console.ReadLine();

            //eğer static ctor u kullansaydık ilk C sonra B sonra A oluşturuldu çıktısı alırdık

            #endregion

            #region Bir sınıftan base class Ctor'ına Ulaşım
            /*Herhangi bir sınıftan nesne üretilirken öncelikle base class'dan nesne üretiliyorsa base class ctoru tetikleniyor demektir
             *Eğer base classta birden fazla ctor varsa istediğimize erişip parametre verebiliriz
             *Bunun için base keyword'ünü kullanırız
             */
            new MyClass2();

            //base classın ctor'u sadece parametre alan ctor ise, base keywordü ile değer göndermeliyiz
            //base class'ta parametreli ctor tanımlanmışsa, torunlarda ctor tanımlanıp base ile işartlenmeli ve parametre gönderilmeli
            //eğerki base class'ta boş parametreli ctor'da varsa, parametreliyi belirtmezsek otomatik onu çalıştıracaktır

            #endregion

            #region Base vs This
            //this ctorlarda kullanıldığında o anki sınıfın ctor'ları arasında geçiş yapmamızı sağlar
            //base ise, kalıtım alınan classın ctor'larına erişim sağlar



            #endregion

            #region Object Türü
            //**
            //en temel sınıf objecttir
            //tüm sınıflar object sınıfından türemiştir(delegate hariç)
            //nesnelerde  ToString, Equals, GetHashCode ve GetType fonksiyonları obejctten kalıtım alındığı için gelir

            //tüm değerler objectten türediği için object tüm değerleri kapsar.(boxing-unboxing işlemi bu sayede gerçekleşir)

            //bir sınıf eğer başka bir sınıftan kalıtım alıyorsa, kalıtım aldığı sınıftan türeyecektir
            //çünkü bir sınıf sadece 1 sınıftan türeyebilir
            //fakat kalıtım aldığı sınıf objectten türediği için dolaylı yoldan o sınıfta objectten kalıtım alır



            #endregion

            #region Name Hiding
            //kalıtım durumlarında atalardaki herhangi bir member ile aynı isimde member'a sahip olan nesneler olabilir
            //derived class'tan nesne ürettiğimizde gelen X memberının nereden geldiğini bilememize Name Hiding denir
            //derived class'tan ürettiğimiz nesne, kendi sınıfındaki X memberına erişebilir
            //base class'taki X memberına erişemez, bu memberı gizlemiş Name Hiding yapmış oluruz

            //eskiden name hiding durumunda derleyeciye bildirmek için "new" keywordünü kullanmamız gerekirdi

            //-----Pratik

            NHD d = new NHD();
            d.X();//D' den gelen X

            #endregion

            #region Record'larda Kalıtım
            //Recordlar sadece recordlardan kalıtım alıp verebilir
            //geri kalan özellikleri classlarda aynıdır, name hiding base, this vb
            
            #endregion

        }
    }

    #region Ornek1

    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool MedeniHal { get; set; }
    }

    class Muhasebeci : Personel
    {
        public bool Musavir { get; set; }
    }

    class Yazilimci : Personel
    {
        public string[] KullandigiDiller { get; set; }
    }

    class Mudur : Personel
    {
        
    }

    #endregion

    #region Kalıtımda Nesne Üretim Sırası

    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)}'dan nesne üretildi");//name of kullanmamızın sebebi, metinsel olarak o kodun ismini yazmak hata oluşturabilir
        }    
    }

    class B:A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)}'den nesne üretildi");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)}'den nesne üretildi");
        }
    }

    #endregion

    #region Bir sınıftan base class Ctor'ına Ulaşım

    class MyClass
    {
        public MyClass(int a)
        {

        }
    }

    class MyClass2:MyClass
    {
        public MyClass2() : base(5)
        {

        }

        public MyClass2(int b) : base(b)
        {

        }

    }

    #endregion

    #region Base vs This

    class E
    {
        private int a;
        public int b;
        
        public int MyProperty { get; set; }

    }

    class F:E
    {
        int c;
        
        public void X()
        {
            this.b=6;//bu sınfıta olmamasına rağmen base class'ta public tanımlandığı için erişilebilir
            //this.a = 5; // erişilemez çünkü private
            this.MyProperty = 6;
            //base.c = 5;//c base classta yok
            base.MyProperty = 6;
            base.b = 6;
            //base.a//private
            c = 5;//compiler otomatik olarak this koyar
            MyProperty = 6;//complier otomatik base koyar

        }
    }


    #endregion

    #region Name Hiding

    class NameHidingA
    {
        public int X { get; set; }
    }

    class NameHidingB:NameHidingA
    {
        public int X { get; set; }
        //public new int X { get; set; }//artık new kullanmak zorunda değiliz
    }

    //------Pratik
    class NHA
    {
        public void X()
        {

        }
    }

    class NHB : NHA
    {
        
    }

    class NHC : NHB
    {
        
    }

    class NHD : NHC
    {
        public void X()
        {

        }

        //public new void X()//eski yöntem
        //{
        //}
    }

    #endregion

}
