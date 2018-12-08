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
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String First_Name { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String Last_Name { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Email { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(1)]
        public String Active { get; set; }

        [DataMember]
        public DateTime Create_Date { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }

        [DataMember]
        public ICollection<Rental> RentalId { get; set; }

        [DataMember]
        public ICollection<Payement> PayementId { get; set; }


    }
}
