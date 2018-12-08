using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serveur_Cinema.Model
{
    [DataContract]
    public class Film_Category
    {
        [DataMember]
        public int Film_CategoryId { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        public Category Cat { get; set; }

        [DataMember]
        public int FilmId { get; set; }

        public Film F { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }
    }
}
