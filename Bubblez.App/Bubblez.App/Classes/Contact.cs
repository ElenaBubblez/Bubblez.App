using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Bubblez.App.Classes
{
    class Contact
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        [MaxLength(11)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

    }
}
