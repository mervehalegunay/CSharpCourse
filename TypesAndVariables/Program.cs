using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //********** VALUE TYPES **********
            //Console.WriteLine("Hello World");

            double number5 = 10.4;   //double 64 bit yer kaplar
            decimal number6 = 10.4m;
            char character = 'A';
            
            bool condition = true;
            byte number4 =255;   //byte 8 bit yer kaplar yani 1 byte
            short number3 = 32767;   //short 16 bit yer kaplar
            int number1 = 2147483647; //int 32 bit yer kaplar
            long number2 = 9223372036854775807;   //long 64 bit yer kaplar
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);   //virgülden sonra 0. eleman virgülden sonraki ilk değer
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character); // başına int yazarak ASCII değerini yazdırabiliriz
            Console.WriteLine(Days.Friday); //başına int yazarsan 4 çıktısı verir. Ya da başlangıç değeri verebilirsin ya da hepsine farklı değer atanacak.
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
