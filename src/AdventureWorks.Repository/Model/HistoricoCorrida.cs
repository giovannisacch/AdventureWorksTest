using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdventureWorks.Repository.Model
{
    public class HistoricoCorrida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CompetidorId { get; set; }
        public int PistaCorridaId { get; set; }
        public DateTime DataCorrida { get; set; }
        public decimal TempoGasto { get; set; }

        public virtual Competidor Competidor { get; set; }
        public virtual PistaCorrida PistaCorrida { get; set; }

    }
}
