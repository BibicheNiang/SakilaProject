using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Payement
    {
        [DataMember]
        public int PayementId { get; set; }

        [DataMember]
        public int Amount { get; set; }

        [DataMember]
        public DateTime Payement_Date { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }
    }
}
