using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Gestion_Location.Models
{
    public class Payement
    {
        [Key]
        [StringLength(10)]
        public string idProprietaire { get; set; }
        public int montant { get; set; }
        public DateTime datePayement { get; set; }
        public string commentaire { get; set; }
        
        [ForeignKey("idContratLocation")]
        public string idContratLocation { get; set; }
        
        public virtual ContratLocation ContratLocation { get; set; }
        
    }
}