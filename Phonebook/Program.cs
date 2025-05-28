using System;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abonent[] Abonents = new Abonent[100];
            for (int i = 0; i < Abonents.Length; i++)
            {
                Abonents[i] = new Abonent("<пусто>", "<пусто>");
            }

            while (true)
            {
                Console.WriteLine("Меню:\n" +
                    "1. Создать абонента.\n" +
                    "2. Удалить абонента.\n" +
                    "3. Вывести информацию об абоненте");

                var userImput = Console.ReadLine();
                if (userImput == "1")
                {
                    Console.Write("Введите номер ячейки для абонента (от 0 до 100): ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Write("Введите имя: ");
                    string abonentName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Введите номер телефона: ");
                    string abonentPhone = Console.ReadLine();
                    Console.WriteLine();

                    Abonents[id] = new Abonent(abonentName, abonentPhone) { };

                    Console.WriteLine($"Абонент в ячейку под номером {id} успешно сохранен!");
                    Console.WriteLine();
                }
                if (userImput == "2")
                {
                    Console.Write("Введите номер ячейки абонента (от 0 до 100): ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Abonents[id] = new Abonent("<пусто>", "<пусто>");

                    Console.WriteLine($"Абонент из ячейки под номером {id} удален.");
                    Console.WriteLine();
                }
                if (userImput == "3")
                {
                    Console.Write("Введите номер ячейки абонента (от 0 до 100): ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    var ab = Abonents[id];

                    Console.WriteLine($"Ячейка под номером {id}\n" +
                                      $"имя: {ab.Name} | тел.: {ab.Phone}");
                    Console.WriteLine();
                }
            }

        }
    }
}
