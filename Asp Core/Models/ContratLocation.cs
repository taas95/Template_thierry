using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Location.Models
{
    public class ContratLocation
    {
        [Key]
        [StringLength(10)]
        public string idContratLocation { get; set; }
        public string libelle { get; set; }
        
        [ForeignKey("idAppartement")]
        public string idAppartement { get; set; }
        
        [ForeignKey("idLocataire")]
        public string idLocataire { get; set; }

//        [ForeignKey("idpayement")]
//        public string idpayement { get; set; }

        [ForeignKey("idImmeuble")] 
        public string idImmeuble { get; set; }

        public virtual Locataire Locataire { get; set; }
        public virtual Appartement Appartement { get; set; }
        public virtual Immeuble Immeuble { get; set; }
        
        
        
        public ICollection<Payement> Payements { get; set; }
    }
}