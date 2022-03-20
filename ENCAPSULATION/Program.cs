using System;
using System.Reflection.Metadata.Ecma335;

namespace ENCAPSULATION
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new();
            m.ASet(15);
            Console.WriteLine(m.AGet());
        }

        #region Manuel Encapsulation

        class MyClass
        {
            private int a;

            public int AGet()
            {
                return this.a;
            }

            public void ASet(int value)
            {
                this.a = value;
            }
        }


        #endregion

        #region Property ile Encapsulation

        class MyClass2
        {
            public int A { get; set; } //encapsulation yapılmış


        }

        #endregion
    }
}
