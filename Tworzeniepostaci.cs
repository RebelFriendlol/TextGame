using System;
using System.Collections.Generic;
using System.Text;

namespace Oberon
{
    internal class Tworzeniepostaci
    {
        public static void CharacterCreator() //Kreator postaci
        {
            bool czytak = true;
            Player gracz = new Player(); //Obiket gracza
            others oth = new others();
            

            while (czytak) //Nadawanie imienia
            {
                Menu.Print("Witaj bezdomny, jak masz na imie?");
                gracz.imie = Console.ReadLine();
                if (gracz.imie == "") //Warunek sprawdze czy gracz podał imie
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIE WPISAŁEŚ IMIENIA! SPRÓBUJ JESZCZE RAZ");
                    Console.ResetColor();
                    continue;
                }
                //Gracz podaje wiek
                Menu.Print($"Dobrze {gracz.imie}, a ile masz lat?");
                gracz.wiek = Console.ReadLine();
                if (gracz.wiek == "") //Warunek sprawdze czy gracz podał wiek
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NIE WPISAŁEŚ WIEKU! SPRÓBUJ JESZCZE RAZ");
                    Console.ResetColor();
                    continue;
                }
                //Sekretne zakończenie #1
                else if (Convert.ToInt32(gracz.wiek) < 18)
                {
                    Console.WriteLine(" ");
                    Menu.Print("Nie jesteś przypadkiem troche za młody na taka prace?");
                    //Wybór
                    Console.WriteLine("   [1] Tak jestem.");
                    Console.WriteLine("   [2] Przepraszam pomyliłem się.");
                    Console.WriteLine(" ");
                    Console.CursorVisible = false;

                    ConsoleKeyInfo level = Console.ReadKey();
                    Console.Clear();
                    switch (level.KeyChar)
                    {
                        case '1':
                            Menu.Print("No to wróc za te kilka lat.");
                            Console.WriteLine(" ");
                            Menu.Print("Własnie odblokowałeś sekretne zakończenie!");
                            Console.WriteLine(oth.end0);
                            Environment.Exit(-1);
                            break;
                        case '2':
                            Console.WriteLine("No dobra, zacznij od nowa.");
                            Console.WriteLine(" ");
                            continue;
                    }
                }
                //Potwierdzenie wieku
                Console.ForegroundColor = ConsoleColor.Yellow;
                Menu.Print($"Więc jesteś {gracz.imie} i masz {gracz.wiek}? (y/n)");
                Console.ResetColor();
                ConsoleKeyInfo level1 = Console.ReadKey();
                Console.Clear();
                switch (level1.KeyChar)
                {
                    case 'y':
                        czytak = false;
                        break;
                    case 'n':
                        continue;
                }
            }

            while (gracz.punkty != 0) //Nadawanie punktów
            {
                Console.WriteLine($"A więc {gracz.imie} teraz pora ustawić twoje współczynniki.");
                Console.WriteLine($"\n[w] {gracz.wytrzymalosc} Wyrzymałość: Odpowiada za twoja sprawność fizyczną.");
                Console.WriteLine($"[r] {gracz.retoryka} Retoryka: Odpowiada za twoją umiejętność rozmowy z ludźmi. ");
                Console.WriteLine($"[i] {gracz.inteligencja} Inteligencja: Odpowiada za umiejętność rozwiązywania logicznych problemów oraz generalnej wiedzy o świecie. ");
                Console.WriteLine($"[s] {gracz.szczescie} Szczęście: Czysty fart, może ci uratować życie w sytuacjach bez wyjścia.");
                Console.WriteLine("\nDomyślnie każda z nich jest ustawiona na 1 a ich maksymalny poziom to 6, masz 6 punktów które możesz zainwestować.");

                Console.WriteLine($"\nMasz aktualnie {gracz.punkty} puntków");

                ConsoleKeyInfo level2 = Console.ReadKey();
                switch (level2.KeyChar) //Czyta klawiature i na podstawie tego wczytuje metode
                {
                    case 'w':
                        gracz.wytrzymaloscPunkty();
                        break;
                    case 'r':
                        gracz.retorykaPunkty();
                        break;
                    case 'i':
                        gracz.inteligencjaPunkty();
                        break;
                    case 's':
                        gracz.szczesciePunkty();
                        break;
                }
                Console.Clear();
            }

            //Wybieranie płci
            Menu.Print("Ostatnie pytanie. Jesteś kobietą czy mężczyzną?");
            Console.WriteLine("\n[f] Kobietą.");
            Console.WriteLine("[m] Mężczyzną.\n");
            ConsoleKeyInfo level3 = Console.ReadKey();
            if (level3.KeyChar == 'f')
            {
                gracz.plec = true;
            }
            else if (level3.KeyChar == 'f')
            {
                gracz.plec = false;
            }
            Console.Clear();

            //Wypisywanie wszystkich danych o postaci
            Console.WriteLine($"Imie: {gracz.imie}");
            Console.WriteLine($"Wiek: {gracz.wiek}");
            if (gracz.plec == true)
            {
                Console.WriteLine("Płeć: Kobieta");
            }
            else
            {
                Console.WriteLine("Płeć: Mezczyzna");
            }
            Console.WriteLine($"Wytrzymalosc: {gracz.wytrzymalosc} z 6");
            Console.WriteLine($"Retoryka: {gracz.retoryka} z 6");
            Console.WriteLine($"Inteligencja: {gracz.inteligencja}  z 6");
            Console.WriteLine($"Szczescie: {gracz.szczescie}  z 6");



            Console.ReadLine();
        }
    }
}







