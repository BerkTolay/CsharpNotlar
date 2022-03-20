using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor
            /*nesne üretilirken ilk tetiklenen metottur
            * Constructor, new ile nesne yaratma talebi geldikten ve nesneye hafızada yer ayrıldıktan sonra tetiklenir
            * Metot adı sınıf adıyla aynı olmalıdır.Özel sınıf elemanlarının dışında(Constructor-Destructor-Static Constructor)
             *hiçbir member sınıf adıyla aynı olamaz(deconstruct metotu özel sınıf elemanıdır fakat aynı isimde olamaz)
            * Geri dönüş değeri belirtilmez
            * public olmalıdır
            *
            */

            new Myclass();
            Myclass m = new();
            new Myclass(); //her durumda da constructor tetiklenir

            //Her sınıfın içerisinde default olarak bir constructor vardır.
            //Eğer kendi constructor'ımızı yazarsak default'u iptal etmiş oluruz
            #endregion

            #region Parametreli Constructor
            //diğer özel sınıf elemanları parametre almaz, parametre alan tek özel eleman constructor'dır
            //overload olabilir

            new MyClass2(5);
            new MyClass2("test");
            new MyClass2();

            #endregion

            #region Private Constructor
            //private olduğu için constructor tetiklenmeyecektir
            //new MyClass3();//tetiklenmediği için nesne üretilmeyecektir

            #endregion

            #region This Keywordü
            //this, sınıfın o anki nesnesini temsil etmesinin yanında, sınıfın o anki nesnesinin farklı constructorları arasında geçiş yapmamızı da sağlar

            
            new MyClass4(5);//hem int overload'lu hemde diğer constructorı çalıştırmak için, ": this" kullanmalıyız

            #endregion

            #region Recordlarda Constructor

            new MyRecord();
            new MyRecord(5);

            #endregion
            
        }

    }

    #region Constuructor

    class Myclass
    {
        public Myclass()//Constructor 
        {
            Console.WriteLine("test");
        }
    }

    #endregion
    
    #region Parametreli Constructor

    class MyClass2
    { 
        public MyClass2(int x)
        {
            Console.WriteLine("test" + x);
        }

        public MyClass2() //overload
        {

        }

        public MyClass2(string a) //overload
        {

        }
    }

    #endregion

    #region Private Constructor

    class MyClass3
    {
        private MyClass3()
        {

        }

        void X()
        {
            new MyClass3();//private olduğu halde class içerisinde constructor a erişilebilir
        }
    }

    #endregion

    #region This Keywordü

    class MyClass4
    {
        public MyClass4()
        {
            Console.WriteLine("1. constructor");
        }

        public MyClass4(int a) : this() //o anki constructorın dışındaki diğer constructorlara erişmemize izin verir, ilk önce 1. constructor, sonra 2. constructor çalıaşcaktır
        {
            Console.WriteLine($"2. consturctor : a = {a}");
        }

        public MyClass4(int a, int b) : this(a) //sırasıyla 1. 2. 3. constructorlar çalışır
        {
            Console.WriteLine("3.constructor");
        }
        public void X()
        {

        }
    }

    #endregion

    #region Recordlarda Constructor

    record MyRecord()
    {
        
        public MyRecord(int a): this()
        {
            Console.WriteLine("record");
        }

        
    }

    #endregion


}
