using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Введите год > ");
            string st = Console.ReadLine();
            int year = int.Parse(st);

            Console.Write("Введите месяц > ");
            string month = Console.ReadLine(); // По указанию Сергея Сергеевича лучше также конвертировать 
                                               // месяц в int и работать с месяцем как с числом, то есть 1 = январь и тд.
                                               // для этого используйте команду int month = int.Parse(st); 
                                               // предварительно новый string можно не объявлять, а работать с переменной st.

            Console.Write("Введите день > ");
            st = Console.ReadLine();
            int day = int.Parse(st);

            string noy = " "; 

            string zz = " ";

            string color = " ";

            switch (month) 
                           // Объяснение что такое switch для тех, кого не было на паре: 
                           // Оператор switch принимает выражение или переменную и сравнивает его значение со значением каждого case (value1, value2, …).
                           // Когда оператор switch находит идентичное значение, выполняется блок кода внутри соответствующего case. 
                           // То есть case по сути микрофункция, которая будет выполняться в случе если значение переменной в скобках совпадает со значением case.
                           // В данной ситуации каждый case должен содержать в себе if, ибо в одном месяце может быть два знака.
            {
                case "январь": 
                    if(day <= 20) zz = "козерог"; 
                    else zz ="водолей";
                    break;

                case "февраль": 
                    if(day <= 18) zz = "водолей";
                    else zz ="рыбы";
                    break;

                case "март":
                    if (day <= 20) zz = "рыбы";
                    else zz = "овен";
                    break;

                case "апрель":
                    if (day <= 19) zz = "овен";
                    else zz = "телец";
                    break;

                case "май":
                    if (day <= 20) zz = "телец";
                    else zz = "близнецы";
                    break;

                case "июнь":
                    if (day <= 21) zz = "близнецы";
                    else zz = "рак";
                    break;

                case "июль":
                    if (day <= 22) zz = "рак";
                    else zz = "лев";
                    break;

                case "август":
                    if (day <= 22) zz = "лев";
                    else zz = "дева";
                    break;

                case "сентябрь":
                    if (day <= 22) zz = "дева";
                    else zz = "весы";
                    break;

                case "октябрь":
                    if (day <= 23) zz = "весы";
                    else zz = "скорпион";
                    break;

                case "ноябрь":
                    if (day <= 22) zz = "скорпион";
                    else zz = "стрелец";
                    break;

                case "декабрь":
                    if (day <= 22) zz = "стрелец";
                    else zz = "козерог";
                    break;
            }

            switch (year % 12) // Это мы разбирали на паре, объясню как это делал я ибо препода я не слушал) 
                               // Я нашел картинку, где расписано какое животное какому году соответствует, нашел год, 
                               // который делится на 12(т.к. животных всего 12) без остатка(2028) 
                               // и начал отсчет от этого животного (обезьяна) по порядку.
            {
                case 0: noy = "обезьяны"; break;

                case 1: noy = "петуха"; break;

                case 2: noy = "собаки"; break;

                case 3: noy = "свиньи"; break;

                case 4: noy = "крысы"; break;

                case 5: noy = "быка"; break;

                case 6: noy = "тигра"; break;

                case 7: noy = "кролика"; break;

                case 8: noy = "дракона"; break;

                case 9: noy = "змеи"; break;

                case 10: noy = "лошади"; break;

                case 11: noy = "козы"; break;
            }

            switch (year % 10) // Цвет года определяется по последней цифре года и один и тот же цвет повторяется дважды.
                               // Цвета написаны в родительном падеже, но вам я так делать не советую, ибо будет шанс вывода типа "Это год белого змеи".
            {
                case 0: color = "белого "; break;

                case 1: color = "белого "; break;

                case 2: color = "синего "; break;

                case 3: color = "синего "; break;

                case 4: color = "зеленого "; break;

                case 5: color = "зеленого "; break;

                case 6: color = "красного "; break;

                case 7: color = "красного "; break;

                case 8: color = "желтого "; break;

                case 9: color = "желтого "; break;
            }
            Console.Write("Знак зодиака ");
            Console.WriteLine(zz);

            Console.Write("Это год ");
            Console.Write(color);
            Console.Write(noy);

            // Простой вывод, но при условии, что цвет будет в именительном падеже, то лучше его подкорректировать.

            Console.ReadLine(); // Здесь могла быть ваша реклама.
        }
    }
}
