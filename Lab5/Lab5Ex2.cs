using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepgoing = true;
            int currentstate = 1;
            char input = 'A';
            string result="O1";
            while (keepgoing)
            {
                switch (currentstate)
                {
                    case 1:
                        {
                            Console.WriteLine("Sunteti in starea 1, tastati 'A' pentru starea 1, 'B' pentru starea 2, 'X' pentru a opri aplicatia");
                            input=char.Parse(Console.ReadLine());
                            if(input =='A')
                            {
                                currentstate = 1;
                                result=result+"O1";
                            }
                            else if(input == 'B')
                                {
                                    currentstate = 2;
                                    result = result + "02";
                                }
                                else if(input == 'X')
                                    {
                                        keepgoing= false;
                                    }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Sunteti in starea 2, tastati 'A' pentru starea 1, 'B' pentru starea 2, 'X' pentru a opri aplicatia");
                            input = char.Parse(Console.ReadLine());
                            if (input == 'A')
                            {
                                currentstate = 1;
                                result = result + "O1";
                            }
                            else if (input == 'B')
                                {
                                    currentstate = 2;
                                    result = result + "02";
                                }
                                else if (input == 'X')
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
