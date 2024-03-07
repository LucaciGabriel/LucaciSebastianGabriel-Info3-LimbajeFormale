using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Introduceti numarul de locuri de parcare");
            n= int.Parse(Console.ReadLine());
            int[] stateslist= new int[n];
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Starea locului " + (i+1) + " (0-liber,1-ocupat):");
                stateslist[i]=int.Parse(Console.ReadLine());
            }
            int chosenspot = 0;
            int input = 0;
            bool keeprunning = true;
            while (keeprunning == true)
            {
                Console.WriteLine("Alege-ti locul la care vreti sa faceti ceva (de la 1 la " + n + "):");
                chosenspot=int.Parse(Console.ReadLine());
                if (chosenspot < 1 || chosenspot > n)
                {
                    Console.WriteLine("Numarul ales nu este valid, alege-ti un numar valid");
                }
                else
                {
                    switch (stateslist[chosenspot - 1])
                    {
                        case 0:
                            {
                                Console.WriteLine("Locul este liber, doriti sa parcati aici si sa ocupati locul? (A-da,B-nu)");
                                input = char.Parse(Console.ReadLine());
                                switch(input)
                                {
                                    case 'A':
                                        {
                                            stateslist[chosenspot - 1] = 1;
                                            break;
                                        }
                                    case 'B':
                                        {
                                            Console.WriteLine("Se intoarce la alegerea de locuri.");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Input invaid, se intoarce la alegerea de loc");
                                            break;
                                        }
                                }
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("Locul este ocupat, doriti sa plecati de aici si sa eliberati locul? (A-da,B-nu)");
                                input = char.Parse(Console.ReadLine());
                                switch (input)
                                {
                                    case 'A':
                                        {
                                            stateslist[chosenspot - 1] = 0;
                                            break;
                                        }
                                    case 'B':
                                        {
                                            Console.WriteLine("Se intoarce la alegerea de locuri.");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Input invaid, se intoarce la alegerea de loc");
                                            break;
                                        }
                                }
                                break;
                            }
                    }
                }
            }
        }
    }
}
