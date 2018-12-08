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
    public class Film
    {
        [DataMember]
        public int FilmId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Title { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Description { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(4)]
        public string Release_Year { get; set; }

    
        [DataMember]
        public int Rental_Duration { get; set; }

        [DataMember]
        public int Rental_Rate { get; set; }


        [DataMember]
        public int Length { get; set; }

        [DataMember]
        public int Replacement_Cost { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string Rating { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Special_Features { get; set; }

        [DataMember]
        public DateTime Last_Update { get; set; }

        [DataMember]
        public ICollection<Inventory> InventoryId { get; set; }

        [DataMember]
        public ICollection<Film_Actor> Film_ActorId { get; set; }

        [DataMember]
        public ICollection<Film_Category> Film_CategoryId { get; set; }


    }
}
