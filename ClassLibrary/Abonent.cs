using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Abonent
    {
        private string _name = "<пусто>";
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        
        private string _phone = "<пусто>";
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public Abonent() { }
        public Abonent(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        
    }
}
