using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Engin";
            int a = 36;

            Kurs kurs1 = new Kurs();
            kurs1.CourseName = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.CourseName = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.CourseName = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.izlenmeOrani = 80;

            // Console.WriteLine(kurs1.CourseName + ": " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.CourseName + ": " + kurs.Egitmen);
            }

            // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string CourseName { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
