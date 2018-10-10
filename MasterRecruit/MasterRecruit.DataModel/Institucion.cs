using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Institucion
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Capacitacion> Capacitaciones { get; set; }

    }
}
