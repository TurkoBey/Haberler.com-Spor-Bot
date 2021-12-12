using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor.Haberler.Com_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "haberler.com/spor Botu";

            Console.WriteLine(
                "\n==========================================================\n" +
                "haberler.com/spor Liglerin Puan Durumunu Getiren Bot" +
                "\n==========================================================\n");

            Console.WriteLine(
                "[ 1 ] ==> Bundesliga" + "\n" +
                "[ 2 ] ==> 1.Lig" + "\n" +
                "[ 3 ] ==> La Liga" + "\n" +
                "[ 4 ] ==> Premier Lig" + "\n" +
                "[ 5 ] ==> PTT 1.Lig" + "\n" +
                "[ 6 ] ==> Seria A" + "\n" +
                "[ 7 ] ==> Spor Toto Süper Lig" +
                "\n\n==========================================================\n");

            Console.Write("Seçim yapınız : ");

            try
            {
                Class1.NewMethod();
            }
            catch (Exception)
            {
                Console.Write("Sadece sayı değeri giriniz..");
            }
            finally
            {
                Console.Write("\n\nSeçim yapınız : ");
                Class1.NewMethod();
            }

            Console.ReadLine();
        }  
    }
}
