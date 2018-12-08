using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Film_Actor
    {
        [DataMember]
        public int Film_ActorId { get; set; }

        [DataMember]
        public int ActorId { get; set; }

        public Actor Act { get; set; }

        [DataMember]
        public int FilmId { get; set; }

        public Film F { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }
    }
}
