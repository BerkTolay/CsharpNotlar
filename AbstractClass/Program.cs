using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace AbstractClass
{
    class Program
    {
        //abstract ile tanımlanmış member, kalıtım alan sınıflarda implemente edilmelidir
        //gövdeleri tanımlandığı class'ta tanımlanmaz, sadece imza niteliği taşırlar. Bir şablondur
        //abstract class'larda abstract olmayan elemanlar bulunabilir, bu elemanlar impelemente edilmek zorunda değildir
        //abstract memberlar sadece abstract sınıflarda tanımlanabilir

        //abstract classlar'dan nesne üretilMEZ
        //abstract class'ta tanımlanmış abstract yapılar bu sınıftan kalıtım alan classlar'a zorunlu olarak implemente edilir

        
        static void Main(string[] args)
        {
            Ornek ornek = new Calisma(); 
        }
    }

    abstract class MyClass
    {
        
        public abstract void Y();//gövde oluşturulmaz
        abstract public int MyProperty { get; set; }
    }

    //--------------------------
    abstract class Ornek
    {
        public abstract void X();
        abstract public int Y { get; set; }
    }

    class Calisma : Ornek
    {
        public override void X()
        {
            throw new NotImplementedException();
        }

        public override int Y { get; set; }
    }

   


}
