using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime Published { get; set; }
        [DataType(DataType.Date)]
        public DateTime Updated { get; set; }
    }
}