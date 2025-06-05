using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Abonents_List
    {
        private List<Abonent> _abonents { get; set; } = [];

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
               

        public static void PrintAbonentInfo(int id, Abonent abonent)
        {
            Console.WriteLine($"Ячейка №{id}:\n" +
                              $"имя: {abonent.Name} | тел.: {abonent.Phone}");
        }

        public static void PrintAbonentWOID(Abonent abonent)
        {
            Console.WriteLine($"имя: {abonent.Name} | тел.: {abonent.Phone}");
        }
        public Abonent GetName(string name)
        {
            for (int i = 0; i < _abonents.Count; i++)
            {
                if (_abonents[i].Name == name)
                    return _abonents[i];
            }

            throw new KeyNotFoundException($"Абонент с именем {name} не найден!");
        }

        public Abonent GetPhone(string phone) 
        {
            for (int i = 0; i < _abonents.Count; i++)
            {
                if (_abonents[i].Phone == phone)
                    return _abonents[i];
            }

            throw new KeyNotFoundException($"Абонент с номером телефона {phone} не найден!");
        }
                
        public Abonent GetById(int id)
        {
            if (id < _abonents.Count)
                return _abonents[id];

            else
                throw new KeyNotFoundException($"Введите номер ячейки от 0 до {_abonents.Count}!");
            
        }

        public static void DeleteAbonent(int id, Abonent abonent)
        {
            abonent.Name = "пусто";
            abonent.Phone = "пусто";
        }


    }
        
}
