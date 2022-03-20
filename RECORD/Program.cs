using System;

namespace RECORD
{
    class Program
    {
        #region Init-Only Properties
        //herhangi bir nesnenin propertylerine ilk değerlerinin verilmesi ve sonraki süreçte bu değerlerin değiştirilmemesini garanti almaya sağlayan yapılanmadır
        //nesnenin sadece ilk yaratılış anında propertylerine değer atanmakta ve böylece iş kuralları gereği runtime'da değeri değilmemesini sağlar
        //propertyleri readonly yaparken ilk değeri vermemizi sağlar
        //readonly property = getter only property

        //------getter only properties ile init only properties arasındaki fark--------
        //Object initializer sırasında yani nesne oluşum sürecinde orada ilk değeri atayabiliyoruz


        //***init sayesinde property hem read only yapılır hemde object oluştururken değer atanabilir hale gelir.

        #endregion

        static void Main(string[] args)
      {

            #region Init-Only Properties
            //MyClass m1 = new MyClass()
            //{
            //    MyProperty // read only olduğu için değer verilemez
            //};

            //------init tanımlama ve kullanma-----
            Book book = new Book()
            {
                Author = "Kutsal isyan",// normalde read only olduğu için hata vermesi gerekirken init sayesinde nesne oluşum sürecinde değer atayabiliyoruz
                Name = "hasan izzet dinamo"
            };

            //book.Name = "hatalı ornek";//hata verir çünkü readonly

            Ornek2 InitOrnek2 = new()
            {
                A = 5 //readonly de normalde atanamaz çünkü set yoktur fakat init sayesinde bu işlem gerçekleştirebilir
            };


            #endregion

            #region Records
            //Record=Class
            /* init only properties özelliği, nesnenin üretiminin dışında değişmemesi gereken değerlerin, constuctor ve auto property
             * yapılanmalarıne ek olarak Oject Initializer yapısının kullanılmasını sağlıyordu.
             *
             * RECORD komple nesnenin değiştirilmemesi gereken durumda kullanılır
             * Yani;
             * 4 tane property içeren bir Class'ın 1 propertysi değişmez diğerleri değişebilirse Init Only Properties
             * 4 property'ninde değiştirilemez olmasını istiyorsak 4 tane init tanımlamak yerine RECORD kullanarak yapabiliriz
             * ***NESNE ön plandaysa CLASS
             * ***NESNE'NİN DEĞERLERİ ön plandaysa RECORD
             *
             * MÜLAKAT recordlar bir nesnedir fakat değerleri ön planda olan bir nesnedir
             */

            /* Classlarda nesne ön planda olduğu için değerleri aynı oyna bile Equals(x,y) false olacaktır. Çünkü iki farklı nesne olarak görecektir
             * classlarda tüm propertyler isimlerde aynı olsa false'dır
             *
             * Recordlarda farklı nesnelerde de olsa property değerleri aynı olduğunca Equals(x,y) true verecektir
             *
             */

            RecordOrnekClass m1 = new()
            {
                MyProperty2 = 5

            };
            RecordOrnekClass m2 = new()
            {
                MyProperty2 = 5
            };

            Console.WriteLine( "Class sonuçları : " + " " + m1.Equals(m2));

            MyRecord m3 = new MyRecord()
            {
                MyProperty2 = 5
            };
            MyRecord m4 = new MyRecord()
            {
                MyProperty2 = 5
            };

            Console.WriteLine("Record sonuçları : "+ " " + m3.Equals(m4));

            /*Recordlar'daki değiştirilemez obje'yi class ilede tanımlayabiliriz fakat, RECORD değeri ön planda tutar
             * +daha profesyonel bir kod yazmamızı sağlar
             * + class'ta init olarak tanımladığımız propertylerin değerini değiştirmek istediğimizde, yeni bir nesne üretip proplarını öyle değiştirebiliriz
             * + nesne sayısı çoğaldıkça kod maliyeti artacaktır(reflection veya serialization ilede uygulanabilir)
             * + record kullanılırsa nesne çoğaltılması durumunda yeni With Expressions'ları getirmektedir
             */

            #region With Expressions
            /* immutable(değişmeyen) türlerde çalışırken nesne üzerinde değişiklik yapabilmek için ilgili nesneyi ya klonlamamız(deep copy)
             * ve üzerinde değişiklik yapmamız gerekmekte ya da manuel yeni bir nesne üretip mevcut nesnedeki değerleri,
             * değişikliği yansıtılacak şekilde aktarmamız gerekir.(with function)
             *
             * Record sayesinde with function yazmadan kolayca with expressions ile kullanabiliriz
            */

            ClassWith n = new ClassWith()
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };
            //n.MyProperty2 = 15; // yapılamaz
            ClassWith n2 = new ClassWith() //bu şekilde yapılabilir fakat nesne üretildiği için maliyetlidir
            {
                MyProperty1 = n.MyProperty1,
                MyProperty2 = 15
            };
            ClassWith n3 = n.With(15);//myproperty2'nin 15 değerini verilmiş yeni bir nesne verilir fakat buda maliyetlidir


