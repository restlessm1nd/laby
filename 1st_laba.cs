using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int UserInputNumber()
        {
            string st = Console.ReadLine(); 
            int number = Convert.ToInt32(st);
            return number;
        }
        static void Main(string[] args)
        {
            int n1 = UserInputNumber(); // В этой и в двух следующих строчках мы ввели с клавиатуры 3 числа с помощью функции выше.
            int n2 = UserInputNumber();
            int n3 = UserInputNumber();

            if (n1 < n2 && n1 < n3) // Здесь мы рассмотрели случай, при котором первое число самое маленькое и сразу вывели его, ибо числа должны идти в порядке возрастания.
            {
                Console.Write("{0}, ", n1);
                if (n2 < n3)       // В if и else мы сравнили оставшиеся два числа и вывели их также в порядке возрастания, дальше все будет очень похоже, только рассматриваться будут другие случаи.
                {
                    Console.Write("{0}, {1}", n2, n3);
                }
                else
                {
                    Console.Write("{0}, {1}", n3, n2);
                }
            }

            if (n2 < n1 && n2 < n3)
            {
                Console.Write("{0}, ", n2);
                if (n1 < n3)       
                {
                    Console.Write("{0}, {1}", n1, n3);
                }
                else
                {
                    Console.Write("{0}, {1}", n3, n1);
                }
            }

            if (n3 < n2 && n3 < n1)
            {
                Console.Write("{0}, ", n3);
                if (n2 < n1)
                {
                    Console.Write("{0}, {1}", n2, n1);
                }
                else
                {
                    Console.Write("{0}, {1}", n1, n2);
                }
            }
            Console.WriteLine(" ");
          // Чтобы из возрастания сделать убывание можно скопировать код выше и везде изменить знак меньше на больше.
            if (n1 > n2 && n1 > n3)
            {
                Console.Write("{0}, ", n1);
                if (n2 > n3)
                {
                    Console.Write("{0}, {1}", n2, n3);
                }
                else
                {
                    Console.Write("{0}, {1}", n3, n2);
                }
            }

            if (n2 > n1 && n2 > n3)
            {
                Console.Write("{0}, ", n2);
                if (n1 > n3)
                {
                    Console.Write("{0}, {1}", n1, n3);
                }
                else
                {
                    Console.Write("{0}, {1}", n3, n1);
                }
            }

            if (n3 > n2 && n3 > n1)
            {
                Console.Write("{0}, ", n3);
                if (n2 > n1)
                {
                    Console.Write("{0}, {1}", n2, n1);
                }
                else
                {
                    Console.Write("{0}, {1}", n1, n2);
                }
            }
            Console.ReadKey();
        }
    }
}
