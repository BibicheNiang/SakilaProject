using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Rental
    {
        [DataMember]
        public int RentalId { get; set; }

        [DataMember]
        public DateTime Rental_Date { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }

        [DataMember]
        public DateTime Return_Date { get; set; }

        [DataMember]
        public ICollection<Payement> PayementId { get; set; }


    }
}
