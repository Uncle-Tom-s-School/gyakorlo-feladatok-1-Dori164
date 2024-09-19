namespace vegyes_feladatok
{
    internal class Program
    {
       /* static double ertekeles()
        {
            double ertek = 1;
            Console.WriteLine("[1] - Ajánlott");
            Console.WriteLine("[2] - Nem ajánlott");
        }*/
        static void feladat1() 
        { 

        }
        static void feladat2() { }
        static int random() 
        {
            Random rnd = new Random();
            int szam = rnd.Next(1,4);
            return szam;
        }
        static int szemely()
        {
            int kpo = 1;

            Console.WriteLine("[1] - Kő");
            Console.WriteLine("[2] - Papír");
            Console.WriteLine("[3] - Olló");
            int v = int.Parse(Console.ReadLine());
            switch (v)
            {
                case 1: kpo = 1; break;
                case 2: kpo = 2; break;
                case 3: kpo = 3; break;
            }
            return kpo;
        }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.ReadKey();
            int szam = random();
            int kpo = szemely();
            Console.WriteLine($"A gép választása: {szam}");
            Console.WriteLine($"A választásod: {kpo}");
            /* Console.WriteLine("1 - Kő");
             Console.WriteLine("2 - Papír");
             Console.WriteLine("3 - Olló");*/
            if (szam == kpo) Console.WriteLine("Az eredmény: Döntetlen");
        }
    }
}
