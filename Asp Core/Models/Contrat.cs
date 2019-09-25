using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gestion_Location.Models
{
    public class Contrat
    {
        [Key]
        [StringLength(10)]
        public string  idContrat { get; set; }
        
        public string  libelleContrat { get; set; }
        public DateTime dateDeb { get; set; }
        public DateTime dateFin { get; set; }
        public int commission { get; set; }
        
        [ForeignKey("idImmeuble")]
        public int idImmeuble { get; set; }
        
        
        public virtual Immeuble Immeuble { get; set; }
        
        public ICollection<Retrait>Retraits { get; set; }
    }
}