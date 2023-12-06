using System ;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace donusumler 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion - Bilinçsiz Dönüşümler 
            byte a = 5; 
            sbyte b = 30 ; 
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " +d);

            long h =d ; 
            Console.WriteLine("h: " +h);

            float i = h ; 
            Console.WriteLine("i: " +i);

            string e ="zikriye";
            char f = 'k';
            object g = e+f+d ;  
            Console.WriteLine("g: " +g);

            //Explicit Conversion - Bilinçli Dönüşüm 

            //C# kendi kendine yapamayacağı dönüşümler, parse ve convert kulllanmamız gereken durumlar

            Console.WriteLine("***** Explicit Conversion ******");
            int x = 4 ; 
            byte y = (byte)x;
            Console.WriteLine("y : " + y);

            int z = 100; 
            byte t = (byte)z ; 
            Console.WriteLine("t : " +t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v : " +v);

            //Çevirimlerde veri kaybolması sık rastlanan bir durumdur. 

            // ***** ToString Methodu ******
            Console.WriteLine("***** ToString Methodu ******");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            string zz = 15.5f.ToString();
            Console.WriteLine("zz : " + zz);

            //System.Convert

            Console.WriteLine("***** System.Convert Sınıfı ******");

            string s1 = "10", s2 ="20";
            int sayi1, sayi2 ; 
            int toplam ; 
            sayi1 = Convert.ToInt32(s1); 
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2; 
            Console.WriteLine(toplam);

            //Parse Methodu
            Console.WriteLine("***** Parse Methodu******");

            //Parse string ifadeleri dönüştürmek için kullanılır dolayısıyla her zaman string bir ifade alır

            ParseMethod();

            static void ParseMethod()
            {
                string metin1 = "10"; 
                string metin2 = "10,25" ; 
                int rakam1 ; 
                double double1 ; 
                
                rakam1 = Int32.Parse(metin1); 
                double1 = Double.Parse(metin2);
                Console.WriteLine("Rakam1 : "+ rakam1);
                Console.WriteLine("Double1 : "+ double1);
            } 

        }
    }
}
