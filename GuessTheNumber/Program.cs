namespace GuessTheNumber
{
    internal class Program
    {
        private const int MaxVærdi = 20;
        static void Main(string[] args)
        {


            //Generer et tal
            int korrektTal = Random.Shared.Next(MaxVærdi) + 1;
            bool talErGættet = false;

            do
            {
                //Bed om et gæt
                Console.Write($"Indtast et tal mellem 1 og {MaxVærdi}: ");
                string? gætSomTekst = Console.ReadLine();

                //konvertér indtastning til tal
                int gæt = Convert.ToInt32(gætSomTekst);

                //Sammenlign gæt med tal
                if (gæt == korrektTal) {Console.WriteLine("KORREKT!");talErGættet = true; }
                else if (gæt > korrektTal) { Console.WriteLine("Du har gættet for højt!"); }
                else {Console.WriteLine("Du har gættet for lavt!");}


            } while (!talErGættet);

        }

    }
}
