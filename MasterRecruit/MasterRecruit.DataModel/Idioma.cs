using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MasterRecruit.DataModel
{
    public class Idioma: IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<IdiomaHablado> IdiomaHablados { get; set; }


    }
}
