using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            int currentstate = 1;
            char input = 'X';
            string result = "";
            while (keepgoing)
            {
                switch (currentstate)
                {
                    case 1:
                        {
                            Console.WriteLine("Sunteti in starea 1, tastati 'X' pentru starea 2, 'Y' pentru starea 1, 'E' pentru a opri aplicatia");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'X')
                            {
                                currentstate = 2;
                                result = result + "O1";
                            }
                            else if (input == 'Y')
                            {
                                currentstate = 1;
                                result = result + "01";
                            }
                            else if (input == 'E')
                            {
                                keepgoing = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Sunteti in starea 2, tastati 'X' pentru starea 1, 'Y' pentru starea 2, 'E' pentru a opri aplicatia");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'X')
                            {
                                currentstate = 1;
                                result = result + "O2";
                            }
                            else if (input == 'Y')
                            {
                                currentstate = 2;
                                result = result + "02";
                            }
                            else if (input == 'E')
                            {
                                keepgoing = false;
                            }
                            break;
                        }
                }
            }
            Console.WriteLine("Rezulatul final este " + result);
        }
    }
}
