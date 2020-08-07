using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyRooms
{
    class Hotel
    {
      
        public int Quarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Hotel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

    }
}
