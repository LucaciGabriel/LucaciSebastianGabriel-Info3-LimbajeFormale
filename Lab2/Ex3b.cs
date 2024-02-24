using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex3b
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
            //conditia asta este pentru regulile de productie, care daca le-am inteles corect,
            //practic inseamna ca stringul generat trebuie sa fie format dintr-o combinatie de 0 si 1, iar ultimul caracter sa fie 2,3 sau 4 daca stringul are macar doua caractere
            if (currentlen == maxlen - 1 && currentlen!=0)
            {
                for (int i = 2; i <= 4; i++)
                {
                    GenerateStringRec(characters, maxlen, currentlen + 1, current + characters[i], stringslist);
                }
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    GenerateStringRec(characters, maxlen, currentlen + 1, current + characters[i], stringslist);
                }
            }
        }
        static void Main()
        {
            char[] characters = { '0', '1', '2', '3', '4' };
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
