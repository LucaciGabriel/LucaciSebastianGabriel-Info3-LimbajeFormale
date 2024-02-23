using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Ex1
{
    class Program
    {
        //functia principala, parcurge lungimile posibile si apeleaza functia recursiva
        static List<string> genpalin(string characters, int min, int max)
        {
            List<string> palindromelist = new List<string>();

            for (int length = min; length <= max; length++)
            {
                genpalinrec(characters, new char[length], 0, length - 1, palindromelist);
            }

            return palindromelist;
        }
        //functie recursiva care genereaza toate palindroamele folosind caracterele din characters pentru o anumita marime data de left,right
        static void genpalinrec(string characters, char[] current, int left, int right, List<string> palindromelist)
        {
            if (left > right)
            {
                palindromelist.Add(new string(current));
                return;
            }

            foreach (char c in characters)
            {
                current[left] = c;
                current[right] = c;
                genpalinrec(characters, current, left + 1, right - 1, palindromelist);
            }
        }
        
        static void Main()
        {
            string E = "012";
            int min = 1;
            int max = 5;
            List<string> palindromelist = genpalin(E, min, max);
            //afisarea palindroamelor generate
            Console.WriteLine("Palindroamele folosind caracterele '" + E + "' intre lungimile " + min + " si " + max + " sunt: ");
            int lengthcounter = 0;
            foreach (var palindrome in palindromelist)
            {
                if (palindrome.Length == lengthcounter)
                    Console.WriteLine(palindrome);
                else
                {
                    lengthcounter++;
                    Console.WriteLine("Lungime "+ lengthcounter +": ");
                    Console.WriteLine(palindrome);
                }
            }
        }
    }
}
