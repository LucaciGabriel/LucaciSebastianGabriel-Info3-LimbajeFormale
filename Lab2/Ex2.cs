using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex2
{
    class Program
    {
        //functie recursiva care genereaza un string bazat pe un set dat de alegeri dintre cele 4 optiuni, pentru un anumit numar de iteratii
        static string GenerateString(int iterations, int counter, int[] choiceslist)
        {
            if (iterations <= 0)
                return "";
            switch (choiceslist[counter])
            {
                case 0:
                    return "a" + GenerateString(iterations - 1,counter + 1,choiceslist) + "a";
                case 1:
                    return "b" + GenerateString(iterations - 1,counter + 1,choiceslist) + "b";
                case 2:
                    return "a";
                case 3:
                    return "b";
                default:
                    return "";//nu ar trebui sa intre aici in mod normal, dar da eroare fara default case
            }
        }

        static void Main()
        {
            List<string> stringslist=new List<string>();
            int[] choicelist = { 0, 0, 0 };
            bool stopgeneration = false;
            Console.WriteLine("Optiunile din regula de productie: ");
            Console.WriteLine("1: aSa");
            Console.WriteLine("2: bSb");
            Console.WriteLine("3: a");
            Console.WriteLine("4: b");
            Console.WriteLine("");
            while (stopgeneration == false)
            {
                Console.WriteLine("Cazul: " + (choicelist[0]+1) + "," + (choicelist[1]+1) + "," + (choicelist[2]+1));
                for (int i = 1; i <= 3; i++)
                {
                    stringslist.Add(GenerateString(i,0,choicelist));
                    Console.WriteLine("Iteratia " + i + ": " + stringslist.Last());
                }
                Console.WriteLine("");
                if (choicelist[2] < 3)
                {
                    choicelist[2] = choicelist[2] + 1;
                }
                else if (choicelist[1] < 3)
                {
                    choicelist[1] = choicelist[1] + 1;
                    choicelist[2] = 0;
                }
                else if (choicelist[0] < 3)
                {
                    choicelist[0] = choicelist[0] + 1;
                    choicelist[1] = 0;
                    choicelist[2] = 0;
                }
                else stopgeneration = true;
            }

        }
    }
}
