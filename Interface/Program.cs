using System;

namespace Interface
{
    class Program
    {
        //abstract class içerisindeki prop ya da metotlar barıdıran ve kendisinden kalıtım alan sınıflara implemente ettireceği elemanların
        //imzasını barındıran bir yapıydı

        //interface ise imza kısmına odaklanmış bir yapıdır
        //kendisinden kalıtım alacak sınıflara kendi içerisinde, o elemanların imzasını barındıran bir yapıdır

        //interface'den nesne oluşturulMAZ ama referans noktası alınabilir
        //bir sınıf bir veya birden fazla interface'den kalıtım alabilir

        //interface'de tanımlanmış yapıların gövdeleri kalıtım almış sınıflarda oluşturulur

        //imzalarda erişim nelirleyicileri olmaz
        static void Main(string[] args)
        {
            
        }
    }

    interface IOrnek
    {
        int X();
        void Y();

        int OrnekProp { get; set; }
    }

    class MyClass
    {
        
    }
    class Ornek : MyClass, IOrnek, IOrnek2 //sıralama ilk önce sınıf, daha sonra interface yazılır
    {
        public int OrnekProp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int X()
        {
            throw new NotImplementedException();
        }

        public void Y()
        {
            throw new NotImplementedException();
        }
    }

     class Myclass5 : IOrnek, IOrnek2
    {
        public int X()
        {
            throw new NotImplementedException();
        }

        public void Y()
        {
            throw new NotImplementedException();
        }

        public int OrnekProp { get; set; }
    }


    interface IOrnek2
    {

    }
}
