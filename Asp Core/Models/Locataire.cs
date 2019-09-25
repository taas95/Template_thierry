using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Location.Models
{
    public class Locataire
    {
        [Key]
        [StringLength(10)]
        public string idLocataire { get; set; }
        
        [StringLength(30)]
        public string nom { get; set; } 
        [StringLength(30)]
        public string prenom { get; set; }
        
        public int tel { get; set; }
        
        public ICollection<ContratLocation> ContratLocations { get; set; }
    }
}