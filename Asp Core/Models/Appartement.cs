using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Location.Models
{
    public class Appartement
    {
        [Key]
        [StringLength(10)]
        public string idAppartement { get; set; }
        public string libelleAppartement { get; set; }
        public string description { get; set; }
        public int caution { get; set; }
        public int loyer { get; set; }
        
        
        public ICollection<ContratLocation> ContratLocations { get; set; }
    }
}