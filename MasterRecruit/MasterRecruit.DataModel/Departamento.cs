using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Departamento: IEntityBase
    {
        public Departamento()
        {
            Puestos = new HashSet<Puesto>();
        }
        [Key]
        public Guid Id { get; set; }
        public int Nombre { get; set; }
        public virtual ICollection<Puesto> Puestos { get; set; }
    }
}
