using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Abonent
    {
        public string Name { get; set; }

        private string phone;
        public string Phone 
        {
            get 
            {  
                return phone;
            }
            set
            {
                if (string.IsNullOrEmpty(phone))
                    throw new ArgumentNullException("Абонент с таким нормером уже существует!");

                phone = value;
            }
        }
        public Abonent(string name, string phone) 
        {
            this.Phone = phone;
            this.Name = name;
        }
    }
}
