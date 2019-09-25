using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

namespace Gestion_Location.Models
{
    public class Retrait
    {
        [Key]
        [StringLength(10)]
        public string idRetrait { get; set; }
        
        public int montant { get; set; }
        public DateTime dateRetrait { get; set; }
        public string commentaires { get; set; }
        [ForeignKey("idContrat")]
        public string idContrat { get; set; }
        
        public virtual Contrat Contrat { get; set; }
    }
}