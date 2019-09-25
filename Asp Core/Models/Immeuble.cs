using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestion_Location.Models
{
    public class Immeuble
    {
        [Key]
        [StringLength(10)]
        public string  idImmeuble { get; set; }
        public string libelle { get; set; }
        public string description { get; set; }
        
        [ForeignKey("idProprietaire")]
        public string idProprietaire { get; set; }
        
        
        public virtual Proprietaire Proprietaire { get; set; }

        public ICollection<Contrat> Contrats { get; set; }
        public ICollection<ContratLocation> ContratLocations { get; set; }
    }
}