using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churrasco.Models
{
    public class Evento
    {

        public int Id { get; set; }
        public  string Nome { get; set; }

        public bool Bebida { get; set; }

        public bool ConfirmaConvidado { get; set; }

        public bool BebidaConvidado { get; set; }

    }
}
