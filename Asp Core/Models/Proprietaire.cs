using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gestion_Location.Models
{
    public class Proprietaire
    {
        [Key] [StringLength(10)] public string id { get; set; }
        [Display(Name = "Nom")] [Required] public string nom { get; set; }


        [Display(Name = "Prénom")] [Required] public string prenom { get; set; }

        [Display(Name = "Téléphone")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public int telephone { get; set; }

        [Display(Name = "Adresse")] public string adresse { get; set; }


        public ICollection<Immeuble> Immeubles { get; set; }
    }
}