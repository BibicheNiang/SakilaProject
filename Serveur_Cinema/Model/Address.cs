using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Adresse_Name1 { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Adresse_Name2 { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public String District { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public String Postal_Code { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public String Phone { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }

        [DataMember]
        public ICollection<Staff> StaffId { get; set; }

        [DataMember]
        public ICollection<Store> StoreId { get; set; }

        [DataMember]
        public ICollection<Customer> CustomerId { get; set; }

    }
}
