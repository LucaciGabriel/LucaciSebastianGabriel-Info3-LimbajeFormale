using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3ex2
{
    internal class Program
    {
        //functie recursiva care genereaza toate combinatiile posibile pentru caracterele din characters care sa fie de lungimea data de length
        //cand un string ajunge la lungimea ceruta, apeleaza checkDoubles pentru a verifica daca are numarul cerut de litere dublate din doubles
        static void GenerateStringRec(string characters, int length, int doubles, int currentIndex, string currentstring, List<string> stringslist)
        {
            if (currentIndex == length)
            {
                if(CheckDoubles(currentstring,doubles)==true)
                {
                    stringslist.Add(currentstring);
                }
                return;
            }

            foreach (char c in characters)
            {
                GenerateStringRec(characters, length, doubles, currentIndex + 1, currentstring + c, stringslist);
            }
        }
        //functie folosita pentru a verifica daca avem numarul de litere duble dorit sau nu
        static bool CheckDoubles(string currentstring, int doubles)
        {
            int doublescounter=0;
            int[] letterdoubles = { 0, 0, 0, 0 };
            for (int i = 0; i < currentstring.Length - 1; i++)
            {
                if (currentstring[i] == currentstring[i + 1])
                {
                    switch (currentstring[i])
                    {
                        case 'a':
                            {
                                letterdoubles[0]++; break;
                            }
                        case 'b':
                            {
                                letterdoubles[1]++; break;
                            }
                        case 'c':
                            {
                                letterdoubles[2]++; break;
                            }
                        case 'd':
                            {
                                letterdoubles[3]++; break;
                            }
                    }
                    i++;
                }
            }
            for(int i=0;i<4;i++)
            {
                if (letterdoubles[i]==1) doublescounter++;
            }
            if (doublescounter == doubles) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            //generam stringuri de 6 litere, dintre literele a,b,c,d, cele corecte sunt doar cele cu 3 litere dublate
            //de ex string corect ar fi aabbcc sau bbaadd, incorect ar fi abcdaa sau addbbc, daca am inteles corect
            //nu este neaparat totusi lungime fix de 6 si fix 3 litere dublate, merge si cu alte valori atata timp cat este o combinatie buna
            //de exemplu lungime 2 si 3 litere dublate nu o sa afiseze nimic pentru ca nu poti crea o combinatie de litere care sa indeplineasca conditiile acestea
            string characters = "abcd";
            int length = 6;
            int doubles = 3;

            List<string> stringslist = new List<string>();
            string currentstring = "";
            GenerateStringRec(characters, length, doubles, 0, currentstring, stringslist);

            foreach (var s in stringslist)
            {
                Console.WriteLine(s);
            }
        }
    }
}
