using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        /*ex1
        public static int lungime(string s1)
        {
            int lung = 0;
            foreach(char c in s1)
            {
                lung++;
            }
            return lung;
        }
        public static string concatenare(string s1,string s2)
        {
            string sconcat = s1 + s2;
            return sconcat;
        }
        public static string inversare(string s1)
        {
            string sinvers="";
            int i = 0;
            int lung=lungime(s1);
            for(i=lung;i>0;i--)
            {
                sinvers = sinvers+s1[i-1];
            }
            return sinvers;
        }
        public static string substitutie(string s1, char a, char b)
        {
            char[] ssubst = s1.ToCharArray();
            int i = 0;
            foreach(char c in s1)
            {
                if (c == a) ssubst[i] = b;
                    i++;
            }
            s1 = new string(ssubst);
            return s1;
        }
        static void Main(string[] args)
        {
            char[] A = new char[3];
            A[0] = 'a';
            A[1] = 'b';
            A[2] = 'c';
            char[] B = new char[3];
            B[0] = 'x';
            B[1] = 'y';
            B[2] = 'z';
            char[] C = new char[3];
            C[0] = '1';
            C[1] = '2';
            C[2] = '3';
            string s1 = "aba";
            string s2 = "123";
            string concat = "";
            int len = lungime(s1);
            Console.WriteLine("Lungime stringului s1: " + len);
            concat = concatenare(s1, s2);
            Console.WriteLine("Stringul concatenat s1+s2: " + concat);
            len = lungime(concat);
            Console.WriteLine("Lungimea stringului concatenat: " + len);
            string invers = inversare(concat);
            Console.WriteLine("Inversul stringului concatenat: " + invers);
            string substituted = substitutie(concat, 'a', 'c');
            Console.WriteLine("Subsitutia stringului concatenat a cu c: " + substituted);
            */
        /*ex2*/
        public static int lungime(string s1)
        {
            int lung = 0;
            foreach (char c in s1)
            {
                lung++;
            }
            return lung;
        }
        public static string concatenare(string s1, string s2)
        {
            string sconcat = s1 + s2;
            return sconcat;
        }
        public static string inversare(string s1)
        {
            string sinvers = "";
            int i = 0;
            int lung = lungime(s1);
            for (i = lung; i > 0; i--)
            {
                sinvers = sinvers + s1[i - 1];
            }
            return sinvers;
        }
        public static string repetare(string s1, int n)
        {
            string srepetat = "";
            int i = 0;
            for (i = 0; i < n; i++) srepetat = srepetat + s1;
            return srepetat;
        }
        public static string extragere(string s1, int i, int j)
        {
            string extras="";
            int k=0;
            for(k=i;k<=j;k++)
            {
                extras = extras+s1[k-1];
            }
            return extras;
        }
        public static string schimbaresub(string s1, string sub, string new_sub)
        {
            char[] newstring=s1.ToCharArray();
            bool okay=true;
            int i=0;
            int sublength=lungime(sub);
            int s1length=lungime(s1);
            while (i<s1length-sublength)
            {
                okay=true;
                for(int k=0;k<sublength && okay==true;k++)
                {
                    if(newstring[i+k]!=sub[k])
                    {
                        okay=false;
                    }
                }
                if (okay==true)
                {
                    for(int k=0;k<sublength;k++)
                    {
                        newstring[i+k]=new_sub[k];
                    }
                    break;
                }
                i++;
            }
            return new string(newstring);
        }
        static void Main(string[] args)
        {
            char[] A = new char[3];
            A[0] = 'a';
            A[1] = 'b';
            A[2] = 'c';
            char[] B = new char[3];
            B[0] = 'x';
            B[1] = 'y';
            B[2] = 'z';
            char[] C = new char[3];
            C[0] = '1';
            C[1] = '2';
            C[2] = '3';
            string s1 = "aba";
            string s2 = "123";
            string concat = "";
            int len = lungime(s1);
            Console.WriteLine("Lungime stringului s1: " + len);
            concat = concatenare(s1, s2);
            Console.WriteLine("Stringul concatenat s1+s2: " + concat);
            len = lungime(concat);
            Console.WriteLine("Lungimea stringului concatenat: " + len);
            string invers = inversare(concat);
            Console.WriteLine("Inversul stringului concatenat: " + invers);
            string repetat = repetare(s1, 3);
            Console.WriteLine("Stringul repetat: " + repetat);
            string extras= extragere(concat, 2,4);
            Console.WriteLine("Stringul extras: " + extras);
            string schimbat= schimbaresub(concat, "ba1", "cd7");
            Console.WriteLine("Stringul schimbat: " + schimbat);
        }
    }
}
