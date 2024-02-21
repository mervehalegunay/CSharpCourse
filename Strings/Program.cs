using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;   //24
            var result2= sentence.Clone();  //string değerin bir referansını daha oluşturmaya yarar
            sentence = "My name is Derin Demiroğ"; //sentence ı değiştirsem de result 2 yi değiştiremiyorum yine Engin geliyo. clon ile bi tane daha değişken oluşturduk. Sentence ı değiştirsem de result 2 yi değiştirememiş oluyorum

            bool result3=sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");  //3
            var result6 = sentence.IndexOf(" ");   //2 bulduğu ilk boşluğu sayar
            var result7 = sentence.LastIndexOf("");    //16
            var result8 = sentence.Insert(0, "Hello");
            var result9 = sentence.Substring(3);   //3. karakterden itibaren olan kısmı alır: Yani cümlenin name'den sonrasını alır. (3,4) dersek 3. karakterden itibaren 4 tane al name alır sadece
            var result10 = sentence.ToLower();   //hepsini küçük yazar
            var result11 = sentence.ToUpper();   //hepsini büyük yazar
            var result12 = sentence.Replace(" ", "-");  //boşluk yerine - kullanmak için
            var result13=sentence.Remove(2);   //2 den itibaren yok et demiş olduk. (2,4) derse 2 den itibaren 4 tane yok et dedik.
            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            //Ankaranın bütün elemanlarını allt alta yazdırmak için
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2; bunu yazıp alttaki () içine result yazmak yerine. Böylelikle bellekte 3. bir değişken tanımlamamış olacağız
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
