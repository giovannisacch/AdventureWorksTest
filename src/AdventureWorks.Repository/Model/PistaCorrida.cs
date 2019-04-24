using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Repository.Model
{
    public class PistaCorrida
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual List<HistoricoCorrida> Corridas { get; set; }
    }
}
