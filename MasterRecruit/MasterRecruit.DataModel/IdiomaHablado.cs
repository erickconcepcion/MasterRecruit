using MasterRecruit.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MasterRecruit.DataModel
{
    public class IdiomaHablado: IEntityBase
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Idioma")]
        public Guid IdiomaId { get; set; }
        public Idioma Idioma { get; set; }

        [ForeignKey("Candidato")]
        public Guid CandidatoId { get; set; }
        public Candidato Candidato { get; set; }

    }
}
