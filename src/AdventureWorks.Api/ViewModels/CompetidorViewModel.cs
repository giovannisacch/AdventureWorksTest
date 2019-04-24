using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Api.ViewModels
{
    public class CompetidorViewModel
    {
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public decimal TemperaturaMediaCorpo { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
    }
}
