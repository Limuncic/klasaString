using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danas radimo sa klasom String.";

            //ispis stringa
            Console.WriteLine(tekst);

            //broj znakova
            Console.WriteLine("Broj znakova: " + tekst.Length);

            //ispis velikim slovima
            Console.WriteLine("Velika slova: " + tekst.ToUpper());
            //mala slova
            Console.WriteLine("Mala slova: " + tekst.ToLower());

            //substring metosa
            Console.WriteLine("\n --Substring-- ");
            Console.WriteLine(tekst.Substring(0,5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));

            //zamjena znakova
            Console.WriteLine(tekst.Replace("Danas", "Sutra"));

            //razdvajanje stringa u više stringova
            Console.WriteLine("\n --Razdvajanje rijeci--");
            string[] rijeci = tekst.Split(' ');
            for(int i = 0; i < rijeci.Length; i++)
            {
                Console.WriteLine(rijeci[i]);
            }

            //umetanje znakova u string
            Console.WriteLine("\n --Umetanje--");
            Console.WriteLine(tekst.IndexOf("radimo"));
            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"), "intenzivno "));

            Console.ReadKey();
        }
    }
}
