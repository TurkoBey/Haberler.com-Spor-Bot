using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spor.Haberler.Com_Bot
{
    public static class Class1
    {
        private static int sayi;
        public static void NewMethod()
        {
            sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    NewMethod("\n[ Almanya ] Bundesliga Puan Durumu Çekiliyor...\n", 3);
                    break;
                case 2:
                    NewMethod("\n[ Fransa ] 1.Lig Puan Durumu Çekiliyor...\n", 2);
                    break;
                case 3:
                    NewMethod("\n[ İspanya ] La Liga Puan Durumu Çekiliyor...\n", 3);
                    break;
                case 4:
                    NewMethod("\n[ İngiltere ] Premier Lig Puan Durumu Çekiliyor...\n", 4);
                    break;
                case 5:
                    NewMethod("\n[ Türkiye ] PTT 1.Lig Puan Durumu Çekiliyor...\n", 5);
                    break;
                case 6:
                    NewMethod("\n[ İtalya ] Seria A Puan Durumu Çekiliyor...\n", 6);
                    break;
                case 7:
                    NewMethod("\n[ Türkiye ] Süper Toto Süper Lig Puan Durumu Çekiliyor...\n", 7);
                    break;
                default:
                    Console.Write("Hatalı seçim yaptınız..");
                    break;
            }
        }

        private static void NewMethod(string baslik, int sayi)
        {
            Console.WriteLine(baslik);
            Thread.Sleep(2000);
            if (sayi == 1) { VeriCek.PuanDurumuCek.SporBundesligaPuanDurumuCek(); }
            else if (sayi == 2) { VeriCek.PuanDurumuCek.SporFransa1LigiPuanDurumuCek(); }
            else if (sayi == 3) { VeriCek.PuanDurumuCek.SporLaLigaPuanDurumuCek(); }
            else if (sayi == 4) { VeriCek.PuanDurumuCek.SporPremierLigPuanDurumuCek(); }
            else if (sayi == 5) { VeriCek.PuanDurumuCek.SporPTT1LigPuanDurumuCek(); }
            else if (sayi == 6) { VeriCek.PuanDurumuCek.SporSerieAPuanDurumuCek(); } 
            else if (sayi == 7) { VeriCek.PuanDurumuCek.SporSuperTotoPuanDurumuCek(); }
            Thread.Sleep(2000);
            Console.Write("\n\nSeçim yapınız : ");
            Class1.NewMethod();
        }
    }
}
