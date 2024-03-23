using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab6ex1
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
                Console.WriteLine("Generated String " + (i+1) + ": " + generatedString);
            }
        }

        //0*1(0+10*1)* expresia regulata dupa care generez stringurile, de fiecare data cand este iteratie(*) este nu numar random de iteratii
        //eu i-am pus intre 1 si 5 iteratii sa poata fi ca sa nu poata fi mult prea lungi stringurile generate, dar poate fi schimbat usor
        static string GenerateString()
        {
            string generatedstring="";
            int aux1=random.Next(1,6);
            int i;
            for (i = 0; i < aux1; i++)
            {
                generatedstring = generatedstring + '0';
            }
            generatedstring = generatedstring + '1';
            int aux2 = random.Next(1,6);
            for (i = 0; i < aux2; i++)
            {
                aux1 = random.Next(0,2);
                if (aux1 == 0)
                {
                    generatedstring = generatedstring + '0';
                }
                else
                {
                    generatedstring = generatedstring + '1';
                    aux1 = random.Next(1, 6);
                    for (i = 0; i < aux1; i++)
                    {
                        generatedstring = generatedstring + '0';
                    }
                    generatedstring = generatedstring + '1';
                }
            }
            return generatedstring;
        }
    }
}
