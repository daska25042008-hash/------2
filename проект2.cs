
using System;

namespace Laboratornaya4
{
    enum ДеньНедели
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1. Проверка последовательности");
            Console.WriteLine("Введите 10 целых чисел:");
            int[] числа = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Число " + (i + 1) + ": ");
                числа[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool порядок = true;
            for (int i = 1; i < 10; i++)
            {
                if (числа[i] <= числа[i - 1])
                {
                    Console.WriteLine("Порядок нарушен!");
                    Console.WriteLine("Номер числа: " + (i + 1));
                    порядок = false;
                    break;
                }
            }
            if (порядок)
            Console.WriteLine("Числа идут по возрастанию.");
        
            Console.WriteLine("Задание 2. Карта");
            try
            {
                Console.WriteLine("Введите номер карты от 6 до 14:");
                int номер = Convert.ToInt32(Console.ReadLine());

                if (номер < 6 || номер > 14)
                    throw new Exception("Неправильный номер карты!");

                if (номер <= 10)
                    Console.WriteLine(номер);
                else if (номер == 11)
                    Console.WriteLine("Валет");
                else if (номер == 12)
                    Console.WriteLine("Дама");
                else if (номер == 13)
                    Console.WriteLine("Король");
                else
                    Console.WriteLine("Туз");
            }
            catch (Exception ошибка)
            {
                Console.WriteLine(ошибка.Message);
            }
            finally
            {
                Console.WriteLine("Задание 2 завершено.");
            }

            Console.WriteLine("Задание 3. Напитки");
            Console.WriteLine("Введите профессию или группу:");
            string слово = Console.ReadLine().ToLower();

            if (слово == "jabroni")
                Console.WriteLine("Patron Tequila");
            else if (слово == "school counselor")
                Console.WriteLine("Anything with Alcohol");
            else if (слово == "programmer")
                Console.WriteLine("Hipster Craft Beer");
            else if (слово == "bike gang member")
                Console.WriteLine("Moonshine");
            else if (слово == "politician")
                Console.WriteLine("Your tax dollars");
            else if (слово == "rapper")
                Console.WriteLine("Cristal");
            else
                Console.WriteLine("Beer");

            Console.WriteLine("Задание 4. День недели");
            Console.WriteLine("Введите число от 1 до 7:");
            int день = Convert.ToInt32(Console.ReadLine());

            if (день >= 1 && день <= 7)
                Console.WriteLine((ДеньНедели)день);
            else
                Console.WriteLine("Ошибка! Введите число от 1 до 7.");
            
            Console.WriteLine("Задание 5. Подсчёт игрушек");
            string[] игрушки =
            {
                "Hello Kitty",
                "Мишка",
                "Barbie doll",
                "Кукла",
                "Hello Kitty",
                "Barbie doll"
            };
            int количество = 0;
            foreach (string игрушка in игрушки)
            {
                if (игрушка == "Hello Kitty" ||
                    игрушка == "Barbie doll")
                {
                    количество++;
                }
            }
            Console.WriteLine("Количество игрушек: " + количество);
        }
    }
}
