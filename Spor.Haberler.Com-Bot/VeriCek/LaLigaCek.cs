﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spor.Haberler.Com_Bot.VeriCek
{
    class LaLigaCek
    {
        public static void SporLaLigaPuanDurumuCek()
        {
            try
            {
                var site = "https://www.haberler.com/spor/superlig/puan-durumu/";

                List<Futbol> TakimListesi = new List<Futbol>();

                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(site);

                var FutbolXpath = "//div[@class='hbTableSports hbColBoxFull piyasa']";
                var FutbolX = document.DocumentNode.SelectNodes(FutbolXpath);

                string deger = "//div[6]/div/div[2]/div/table/tbody/tr[";

                foreach (var Futbol in FutbolX)
                {
                    for (int i = 1; i <= 20; i++)
                    {
                        string TakimSira = Futbol.SelectSingleNode(deger + i + "]/td[1]").InnerText;
                        string TakimAD = Futbol.SelectSingleNode(deger + i + "]/td[2]/a").InnerText;
                        string Takim_O = Futbol.SelectSingleNode(deger + i + "]/td[3]").InnerText;
                        string Takim_G = Futbol.SelectSingleNode(deger + i + "]/td[4]").InnerText;
                        string Takim_B = Futbol.SelectSingleNode(deger + i + "]/td[5]").InnerText;
                        string Takim_M = Futbol.SelectSingleNode(deger + i + "]/td[6]").InnerText;
                        string Takim_A = Futbol.SelectSingleNode(deger + i + "]/td[7]").InnerText;
                        string Takim_Y = Futbol.SelectSingleNode(deger + i + "]/td[8]").InnerText;
                        string Takim_Av = Futbol.SelectSingleNode(deger + i + "]/td[9]").InnerText;
                        string Takim_P = Futbol.SelectSingleNode(deger + i + "]/td[10]").InnerText;

                        TakimListesi.Add(new Futbol()
                        {
                            TakimSira = TakimSira,
                            TakimAD = TakimAD,
                            Takim_O = Takim_O,
                            Takim_G = Takim_G,
                            Takim_B = Takim_B,
                            Takim_M = Takim_M,
                            Takim_A = Takim_A,
                            Takim_Y = Takim_Y,
                            Takim_Av = Takim_Av,
                            Takim_P = Takim_P
                        });
                    }
                    break;
                }
                Console.WriteLine("======================================================================================");
                Console.WriteLine("                                İspanya La Liga");
                Console.WriteLine("======================================================================================");
                Console.WriteLine($"Takım     \t\t\t   O\t   G\t   B\t   M\t   A\t   Av\t   P");
                Console.WriteLine("======================================================================================");
                foreach (var Takim in TakimListesi)
                {
                    if (Takim.TakimAD != "Atletico Madrid" && Takim.TakimAD != "Real Sociedad" && Takim.TakimAD != "Rayo Vallecano" && Takim.TakimAD != "Athletic Bilbao" && Takim.TakimAD != "Celta de Vigo" && Takim.TakimAD != "Deportivo Alaves")
                    {
                        Console.Write(
                            $"{Takim.TakimSira}) {Takim.TakimAD}\t\t\t| {Takim.Takim_O} |\t| {Takim.Takim_G} |\t| {Takim.Takim_B} |\t| {Takim.Takim_M} |" +
                            $"\t| {Takim.Takim_A} |\t| {Takim.Takim_Av} |\t| {Takim.Takim_P} |");
                    }
                    else if (Takim.TakimAD == "Atletico Madrid" || Takim.TakimAD == "Real Sociedad" || Takim.TakimAD == "Rayo Vallecano" || Takim.TakimAD == "Athletic Bilbao" || Takim.TakimAD == "Celta de Vigo" || Takim.TakimAD == "Deportivo Alaves")
                    {
                        Console.Write(
                            $"{Takim.TakimSira}) {Takim.TakimAD}\t\t| {Takim.Takim_O} |\t| {Takim.Takim_G} |\t| {Takim.Takim_B} |\t| {Takim.Takim_M} |" +
                            $"\t| {Takim.Takim_A} |\t| {Takim.Takim_Av} |\t| {Takim.Takim_P} |");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception mesaj)
            {
                Console.WriteLine(">>" + mesaj.Message);
            }
        }
    }
}
