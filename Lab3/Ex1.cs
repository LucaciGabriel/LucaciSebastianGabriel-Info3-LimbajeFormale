using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3ex1
{
    internal class Program
    {
        //q0,c-q1 q0,t-q2 q0,a-q3 q0,h-q4
        //q1,ok-q5 q2,ok-q5 q3,ok-q5 q4,ok-q5 q5,ok-q0


        static void Main(string[] args)
        {
            int state = 0;
            bool keeprunning = true;
            while (keeprunning==true)
            {
                switch (state)
                {
                    //0=q0(stare initiala), 1,2,3,4=q1,q2,q3,q4(starile la fiecare bautura aleasa) 5=q5(starea finala)
                    case 0:
                        {
                            Console.WriteLine("Selectati bautura dorita: 1.cafea 2.ceai 3.cappucino 4.ciocolata calda");
                            state=int.Parse(Console.ReadLine());
                            if(state<0 || state>5)
                            {
                                Console.WriteLine("Optiune invalida, se revine la starea initiala");
                                state = 0;
                            }    
                            break;
                        }
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        {
                            Console.WriteLine("Ati selectat o bautura, tastati 5 pentru a confirma alegerea");
                            state = int.Parse(Console.ReadLine());
                            if (state!=5)
                            {
                                Console.WriteLine("Optiune invalida, se revine la starea initiala");
                                state = 0;
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Daca doriti sa va schimbati alegerea tastati 5, altfel pentru a termina procesul tastati 6");
                            state = int.Parse(Console.ReadLine());
                            if (state == 5)
                            {
                                state = 0;
                            }
                            break;
                        }
                    case 6:
                        {
                            keeprunning = false;
                            break;
                        }
                }
                
            }
        }
    }
}
