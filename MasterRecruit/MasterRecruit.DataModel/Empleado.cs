using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Empleado: IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("Puesto")]
        public Guid PuestoId { get; set; }
        public virtual Puesto Puesto { get; set; }

        [ForeignKey("Persona")]
        public Guid PersonaId { get; set; }
        public virtual Persona Persona { get; set; }


        public virtual ICollection<Candidato> Candidatos { get; set; }

    }
}
