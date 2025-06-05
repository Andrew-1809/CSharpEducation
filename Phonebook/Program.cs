using ClassLibrary;
using System;
using System.Numerics;
using System.Xml.Linq;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Abonents_List();

                                   
            while (true)
            {
                Console.WriteLine("Меню:\n" +
                    "1. Создать абонента.\n" +
                    "2. Удалить абонента.\n" +
                    "3. Вывести информацию об абоненте.\n" +
                    "4. Поиск абонента по телефону.\n" +
                    "5. Поиск абонент по имени.");
                Console.WriteLine();

                var userImput = Console.ReadLine();
                if (userImput == "1")
                {
                    
                    Console.Write("Введите имя: ");
                    string abonentName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Введите номер телефона: ");
                    string abonentPhone = Console.ReadLine();
                    Console.WriteLine();

                    book.WriteAbonentToPhonebook(new Abonent(abonentName, abonentPhone));

                    Console.WriteLine($"Абонент успешно сохранен!");
                                                            
                }
                if (userImput == "2")
                {
                    Console.Write("Введите номер ячейки абонента: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Abonent ab = book.GetById(id);
                    Abonents_List.DeleteAbonent(id, ab);

                    Console.WriteLine($"Абонент из ячейки под номером {id} удален.");
                    Console.WriteLine();
                }
                if (userImput == "3")
                {
                    Console.Write("Введите номер ячейки абонента: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Abonent ab = book.GetById(id);

                    Abonents_List.PrintAbonentInfo(id, ab);
                }
                if (userImput == "4")
                {
                    Console.Write("Введите номер телефона абонента: ");
                    string abonentPhone = Console.ReadLine();
                    Console.WriteLine();

                    Abonent ab = book.GetPhone(abonentPhone);
                    Abonents_List.PrintAbonentWOID(ab);

                }
                if (userImput == "5")
                {
                    Console.Write("Введите имя абонента: ");
                    string abonentName = Console.ReadLine();
                    Console.WriteLine();

                    Abonent ab = book.GetName(abonentName);
                    Abonents_List.PrintAbonentWOID(ab);

                }

                Console.ReadKey(); Console.Clear();


            }
            
        }
    }
}
