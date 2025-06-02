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
            //Создал массив Abonents класса Abonent на 100 ячеек
            Abonent[] Abonents = new Abonent[100];
            for (int i = 0; i < Abonents.Length; i++)
            {
                Abonents[i] = new Abonent();
            }

            //Создал массив Phonebook на те же 100 ячеек для записи туда строк со значениями в "человеческом виде"
            string[] Phonebook = new string[100];
            
            for (int  j = 0; j < Phonebook.Length; j++)
            {
                int id = 0 + j;
                var ab = Abonents[j];
                Phonebook[j] = ($"Ячейка под номером {id}\n" +
                              $"имя: {ab.Name} | тел.: {ab.Phone}");
            }

            ///for (int j = 0; j < Phonebook.Length; j++)
            ///{
                ///Console.WriteLine(Phonebook[j]);
            ///}

            while (true)
            {
                Console.WriteLine("Меню:\n" +
                    "1. Создать абонента.\n" +
                    "2. Удалить абонента.\n" +
                    "3. Вывести информацию об абоненте");

                var userImput = Console.ReadLine();
                if (userImput == "1")
                {
                    Console.Write("Введите номер ячейки для абонента (от 0 до 99): ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var ab = Abonents[id];
                    
                    if (ab.Name != "<пусто>")
                    {
                        Console.WriteLine($"Ячейка с номером {id} уже занята!");
                            
                    }
                    else
                    {
                        Console.Write("Введите имя: ");
                        string abonentName = Console.ReadLine();
                        Console.WriteLine();

                        Console.Write("Введите номер телефона: ");
                        string abonentPhone = Console.ReadLine();

                                                
                        for (int j = 0; j < Phonebook.Length; j++)
                        {
                                                        
                            if (Phonebook[j].Contains(abonentPhone))
                            {
                                Console.WriteLine($"Абонент c таким номером телефона уже существует!");
                                
                            }
                            else
                            {
                                Console.WriteLine();
                                Abonents[id] = new Abonent(abonentName, abonentPhone) { };

                                Console.WriteLine($"Абонент в ячейку под номером {id} успешно сохранен!");
                                break;
                            }
                            
                        }

                            
                        
                               
                            
                        
                                                    
                    }
                                                    
                    
                    
                }
                if (userImput == "2")
                {
                    Console.Write("Введите номер ячейки абонента (от 0 до 100): ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Abonents[id] = new Abonent();

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

                for (int j = 0; j < Phonebook.Length; j++)
                {
                Console.WriteLine(Phonebook[j]);
                }

                Console.ReadKey(); Console.Clear();


            }
            
        }
    }
}
