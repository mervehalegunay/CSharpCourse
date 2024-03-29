﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";

            string[] students2 = new[] { "Engin", "Derin", "Salih" };
        

            //foreach (var student in students) 
            //{
            //    Console.WriteLine(student);
            //}

            //Çok Boyutlu Diziler
            //TR'nin 5 bölgesii ve bu bölgelerdeki en büyük 3 şehri. Yani 2 boyutlu
            string[,]regions=new string[5,3] //5 satır 3 sütun
            {
                { "İstanbul", "İzmit", "Balıkesir"},
                { "Ankara", "Konya", "Kırıkkale"},
                { "Antalya", "Adana", "Mersin"},
                { "Rize", "Trabzon", "Mersin"},
                { "İzmir", "Muğla", "Manisa"}
            };

            for(int i = 0; i <= regions.GetUpperBound(0); i++) //0. dimension ın en üst değeri anlamına gelir
            { 
                for(int j = 0;j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }

            Console.ReadLine();
        }
    }
}
