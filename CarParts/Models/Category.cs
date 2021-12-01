using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(29, MinimumLength = 1)]
        public string Title { get; set; }
        [StringLength(300, ErrorMessage = "The description is too long! Maximum of 300 symbols!")]
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Products> Articles { get; set; }
    }
}