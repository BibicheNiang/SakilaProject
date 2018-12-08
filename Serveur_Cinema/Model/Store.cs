using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public DateTime Last_update { get; set; }

        [DataMember]
        public ICollection<Inventory> InventoryId { get; set; }

        [DataMember]
        public ICollection<Staff> StaffId { get; set; }

        [DataMember]
        public ICollection<Customer> CustomerId { get; set; }
    }
}
