using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churrasco.Models
{
    public class RelatorioEvento
    {
        public int  TotalArrecadado { get; set; }

        public double TotalGasto { get; set; }

        public double TotalGastoComida { get; set; }

        public double TotalGastoBebida { get; set; }

        public List<string> NomeFuncionarios { get; set; }
    }
}


