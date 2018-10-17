using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Experiencia: IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal Salario { get; set; }
        public string PuestoUsado { get; set; }
        

        [ForeignKey("Candidato")]
        public Guid CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }

        [ForeignKey("Empresa")]
        public Guid EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
