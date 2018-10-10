using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterRecruit.DataModel
{
    public class Candidato: IEntityBase
    {
        public Candidato()
        {
            Experiencias = new HashSet<Experiencia>();
            Capacitaciones= new HashSet<Capacitacion>();
            Competencias= new HashSet<Competencia>();
        }
        [Key]
        public Guid Id { get; set; }
        public decimal SalarioPropuesto { get; set; }
        public DateTime LastVisit { get; set; }

        [ForeignKey("Puesto")]
        public Guid PuestoId { get; set; }
        public virtual Puesto Puesto { get; set; }

        [ForeignKey("Persona")]
        public Guid PersonaId { get; set; }
        public virtual Persona Persona { get; set; }

        [ForeignKey("Oportunity")]
        public Guid OportunityId { get; set; }
        public virtual Oportunity Oportunity { get; set; }

        [ForeignKey("Empleado")]
        public Guid? EmpleadoId { get; set; }
        public virtual Empleado Empleado { get; set; }

        public virtual ICollection<Experiencia> Experiencias { get; set; }
        public virtual ICollection<Capacitacion> Capacitaciones { get; set; }
        public virtual ICollection<Competencia> Competencias { get; set; }
        public virtual ICollection<IdiomaHablado> IdiomaHablados { get; set; }


    }
}
