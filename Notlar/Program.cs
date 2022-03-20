using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;


namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Todo

            //açıklama satırının başına yazılırsa Görünüm->Görev listesinden kolayca erişilebilir
            //todo ornek

            #endregion

            #region Primitive Type

            //en ilkel türdür, türetilmemiştir.
            //byte primitive türdür, decimal ise bytelardan meydana gelmiştir primitve değildir.
            //Console.WriteLine(typeof(int).IsPrimitive);//verilen türün primitve olup olmadığını verir


            #endregion

            #region BreakPoint

            //breakpoint konulan koda gelince complier orada durur F10 ile adım adım devam edilir, f5 sonlandırır

            #endregion

            #region WatchPenceresi

            //debug modda değişkene sağ tıklayıp add watch denilirse, kodlar tetiklendiğinde değişkenler hangi halleri alır gösterir


            #endregion

            #region STACK

            //degişken türü, adı ve değeri stackte tutulur
            //metotlar stackte tutulur
            //FIFO mantığına göre çalışır

            #endregion

            #region @

            //@ işareti anlamlı isimleri ezer
            // string static; hata verir
            //string @static; hata vermez

            #endregion

            #region Tuple

            //Bir nesnedir.
            //Tekbir syntax üzerinde fazla değişken tanımlanabilir
            //(int yas, string adi, bool medenihal) kisi = (10, "B", true);
            //kisi.yas = 4;

            #endregion

            #region _

            //int sayi = 1_000_000;


            #endregion

            #region defaultdegerler

            //default degerini ogrenmek için;
            //bool ornek = default(bool);

            #endregion

            #region Sabitler/degismezler

            //const STATICTIR, degeri degistirilemez bir sabittir.
            //constlar tanımlanırken degeri atanmalıdır
            //readonly sadece okunabilir degerlerdir. consttun farkı, constructor içinde de degeri atanabilir,  tanımlanırkende atanabilir.
            //readolny STATIC degildir

            //double pi = 3.14;
            //const double pi = 3.14;


            #endregion

            #region GlobalDegiskenler

            //degisken class icerisinde(memberı oluyorsa) tanımlanıyorsa global degisken denir.
            //metot icinde tanimlaniyorsa buna local degisken denir.

            #endregion

            #region DeepCopy

            //eldeki veri cogalir/klonlanir
            //int a = 5;
            //int b = a;
            //a = 7;
            //Console.WriteLine("{0}", b);

            #endregion

            #region Object Boxing/Unboxing

            //object tum turleri kapsar
            //referans turlu bir degiskendir  
            //object icine konulan degeri(boxing), turune ozgu islemlerde kullanmak icin unboxing yapılmalı
            //Cast operatoru: unboxing islemini yapar, cast operatoru=()'dir.
            //int a=5;
            //object b=a; boxing
            // b= b*6; yapılamaz 
            //(int)b; unboxing
            //** int türünde boxing edilmiş bir veri int türünde unboxing edilmeli, yoksa runtimeda hata verir

            #endregion

            #region VAR

            //tutulacak türün değerine uygun bir degisken tanımlayabilmek için kullanılan keywordtür
            //var medeniHal=true; complier otomatik bool yapar
            //var bir tür değildir.
            //farklı diller arasında desteklenmeyen türler arasındaki verileri karşılayabilmek için oluşturulmuş ortak bir keywordtür.
            //tanımlarken değer verilmeli, ilk değer verildikten sonra o değerin türüne bürüneceği için sonraki durumlarada değeri farklı türlerde verilemez
            //var bir keywordtür, tür değildir

            #endregion

            #region Dynamic
            // runtime da türü belirler
            //türünü bildimediğimiz veri geldiğinde kullanılır
            //dynamic program çalışana kadar atanan veriyi dynamic olarak tutar
            //dynamic a=5;

            //dynamic a="berk"; //runtime da tür belirlenir
            //Console.WriteLine(x.GetType());
            //x = 3.14D;
            //Console.WriteLine(x.GetType());

            #endregion

            #region Parse Metodu

            //string dataları hedef türe dönüştürmek için kullanılır 
            //char y=char.Parse(string ifade)

            #endregion

            #region ToString

            //her veri .ToString komutu ile dönüştürülebilir


            #endregion

            #region TurDonusumu

            //Biliçli ve bilinçli tür değişimi diye ikiye ayırırırz
            //sadece sayısal türlerler olur
            //daha geniş bir türe dönüştürecesek buna BİLİNÇSİZ tür dönüşümü denir. /örn: int i long a çevirmek
            //daha dar bir türe yani olası veri kaybını kabul ettiğimiz bir dönüşüm ise buna BİLİNÇLİ tür dönüşümü denir /örn: inti shorta çevirmek shortun en büyük değerine göre mod alınır

            #endregion

            #region BilincliTurDonusumu

            //gerceklestirmek için cast operatoru kullanılır
            //int x = 60000;
            //short y = x; calismaz
            //short y = (short) x;


            #endregion

            #region **BilincliTurDonusumu

            //int a = 3000;
            //short s = (byte) a;  //eşitlik sağ taraf bilinli tür dönüşümü, tüm ifade bilinçsiz


            #endregion

            #region Checked-Uncheck

            //bilinçli tür dönüşümünde eğer veri kaybı varsa bize runtime da uyarı verir

            //checked
            //{
            //    int a = 500;
            //    byte b = (byte) a;
            //    Console.WriteLine(b);
            //}

            //unchecked //default olan durumdur uyarı vermez
            //{
            //    int a = 500;
            //    byte b = (byte) a;
            //    Console.WriteLine(b);
            //}

            #endregion

            #region *AritmetikOperatorler

            //İki sayısal değer üzerinde işlem yapan operatörler oldukları için işlem sonucunda geriye "uygun türde" sonuç dönerler
            //int sonuc = 3 + 5; // + operatoru int ile inti topladığı için int döner

            //int x=3, y=5;
            //int sonuc = x * y; // int döndürür

            //(double) + (double) -> double döner

            // (double) + (int) -> inti bilinçsiz olarak double a dönüştürüp işlemi yapar, double döndürür

            // (byte) *,+,-,%,/ --(byte) -> her zaman int döner (istisna)


            #endregion

            #region *MantiksalOperatorler

            // ^ ya da operatörü

            #endregion

            #region TernaryKalıbı(?:)

            //Bir değişkene/metoda/property' ye değer atarken eğer ki bu değer şarta göre fark edecekse satır bazlı/tek satırda bu şart
            //kontrolünü yaparak duruma göre değeri döndürmemizi sağlayan bir kalıpsal operatördür

            //     ....sart/durum...      ?       .............    :  .............
            // //bool sonuc döndürür//          //sart doğruysa//    //sart yanlışsa//
            // dönecek değerler aynı türde olmalıdır int/int string/string
            // polimorfizm kurallarına göre birbirlerinden türüyen değerlerde desteklenmektedir c# 9.0

            //bool medeniHal = true;
            //string mesaj = medeniHal == true ? "Evli" : "bekar";
            //Console.WriteLine(mesaj);

            //int yas = 25;
            //string sonuc = yas < 25 ? "A" : (yas == 25 ? "B" : "C");
            //Console.WriteLine(sonuc);



            #endregion

            #region Typeof

            //verilen değerin tipini verir
            //ileri düzey programlşamada reflection konusunda, elimizdeki türün reflectionına girmek için kullanılır

            //Type t = typeof(int); //int türüne ait tüm bilgiler burada t değişkenine atanır
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.IsPrimitive);

            #endregion

            #region Default

            //belirtilen türün default değerini döndürür
            //Console.WriteLine(default(int));

            #endregion

            #region IsOperatoru

            //boxing yapılmış bir değerin öz türünü öğrenmek için kullanılır
            //object x = false;//boxing
            //polimorfizm is operatöyle kalıtımsal durumlardaki nesnelerin türlerini öğrenmede kullabılır

            //Console.WriteLine(x is bool); // true ya da false gönderir

            #endregion

            #region IsNull-IsNotNull

            //is null: değişkenin değerinin null olup olmadığını kontro leder ve geriye bool döndürür
            //string a = null;
            //Console.WriteLine(a is null);
            //is null sadece null olabilen türlerde(referans türlerde) kullanılır
            //int b = 3;
            //Console.WriteLine(b is null);//hata verir

            //Console.WriteLine(a is not null);

            #endregion

            #region AsOperatoru

            //cast operatörünün unboxing işlemine alternatif olarak üretilmiştir
            //cast operatörü, boxing edilmiş değerin türüne uygun dönüşüm yapar. Uygun tür verilmezse program hata verir

            //as operatörü eğer uygun tür değilse null geri döndörür hata vermez

            //prototip: x as Type
            //as operatörü null olabilecek türlerle çalışır yani değer türlü değişkenlerde kullanılamaz örn int te kullanılamaz 

            //object x = "top";
            //string y = x as string;
            //Console.WriteLine(y);

            #endregion

            #region Nullable

            //değer türlü değişkenler null değerini alamazlar
            //? operatörü ile null değeri verilebilir
            //nullable yapılmış değer türlü değişkenlerde is null/ in not null/as operatörleri kullanılabilir
            //int? a = null;
            //bool? b = null;
            //bool? c = false;

            #endregion

            #region Null-Coalescing

            //elimizdeki değer null olma durumuna göre farklı bir değeri göndermemizi sağlar
            //string a = null;
            //Console.WriteLine(a ?? "Merhaba"); //a null ise merhaba yazdır değilse kendi değerini yazdır

            #endregion

            #region Null-Coalescing-Assignment

            //değişkenin değeri null ise istenileni yazdır ve içine değeri ata

            //string x = null;
            //Console.WriteLine(x ??="Merhaba");// x in değeri null ise ekrana merhaba yazdırır + x in değerini merhaba yapar

            #endregion

            #region Switch

            #region Switch-When

            //int SatisTutar = 1000;
            //switch (SatisTutar)
            //{
            //    case 1000 when (3 == 5):
            //        Console.WriteLine("ilk blok");
            //        break;
            //    case 1000 when (3 == 3):
            //        Console.WriteLine("ikinci blok");
            //        break;
            //}

            #endregion

            #region *Switch-Expressions

            //tek satırlık işlemler için maliyet düşürür

            #region eski

            //string isim = "";
            //int i = 10;
            //switch (i)
            //{
            //    case 5:
            //        isim = "berk";
            //        break;
            //    case 7:
            //        isim = "tolay";
            //        break;
            //}


            #endregion

            #region yeni

            //int i = 10;
            //string isim = i switch

            //{
            //    5 => "berk",
            //    7=>"tolay",
            //};


            #endregion

            #endregion

            #region *Switch-Expressions + When

            //int i = 10;
            //string isim = i switch

            //{
            //    5 when 3==3 => "abc",//i 5 ve sağdaki durum true ise şart sağlanır
            //    var x when x==7 && x % 2 == 1 => "asd",
            //    10 => "a",
            //    int y when y == 5 => "ddd",
            //    var x => "hicbiri",// bu default tanımlamasına karşılık gelecektir


            //};

            #endregion

            #region **Switch-Expressions + Tuple Patterns

            //int s1 = 10;
            //int s2 = 20;
            ////string mesaj = "";
            ////switch (s1,s2)
            ////{
            ////    case (5, 10):
            ////        mesaj = "5 ile 10";
            ////        break;
            ////    case (10, 20):
            ////        mesaj = "10 ile 20";
            ////        break;

            ////}

            //string mesaj = (s1, s2) switch
            //{
            //    (5, 10) => mesaj = "5 ile 10",
            //    (10, 20) => mesaj = "10 ile 20"
            //      (_,_) => "hiçbiri";
            //};


            #endregion

            #endregion

            #region *Positional Patterns

            //desconstruct özelliği olan nesneleri kıyaslamak veya değersel karşılaştırmak için kullanılır

            #endregion

            #region *Property Patterns

            //araştır


            #endregion

            #region Type Pattern

            /* Type Pattern, object içerisindeki bir tipin belirlenmesinde kullanılan is operatörünün desenleştirilmiş halidir
             * is ile belirlenen türün direkt dönüşümümü sağlar */

            //object x = 125;
            ////if (x is string)
            ////{
            ////    string xx = x as string;
            ////}            
            ////else if (x is int)
            ////{
            ////    int xx = (int)x;
            ////}

            //if (x is string xx) // eğer string ise, x'in tipini string yapıp xx e atar
            //{
            //    Console.WriteLine("berk");
            //}
            //else if (x is int xy)
            //{ 
            //    Console.WriteLine("x int");
            //}
            //if parantezinde tanımlanan string x if dışında kullanılabilir ama console.writline ile yazılamaz çünkü null olma ihtimali vardır
            #endregion

            #region Constant Pattern
            /*elimizdeki bir veriyi sabir bir değer ile karşılaştırabilmemizi sağlar, == operatörü gibi kullanılırsa constant pattern'dır.
             *referans türlü olmak zorunda değil, değer türlü değişkenler ve primitive türlerde bile kullanılabilir.
             *a is int, a is bool, a is string -> tür kontrolü yapılıyorsa bu Constant Pattern DEĞİLDİR */

            //object x = 123;
            //if (x is 123)
            //{

            //}
            //if(x is int)
            //{

            //}

            #endregion

            #region Var Pattern
            /* eldeki veriyi 'var' keywordü ile elde etmemizi sağlar 
            * x'in türü ne olursa olsun runtime'da var türünde çıkartır
            * Mülakat**var ın türü runtime da belirlenir, normal var'da derleme zamanında belirlenir, dynamic pattern olarak kullanılamaz
            */

            //object x = "Türkiye";
            /* var b ="berk"; derleme zamanında çalışır */
            //if (x is var a) // runtime da çalışır
            //{
            //    Console.WriteLine(a);
            //}

            #endregion

            #region Recursive Pattern
            /* tür kontrolü yaptığı için Type pattern + case null komutu ile turun referansının null olup olmadığını kontrol edebilmesinden dolayı
             * constant patterni kapsar */
            #endregion

            #region Pattern Matching

            #region Type ve Var Pattern Üzerine
            //bool result = x is string; // is operatörü kullanımı
            //bool result = x is string o; // eğer x string değilse 'o' null olur
            //Console.WriteLine(o); // o null ise kullanılamaz


            //bool result = x is var o;
            /* var runtime da türünü belirler o yüzden aşağıda hata vermez. Null olup olmadığı runtime da belirlenir.
             * Türü ne olursa olsun var a atayacağı için NULL gelme olasılığı yok
            */
            //Console.WriteLine(o);


            #endregion

            #region Simple Type Pattern
            //type pattern ile yapılan tür bildirimlerinin yanına değişken adı gerekliydi bununla birlikte gerekli değil c#9.0

            //ESKİ
            //object obj = new Person();
            //switch (obj)
            //{
            //    case Person p: //eski
            //        //..

            //}

            //YENİ

            //switch (obj)
            //{
            //    case Person: //yeni
            //        //..
            //        break;
            //}


            #endregion

            #region Relational Patterns
            //desenlerde < > <= >= operatörleri kullanılabilir

            //int number = 111;
            //string result = number switch
            //{
            //    < 50 => "50den küçük",
            //    > 50 => "50den büyük",
            //      50 => "50ye eşit"
            //       _ => "hiçbiri",
            //};

            #endregion

            //Mülakat if-switch farkı, switch sadece eşitlik durumuna bakmakta if tüm karşılaştırmaları yapar
            //relation pattern sayesinde switch tüm karşılaştırmalara yapabilir

            #region Logical Patterns
            // and or ve not gibi mantıksal operatörler kullanılır
            //int number = 111;
            //string result = number switch
            //{
            //    > 10 and <50 => "50den küçük",
            //    > 50 or <100 and 60 => "50den büyük",
            //     50 => "50ye eşit",

            //};

            #endregion

            #region Not Patterns

            //string GetProduct(IProduct p) => p switch
            //{
            //    Technologic => "Teknolojik",
            //    Computer=>"Bilgisayar",
            //    not Goggles => "Gözlük"
            //};

            //object obj = new Goggles();
            //if(obj is not Technologic)
            //{
            //    //obj tecnologic değilse if koşulu sağlanır
            //}


            #endregion

            #endregion

            #region Hata Kontrol Mekanizmaları
            //try'a minimum kod konulmalı, sürekli kontrol edeceği için maliyetlidir

            #region Try-Catch
            /*uygulama sürecinde olası hatayı kullanıcıya hissettirmeden, farklı bir durum veya olağan bir mesaj gibi gösterir
            *hataya dair log oluşturulabilir 
            *Amaç: Kullanıcıya hatayı hissettirmemek
            *Hatanın nedenina dair kullanıcıyı bilgilendirmek
            *İşletim sistemi hata olduğunda uygulamayı sonlandırır
            *Try catch ile uygulama sonlanmadan devam edilmesini sağlar
            */

            //try
            //{
            //    //olası runtime hatalarını verebilecek kodlar buraya yazılır
            //}
            //catch (Exception)
            //{
            //    //try içerisinde hata varsa kodun akışı orada kesilir ve akış bu bloktan devam eder
            //    throw;
            //}


            //ORNEK--
            //try
            //{
            //    Console.WriteLine("lütfen birinci sayıyı gir");
            //    int sayi1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("lütfen ikinci sayıyı gir");
            //    int sayi2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("toplam : " + (sayi1 + sayi2));

            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("hata");
            //}



            #endregion

            #region Try Catch Parametleri

            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int a = s2 / s1;
            //}
            //catch (Exception ex) //exception hatayla ilgili tüm bilgileri getirecek olan bir üst türdür(atasıdır), bütün hataları karşılayabailir
            //{
            //    /* exception parametresi yazılmak zorunda değildir, tanımlama yapılmazsa hataya dair bilgi alınamaz */
            //    Console.WriteLine("Mesaj : " + ex.Message);
            //}

            #endregion

            #region Exception Dışında farklı bir tür ile hata yakalama

            //try
            //{
            //    int s1 = 2, s2 = 10;
            //    int a = s2 / s1;

            //    int.Parse("berk"); 
            //}
            //catch (DivideByZeroException ex) // sadece belirtilen hatayı yakalayabilir
            //{
            //    Console.WriteLine("Mesaj :" + ex.Message);
            //}

            ////+++
            ////sıralama önemlidir, "Exception ex" en sona yazılmalı.
            //catch(FormatException ex) // formatexception hatasında çalışacak blok
            //{

            //}

            //catch (Exception ex) // default
            //{

            //}

            #endregion

            #region Finally
            // try catch de hata alınsada alınmasada, her iki durumda da çalışması gereken kodların yazdılığı bloktur.

            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            //finally // en sona tanımlanmalı
            //{

            //}
            #endregion

            #region When Yapısı ile
            //string x = "c";
            //try
            //{
            //    int s1 = 0, s2 = 10;
            //    int a = s2 / s1;
            //}
            //catch (DivideByZeroException ex) when(x=="a") //dividebyzero ile when şartının true olması lazım
            //{

            //    throw;
            //}
            //catch (DivideByZeroException ex) when (x == "b")
            //{
            //    throw;
            //}

            ////hiçbir catch bloguna girmezse hata verirse kullanıcıya gösterecektir, en son exceptin catch yapılmalı
            #endregion


            #endregion

            #region For döngüsü
            //for (int i = 0, k=0; i < 10 && k < 5; i++, k++)
            //{

            //}



            #endregion

            #region Sonsuz dönğü
            //bool dongu = true;
            //for (; dongu;)
            //{
            //    if (true)
            //    {
            //        dongu = !dongu;
            //    }
            //}
            #endregion

            //int gibi değikenler konseptli keywordlerdir( yani o konsepte uygmalıyız, switch try-catch konseptlidir)
            //goto, return gibi keywordlar konseptli değildir

            #region Diziler
            /* koleksiyonların temelini oluşturur
            *Referans türlü değişkenlerdir yani nesnel yapıdadırlar
            *Özlerinde classtırlar
            *Yapısal olarak HEAP'te tutulurlar.
            *Dizilere her türlü değer konulabilir(değer türlü-referans türlü) sadece tek bir türde değer alabirler.
            *
            * eleman sayısı kesinlikle belirtilmeli 0 <=, bu durum bir sınırlılıktır. Bunun yönetilebilmesi gerekir. Çünkü alan arttırılıp azaltılamaz.
             */

            /*
             * Dizilere atama yaparken o anki indis bilinmesi gerekli + indexer operatörünün çok kullanılması
             * + eleman sayısının arttırılıp azaltılamaması gibi sınırlamalar yüzünden koleksiyonlar türetilmiştir
             * koleksiyonlar türetilmiş olduğu için(diziler programlama dili seviyesindedir) diziye göre DAHA YAVAŞ ÇALIŞIR
             * Diziler daha hızlı ve maliyeti daha düşüktür.
             */

            #region Diziler Temel

            //int[] ages = new int[5]; //ages stackte tutulur, HEAP'deki nesneyi işaret eder(5 birimlik bir diziyi)

            //int[] yaslar = { 2, 3, 4, 5, 6, 7 };

            //string[] isimler = { "asdasd", "asdasd", "asdasdasd" };
            //string[] isimler1 = new string[] { "asdasd", "asdasd", "asdasdasd" };

            //string[] isimler2 = new string[3] { "asd", "ads", "gasd" }; // belirtilen sayi kadar değer girilmelidir

            //int[] sayilar = new int[] { 3, 5, 7 };
            //var sayilar1 = new int[] { 3, 5, 7 }; // hepsi aynı türde olursa editör otomatik tür tanımlar  { 3, 5, 7, "asdsa" } hata verir

            #endregion

            #region Array Sınıfı
            /* Dizi=Array Sınıfı yani dizi referans türlüdür
             * Dizi olarak tanımlanan değişkenler array sınıfından türetilmektedirler.
             *  
             */

            //int[] yaslar0 = new int[5]; // Dizi kendi türünde tutuluyorsa/referans ediliyorsa indexer operatörü kullanılabilir, operatif çalışılabilir
            //                            // Algoritmalarda tercih edilir çünkü indexer algoritmalarda kullanılır
            //Array yaslar1 = new int[3]; // Dizi array türünde referans ediliyorsa indexer operatörünü kullanılamaz, operatif çalışılaMAZ fonksiyonel çalışılır
            //                            // Dizi üzerinde işlemler yapılıyorsa sıralama, boyut ölçümü vb. array kullanılır.

            //Array dizi = new int[3];
            //dizi[0] = 123123; // yapılamaz

            #endregion

            #region Array Sınıfı-2

            //1.YÖNTEM
            //int[] dizi = new int[3];
            //dizi[0] = 30;
            //dizi[1] = 31;
            //dizi[2] = 32;
            //Array dizi2 = dizi; 

            //2.YÖNTEM PARAMETRİK OPERATÖRSEL YAKŞALIM
            //Array dizi = new int[] {3, 5, 7, 9};
            //Array dizi2 = new int[4] { 3, 5, 7, 9 };
            //Array dizi3 = new[] { 3, 5, 7, 9 };
            //Array dizi3 = { 3, 5, 7, 9 }; //Kullanılamaz

            //3.YÖNTEM FONKSİYONEL YAKŞALIM
            //Array dizi = new int[3];
            //dizi.SetValue(30, 0);
            //dizi.SetValue(31,1);
            //dizi.SetValue(32,2);
            #endregion

            #region Array Sınıfı Değer okuma

            //Array dizi = new int[3];
            //dizi.SetValue(30, 0);
            //dizi.SetValue(31, 1);
            //dizi.SetValue(32, 2);

            //object value=dizi.GetValue(1); // ilgili değer neyse object ile gönderir
            //Console.WriteLine(value);

            #endregion

            #region Array Sınıfı Clear Metodu
            //Dizinin türüne uygun olarak tüm elemanlara varsayılan değeri atar **tüm elemanaları siler yanlış bir tabir

            //Array isimler = new[] {"Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah"};
            //Array.Clear(isimler,0,isimler.Length); // 0. indisten, isimler.Lenght ADET 
            //for (int i = 0; i < isimler.Length; i++)
            //{
            // Console.WriteLine(isimler.GetValue(i));   
            //}

            #endregion

            #region Array Sınıfı Copy Metodu
            //elimizdeki bir dizinin verileirini başka bir diziye kopyalar

            //1
            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            //string[] isimler2 = new string[isimler.Length];
            //Array.Copy(isimler,isimler2,5);
            //for (int i = 0; i < isimler2.Length; i++)
            //{
            // Console.WriteLine(isimler2[i]);   
            //}

            //2 Overload
            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            //string[] isimler2 = new string[isimler.Length];

            //Array.Copy(isimler,2,isimler2,3,2);
            //for (int i = 0; i < isimler2.Length; i++)
            //{
            //    Console.WriteLine(isimler2[i]);
            //}

            #endregion

            #region Array Sınıfı İndexOf Metodu
            //dizinin içerisinde bir elemanın var olup olmadığını sorgular
            //Aranan değer varsa int olaraka o değerin index numarasını gönderir, yoksa -1 döndürür
            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            //string[] isimler2 = new string[isimler.Length];

            //int index=Array.IndexOf(isimler, "Rıfkı");
            //if (index!=-1)
            //{
            //    //demekki arannan değer dizide var
            //    Console.WriteLine("var");
            //}

            //int index=Array.IndexOf(isimler, "Rıfkı", 0, 3);//0. indexten başla 3 ilerisine kadar ara

            #endregion

            #region Array Sınıfı Reverse Metodu
            //Dizinin elemanları tersine sıralar

            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            //string[] isimler2 = new string[isimler.Length];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            //Array.Reverse(isimler);
            //Console.WriteLine("**********");
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}

            //Console.WriteLine("---------------");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            //Array.Reverse(isimler, 0, 3); // 0 dan başla 3 elemanı dönüştür
            //Console.WriteLine("**********");
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}


            #endregion

            #region Array Sınıfı Short
            //sıralama yapar

            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };


            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            //Array.Sort(isimler);

            //Console.WriteLine("***********");

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine(isimler.GetValue(i));
            //}
            #endregion

            #region Array IsReadOnly Propertysi
            //Dizinin okunabilir olup olmadığını bool türünde bildirir
            //Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
            //Console.WriteLine(isimler.IsReadOnly); //sadece okunabilirse true verir

            #endregion

            #region Array IsFixedSize
            //bir veri kümesinin eleman sayısının sabit olup olmama durumunu IsFixedSize ile öğrenilebilir, tüm dizilerde dizilerin eleman sayısı sabittir(Arraylist hariç)


            #endregion

            #region Array Rank Propertysi
            //ilgili diznin derece sayısını verir  int[] 1 dereceli , int [,] 2 dereceli, int[,,] 3 dereceli


            #endregion

            #region Array CreateInstance Metodu
            //int[] yaslar = new int[3];
            // yukarıdaki kod array sınıfının createinstance metodunu kullanmaktadır
            //Bu metodu kullanarak fonskiyonel diziler oluşturabiliriz
            //Array.CreateInstance(typeof(int), 3);//int tipinde, uzunluğu 3 olan array tanımla

            //Çok boyutlu dizi tanımlamak

            //Array.CreateInstance(typeof(int), 5, 3, 5, 6); //4 dereceli bir dizi


            #endregion

            #region Çok Boyutlu Diziler

            //int[,] sayilar = //(3,4) dizi
            //{
            //    {3, 5, 7},
            //    {5, 6, 7},
            //    {15, 36, 57},
            //    {95, 45, 34}
            //};

            #endregion

            #region Düzensiz Diziler
            //dizinin her elemanının ayrı bir dizi olmalı. Sütun sayıları değişkendir

            //int[][] sayilar = new int[3][];

            //sayilar[0] = new int[3] {3, 5, 7};
            //sayilar[1] = new int[5] {1, 2, 6, 6, 7};
            //sayilar[2] = new int[10] {9, 7, 3, 6, 7, 8, 5, 4, 7, 8};

            //length 3 değerini verecektir. 

            #endregion

            #endregion

            #region Ranges and Indices
            //C# 8.0
            //System.Index ve System.Range özellikleri + .. ve ^ operatörleri gelmiştir.
            //Veri kümesindeki hedef verilere ağır algoritmalar yerine bu özelliklerle daha hızlı odaklanmamızı sağlar

            #region System.Index
            /*Dizi ve koleksiyonlardaki index kavramını tür olarak belirlenmiş halidir
            *  ^ ifadesiyle birlikte indexi sondan başlatabiliriz (sondan 1 2 3 diye sıralanır, baştan 0 1 2 3 şeklinde)
            * Örneğin 7 elemanlı bir veri kümesi olsun, normalde index i=3; denildiğinde 0 1 2 *3* 4 5 6 ifade edecektir
            *  index i=^3; denirse 0 1 2 3 *4* 5 6 ifade edilecektir
             */

            //string[] isimler = new[] {"SIFIR", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "Altı"};
            //Index index = 3;
            //Console.WriteLine(isimler[index]);
            //Console.WriteLine("******");
            //index = ^3;
            //Console.WriteLine(isimler[index]);

            #endregion

            #region System.Range
            //Veri kümelerinde hangi değerler ile çalışacağımızı belirleyebilmek için index üzerinden .. operatörü ile aralık verebiliriz
            // index..sırano

            //string[] isimler = new[] { "SIFIR", "BİR", "İKİ", "ÜÇ", "DÖRT", "BEŞ", "ALTI","YEDİ","SEKİZ","DOKUZ","ON","ONBİR","ONİKİ" };
            //Range range = 3..7; // 3 index no , 7 sıra NO'dur !!! "İKİ"= 2. indexte fakat 3. sıra No'da dır.

            ////** yukarıda kod "ÜÇ" ile "ALTI" arasını range türünde geri getirecektir. İlgili aralığı bir diziymiş gibi kullanabiliriz.

            //Range range2 = 3..^6; // ..^ ile sıra no tersten sayılacaktır yani ^6="YEDİ" değerini gösterir fakat o eleman dahil edilmeyecek bir önceki "ALTI" değerini gönderecektir

            //Range range3 = ^6..^3; // sağdan 6 = "YEDİ"yi işaret eder(solda olduğu için kayma yapmaz) ve gönderir, ^3 sağdan kayma yapıp sağdan 4.yü("DOKUZ") gönderecektir

            //var isimler2=isimler[range3];
            //for (int i = 0; i < isimler2.Length; i++)
            //{
            //    Console.WriteLine(isimler2[i]);
            //}

            //Range range4 = ..; // tüm diziye karşılık gelmektedir, tüm diziyi kopyalar


            #endregion

            #region .. Operatörü
            // index..index sağına soluna sayısal bir değer alabildiği gibi özü itibariyle System.Index türünden de değerler alabilir Geriye döndürülen yapı System.Range türünden olur

            //int[] sayilar={1,2,3,5,7,9,31,56,78,321,457,534,5643};

            //Index i1 = 5, i2 = 10;

            //Range range=i1..i2;
            //var sayilar2 = sayilar[range];
            ////var sayilar2 = sayilar[i1..i2]; //çalışır
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //   Console.WriteLine(sayilar2[i]);
            //}


            #endregion

            #endregion

            #region String
            //referans türlü olduğu halde programlama dilinde bir keyword barındıran bir değerdir(diğeri objecttir).

            //int a = 5; //bir değer türlü değişken belleğin stack kısmında kendi değeriyle beraber tutulur
            //string b = "berk";// (string)b -> stackte, "berk" heapte tutulur. b "berk"i referans eder. "berk" nesnedir

            #region NULL-Empty
            /*bir değişken nullable veya referans olabilir eğerki NULL alıyorsa, bu durum değişkene bellekte bir yer tanımlanmadığı/ayrılmadığı belirtilir.
            *empty ise alan tahsisi yapılmıştır fakat içi boştur
            *Değer türlü değiikenler null alamazlar, sadece referans türler NULL alabilir
            * Değer türlü değişkenlerin NULL alabilmesi için nullable olmalıdır => int? a=null;
            *Tüm değerlere empty verilebilir
            *Default değerlere empty denilir
            *Empty bellekte yer kaplar null kaplamaz
             *NULL olan bir değer üzerinde bir işlem yapmaya çalıştığımızda runtime hatası verir
             *Empty de işlem yapılabilir
            */
            //int a = 0;//empty
            //bool c = false;//empty

            //string b = "";//empty =>alan tahsisi yapılmış
            //string b2 = string.Empty// yukarıdaykiyle aynı;
            //string _b = null;//alan tahsisi yok


            #endregion

            #region IsNullOrEmpty
            ////string ifadeleri kullanmadan önce kesinlikle kontrol edilmesi gerektirmektedir


            //string x = "";//Empty

            ////if(x != "")
            //if (x != string.Empty && x is not null)
            //{

            //}

            ////IsNullorEmpty string ifadenin null ya da empty olup olmadığını kontrol eder ve bool türde sonuç gönderir.
            ////Değer null ya da empty ise geriye true gönderir

            //if (string.IsNullOrEmpty(x))
            //{

            //}
            #endregion

            #region IsNullOrWhiteSpace
            //Fonksiyonu string ifadenin null empty veya boşluk karakter olma durumunda geriye true döndürür.
            //Bazı uzaktan veri gönderen servisler string ifadeye boş olarak gönderebiliyor

            //string x = "       ";
            //if (string.IsNullOrWhiteSpace(x))
            //{

            #endregion

            //string özünde bir char dizisidir bu yüzden referans türlü olmak zorundadır. Yazılım açısından string ifade yoktur. Karakterlerin bir araya gelmiş halidir.
            //Diziler referans türlü olduğu için stringlerde bir char dizisi old göre stringlerde referans türlüdür.
            //karakter baştan sona otomatik indexlenir. String ifade üzerinde indexer operatörü kullanılabilir
            //string metin = "berk tolay";
            //Console.WriteLine(metin[3]);

            //string özünde bir char dizisidir fakat yapısal olarak string olduğu için Array referansına atılamaz
            //Array array = metin; //hata

            #region String ifadelerde + operatörü
            //iki string ifade arasında birleşirme görevi görür

            //string a = "merhaba", b = "dünya";
            //Console.WriteLine(a + b);
            //Bir string ifade ile herhangi bir tür + operatörüyle işleme tabi tutulabilir
            //Bu durumda object + string davranışı sergiler ve sonuçu string olarak döndürür.
            //Dolayısıyla herhangi bir ifadeyi string'e dönüştürebilmek için o ifadeyi + "" ile işleme tutabiliriz.
            //To.String önerilir çünkü üstteki yöntem maliyetlidir.
            //int a2 = 5;
            //Console.WriteLine(5+a2+a); // tamamı string bir ifadedir.



            #endregion

            #region String Formatlandırma
            //Faturalara uygun değerleri yerleştirme vb gibi durumlarda çokça kullanılır
            //string isim = "berk", soyisim = "tolay", TcNo = "12345678910";
            //int yas = 31;
            //bool MedeniHal = false;

            //+ Operatörü ile

            //Console.WriteLine("TC No : " + TcNo + " olan " + isim + " " + soyisim + " şahsın bilgileri | Yaş : " + yas + " Medeni Hal : " + (MedeniHal ? "Karı Var" : "Karı Yok"));


            #endregion

            #region string.Format Metodu
            //string isim = "berk", soyisim = "tolay", TcNo = "12345678910";
            //int yas = 17;
            //bool MedeniHal = false;
            //string sonuc = string.Format("TC No : {0} olan {1} {2} şahsın bilgileri | Yas : {3} | Medeni Hal : {4}", TcNo,isim,soyisim,yas,MedeniHal ? "Karı Var" : "Karı Yok");
            //Console.WriteLine(sonuc);

            #endregion

            #region String Interpolation
            //C# 6.0, $
            //string isim = "berk", soyisim = "tolay", TcNo = "12345678910";
            //int yas = 17;
            //bool MedeniHal = false;
            //Console.WriteLine($"TC No: { TcNo} olan { isim} { soyisim} şahsın bilgileri | Yas : { yas} | Medeni Hal: {(MedeniHal ? "evli" : "bekar")}");
            ////string interpolation kullanılan ifadelerde metinsel olarak süslü parantez kullanmak istiyorsak onun dışına bir süslü parantez daha eklemek gerekir
            //Console.WriteLine($"TC No: { TcNo} olan { isim} { soyisim} şahsın bilgileri | Yas : { yas} | Medeni Hal: {(MedeniHal ? "evli" : "bekar")} {{abc}} ");
            #endregion

            #region String Escape Karakteri
            // ", \₺ , \r \' gibi karakterleri metinsel olarak yazdırmak için kullanılır
            //    \ kendin sonra gelen karakterin operatif bir karakter olmadığını metinsel bir karakter olduğunu ifade eder
            //Console.WriteLine("\"bugün hava çok güzel\"");

            #endregion

            #region @-Verbatim Strings Operatörü
            //keywordleri değişken gibi kullanmamızı sağlar
            //int void=5; //hata
            //int @void = 5;

            //2
            //string metin=@"hava çok ""güzel"" ";

            //"" içerisindeki metinleri tek satırda yazmak zorundayız ya da + operatöriyle birleştirmek zorundayız
            //string metin = "hava " +
            //               "çok" +
            //               "güzel";
            //string metin2 = @"hava
            //            çok
            //                güzel";

            //3-) verbatim string + interpolation
            //string isim="A", soyisim = "b", siparisno = "123";
            //int fiyat = 500;
            //string message = @$"abc {isim} {soyisim} {siparisno} {fiyat}";
            //Console.WriteLine(message);


            #endregion

            #region Contains
            //metinsel ifadenin içerisinde bir değerin olup olmadığını bool olarak döndürür, büyük küçük harf duyarlı
            //string metin = "berk tolay abcdefg";
            //bool sonuc = metin.Contains("abcdefg");
            //Console.WriteLine(sonuc);

            #endregion

            #region StartsWith
            //metnin belirtilen ifadeyle başlayıp başlamadığını bool olarak döndürür
            //string metin = "berk tolay abcdefg";
            //bool sonuc = metin.StartsWith("abcdefg");
            //Console.WriteLine(sonuc);
            #endregion

            //EndWith  //belritilen ifade ile sonlanıp sonlanmadığını bool olarak döndürür

            //Equals seşitlik kontorlü yapar 

            #region Compare ve CompareTo
            //metinsel ifadelerin karşılaştırır ve int olarak geri döner
            //0 ise her iki değer birbirine eşit
            //1 soldaki ifade B sağdaki ifade A ile başlarsa Z>....>B>A
            //-1 tam tersi

            //string metin = "berk tolay abcdefg";
            //int sonuc = string.Compare(metin, "b");
            //Console.WriteLine(sonuc);
            //Console.WriteLine(String.Compare(metin,9,metin,8,5)); //metinden 9. karakterden başla sonra 8. başlayıp 5 karakter al karşılaştır

            //COMPARETO
            //string metin = "ajadı lsadpaspd sana";

            //Console.WriteLine(metin.CompareTo("f"));
            //Console.WriteLine(metin.CompareTo("a"));
            //Console.WriteLine(metin.CompareTo("metin"));
            #endregion

            #region IndexOf
            //Verilen değerin string içerisinde olup olmadığını int olarak döndürür(index no döndürür)
            //eşleşen yoksa -1 gönderirir
            //string metin = "berk tolay abc";
            //Console.WriteLine(metin.IndexOf("ay"));
            //Console.WriteLine(metin.IndexOf("abc")); // ilk harfin indexini döndürür

            #endregion

            #region Insert
            //araya değer dahil eden bir fonksiyon
            //string metin = "abc Berk Tolay";
            //string sonuc=metin.Insert(13, "WWW");// ekleme yaptıktan sonra eklenmiş hali string olarak dönderilir. Orijinal metin ayrı bir şekilde tutulur
            //Console.WriteLine(metin);
            //Console.WriteLine(sonuc);
            #endregion

            #region Remove
            //Orijinal veril değişmez, işlem yapılmış ifade string oalrak geri döndürür
            //string metin = "abc Berk Tolay";
            //Console.WriteLine(metin.Remove(8));
            //Console.WriteLine(metin.Remove(5,2));


            #endregion

            #region *Replace
            //metinsel ifade belirtilen değerleri, belirtilen değer ile değiştirmeyi sağlar
            //string metin = "abc Berk Tolay";
            //Console.WriteLine(metin.Replace('A','b'));

            #endregion

            #region *****Split
            //verilen değeri stringde ayraç olarak kullanır ve her bir parçayı bir indiste olacak şekilde sonucu string dizi olarak döndürür
            //string metin = "abc Berk Tolay";
            //string[] sonuc=metin.Split(' ');

            //foreach (var item in sonuc)
            //{
            // Console.WriteLine(item.ToString());   
            //}


            //Console.WriteLine("[{0}]", string.Join(", ", sonuc)); 

            //string[] sonuc2 = metin.Split(' ', 'A');
            //Console.WriteLine("[{0}]", string.Join(", ", sonuc2)); 
            #endregion

            #region *****Substring*****
            //stringin belirli bir aralığını elde etmemizi sağlar
            //string metin = "abc Berk Tolay";
            //Console.WriteLine(metin.Substring(5));
            //Console.WriteLine(metin.Substring(5,6));


            #endregion

            #region Trim
            //string ifadelerin sağındaki ve solundaki boşluk karakterlerini siler
            //Console.WriteLine("     Berk Tolay                               !".Trim());
            //Console.WriteLine("     Berk Tolay                               ".TrimEnd());
            //Console.WriteLine("     Berk Tolay                               !".TrimStart());


            #endregion

            ////baştan 3. sondan 5. karakteri yazdır
            //string adsoyad = "Berk Tolay";
            //string sonuc=adsoyad[2..^4];
            //Console.WriteLine(sonuc[0]);
            //Console.WriteLine(sonuc[sonuc.Length-1]);

            ////girilen string in içerisinde kaç adet "n" karakterinin geçtiğini hesapla
            //string metin = Console.ReadLine();
            //int adet = 0;
            //for (int i = 0; i < metin.Length ; i++)
            //{
            //    if (metin[i] == 'n') // index char olarak getireceği için ' ' içerisinde alınır
            //        adet++;
            //}
            //Console.WriteLine(adet);

            ////Girilen metindeki kelime sayısını hesapla.
            //string metin = Console.ReadLine();
            //int sayac = 0;
            //for (int i = 0; i < metin.Length; i++)
            //{
            //    if (metin[i] == ' ')
            //        sayac++;
            //}
            //Console.WriteLine(++sayac);

            //string[] kelimeler = metin.Split(' '); // her bir parçayı 1 değer olarak alır
            //Console.WriteLine(kelimeler.Length);


            //int adet = 1;
            //while (true)
            //{
            //    int index = metin.IndexOf(' ');
            //    if (index == -1)
            //        break;
            //    adet++;
            //    metin = metin.Substring(index + 1); // ilk boşluktan sonraki kelimeden devam etmesi için
            //}
            //Console.WriteLine(adet);



            #endregion

            #region Dizi Maliyetleri
            //**
            //string veya genel olarak dizilerde kullandığımız tüm fonksiyonlar diziyi/stringi çoğaltarayak/kopyalayarak yapılan işlemlerdir
            //string ifadelerde + operatörünü kullanmak maliyeti arttırır, string değerleri artar
            //string text1 = "Merhaba"; //1.dizi
            //string text2 = "Dünya";//2.dizi
            //Console.WriteLine(text1 + " " + text2); // (text1 + " ") => ayrı bir dizi oluşur , (text1 + "  ") + text2 ayrı bir dizi olarak kaydedilir
            //bu maliyetleri ortadan kaldırmak ve daha performanslı çalışabilmek için ArraySegment ve StringSegment türleri geliştirilmiştir


            #endregion

            #region ArraySegment
            //go to Dizi maliyetleri
            //Bir dizinin bütünü yerine belirli bir kısmına bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlar
            //veriler türetmememiz gereken durumlarda kullanılır
            //int[] sayilar = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            //ArraySegment<int> segment1 = new ArraySegment<int>(sayilar); //sayiların tüm elemenlarını segment1 ile referans ediyor
            //ArraySegment<int> segment2 = new ArraySegment<int>(sayilar, 2, 5);//2.indexten 5. adete kadar aralığı tut 30-50

            #region Array Slicing(Dilimleme)
            //Bir dizi üzerinde birden fazla parça üzerinde çalışacaksak bir ArraySegment üzerinden tanımlayabiliriz.
            //Diziyi tek bir ArraySegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz. Yani ilgili diziyi tek bir segment üzerinden parçalayabiliriz
            //Yazılımsal açıdan daha efektif olacaktır.
            //int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //ArraySegment<int> segment = new ArraySegment<int>(sayilar);
            //ArraySegment<int> segment2= segment.Slice(0, 3); //int türünde ArraySegment döndürecektir
            //ArraySegment<int> segment3 = segment.Slice(4, 7);
            //ArraySegment<int> segment4 = segment.Slice(5, 10);
            #endregion


            #endregion

            #region StringSegment
            //char dizisi olan stringler üzerinde daha performanslı işlemler yapılabilir
            //string char dizisnde olmayan bazı fonksiyonlara sahiptir substring, insert
            //substring normal kullanıldığında belirtilen aralığı alıp kopyalar, yani maliyeti yükseltir
            //StringSegment ise o kısmı referans ederek işlemleri gerçekleştirdiği için maliyeti düşürüür
            //stringsegment türünün kullanılması için Microsoft.Extensions.Primitives paketlerinin yüklenmesi gerekir
            //performans odaklı, maliyetin düşünüldüğü projelerde substring vs kullanılmaz StringSegment kullanılır
            //string text = "ornek metin.";
            //StringSegment segment = new StringSegment(text);
            //StringSegment segment1 = new StringSegment(text,2,5);

            //Console.WriteLine(segment1); // stringsegment ipsilit??? derinlemesine bir tür dönüşüm yapılanmasına sahiptir. Derinlemesine bir tür dönüşümüdür? Operatör Tür dönüşümlerinde gösterilir.  Yani direk stringe dönüştürülür.


            #endregion

            #region StringBuilder
            //dizilerdeki operasyonlar maliyetli + stringde bir dizi olduğu için string üzerindeki işlemler ekstra maliyetli
            //bu yüzden genelde + operatörünü kullanarak string birleştirme işlemlerini yapıp bu + operatörünün maliyetini gözardı ederiz

            //string isim = "Berk";
            //string soyisim = "Tolay";
            //Console.WriteLine(isim + " " + soyisim); // bir yerden sonra çok maliyetli hale gelir

            //StringBuilder, string birleştirme operasyonlarında + operatörüne göre yüksek maliyeti düşürmek için arkaplanda StringSegment kullanan bir sınıftır.

            //StringBuilder builder = new StringBuilder();
            //builder.Append(isim);//birleştirme yapar, maliyeti minimize eder
            //builder.Append(" ");
            //builder.Append(soyisim);
            //Console.WriteLine(builder.ToString());
            #endregion

            #region Span & Memory
            //SPAN (aslında bir structure dır)
            //bellek üzerindeki bir alanı temsil ederek işlemler gerçekleştirmemizi sağlar pointer gibi
            //arraylar normalde heapte tutulur, fakat stackalloc keyword ü ile Stack'te de tanımlanabilir
            //arraysegment heapteki dizi veya stringlerdeki belirli bir alanı referans ederken, SPAN ise hep heap'te hemde stackalloc ile stack'te İSTENİLEN alanı referans edebilir, yani dizi veya string şartı yoktur


            //ReadOnlySpan<T>
            //Sadece temsil edilecek yani sadece okunabilirlik sağlayacaksa kullanılır

            //Sadece string veya array türler çalışılacaksa ArraySegment ve StringSegment kullanılması önerilir.

            //MEMORY
            /*Span ref struct olarak tasarlanmış bir struct'tır. Dolayısıyla Heap'te allocation edilememe, object, dynamic veya interface türleri aracılığıyla referans
             edilememe veya bir class içerisinde field veya property olarka tanımlanamama gibi kısıtlamaları vardır
             *Memory türü Span'ın bu kısıtlamalarından kurtulmuş versiyonudur
             */

            //ReadOnlyMemory
            //Memory türünün sadece okunabilir halidir


            #region Span Türü

            //int[] sayilar = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

            //Span<int> span = new Span<int>(sayilar);
            //Span<int> span2 = sayilar;//aynı şey

            //Span<int> span3 = new Span<int>(sayilar, 3, 5);//buradaki overload 3'ten başlayıp 5 tane alır yani sıra no vs yok (40,50,60,70,80)

            //Span<int> span4=sayilar.AsSpan(); // diziden span türünde bir nesne talep edildi

            //sayilar.AsSpan(3, 5);

            //string text = "ABECEDE EFEGEHE";
            //ReadOnlySpan<char> readOnlySpan = text.AsSpan();  //metinsel ifadeler üzerinde bir referans readonly gelecektir


            #endregion


            #endregion

            #region Regular Expressions
            /*Evrensel Yapılardır
             * Düzenli İfadeler anlamına gelir
             * Metinsel yapılanmalarda belirli koşulları sağlayabilen ifadelerdir
             *örn: bir metilsek ifade içerisinde @ harakteri geçen tüm aralıkları elde etmek isteyelim
             *  asdsaodas@39ae93a9ad@3af*a3w'psaf*wa3fs
             * bu aralıklar döngü ile vs yapılabilir fakat şartlar arttıkça kodlamak zor olacaktır
             *
             *örn: email formatı bellidir ******@****.com .org .edu.tr vb. fakat birden fazla nokta varsa biri mutlaka @ karakterinden sonra gelmelidir.
             * gelen karakter dizisinin bir email adresi olup olmadığını test etmek zor olacaktır
             *
             *Bu problemleri normal algoritmalarla değil Regex algoritmaları ile sağlarız(regex operatörleri kullanılırz)
             * Bu operatörler ile elde edilen verinin tasaralnan metinsel düzene uyup uymadığı kontrol edilir
             * Regular ifadeler System.Text.RegularExpressions namespace'i altındaki Regex sınıfı tarafından temsil edilir
             */

            #region ^ operatörü
            //satır başının istenilen ifadeyle başlamasını sağlar
            //^9 : yazı 9 ile başlamalı örn: 9asdasdghak, 91254, 9!'%+

            //string text = "92135454sagawegwealğa'^%";
            //Regex regex = new Regex("^9");
            //Match match=regex.Match(text);// sonuç match sınıfında döner
            //Console.WriteLine(match.Success); //bool döner

            //regex =new Regex("^91");
            //match=regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion

            #region \ Operatörü
            //belirli karakter gruplarını içermesini istiyorsak kulalnırız,
            /*\D metinsel değerin ilgili yerinde rakam olmayan bir ifade bulunması gerektiğini belirtir
             *\d 0-9 arasında bir rakam olması gerektiğini ifade eder
             *
             * \W alfanümerik OLMAYAN karakterin olması gerekir, alfanümerik= a-z, A-Z, 0-9
             * \w  alfenümerik olsun
             *
             *\S boşluk karakteri olMAYACAK (tab/space)
             *\s olsun
             */

            //9 ile başlayan ve ikinci karakteri herhangi bir sayı olan ve 3. karakteri boşluk olmayan bir düzenli ifade oluştur => ^9\d\S

            //string text = "92135454sagawegwealğa'^%";
            //Regex regex = new Regex(@"^9\d\S"); //sola yatık çizgiyi kullanmak için verbatim string veya sağa yatık çizgi
            //Match match = regex.Match(text);// sonuç match sınıfında döner
            //Console.WriteLine(match.Success); //bool döner

            #endregion

            #region + Operatörü
            //aritmetik op değildir
            //belirtilen gruptaki(\s \W operatörleri vs) karakterlerden bir ya da daha fazlasının olmasını istiyorsak kullanılır

            // 9 ile başlasın arada herhangi bir sayısal ifade(ler) olsun son karakteri ise boşluk olmasın ^9\d+\S

            //string text = "92a135454%";
            //Regex regex = new Regex(@"^9\d+\S"); //sola yatık çizgiyi kullanmak için verbatim string veya sağa yatık çizgi
            //Match match = regex.Match(text);// sonuç match sınıfında döner
            //Console.WriteLine(match.Success); //bool döner

            //string text = "92135a454%"; 9 la başladı, 2. karakter sayısal sonrasıda sayısal, sonuncusu(a) boşluktan farklı, 92135a düzenli ifadesi var o yüzden true

            #endregion

            #region | Operatörü
            //birden fazla karakter olma durumunda kullanılır
            //string text = "alla";
            //Regex regex = new Regex(@"a|b|c");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);
            #endregion

            #region {} Operatörü
            //sabit sayıda karakterin olması isteniyorsa {adet} şeklinde belirtilmeli
            //505-5245252
            //\d\d\-\d\\d\d\d\d\d yerine \d{3}-\d{6}

            //string text = "505-5245252";
            //Regex regex = new Regex(@"\d{3}-\d{7}");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);

            #endregion

            #region ? Operaötrü
            //? önüne gelen karakter en fazla 1 defa olabilir almamına gelir
            //\d{3}B?A => max 1 tane 'B' olabilir
            //string text = "123BBA";
            //Regex regex = new Regex(@"\d{3}B?A");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);

            #endregion

            #region . Operatörü
            // kullanıldığı yerde herhangi bir karakter kullanılabilir anlamında ifade edilir
            //\n kullanıldığı yerde \n karakteri dışında herhangi bir karakter bulunabilir
            //string text = "123'A";
            //Regex regex = new Regex(@"\d{3}.A"); //3 sayı sonraki karakter her şey olabilir sonra A gelmeli
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);


            #endregion

            #region \b \B Operatörleri
            //\B kullanılan ifadenin kelimenin başında ya da sonunda olmaması gerektiğini bildiir
            //\b belirtilen ifade ile bitmesini sağlar

            //\d{3}dır\B => dır123 ve 123dır false olacaktır

            //string text = "123dır";
            //Regex regex = new Regex(@"\d{3}dır\B");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);

            #endregion

            #region [] Operaötrü
            //özel karakterlerin yerinde yazılmasını kontrol eder
            //Karakter aralığı belirtilebilir
            //\d{3}[A-E] => ilk 3 sayı sonraki A B C D E olabilir

            //string text = "123C";
            //Regex regex = new Regex(@"\d{3}[A-E]");
            //Match match = regex.Match(text);
            //Console.WriteLine(match.Success);

            //(505) 524 52 52
            //[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}

            #endregion

            #region Match Sınıfı Özellikleri

            //string text = "aaa(505) 524 52 52aaaaaaaa";
            //Regex regex = new Regex(@"[(]\d{3}[)]\s\d{3}\s\d{2}\s\d{2}");
            //Match match = regex.Match(text);

            //Console.WriteLine($"Success : {match.Success}"); 
            //Console.WriteLine($"Value : {match.Value}"); // doğrulanan verinin ne olduğunu getirir(sadece doğrulnan kısım gelir), FALSE ise değer gelmez
            //Console.WriteLine($"Index : {match.Index}"); // doğrulama hangi index no'da başladığını belirtir
            //Console.WriteLine($"Length : {match.Length}"); // doğrulamanın yapıldığı ifadenin uzunluğunu verir

            #endregion

            #endregion

            #region Koleksiyonlar
            //Dizilerde eleman sayısı belirtilmeli, ve alan arttırılıp azaltılamaz koleksiyonda bunlar free

            #region ArrayList
            /* dizilerdeki sınırlılıkları kaldırmıştır, koleksiyonlar arasında en ilkelidir */

            //int[] yaslar = new int[17];
            //ArrayList _yaslar = new ArrayList(); // TANIMLAMA
            //_yaslar.Add(23);  // DEĞER ATAMA
            //for (int i = 0; i < _yaslar.Count; i++)
            //{
            //    Console.WriteLine(_yaslar[i]);    //DEĞER OKUMA
            //}   

            #endregion

            #region ArrayList Boxing-Unboxing
            //arraylist object türünde değer alır(bir object türe herhangi bir türdeki değer verilmesine boxing, object olanı kendi türüne çevirmeye unboxing denir)
            //Yani boxing işlemine tabi tutar, bunları kullanırken unboxing yapacağımız için maliyet artacaktır
            // ArrayList in diziye karşı geride olduğu tek konu budur -> Bu durum generic listler ile çözülecektir
            // ** Dizilerde yaslar.Length kullanılırken koleksiyonlarda _yaslar.Count kullanılır

            //ArrayList _yaslar = new ArrayList();
            //for (int i = 1; i < 11; i++)
            //{
            //    _yaslar.Add(i * 10);
            //}

            //int toplam = 0;
            //for (int i = 0; i < _yaslar.Count; i++)
            //{
            //    toplam += (int)_yaslar[i]; // cast op ile unboxing yaparız // as operatörüyle unboxing yapılabilirdi fakat as operatörü dönüşüm yapıalcak hedef türün nullable yani referans türlü olması lazım
            //}

            //Console.WriteLine(toplam);

            #endregion

            #region ArrayList Collection Initializers
            //koleksiyon ilklendirici ile değer ekleme

            //ArrayList arrayList = new ArrayList()
            //{
            //    "berk",
            //    123,
            //    'a',
            //    true
            //};
            // farklı türde değerler varsa bunları kullanırken kontrol edilmesi gerekir


            #endregion

            #region List - Generic List
            //özelleştirilmiş bir koleksiyon olduğu için belirlediğimiz tipte değerler alacaktır

            List<int> liste = new List<int>();
            liste.Add(5);
            List<string> liste2 = new List<string>();

            Ogrenci o1 = new();
            Ogrenci o2 = new();
            List<Ogrenci> OgrList = new List<Ogrenci>();
            OgrList.Add(o1);
            OgrList.Add(o2);


            #endregion


            #endregion

            #region Döngü - iterasyon Farkı
            /* Döngü ile iterasyon farklı şeylerdir
             * döngüler bir mantıksal kombinasyon üzerinden işlem yapar, sonsuza kadar çalışabilir
             * iterasyon sonsuza kadar çalışmaz, belli kombinasyona göre işlem yapmaz, elindeki veri kümesinin elemanı kadar işlem yapar
             
             * Foreach veri kümesi üzerinde çalışır, bu veri kümesinin değişmemesi gerekir
             */

            #endregion

            #region Foreach iterasyonu
            //ArrayList arrayList = new ArrayList {123, 123, 325, 2, 534, 5, 345, 345};
            //foreach (object item in arrayList) //
            //{
            //    arrayList.Add(12345);//foreachte veri kümesi değiştirilmemelidir
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Math Sınıfı

            //ABS
            //Mutlak değer işlemini yapar
            //int i=Math.Abs(-5);

            //CEİLİNG
            //yukarı yuvarlama yapar
            //double sonuc=Math.Ceiling(3.14);

            //Floor
            //aşağı yuvarlar

            //ROUND
            //en yakın tam sayıya yuvarlar
            //3.5 gibi ortaki sayılarda ise tam kısım tek sayı ise yukarı, çift sayı ise aşağı yuvarlar
            //Console.WriteLine($"3.4 => {Math.Round(3.4)}");
            //Console.WriteLine($"3.5 => {Math.Round(3.5)}");
            //Console.WriteLine($"3.6 => {Math.Round(3.6)}");
            //Console.WriteLine($"4.5 => {Math.Round(4.5)}");

            //POW
            //üst alma işlemi, double döner
            //Console.WriteLine(Math.Pow(2,10));

            //TRUNCATE
            //yuvarlama yapmadan sadece tam sayı değerini elde etmek
            //Console.WriteLine(Math.Truncate(3.14));
            #endregion

            #region DateTime Struct

            //NOW
            //şuanki tarih ve zamanı veren PROPERTY'dir
            //Console.WriteLine(DateTime.Now);

            //TODAY
            //nowdan farkı sadece tarihi getirmesidir

            //COMPARE
            //iki tarihi kıyaslayıp int değer döndürür
            //dönen değer -1 ise 1. tarih daha küçük
            //0 ise aynı tarih
            //1 ise 2.tarih büyük
            //DateTime tarih1=new DateTime(2021, 01, 01);
            //DateTime tarih2 = new DateTime(2022, 01, 01);
            //int result = DateTime.Compare(tarih1, tarih2);
            //Console.WriteLine(result);

            //ADD fonksiyonları
            //elimizdeki tarihe gün,saniye vs eklendiğinde hangi tarihe/zamana denk geldiğini verir
            //** tokenların geçerlilğinin ayarlarken kontrol ederken kullanılır
            //Console.WriteLine(DateTime.Now.AddYears(999));
            //Console.WriteLine(DateTime.Now.AddSeconds(999));
            #endregion

            #region TimeSpan
            //2 date time arasındaki farkı timespan olraka alırız
            // DateTime t1=DateTime.Now;
            // DateTime t2 = new DateTime(2000, 1, 1);
            //TimeSpan span= t1 - t2;
            //Console.WriteLine(span.Days);
            //Console.WriteLine(span.Minutes);
            #endregion

            #region Random-Next-NextDouble

            //Random random = new Random();

            //next belirli bir aralıkta tamsayı değer oluşturmak için
            //Console.WriteLine(random.Next());//0 dan büyük bir değer
            //Console.WriteLine(random.Next(100));//0-100 100 dahil değil 0 dahil
            //Console.WriteLine(random.Next(50,1000));//50-100 100 dahil değil 50 dahil
            //Console.WriteLine(random.Next(-30,0));

            //NextDouble
            //0 ile 1 arasında rastgele değer üretir
            //Console.WriteLine(random.NextDouble());

            #endregion

            #region Metotlar
            //metot=fonksiyon
            //yazışımda gerçekleştiridğimiz, fiili olarka gerçekleştirdiğimiz tüm operasyonlar bir metottur
            //prosedürel programlamanın temel elenıdır
            //bir iş, operasyon en küçük program parçaçıklarıdır
            //** Property yapılanmasında kod yazılabilmesi complier seviyesinde bir metot olduğu içindir

            //metotlar sadece class içerisinde tanımlanabilir(local functionslar hariç)



            #endregion

            //Parse string ifadeyi önünde belirtilen tipe çevirir, tüm değer türlü değişkenlerde ortak bir fonksiyondur

            #region Nesne Notları
            /*instance/object/obje/nesne aynı şeyler
             *Nesneler referans türlü değerlerdir
             *Nesneleri tutan değişkenler değer türlü değişkenlerdir
             *
             * STACKTE
             * 1-)Değer türlü değişkenler ve değerleri
             * 2-) Referansları tututlur
             *
             * HEAP
             * 1-)Sadece nesneler tutulur
             *
             * Nesnelere/Classlara referans türlü değişken denmesinin sebebi, HEAP'e direk erişimimiz olmadığı için, STACKte tanımladığımız değişkenin HEAP'teki referans etmesidir
             *
             *OOP'de bir object oluşturabilmek için ilk önce o objectin tanımlanması/modellenmesi gerekmektedir
             * Bir objectin modelini/tanımını oluşturmak için CLASS yapısı kullanılır.
             *
             *Sınıftan birden fazla nesne oluşturulabilir
             * Classlarda nesnelerdeki ortak alan tanımları yapılır
            */

            #endregion

            #region Ref-Out
            //ref keywordü ile değişkenin adresini gönderip, değişikliklerin her yerde geçerli olmasını sağlarız
            //ref'te ilk değeri vermek zorundayız
            int a = 8;
            arttir(ref a);
            Console.WriteLine(a);

            //out ref ile aynıdır, out kullanıldığında ilk değer verilmesi zorunlu değildir
            //fakat metot içerisinde dışarıya değer döndürülebilmesi için değer atanmalıdır
            int b;
            arttir2(out b);
            Console.WriteLine(b);

            

            #endregion

            Console.ReadLine();
        }

        #region Ref-Out

        static void arttir(ref int s)
        {
            s++;
        }

        static void arttir2(out int s)
        {
            s = 12;
            s++;
        }

        #endregion

        #region Static(eksik)
        /*static tanımladığımız class new'lenemez, çünkü arka planda bir nesne oluşturulur
        * ve oluşturulan bu nesne tüm kullanıclar tarafından kullanılabilir

        * static classlar içerisindeki elemanlarda static olmalıdır
        * mainde class ismi üzerinden . operatörü ile elemanlara erişilebilir

        * eleman üzerinde yapılan değişikler her yerde değişir   

        *static olmayan bir class içerisidne static eleman tanımlanabilir
        *bu eleman nesne üzerinden değil class ismi üzerindnen . operatörü ile erişilebilir
        */
        #endregion

    }

    #region List - Generic List
    class Ogrenci
    {
        public int Yas { get; set; }
    }

    #endregion

    

}
