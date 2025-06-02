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

        public void WriteAbonentToPhonebook(Abonent abonent)
        {
            _abonents.Add(abonent);
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
                if (_abonents[i].Name == phone)
                    return _abonents[i];
            }

            throw new KeyNotFoundException($"Абонент с номером телефона {phone} не найден!");
        }
    }
        
}
