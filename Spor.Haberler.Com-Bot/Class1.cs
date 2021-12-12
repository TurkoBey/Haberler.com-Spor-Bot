using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Spor.Haberler.Com_Bot
{
    class Class1
    {
        public static void NewMethod()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("\n[ Almanya ] Bundesliga Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.BundesligaCek.SporBundesligaPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 2:
                    Console.WriteLine("\n[ Fransa ] 1.Lig Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.Fransa1Lig.SporFransa1LigiPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 3:
                    Console.WriteLine("\n[ İspanya ] La Liga Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.LaLigaCek.SporLaLigaPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 4:
                    Console.WriteLine("\n[ İngiltere ] Premier Lig Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.PremierLigCek.SporPremierLigPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 5:
                    Console.WriteLine("\n[ Türkiye ] PTT 1.Lig Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.PTT1LigCek.SporPTT1LigPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 6:
                    Console.WriteLine("\n[ İtalya ] Seria A Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.SeriaACek.SporSerieAPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;
                case 7:
                    Console.WriteLine("\n[ Türkiye ] Süper Toto Süper Lig Puan Durumu Çekiliyor...\n");
                    Thread.Sleep(2000);
                    VeriCek.SuperTotoCek.SporSuperTotoPuanDurumuCek();
                    Thread.Sleep(2000);
                    Console.Write("\n\nSeçim yapınız : ");
                    Class1.NewMethod();
                    break;         
                default:
                    Console.Write("Hatalı seçim yaptınız..");
                    break;
            }
        }
    }
}
