using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7ex1
{
    internal class Program
    {
        static Random random = new Random();
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                string generatedexpressioninitial = firstGen("E", 5, 0);
                int j = 0;
                string generatedexpressionfinal="";
                while(j<generatedexpressioninitial.Length)
                {
                    if (generatedexpressioninitial[j]=='*'|| generatedexpressioninitial[j] == '+' || generatedexpressioninitial[j] == '(' || generatedexpressioninitial[j] == ')')
                    {
                        generatedexpressionfinal += generatedexpressioninitial[j];
                    }
                    else
                    {
                        generatedexpressionfinal += secondGen("I", 5, 0);
                    }
                    j++;
                }
                Console.WriteLine("Generated expression "+ (i+1) + ": " + generatedexpressionfinal);
            }
        }

        static string firstGen(string initialexpression, int maxderiv, int derivcount)
        {
            string generatedexpression = initialexpression;
            if (maxderiv > derivcount)
            {
                int aux = random.Next(1, 5);
                switch (aux)
                {
                    //E->I
                    case 1:
                        {
                            generatedexpression = "I";
                            break;
                        }
                    //E->E+E
                    case 2:
                        {
                            generatedexpression = firstGen("E",maxderiv,derivcount+2) + "+" + firstGen("E", maxderiv, derivcount + 2);
                            break;
                        }
                    //E->E*E
                    case 3:
                        {
                            generatedexpression = firstGen("E", maxderiv, derivcount + 2) + "*" + firstGen("E", maxderiv, derivcount + 2);
                            break;
                        }
                    //E->(E)
                    case 4:
                        {
                            generatedexpression = "(" + firstGen("E", maxderiv, derivcount + 1) + ")";
                            break;
                        }
                }
            }
            else generatedexpression = "I";
            return generatedexpression;
        }

        static string secondGen(string initialexpression, int maxderiv, int derivcount)
        {
            string generatedexpression = initialexpression;
            if (maxderiv > derivcount)
            {
                int aux = random.Next(1, 7);
                switch (aux)
                {
                    //I->a
                    case 1:
                        {
                            generatedexpression = "a";
                            break;
                        }
                    //I->b
                    case 2:
                        {
                            generatedexpression = "b";
                            break;
                        }
                    //I->Ia
                    case 3:
                        {
                            generatedexpression = secondGen("I",maxderiv,derivcount+1) + "a";
                            break;
                        }
                    //I->Ib
                    case 4:
                        {
                            generatedexpression = secondGen("I", maxderiv, derivcount + 1) + "b";
                            break;
                        }
                    //I->I0
                    case 5:
                        {
                            generatedexpression = secondGen("I", maxderiv, derivcount + 1) + "0";
                            break;
                        }
                    //I->I1
                    case 6:
                        {
                            generatedexpression = secondGen("I", maxderiv, derivcount + 1) + "1";
                            break;
                        }
                }
            }
            else
            {
                int aux = random.Next(1, 2);
                if (aux == 1) generatedexpression = "a";
                else generatedexpression = "b";
            }
            return generatedexpression;
        }
    }
}

