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
    public class Language
    {
        [DataMember]
        public int LanguageId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string Name { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }


        [DataMember]
        public ICollection<Film> Language_Id { get; set; }

        [DataMember]
        public ICollection<Film> Original_Language_Id { get; set; }



    }
}
