using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int InventoryId { get; set; }
        [DataMember]
        public int FilmId { get; set; }
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public DateTime Last_update { get; set; }

        [DataMember]
        public ICollection<Rental> RentalId { get; set; }

    }
}
