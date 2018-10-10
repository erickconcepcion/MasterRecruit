using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MasterRecruit.DataModel
{
    public class Competencia : IEntityBase
    {

        [Key]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        [ForeignKey("Candidato")]
        public Guid CandidatoId { get; set; }
        public virtual Candidato Candidato { get; set; }

    }
}
