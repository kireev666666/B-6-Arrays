using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[3, 3] { { 2, 4, 6 }, { 3, 5, 9 }, { 1, 7, 11 } };
            int max;
            for (int i = 0; i < 3; i++)
            {
                max = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (mass[i, j] > max) max = mass[i, j];
                }
                Console.WriteLine(max);
            }
            Console.ReadKey();

        }

        public static void DMasiveSort()
        {
            Console.WriteLine("Заполните массив");
            int a, b, c, d, e;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[5] { a, b, c, d, e };
            Array.Sort(mass);
            for (int i = 0; i < mass.Length; i++)
                Console.Write(" " + mass[i]);
            Console.ReadKey();
        }
       
        public static void Pyatnashki()
        {
            int[,] mass = new int[3, 3];
            printmass(mass);
            initmass(mass);
            Console.WriteLine();
            printmass(mass);

        }

        private static void printmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                Console.Write($"{mass[i,j]} ");
                }
                Console.WriteLine();
            }
          
        }
        static Random r = new Random();
        private static void initmass(int[,] mass)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = r.Next(10);
                    
                }
                
            }

        }

        public static void  CutString()
        {
            Console.Write("Введите предложение: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
                if (text.Length > 13)
                {
                    text = text.Remove(13) + "...";
                }
            Console.WriteLine(text);

            Console.ReadKey();

        }
                
        public static void ReplaceInPoem()
        {
            Console.WriteLine("Введите стихотворение в одну строку разделяя строки точкой с запятой ");
            string text = Console.ReadLine();
            text = text.Replace('а', 'о').Replace("л", "ль").Replace("ть", "т");
            string[] words = text.Split(';');

            foreach (var word in words)
            {
                Console.WriteLine(word);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
