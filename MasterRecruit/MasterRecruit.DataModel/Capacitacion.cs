using MasterRecruit.Common;
using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterRecruit.DataModel
{
    public class Capacitacion : IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public Nivel Nivel { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        [ForeignKey("Candidato")]
        public Guid CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }

        [ForeignKey("Institucion")]
        public Guid InstitucionId { get; set; }
        public virtual Institucion Institucion { get; set; }
    }
}
