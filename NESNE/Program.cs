using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace NESNE
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Nesne

            //complex type=Class
            //Nesneler complex değerlerdir. Bu complex değerleri oluşturmamızı sağlayan modelleyici class, komplex type'tır
            //Nesne oluşturmak için CLASS kullanmak zorundayız (interface-abstract class-struct nesne OLUŞTURMAZ)
            //recordslar bir class olduğu için nesne oluşturulabilir

            //new MyClass();//Ramde HEAP bölümünde nesne oluşturuldu, fakat bunu referans eden bir nokta tanımlamadık
            //MyClass x = new MyClass();//Referans edeceğimiz nesnenin türü nesye referans noktasıda o türden olmalıdır, x=referans türlü değişkendir
            //= operatörü değer türlü değişkenlerde atama(assign) operatörü, referans türlü değişkenlerde referans etme/işaretleme operatörü denir

            //C# 9.0'dan sonra oluşturulacak nesnenin türü referanstan öğrenilir
            //MyClass x1= new MyClass(); yerine
            //MyClass x1 = new();//yazılabilir 

            #endregion

            #region Referans-Nesne İlişkisi
            /*MyClass m
             *MyInterface m
             * MyAbsctractClass m
             *Bu referans noktalarıyla HEAP'teki nesneyi referans edip işlemler yapabiliriz fakat Nesne SADECE CLASS'LARDAN ÜRETİLEBİLİR(interface ve abstract classlarda complier seviyesinde nesne oluşturulur)
             *MyRecord m Recordlar ile nesne oluşturup referans edebilriiz
             */
            //değer türlü değişkenlerde bir değer verilmiyorsa default değer verilir
            //referanslar eğer nesne işaret etmeden tanımlanırsa null değerini alır



            //MyClass m = new();
            //m.A = 10; //stackte oluşturulan m referans noktası, heap'te oluşturulan Myclass nesnesini referans ediyor. Nesnenin üzerinde A propertysinde işlem yapıp 10 değerini atıyor

            //MyClass m1 = null;
            //m1.A = 20; //access modifier sayesinde ilgili referansın içerisindeki memberlara erişebiliriz.Fakat bir nesnesi olmadığı için bu memberı üzerinde çalıştıracak bir nesne olmayacağı için NULL Referance hatası vercektir

            #endregion

            #region Referansız Nesneler
            //bir nesne oluşturulduğunda herhangi bir referans noktası ile işaretlenmezse HEAP'e yerleştirilir
            //Bu nesneye sonradan erişemeyiz. Nesneyle kurulacak tek diyalog oluşturma anındadır
            //eğerki bir nesne referansızsa memoryde yer kaplayacağından dolayı belirsiz bir süre sonra Garbage collector(GC) tarafından temizlenecektir
            //GC referansız nesneleri imha eder

            #endregion

            #region Object Initializer
            //Nesne Oluşturma esnasında propertylere ilk değer atama

            //MyClass m3 = new()
            //{
            //    A=10, // ilk oluştururken object initializer yapılanması sayesinde değerleri atanır, sanki propertylerin defaultu bu değermiş gibi düşünebiliriz
            //    MyProperty = 40
            //};

            //MyClass m4 = new(); // bu nesne oluştururken oluşturulurken default verilir
            //m4.A = 5;//daha sonra değer atanır


            #endregion

            #region NESNE KOPYALAMA

            //DEEP COPY
            //int a = 5;
            //int b = a;//bu davranış değer türlü değişkenler üzerinden oluyorsa bu deep copy dir
            //stackte elimizdeki veri 1'den 2 olur yani (int) a=5; (int) b=5; şeklinde tutulur


            #region SHALLOW COPY
            //----SHALLOW COPY
            //var olan bir nesnennin, değerin(nesnelerde complex değerlerdir), referansının kopyalanmasıdır
            //bir nesne birden fazla referans noktası üzerinden işaretlenmiş olur

            //MyClass m5 = new(); //nesne m5 referansı ile işaretlenmiş
            //MyClass m6 = m1; //bu davranış nesneler üzerinden yapılıyorsa bu shallow copy dir
            //MyClass m7 = m6; //m7 m6'yı görüyor m6 m5'in gösterdiği nesneyi referans ettiği için, m7'de o nesneyi referans eder
            //MyClass m8 = new MyClass();

            //MyClass m9 = null;//referans oluşturuldu fakat işaret ettği bir nesne yok
            //MyClass m10 = new MyClass();//m10 referansı oluşturuldu ve bir nesneyi işaretliyor
            //MyClass m11 = m10;//referans türlü değişkenler olduğu için m11, m10'un işaret ettiği nesneyi işaret eder
            //m9 = m11;//m9 m11'in gördüğü nesneyi işaret eder

            //**
            //Bir nesneyi birden fazla referans işaretliyor ve bu nesne türetilmiyorsa buna shallow copy denir


            #endregion

            #region DEEP COPY

            MyClass2 m1 = new MyClass2();
            MyClass2 m2 = m1; //shallow
            MyClass2 m3=m1.Clone();

            #endregion


            #endregion

        }

        class MyClass
        {
            public int A { get; set; }

            public void Y()
            {

            }

            public int MyProperty { get; set; }

        }

        class MyClass2
        {
            public MyClass2 Clone() //MyClass2 döndürecek
            {
                //this.MemberwiseClone();//bir sınıfın içerisinde o sınıftan üretilmiş olan o anki nesneyi kloanlamamızı sağlar ve object olarak döndürür
                return (MyClass2)this.MemberwiseClone();
            } 
        }

        
    }
}
