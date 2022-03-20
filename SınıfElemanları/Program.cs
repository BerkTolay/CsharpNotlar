using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SınıfElemanları
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-)Field: classtan ürettiğimiz nesne üzerinde değer tutmamaızı sağlayan yapılar
            //2-)Porperty: Fieldler üzerinde kontrollü bir şekilde değerleri dışarı açmamızı sağlar ve kontrollü bir şekilde dışarıdan gelen değerleri fieldlara atmamızı sağlar
            //3-)Metot: Nesne üzerinde prosedürel işlemler yapmamızı sağlayan küçük kod yapıları
            //4-)İndexer: dizi veya koleksiyonlarda olduğu gibi nesneye indexer operatörü kazandırır

            // Constructor-Destructor-Static Constructor sınıfın elemanlarıdır fakat bunlar özelleştirilmiş memberlardır. Tanımlanmasa bile lassın içerisinde var olan yapılanmalardır
            // 1-2-3-4 yapılanmalar biz tanımladığımız sürece var olurlar.

            #region Field
            //OOP'da bir nesne içerisinde yapılandıran en temel yapılardır
            //Nesne içerisinde veri depoladığımız alanlardır Nesne içerisindeki data/veridir
            //Class içerisindeki değişkenlerdir, herhangi bir türden olabilir
            //Sadece classın scope içerisinde tanımlanan değişkenlere field denir, metot, main de tanımlananlar field değildir
            
            //go to FieldOrnek
            //a'yı kullanabilmek için nesne oluşturmalıyız
            FieldOrnek m1 = new FieldOrnek(); //Bir nesne oluşturduk ve FieldOrnek türünden m1 referansı ile bu nesneyi işaretledik
            m1.a = 5;//m1 referansının işaret ettiğin nesne içindeki a field ına 5 değerini atadık
            FieldOrnek m2 = new FieldOrnek();
            m2.a = 25; //m2 nin referans ettiği nesnenin a field ına 25 değerini atadık

            //Bir class oluşturup ve field oluşturursak varsayılan değer alırlar
            /* class Myclass
             {
              int a; ->default değer atanır
             }

            */
            Console.WriteLine(m1.c);//int default değeri 0 dır
                                    //Bir metot ya da property içersinde olsaydı default değer atanmayacaktır
            #endregion

            #region Property
            //Esasında bir metottur, işlevsel olarak metottan farkı yoktur
            //Davranışsal olarak farklılık gösterir -> bir field'a değer atamak ve değer okumak
            /*
             public int x
            {
                 get //
                 {
                    //return 0;
                 }
                 set
                 {
                    //atanan veri buradan yakalanır
                 }
            }
            */
            //get ve set aslında bir metottur

            //Fieldlardaki verileri kontrollü bir şekide dışarıya açmak istediğimiz için kullanılır
            //Buna ENCAPSULATION denir
            //hangi field'ı enscapsulation ediyorsa o türde bir property olmalıdır
            #region 1-)Full Property
            //En sade en temel property yapılanmasıdır
            //içerisinde get ve set blokları tanımlanmalıdır
            // [erişim belirleyicisi] [geri dönüş/alış değeri] [property adı]
            //set bloğu tanımlanmazsa write only, get bloğu tanımlanmazsa read only property oluşuturulur

            MyClass myClass = new MyClass();
            myClass.Yasi = 65;
            Console.WriteLine(myClass.Yasi);

            #endregion

            #region 2-)Prop
            //Temsil ettiği field'da ki dataya hiç müdahele etmeden erişilmesini ve veri atanmasını sağlıyorsa böyle bir durumda kullanılan porperty imzasıdır
            //Her zaman ENCAPSULATİON yapılmalıdır o yüzden böyle bir property türü vardır
            //Prop propertyler compile edildiklerinde arkaplanda kendi field'larını oluştururlar dolayısıyla bir field tanımlamaya gerek yok


            #endregion

            #region 3-)Auto Property Initializers
            //bir property nin ilk değerini nesne ayağa kaldırılır kaldırılmaz verilebilir


            #endregion

            #region 4-)Ref Readonly Returns
            //REF metotlarda kullanılır, metotun parametresine verilen değer eğer bir değişkenden geliyorsa, değerini değil değişkenin referansını verir
            //bunu class içerisinde property içerisinde yapmamızı sağlar.
            //bir sınıf içerisindeki field'ı referansıyla döndürmemizi sağlayan ve bu değişkenin değerini read only yapan özelliktir


            #endregion

            #region 5-)Computed(Hesaplanmış) Properties
            //içerisinde türetilmiş bir bağıntı taşıyan propertylerdir


            #endregion

            #region 6-)Expression-Bodied Property
            //Tanımlanan property'de Lambda Expression kullanmamızı sağlayan söz dizimidir


            #endregion

            #region 7-)Init-Only Properties - Init Accessor
            //nesnenin ilk yaratılış anında propertlerine değer atamaktadır, //bu bildiğimzi yapılanma
            //İş kuralı gereği run time'da değeri  değişmemesi gereken nesneler için bir önlen alınmaktadır //read only propertinin kendisi
            /* init-only properties developer açısından süreç esnasında değiştirilmemesi gereken property değerlerinin "yanlışlıkla" değiştirilmesinin
             * önüne geçmekte ve böylece olası hata ve bug'lardan yazılımı arındırmaktadır -> Auto property initilaizers'dan farkı
             * OBJECT İNİTİALİZER desteğidir
            */
            #endregion


            #endregion

            #region Metot
            //void olabilir
            myClass.X();
            myClass.Y();

            #endregion

            #region Indexer
            //nesneye indexer özelliği kazandırır property ile aynı şeyi yapar
            // erişim belirleyicisi + geri dönüş dğeri this [parametreler]
            //this indexer özelliği kazandırır
            myClass[5] = 10;

            Ornek o = new();
            o[0] = "A";
            o[1] = "B";

            #endregion
        }
    }

    class FieldOrnek
    {
        public int a;//field
        public string b; //field
        public int c;//default değer örneği
    }

    #region Property Ornek

    class MyClass
    {
        private int yasi;//field adları küçük yazılır
        

        public int Yasi //property adı temsil ettiği field'ın büyük harfli başlar
        {
            get
            {
                return yasi;
            }
            set
            {
                yasi = value;
            }
        }

        public int Yasi1 { get; set; } //Prop örnek
        public int Yasi2 { get; set; } = 15; //Auto Property Initializers

        private string adi = "berk";
        public ref readonly string Adi => ref adi;  //adi değerine her erişmek gerektiğinde bir nesne oluşturmalıyız
        //her nesne oluşturulduğunda bir field oluşturulur bu maliyetinin önüne geçmek için sadece referansını gönderebiliriz


        //Computed property
        private int s1 = 5;
        private int s2 = 10;
        public int Topla
        {
            get
            {
                return s1*s2;
            }

        }

        //Expression-Bodied Property
        /*private string cinsiyet;

         public string Cinsiyet
        {
            get
            {
                return "erkek";
            }
            
        }*/ //Yerine
       public string Cinsiyet => "Erkek"; // yazılabilir sadece read only çalışır
       //Auto property initiaizers ile benzerdir

       //----Metot örnek
       public int X()
       {
           return 0;
       }

       public void Y()
       {

       }

       //----Indexer
       public int this[int a]
       {
           get
           {
               return a;
           }
           set
           {

           }
       }
    }

    #region Indexer Ornek2
    
    class Ornek
    {
        private string[] isimler = new string[10];
        public string this[int a]
        {


            get
            {
                return isimler[a];
            }
            set
            {
                isimler[a] = value;
            }
        }
    }


    #endregion


    #endregion
}
