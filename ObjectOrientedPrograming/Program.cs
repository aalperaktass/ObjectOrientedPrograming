using System;

namespace ObjectOrientedPrograming
{
    class Araba
    {
        public Araba()
        {
            this.Hız = 180;
            Console.WriteLine("yapıcı metot çalıştırıldı.");
        }
        public Araba(int maxhiz)
        {
            this.Hız = maxhiz;
        }

        public Araba(string marka, string model, string renk, bool otomatik, int hız)
        {
            this.Marka = marka;
            this.Model = model;
            this.Renk = renk;
            this.Otomatik = otomatik;
            this.Hız = hız;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }
        public int Fiyat { get; set; }
        public int Hız { get; set; }
  

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

        public void Hızlan(int km)
        {
            if (km > this.Hız)
            {
                Console.WriteLine($"Arac {this.Hız} km hızı aşamaz lütfen yavaşlayın.");
            }
            else
                Console.WriteLine($"{this.Marka} {this.Model} Aracımız {km} km hıza ulaştı.");

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
                        Console.WriteLine("Hız bilgisi girmek istiyor musunuz ? ( 'e' Evet )");
                        var secim = Console.ReadLine();

                        if (secim == "e")
                        {
                            Console.WriteLine("Lütfen Hız Girin");
                            int km = int.Parse(Console.ReadLine());
                            this.Hızlan(km);
                        }
                        else
                        {
                            this.Hızlan();
                        }
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
            Araba ford = new Araba(200);
            Console.WriteLine(ford.Hız);
            //ford.Marka = "Ford";
            //ford.Renk = "Beyaz";
            //ford.Model = "Sedan";
            //ford.Otomatik = true;
            //ford.Hız = 260;

            var bmw = new Araba("Bmw", "Hatchback", "Siyah", true, 300);

            Console.WriteLine(bmw.Marka);
            Console.WriteLine(bmw.Model);
            Console.WriteLine(bmw.Renk);
            Console.WriteLine(bmw.Otomatik);
            Console.WriteLine(bmw.Hız);


            //bmw.Marka = "Bmw";
            //bmw.Renk = "Siyah";
            //bmw.Model = "Hatchback";
            //bmw.Otomatik = false;
            //bmw.Hız = 300;

            //ford.Menu();
            //bmw.Menu();
        }
    }
}