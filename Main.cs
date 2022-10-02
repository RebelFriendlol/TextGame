using System;


namespace Oberon
{
    class Program
    {

        static void Main(string[] args)
        {
            const string autor = "Bartosz Lorenc-Buśko";
            const string werjsa = "Alpha 0.0.1";
            Player gracz = new Player(); //Obiket gracza

            Console.Title = $"Oberon Autor: {autor}, Wersja: {werjsa} (Prace w toku)";  //Wypisywanie podstawowych informacji o programie na Title barze

            Menu.TitleScreen(); //Metoda wypisuje duży napis "RPG" (mimo że to nie jest gra rpg ale chuj z tym)
            Menu.Options(); //Metoda wypisuje opcje
            Tworzeniepostaci.CharacterCreator(); //Metoda tworzenia postaci


        }
    }
}

