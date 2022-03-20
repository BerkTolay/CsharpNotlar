using System;

namespace Polimorfizm
{
    class Program
    {

    //bir nesnenin birden fazla farklı türdeki referans tarafından işaretlenebilmesi polimorfizmdir
    //nesne birden fazla türün davranışını sergileyebilmesini sağlarız
    //bir nesneyi kendi türünün dışındaki bir tür ile işaretleyebilmek için kesinlikle türemiş olmalıdır
        static void Main(string[] args)
        {
            MyClass m = new N();
            N n = new N();

            #region Ornek

            C c = new C();
            c.X();
            c.Y();
            c.Z();

            B b = new C();//sadece B'nin nitelikleri gelecektir
            b.X();
            b.Y();
            //b.Z();// B referans ile, bu nesnenin B türüne ait davranışlarına erişebiliriz C'ye ait davranışa erişemez
            //b referansı bir sınırlama getiriyor

            A a = new C();
            a.X();
            //a.Y();
            //a.Z();

            #endregion
        }
    }

    class MyClass
    {
        
    }

    class N : MyClass
    {

    }


    #region Ornek

    class A
    {
        public void X()
        {

        }
    }

    class B:A
    {
        public void Y()
        {

        }
    }

    class C:B
    {
        public void Z()
        {
            Console.WriteLine("asdasd");
        }
    }

    #endregion
}
