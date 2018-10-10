using MasterRecruit.Common;
using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Puesto:IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public Riezgo Riezgo { get; set; }
        public decimal SueldoMinimo { get; set; }
        public decimal SueldoMaximo { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("Departamento")]
        public Guid DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }


        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<Candidato> Candidatos { get; set; }


    }
}
