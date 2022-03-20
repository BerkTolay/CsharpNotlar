using System;

namespace Deconstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /* sınıfın nesnesi üzerinden hızlıca özet(istediğimiz propları) olarak Tuple bir değer döndürmemizi sağlar
             * 
             *
             * özel sınıf elemanı olmasına rağmen sınıf ile aynı isim alamaz
             */
            Person person = new()
            {
                Name = "test",
                Age = 17
            };

            var (x, y) = person;

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)// geri dönüş: void olmalı, isim Deconstruct, parametreler out olmalı
        {
            name = Name;
            age = Age;
        }
    }
}
