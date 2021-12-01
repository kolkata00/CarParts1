using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarParts.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}