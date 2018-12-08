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
    public class Staff
    {
        [DataMember]
        public int StaffId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String First_Name { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String Last_Name { get; set; }

        [DataMember]
        public string Picture { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Email { get; set; }

        [DataMember]
        public int Active { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(16)]
        public String Username { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public String Password { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }

        [DataMember]
        public ICollection<Rental> RentalId { get; set; }

        [DataMember]
        public ICollection<Store> StoreId { get; set; }

        [DataMember]
        public ICollection<Payement> PayementId { get; set; }
    }
}
