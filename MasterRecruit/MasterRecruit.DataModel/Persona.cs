using MasterRecruit.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Persona : IEntityBase
    {
        public Persona()
        {
            Empleado = new Empleado();
            Candidato = new Candidato();
        }
        [Key]
        public Guid Id { get ; set ; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Candidato Candidato { get; set; }

    }
}
