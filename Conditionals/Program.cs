using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = 11;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else 
            //{
            //    Console.WriteLine("Number is not 10");
            //}

            //bu ifadeyi şu şekilde de yazabiliriz
            //Single Line if
            //var number = 11;
            //Console.WriteLine(number==10 ? "Number is 10" : "Number is not 10");
            ////Sayı 10 ise "Number is 10" yazar değil ise "Number is not 10" yazar
            //Console.ReadLine();




            //Else if Bloğuyla Çalışmak

            //var number = 11;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10");
            //}




            //Switch Bloğuyla Çalışmak

            //var number = 11;
            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;
            //}
            //Console.ReadLine();



            //Çoklu Şartlarla Çalışmak

            //var number = 20;
            //if (number >= 0 && number <= 100)
            //{
            //    Console.WriteLine("Number is between 0-100");
            //}
            //else if(number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200");
            //}
            //else if(number>200||number<0)
            //{
            //    Console.WriteLine("Number is less than 0 or greater than 200");
            //}



            //İç İçe If Bloklarıyla Çalışmak
            var number = 11;
            if (number < 100)
            {
                if (number >= 90 && number < 95)
                { 
                
                }
            }
            Console.ReadLine();
        }
    }
}
