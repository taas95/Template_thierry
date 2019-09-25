using System.Collections.Generic;
using Gestion_Location.Models;

namespace Gestion_Location.Entities
{
    public class PropriAll
    {
        public Proprietaire Apropri { get; set; }
        public IEnumerable<Proprietaire> ListPropri { get; set; }
    }
}