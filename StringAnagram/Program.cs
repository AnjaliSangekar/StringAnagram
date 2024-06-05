using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Anagram();
            Console.WriteLine();
            Insertstring();
            Console.WriteLine();
            Comparestring();
            Console.WriteLine();
            SplitString();
            Console.WriteLine();
            Interpolation();

        }


        public static void Anagram()
        {

            string s1 = "silent";
            string s2 = "listen";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            char[] a = s1.ToLower().ToCharArray();
            char[] b = s2.ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            string n1 = new string(a);
            string n2 = new string(b);


            if(n1 == n2)
            {
                Console.WriteLine("Anagarm String");
            }
            else
            {
                Console.WriteLine("Not Anagram String");
            }

        }


        public static void Insertstring()
        {
            string s = "welcome ";

            Console.WriteLine(s);

            string s1 = "home";

            Console.WriteLine("Insert string");

            Console.WriteLine(s.Insert(s.Length, s1));
        }


        public static void Comparestring()
        {
            string s1 = "java";
            string s2 = "java";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("String equal or not");
            Console.WriteLine(string.Compare(s1, s2));

        }


        public static void SplitString()
        {
            string s = "hello how are you";

            Console.WriteLine(s);

            string[] sp = null;

            char[] split = { ' ' }; 

            sp = s.Split(split);

            Console.WriteLine("Split string");

            for (int i=0; i<sp.Length; i++)
            {
                //MessageBox.Show(sp[i]);
                Console.WriteLine(sp[i]);
            }
        }


        public static void Interpolation()
        {
            string s1 = "welcome";
            string s2 = "home";

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("Using Interpolation");

            Console.WriteLine($"{s1} {s2}");
        }
    }
}
