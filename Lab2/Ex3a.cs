using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex3a
{
    class Program
    {
        //functia principala, parcurge lungimile posibile si apeleaza functia recursiva
        static List<string> GenerateStrings(char[] characters, int maxlen)
        {
            List<string> stringslist = new List<string>();
            for (int length = 1; length <= maxlen; length++)
            {
                GenerateStringRec(characters, length, 0, "", stringslist);
            }
            return stringslist;
        }
        //functie recursiva care genereaza toate combinatiile posibile pentru caracterele din characters care sa fie de lungimea data de maxlen
        static void GenerateStringRec(char[] characters, int maxlen, int currentlen, string current, List<string> stringslist)
        {
            if (currentlen == maxlen)
            {
                stringslist.Add(current);
                return;
            }
            //conditia asta este practic pentru regulile de producte S->AB, A->aA|null, B->bB|null,
            //care practic inseamna ca stringul generat nu poate sa aiba vreun caracter 'a' dupa 'b'
            if (current.Contains("b") == false)
            {
                foreach (char character in characters)
                {
                    GenerateStringRec(characters, maxlen, currentlen + 1, current + character, stringslist);
                }
            }
            else GenerateStringRec(characters, maxlen, currentlen + 1, current + 'b', stringslist);
        }
        static void Main()
        {
            char[] characters = { 'a', 'b' };
            int maxlen = 5;
            //enuntul nu era clar pentru ca zicea doar "de lungime maxima", fara un numar care sa fie lungimea maxima,
            //asa ca am luat 5 ca lungime maxima, dar poate fi schimbata valoarea la maxlen pentru alta lungime maxima
            List<string> stringslist = GenerateStrings(characters, maxlen);
            foreach (string s in stringslist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
