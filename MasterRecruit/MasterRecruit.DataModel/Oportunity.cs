using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterRecruit.DataModel
{
    public class Oportunity: IEntityBase
    {
        public Oportunity()
        {
            Candidato = new Candidato();
        }
        [Key]
        public Guid Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Candidato Candidato { get; set; }
    }
}