            //----- RECORD ile Çözüm-------
            RecordWith r1 = new RecordWith()
            {
                MyProperty1 = 5,
                MyProperty2 = 10
            };

            RecordWith r2 = r1 with {MyProperty2 = 15}; // en az maliyetli

            #endregion

            #endregion

            #region Positional Record
            //Record'lar içerisinde constructor ve deconstructor kullanımlarını daha da özelleştirilmesidir

            MyRecord2 r3 = new MyRecord2("berk", "tolay");
            
            var (p, s) = r3;
            


            #endregion

      }

        #region Init-Only Properties
        class MyClass
        {
            public int MyProperty { get; } = 3; //readonly property, ilk değerinide verdik //ilk değeri contructor metotu ilede verebiliriz
        }



        #region Init only property tanımlama

        #region init ornek 1
        class Book
        {

            public string Name { get; init; } = "Kutsal isyan"; //init kullanılan property'ye auto property initializers ilede ilk değer atanabilir
            public string Author { get; init; }

            public Book()
            {
                Author = "Hasan İzzet Dinamo";
            }
        }

        #endregion

        #region İnit örnek 2

        class Ornek2
        {
            private readonly int a; // set çalışmaz

            public int A
            {
                get
                {
                    return a;
                }
                //set{} çalışmaz çünkü readonly
                init
                {
                    a = value;
                }
            }
        }


        #endregion

        #endregion





        #endregion

        #region RECORD

        record MyRecord
        {
            //record bir class olduğu için class'ta tanımlana bilen her şey record'da da tanımlanabilir
            public int MyProperty { get; set; } // init olmasına gerek yok normal property,de konulabilir
            //record içerisinde değer ön  planda tutacaksan tümünü init yap
            //init yapılan tüm propertlerin değerleri ön planda olacaktır
            //recordlarda daha çok init kullanırız
            public int MyProperty2 { get; init; }

            public void X() //metot tanımlanabilir
            {

            }

            public MyRecord() //constructor
            {

            }

            ~MyRecord() //deconstructor
            {

            }

            static MyRecord() //statik constructor
            {

            }
        }

        class RecordOrnekClass
        {
            public int MyProperty2 { get; set; }

        }

        #endregion

        #region With Expressions

        

        class ClassWith
        {
            public int MyProperty1 { get; init; }
            public int MyProperty2 { get; init; }

            public ClassWith With(int property2) //nesne üretim maliyeti
            {
                return new ClassWith()
                {
                    MyProperty1 = this.MyProperty1,
                    MyProperty2 = property2
                };
            }
        }

        record RecordWith
        {
            public int MyProperty1 { get; init; }
            public int MyProperty2 { get; init; }
        }

        #endregion

        #region Positional Record

        //Classic
        //record MyRecord2
        //{
        //    public MyRecord2()
        //    {

        //    }

        //    public void Deconstruct()
        //    {

        //    }
        //}

        //-----positional

        record MyRecord2(string name, string surname)//constructor, destructor
        {
            //name ve surname propları otomatik tanımlanacaktır ve init olacaktır

            //posiitonal record kullanırken kendimize ait bir ctor tanımlarken
            public MyRecord2(): this("BERK","TOLAY")
            {
                
            }

            public MyRecord2(string name) : this()
            {

            }
        }

        #endregion


    }
}
