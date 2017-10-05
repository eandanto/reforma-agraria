using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace reforma_agraria.Models
{
    public class Region
    {
        public Region()
        {

        }
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public RegionType Type { get; set; }

        [ForeignKey("Parent")]
        public string fkParentId { get; set; }
        public virtual Region Parent { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
