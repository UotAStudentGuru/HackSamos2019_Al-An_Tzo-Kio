using System;
using System.Collections.Generic;
using System.Text;

namespace MagicBus.Common.Models
{
    public class User : BaseModel
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Name
        {
            get => _name;
            set
            {
                _name = value; 

            }
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

       
    }
}
