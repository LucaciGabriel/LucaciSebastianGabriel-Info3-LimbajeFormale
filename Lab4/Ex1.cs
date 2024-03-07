using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char state = 'A';
            int input = 0;
            bool keeprunning = true;
            while (keeprunning == true)
            {
                switch (state)
                {
                    case 'A':
                        {
                            Console.WriteLine("Starea curenta A, introduceti 0 pentru a trece in starea B, 1 pentru a ramane in starea A, sau 2 pentru a opri programul");
                            input = int.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case 0:
                                    {
                                        state = 'B';
                                        break;
                                    }
                                case 1:
                                    {
                                        state = 'A';
                                        break;
                                    }
                                case 2:
                                    {
                                        keeprunning= false;
                                        break;
                                    }
                                default: 
                                    {
                                        Console.WriteLine("Optiune invalida, se revine la starea initiala");
                                        state = 'A';
                                        break; 
                                    }
                            }
                            break;
                        }
                    case 'B':
                        {
                            Console.WriteLine("Starea curenta B, introduceti 0 pentru a trece in starea A, 1 pentru a ramane in starea B, sau 2 pentru a opri programul");
                            input = int.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case 0:
                                    {
                                        state = 'A';
                                        break;
                                    }
                                case 1:
                                    {
                                        state = 'B';
                                        break;
                                    }
                                case 2:
                                    {
                                        keeprunning = false;
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Optiune invalida, se revine la starea initiala");
                                        state = 'A';
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
