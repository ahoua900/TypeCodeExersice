using System;
using System.Collections.Generic;
using TypeUser.Models;
using System.Text;

namespace TypeUser.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Adress Adress { get; set; }
    }
}
