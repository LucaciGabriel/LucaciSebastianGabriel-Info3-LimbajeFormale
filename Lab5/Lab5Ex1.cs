using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            int currentstate = 0;
            char input = 'a';
            while(keepgoing)
            {
                switch(currentstate)
                {
                    case 0:
                        {
                            Console.WriteLine("Sunteti in starea 0, tastati 'a' pentru a trece in starea 1");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'a')
                            {
                                currentstate = 1;
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Sunteti in starea 1, tastati 'a' pentru a ramane in starea 1 sau 'E' pentru a trece in starea 2");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'E')
                            {
                                currentstate = 2;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Sunteti in starea 2, tastati 'b' pentru a ramane in starea 2 sau tastati 'a' sau 'b' pentru a trece in starea 3");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'a')
                            {
                                currentstate = 3;
                            }
                            if(input=='b')
                            {
                                Console.WriteLine("Ramaneti in starea 2 sau treceti in starea 3(2-starea 2,3-starea 3)");
                                input=char.Parse(Console.ReadLine());
                                if(input=='2')
                                {
                                    currentstate = 2;
                                }
                                else if(input=='3')
                                {
                                    currentstate = 3;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Sunteti in starea 3, tastati 'a' pentru a ramane in starea 3, 'b' pentru a trece in starea 1 sau 'E' pentru a trece in starea 4 si a termina programul");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'a')
                            {
                                currentstate = 3;
                            }
                            else if(input=='b')
                                {
                                    currentstate = 1;
                                }
                                else if(input=='E')
                                    {
                                        currentstate = 4;
                                    }
                            break;
                        }
                    case 4:
                        {
                            keepgoing = false;
                            break;
                        }
                }
            }
        }
    }
}
