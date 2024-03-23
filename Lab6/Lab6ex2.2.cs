using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab6ex2._2
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

        //L={(a^i b^j)|i<=j} este limbajul dupa care generez stringurile, de fiecare data cand este iteratie(*) este nu numar random de iteratii
        //eu i-am pus intre 1->5 pentru j si 1->j pentru i iteratii sa poata fi ca sa nu poata fi mult prea lungi stringurile generate, dar poate fi schimbat usor
        static string GenerateString()
        {
            string generatedstring = "";
            int j = random.Next(1, 6);
            int i = random.Next(1, j+1);
            int k;
            for (k = 0; k < i; k++)
            {
                generatedstring = generatedstring + 'a';
            }
            for (k = 0; k < j; k++)
            {
                generatedstring = generatedstring + 'b';
            }
            return generatedstring;
        }
    }
}
