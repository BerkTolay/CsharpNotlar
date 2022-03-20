using System;

class NameSpaceDisi
{

}

namespace Sınıf
{
    /*clas[isim]
         * {
         *  Nesne oluşturuabilir bir yapılanma bu şekilde oluşturulur. 
         * }
         *
         * classın türü neyse RAM'e yerleştirdiğimizin NESNE'nin de türü o'dur.
         * Herhangi bir OOP destekleyen programlama dilinde oluşturduğumuz class bir referans türdür. Bir türe karşılık gelir
          */

    #region ------Sınıflar 3 farklı yerde oluşturulabilir----  

    #region 1-) NameSpace içerisinde
    //Aynı namespace altındaki classlar birbirlerine isimleriyle erişebilir
    class Namespaceici
    {

    }

    #endregion

    #region 2-)NameSpace Dışarısında
    //Aynı namespace altındaki classlar birbirlerine isimleriyle erişebilir
    //Farklı Namespace altındaki classlar namespace ismi üzerinden birbirlerine erişebilir
    //Namespace DIŞINDA tanımlanan classlara herhangi bir namespace ismi belirtmeden erişilebilir

    #endregion

    #region 3-)Class içerisinde (Nested Type)
    //Mülakat
    //Clas içerisinde oluşturan class, dıştaki classın bir member'ı değildir
    

    #endregion

    #endregion

    //bir class tanımlamasında tanımlanan yerde(namesapece içi/dışı, class içerisinde) aynı isimde birden fazla class tanımlanamaz

    #region -------Sınıf ile Nesne Modeli Tasarlama---------
    //1-)Nesne içerisinde değerler tuttulacaksa FİELD tanımlanmalı
    //2-)Operasyonel işlemler yapılacaksa metotlar tanımlanmalı
    
    class OrnekModel
    {
        //classın içerisinde oluşturulan değerlere FİELD denir
        //Bu classtan nesne oluşturduğumuzda içerisinde int a ve int b olacaktır
        private int a;
        private int b;
        //Her nesnenin içerisinde a,b X() ve Y() vardır
        public void X()
        {
            Console.WriteLine(a + " " +b); //scope dan dolayı a ve b'ye erişebiliyoruz
        }

        public int Y()
        {
            return a * b;
        }
    }

    #endregion

    #region -----Sınıf Modelinden Referans Noktası Oluşturma
    //HEAP'teki nesneye erişmek için Stack'te tanımladığımız değişkenler(referans türlü)
    //Bir class tanımlandığında class adı bir türdür. O türü kullanabilmek için direkt olarak class adını kullannmamız yeterlidir
    //go to Main




    #endregion

    #region MyRegion

    

    #endregion

    class Program
    {
        
        
        static void Main(string[] args)
        {

            //-------Nested Class
            ClassIcindeClass m1 = new ClassIcindeClass();
            //m1.icclass oluşturulamaz
            ClassIcindeClass.icclass m2 = new ClassIcindeClass.icclass();
            m2.a = 5;




            //Main
            OrnekModel w;//referans noktası alma, referans noktası ayarlama, referans alma denir.
            //Şuan herhangi bir nesneyi ifade etmediği için NULL değere sahiptir. Referans türlü değişkenler NULLABLE değişkenlerdir
            // OrnekModel bir class olduğu için değişken türü olarak kullanmamızı sağlayan şey özünde bir referans türlü değişken olmasıdır
            

            //--------Açıklama satırlı class
            AciklamaSatirliClass m3 = new AciklamaSatirliClass();
            m3.X(5);


        }
    }


    //-------Nested Class
    class ClassIcindeClass
    {
        public class icclass
        {
            public int a;
            public string b;
        }
    }


    //-----Class'a açıklama satırı

    /// <summary>
    /// Aciklama satiri konulmuş bir classtır
    /// </summary>
    class AciklamaSatirliClass
    {
        /// <summary>
        /// public tanımlanmış int field
        /// </summary>
        public int a;

        /// <summary>
        /// örnek bir metot overloadı
        /// </summary>
        /// <param name="a parametresi"></param>
        public void X(int a){}
    }
}
