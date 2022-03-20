using System;

namespace Generic_Class
{

    class Program
    {
        static void Main(string[] args)
        {

            #region Açıklama-Tanım 1
            //normal bir sınıftan daha kapsamlıdır
            //birden fazla tipe özelleştirilmiş sınıftır
            //class MyClass<T> bu şekilde tanımlanır. T: type'ın T sini temsil eder. <buraya yazılan değişken bir tipi temsil edecektir>
            //T, MyClass sınıfından oluşturan referans ya da nesnelerde farklı bir sınıfın tipini alacak olan değişkendir

            MyClass<Ornek> m1 = new MyClass<Ornek>();//T ornek tipine bürünür

            #endregion

            #region Açıklama-Tanım 2

            MyClass2<Ornek, SqlConnection> m2 = new MyClass2<Ornek, SqlConnection>();

            #endregion

            #region Base Class Constraint
            //parametreye bir kısıtlama getirmemizi sağlar

            MyClass3<A> m3 = new MyClass3<A>();//T parametresi A veya A'dan türeyen sınıfları refere edebilsin

            MyClass3<B> m4 = new MyClass3<B>();//T parametresi B veya B'dan türeyen sınıfları refere edebilsin


            #endregion

            #region New Constraint
            //generic sınıfın parametreye gelen sınıftan nesne oluşturup oluşturamayacağımızın kısıtlamasını sağlayan bir yapıdır

            #endregion

        }
    }

    #region Açıklama-Tanım 1

    class MyClass<T>
    {
        private T t;//örnek tipinden bir referans oluşturduk


    }

    class Ornek
    {

    }

    #endregion

    #region Açıklama-Tanım 2

    class MyClass2<T, T2>
    {
        private T t;
        private T2 t2;

        public void X()
        {
            //t2 = new T2();//t2 değişkinine verilen tipin nesne oluşturulamama ihtimali var
            //t2 sembolüne gelecek olan tipin sınıfının ctor'u private olabilir
            //ctor'u parametre alıyor olabilir
            //static bir sınıf olabilir
            //interface olabilir
            //t2'ye verilecek sınıfın kesinlikle nesne üretebilir bir sınıf olduğunu bildirmemiz gerekiyor(new Constraint)
        }
    }

    class SqlConnection
    {

    }

    #endregion

    #region Base Class Constraint
    
    class MyClass3<T> where T : A //t tipi A veya A'dan türeyen sınıfları temsil edebilir
    //class MyClass3<T> where T : class -> ise T sadece bir sınıf yapısında bir elemanı/tipi refere edebilir 
    {
        private T t;

        public void X()
        {

        }
    }

    class A
    {

    }

    class B : A
    {

    }

    class C : B
    {

    }

    class D : C
    {

    }


    #endregion

    #region New Constraint

    class MyClass4<T> where T : new()//nesne üretilebilir bir sınıf verileceğini bildiriyoruz
    {
        public void X()
        {
            T t1 = new T();
        }

    }

    //+++++++++++++++++
    //bir generic class'a aynı anda hem base class, hemde new constraint uygulanabilir
    //ilk önce class olduğunu belirtip ardından new constraint uygulanabilir
    class MyClass5<T> where T : class, new()

    {

    }

    #endregion


}
