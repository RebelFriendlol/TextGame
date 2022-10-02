using System;


namespace Oberon
{
    class Menu
    {
        public static void TitleScreen() //Metoda odpowiedzialna za wypisanie ekranu tytułowego na ekran
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Print(" .88888.  dP   ", 10);
            Print("d8'   `8b 88     ", 10);
            Print("88     88 88d888b. .d8888b. 88d888b. .d8888b. 88d888b. ", 5);
            Print("88     88 88'  `88 88ooood8 88'  `88 88'  `88 88'  `88 ", 5);
            Print("Y8.   .8P 88.  .88 88.  ... 88       88.  .88 88    88", 5);
            Print(" `8888P'  88Y8888' `88888P' dP       `88888P' dP    dP ", 5);
            Print("ooooooooooooooooooooooooooooooooooooooooooooooooooooooo", 5);
            Console.ResetColor();
        }

        public static void Print(string text, int speed = 40) //Metoda odpowiedzialna za szybkość tekstu
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }



        public static void Options() //Opcje które gracz może na poczatku wybrać
        {
            Console.CursorVisible = false;
            Console.WriteLine("                          ");
            Console.WriteLine("[1] Zacznij gre");
            Console.WriteLine("[2] Wyjdz z programu");

            ConsoleKeyInfo wybor = Console.ReadKey();

            Console.Clear();
            switch (wybor.KeyChar)
            {
                case '1':
                    //Program idze dalej
                    break;
                case '2':
                    Console.WriteLine("Żegnaj!");
                    Environment.Exit(-1); //Program zamyka się
                    break;
                default:
                    TitleScreen(); //Gdy gracz klicnie inny przycisk to wczytuje menu od nowa
                    Options();
                    break;

            }
        }
    }
}

