using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Abonents_List
    {
        //Инициализация списка, в котором будет храниться информация об абонентах
        private List<Abonent> _abonents { get; set; } = [];

        //Чтение из файла в список:
        public void ReadFromFile(string path)
        {
            string[] list = File.ReadAllLines(path);
            if (list.Length > 1)
            {
                for (int i = 0; i < list.Length; i = i + 2)
                {
                    Abonent abonent = new Abonent(list[i], list[i+1]);
                    _abonents.Add(abonent);
                }
            }
        }

        //Запись списка в файл:
        public bool WriteToFile(string path)
        {
            using StreamWriter sw = File.CreateText (path);
            foreach (var item in _abonents)
            {
                sw.WriteLine (item.Name);
                sw.WriteLine (item.Phone);
            }
            return true;
        }

        //Добавление абонента в список:
        public void WriteAbonentToPhonebook(Abonent abonent, string phone)
        {
            for (int i = 0; i < _abonents.Count; i++)
            {
                if (_abonents[i].Phone == phone)
                    throw new KeyNotFoundException("Абонент с таким номером телефона уже существует!");
            }

            _abonents.Add(abonent);
            Console.WriteLine($"Абонент успешно сохранен!");
        }
               
        //Вывод в консоль информации об абоненте:
        public static void PrintAbonentInfo(int id, Abonent abonent)
        {
            Console.WriteLine($"Ячейка №{id}:\n" +
                              $"имя: {abonent.Name} | тел.: {abonent.Phone}");
        }

        //Вывод в консоль информации об абоненте без ID:
        public static void PrintAbonentWOID(Abonent abonent)
        {
            Console.WriteLine($"имя: {abonent.Name} | тел.: {abonent.Phone}");
        }

        //Поиск абонента по имени
        public Abonent GetName(string name)
        {
            for (int i = 0; i < _abonents.Count; i++)
            {
                if (_abonents[i].Name == name)
                    return _abonents[i];
            }

            throw new KeyNotFoundException($"Абонент с именем {name} не найден!");
        }

        //Поиск абонента по номеру телефона
        public Abonent GetPhone(string phone) 
        {
            for (int i = 0; i < _abonents.Count; i++)
            {
                if (_abonents[i].Phone == phone)
                    return _abonents[i];
            }

            throw new KeyNotFoundException($"Абонент с номером телефона {phone} не найден!");
        }

        //Поиск абонента по ID
        public Abonent GetById(int id)
        {
            if (id < _abonents.Count)
                return _abonents[id];

            else
                throw new KeyNotFoundException($"Введите номер ячейки от 0 до {_abonents.Count}!");
            
        }

        //Удаление абонента
        public static void DeleteAbonent(int id, Abonent abonent)
        {
            abonent.Name = "пусто";
            abonent.Phone = "пусто";
        }

    }
        
}
