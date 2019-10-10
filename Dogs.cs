using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Data
{
    public class Dogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DID { get; set; }
        public string DogName { get; set; }
        public string Breed { get; set; }

        [ForeignKey("SID")]
        public int StoreID { get; set; }

    }
}
