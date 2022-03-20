using System;

namespace Static_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ** 
             * constructor bir sınıftan HER NESNE üretildiğinde tetiklenir
             * Static Constructor bir nesneden İLK tetiklenen fonksiyondur
             * Normal constructor sonra tetiklenir
             *
             * static constructor ilk nesne tetiklediğinde tetiklenir ve bir daha tetiklenmez
             *
             */

            new MyClass();
            new MyClass();
            GC.Collect();
            Console.WriteLine();

            /*
             * Static ctor un tetiklenmesi için ilk nesne üretilmesine gerek yoktur
             * o sınıf içerisinde herhangi bir static bir member tetiklenirsede static ctor tetiklenir
             */


            //------design pattern
            var database1 = Database.GetInstance;

        }
    }

    class MyClass
    {
        public MyClass()//constructor
        {
            Console.WriteLine("ctor tetiklendi");
        }

        static MyClass()//static constructor, geri dönüş değeri ve erişim belirleyicisi belirlenmez, overload yok
        {
            Console.WriteLine("static ctor tetiklendi");
        }
    }

    #region Singleton Design Pattern
    /*
     * bir sınıftan uygulama bazında sadece tek bir nesne oluşturulmasını istiyorsak kullanırız
     * sadece 1 nesne üretileceği için o sınıfın ctorunu private yapmamız gerek
     */

    class Database
    {
        Database() //private ctor
        {
            
        }

        private static Database database;//statik bellekte duran bir referans

       static public Database GetInstance
        {
            get
            {
                return database;
            }
        }

        static Database()//statik bellekte duran referansa nesne atamak için static ctor kullanırız
        {
            database = new Database();//bir sınıfın ctor'unu private yaptık fakat private dışarıdan erişilmesini engeller, aynı scope içerisinde erişebiliriz
        }
    }

    #endregion
}
