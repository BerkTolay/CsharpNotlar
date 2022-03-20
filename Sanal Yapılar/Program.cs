using System;

namespace Sanal_Yapılar
{
    class Program
    {
        //bir nesne üzerinde var olan tüm memberların tamamı derleme zamanında  belirgindir
        //yani, derleme aşamasında hangi nesne üzerinden hangi metotların çağırılabilceği bilinmektedir
        //Sanal yapılar ile derleme zamanında kesin bilinen bu bilgi runtime'da belirlenebilmektedir
        //Yani ilgili nesnenin hangi metodu/property kullanacağı bilgisi runtime'da kararlaştırılır

        #region Sanal Yapılar
        //bir sınıf içerisindeki bir memberdır
        //bu sınıftan türeyen başka bir sınıfta tekrar bildirilebilir
        //derleme zamanında hangisinde olduğumuzu bilemeyiz
        //metot ya da property olabilirler

        //name hiding'den farkı base class'ta tanımlanan sanal yapılanmanın, kendisinden türüyen herhangi bir class'ta
        //tekrar bildirilmesidir. Base class'takini ezer(yeniden oluşturulabilme)

        //yani sanal yapılanmalarda Name Hiding'de olduğu gibi bir isimsel çakışmadan ziyade üstten gelen bir yapının
        //işlevini iptal edip, yeniden yapılandırmak vardır


        //bir sınıfta tasarlanmış sanal yapının işlevinin iptal edilip edilmeme durumuna göre tanımlandığı sınıftan mı yoksa
        //bu sınıfın torunlarından mı çağrılacağının belirlenmesi run time'da gerçekleşir

        //base class'ta bir member var ve bu member sanal
        //derived ya da torunlardaki bir class'ta da bu member var. Derleme aşamasında hangisinin kullanıcağı bilinemez
        //runtime'da kararlaştırırlır

        //ezilmeden kalıtımsal olarak aktarılıyorsa (derleme sırasında bilinemez) runtime base class'tan çağırılacağı kararlaştırılır
        //İptal edilip yeniden yazılıyorsa runtime'da torundan geleceği kararlaştırılır

        //Metot ya da property nir sanal member ise hangi türe ait olduğunun runtime'da belirlenmesine Geç bağlama(late binding) denir

        //virtual public ya da public virtual oalrak tanımlanır
        //torunlarda bu prop ya da metot ezilmek isteniyorsa torunlarda override keywordü kullanılmalı
        //eğer ezilmeyecekte override kullanmaya gerek yok
        //virtual edilmemiş herhangi bir member override edilemez(abstract classlarda olabilir)

        

        #endregion
        static void Main(string[] args)
        {
            #region Ornek1

            Terlik t = new();
            t.Bilgi();//virtual tanımlamazsak obje yazar
            Kalem kalem = new(); 
            kalem.Bilgi();//virtual tanımlamazsak obje yazar

            #endregion

            //bir class'ta virtual ile işaretlenmiş herhangi bir member torunların herhangi birinde de override edilebilir

            #region Ornek2

            Meymun m = new();
            m.Konus();//
            Inek i = new();
            i.Konus();


            #endregion

            #region Ornek3

            Ucgen u = new(3, 4);
            Console.WriteLine(u.AlanHesapla());
            
            Dortgen d = new(3, 4);
            Console.WriteLine(d.AlanHesapla());
            

            #endregion

            //sanal yapılar Polimorfizm(çok biçimlilik) uygulayan yapılardır
            //sanal yapıların en önemli özelliği late binding(geç bağlam)'dir
            //eğer bir member sanal olarak bildirilmemişse derleme zamanında hangi nesneden ilili memeber'ın çağrılacağını bilir
            //sanal olarak bildiirişmişşse, hangi nesne üzerinden çağrılacağı run time'da belirlenir
            //hangi memberın runtime'da belirlenmesine geç bağlama denir
            //static yapılanmalar sanal olarak bildirilezmler
        }
    }

    class MyClass
    {
        //public void MyMethod() { } // normal metot
        public virtual void MyMethod()//sanal metot
        {

        }

        //public int MyProp { get; set; }//normal prop
        public virtual int MyProp { get; set; }//sanal prop
    }

    #region Ornek1

    class Obje
    {
        public virtual void Bilgi()
        {
            Console.WriteLine("Obje");
        }
    }

    class Terlik:Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("terlik");
        }
    }

    class Kalem:Obje
    {
        public override void Bilgi()
        {
            Console.WriteLine("kalem");
        }
    }

    #endregion

    #region Ornek2

    class Memeli
    {
        virtual public void Konus()
        {
            Console.WriteLine("ben konuşmuyom");
        }
    }

    class Meymun:Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("meymınız");
        }
    }

    class Inek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("mööö");
            //inekte override etmeseydik(maymun override edilmiş) "ben konuşmuyom yazardı"
            //eğer inek maymundan türeseydi ve override etmeseydik "meymınız yazardı"
            
        }
    }

    #endregion

    #region Ornek3

    class Sekil
    {
         protected int Boy; //protected member o sınıfta veya o sınıftan kalıtım almış saınıflarda kullanılabilir
         protected int En; //ama nesne üzerinden erişilemez

        public Sekil(int boy, int en)
        {
            Boy = boy;
            En = en;
        }

        virtual public int AlanHesapla()
        {
            return 0;
        }
    }

    class Ucgen : Sekil
    {
        public Ucgen(int boy, int en):base(boy,en)
        {
            
        }

        public override int AlanHesapla()
        {
            return Boy * En /2 ;
        }
    }

    class Dortgen:Sekil
    {
        public Dortgen(int boy, int en) : base(boy, en)
        {
            //eğer base class'ta parametreli ctor tanımlanmışsa, torunlarda ctor tanımlanıp base ile işartlenmeli ve parametre gönderilmeli
        }

        public override int AlanHesapla()
        {
            return Boy * En;
        }
    }

    class Dikdortgen:Sekil
    {
        public Dikdortgen(int boy, int en) : base(boy, en)
        {
            //eğer base class'ta parametreli ctor tanımlanmışsa, torunlarda ctor tanımlanıp base ile işartlenmeli ve parametre gönderilmeli
        }

        public override int AlanHesapla()
        {
            return Boy * En;
        }
    }

    #endregion
}
