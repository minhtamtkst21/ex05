using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minhtam5a
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z();
            Print_z_2_a();
            Print_A_2_Z();
            //while(true)
            //{
            //    char c= Console.ReadKey().KeyChar;
            //    Console.WriteLine(" " + Char2Code(c));
            //}
            //---------------------------------
            //while (true)
            //{
            //    char c = Console.ReadKey().KeyChar;
            //    Console.WriteLine(isUper(c));
            //}
            //-------------------------------------
            //while (true)
            //{
            //    char c = Console.ReadKey().KeyChar;
            //    Console.WriteLine(isLower(c));
            //}
            //----------------------------------
            while (true)
            {
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(changeUpPer_Lower(c));
            }
        }
        static void Print_a_2_z()
        {
            //for (int i=97;i<=122;i++)
            //{
            //    Console.Write((char)i+",");
            //} 
            //Console.WriteLine();
            //--------------------------------
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.Write(c + ",");
            }
            Console.WriteLine();
        }
        static void Print_z_2_a()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)(122+97-i) + ",");
            }
            Console.WriteLine();
        }
        static void Print_A_2_Z()
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + ",");
            }
            Console.WriteLine();
        }
        static int Char2Code(char c)
        {
            return (int)c;
        }
        static bool isUper(char c)
        {
            if ((int)c >= 65 && c <= 90)
                return true;
            return false;
        }
        static bool isLower(char c)
        {
            if ((int)c >= 97 && c <= 122)
                return true;
            return false;
        }
        static char changeUpPer_Lower(char c)
        {
            if ((int)c >= 65 && c <= 90)
            {
                int ch = c + 32;
                return (char) ch;
            }
            else
            {
                int ch = c - 32;
                return (char)ch;
            }
            return ' ';
        }
    }
}
