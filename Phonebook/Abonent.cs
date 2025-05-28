using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Abonent
    {
        public string Name { get; private set; }
        
        private string _phone;
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Абонент с таким номером телефона уже есть!");

                _phone = value;
            }
        }
        public Abonent(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        

    }
}
