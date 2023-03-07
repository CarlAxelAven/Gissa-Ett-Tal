using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTal
{
    public class App
    {
        public void Run()
        {
            Console.WriteLine("Välkommen till Gissa ett tal!");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1. Gissa ett tal");
                Console.WriteLine("2. Kolla Low Score listan");
                Console.WriteLine("3. Avsluta spelet");
                var Val = Console.ReadLine();
                int huvudmenyVal;
                bool checkVal = Int32.TryParse(Val, out huvudmenyVal);
                if(checkVal)
                {
                    if (huvudmenyVal < 1 || huvudmenyVal > 3) Console.WriteLine("Du måste skriva ett tal mellan 1 och 3");
                    if (huvudmenyVal == 1) spelaGissaEttTal();
                    if (huvudmenyVal == 2) visaLowScores();
                    if (huvudmenyVal == 3) break;
                }
                else {
                    Console.WriteLine("Du måste skriva en siffra mellan 1 och 3");
                    Console.WriteLine();
                }
            }
        }

        private static void visaLowScores()
        {

            var app = new App();
            app.Run();
        }

        private static void spelaGissaEttTal()
        {
            Random random = new Random();
            int randomNumber = random.Next(100) + 1;
            int runda = 1;
            int gissning;
            while(true)
            {
                Console.WriteLine("Runda " + runda);
                Console.WriteLine("Skriv ett tal mellan 1 och 100.");
                var s = Console.ReadLine();
                bool checkGissning = Int32.TryParse(s, out gissning);
                if (checkGissning) runda = Gissning(randomNumber, gissning, runda);
                else Console.WriteLine("Du skrev inte en siffra");
                if (gissning == randomNumber)
                {

                    while (true)
                    {
                        int menyVal;
                        Console.WriteLine("1. Spela en gång till");
                        Console.WriteLine("2. Avsluta spelet");
                        Console.WriteLine("3. Kolla Low Score listan");
                        var Val = Console.ReadLine();

                        bool checkVal = Int32.TryParse(Val, out menyVal);

                        if (checkVal)
                        {
                            if (menyVal > 3 || menyVal < 1)Console.WriteLine("Du måste skriva ett tal mellan 1 och 3");
                            if (menyVal == 1) spelaGissaEttTal();
                            var app = new App();
                            if (menyVal == 2) app.Run();
                            if (menyVal == 3) visaLowScores();
                        }
                        else
                        {
                            Console.WriteLine("Du måste skriva en siffra mellan 1 och 3. SLUTA");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        private static int Gissning(int random, int gissning, int runda)
        {
            if(gissning > 100 || gissning < 1)
            {
                Console.WriteLine("Du skrev inte en siffra mellan 1 och 100");

                return runda;
            }
            if(gissning < random)
            {
                Console.WriteLine("Talet du letar efter är större än " + gissning);
                runda++;
                return runda;
            }
            if (gissning > random)
            {
                Console.WriteLine("Talet du letar efter är mindre än " + gissning);
                runda++;
                return runda;
            }
            if (gissning == random)
            {
                Console.WriteLine("Grattis! " + gissning + " är talet du letade efter!");
                return runda;
            }
            return runda;
            

        }
    }
}
