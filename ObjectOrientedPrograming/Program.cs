using System;
using System.Diagnostics;

namespace ObjectOrientedPrograming
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }
        public int Fiyat { get; set; }

        public void Start()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Aracımız  Çalıştı");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Aracımız  Durdu");
        }
        public void Hızlan()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Aracımız  Hızlandı");

        }
        public void Yavasla()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Aracımız Yavasladı");
        }
        public void Cıkıs()
        {
            Console.WriteLine("Menuden Çıkıldı");
        }

        public void Menu()
        {
            string Komut = "";
            do
            {
                Console.WriteLine("Seçiminiz : 1.Start ------- 2.Stop -------  3.Hızlan -------  4.Yavasla -------  5.Çıkış = C");
                Komut = Console.ReadLine();

                switch (Komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Stop();
                        break;

                    case "3":
                        this.Hızlan();
                        break;

                    case "4":
                        this.Yavasla();
                        break;
                    case "C":
                        this.Cıkıs();
                        break;

                    default:
                        Console.WriteLine("Yanlış Tuşa Bastınız.");
                        break;

                }

            }

            while (Komut != "C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Araba ford = new Araba();
            ford.Marka = "Ford";
            ford.Renk = "Beyaz";
            ford.Model = "Sedan";
            ford.Otomatik = true;

            var bmw = new Araba();
            bmw.Marka = "Bmw";
            bmw.Renk = "Siyah";
            bmw.Model = "Hatchback";
            bmw.Otomatik = false;

            //ford.Menu();
            bmw.Menu();
        }
    }
}