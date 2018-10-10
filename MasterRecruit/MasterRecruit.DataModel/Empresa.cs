using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Empresa: IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Experiencia> Experiencias { get; set; }



    }
}
