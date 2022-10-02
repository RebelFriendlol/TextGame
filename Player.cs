using System;
using System.Collections.Generic;
using System.Text;

namespace Oberon
{
    public class Player
    {
        public string imie;
        public bool plec; // false = male, true = female
        public string wiek;
        public int wytrzymalosc = 1;
        public int retoryka = 1;
        public int inteligencja = 1;
        public int szczescie = 1;
        public int punkty = 6; // ilosc puntkow

        public void wytrzymaloscPunkty() //Dodaje punkty do wspolczynniku 
        {
            wytrzymalosc = wytrzymalosc + 1;
            punkty = punkty - 1;
        }
        public void retorykaPunkty() //Dodaje punkty do wspolczynniku 
        {
            retoryka = retoryka + 1;
            punkty = punkty - 1;
        }
        public void inteligencjaPunkty() //Dodaje punkty do wspolczynniku 
        {
            inteligencja = inteligencja + 1;
            punkty = punkty - 1;
        }
        public void szczesciePunkty() //Dodaje punkty do wspolczynniku 
        {
            szczescie = szczescie + 1;
            punkty = punkty - 1;
        }
    }



}
