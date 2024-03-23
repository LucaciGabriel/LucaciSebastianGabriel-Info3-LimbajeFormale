using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab6ex2._3
{
    internal class Program
    {
        static Random random = new Random();
        static void Main()
        {
            //generez doar 10 stringuri ca sa nu ia prea mult, dar nu este limitat la atat
            for (int i = 0; i < 10; i++)
            {
                string generatedString = GenerateString();
                Console.WriteLine("Generated String " + (i + 1) + ": " + generatedString);
            }
        }

        //L={(a^n b^n c^n)|n>0} este limbajul dupa care generez stringurile, de fiecare data cand este iteratie(*) este nu numar random de iteratii
        //eu i-am pus intre 1->5 pentru n iteratii sa poata fi ca sa nu poata fi mult prea lungi stringurile generate, dar poate fi schimbat usor
        static string GenerateString()
        {
            string generatedstring = "";
            int n = random.Next(1, 6);
            int i;
            for (i = 0; i < n; i++)
            {
                generatedstring = generatedstring + 'a';
            }
            for (i = 0; i < n; i++)
            {
                generatedstring = generatedstring + 'b';
            }
            for (i = 0; i < n; i++)
            {
                generatedstring = generatedstring + 'c';
            }
            return generatedstring;
        }
    }
}
