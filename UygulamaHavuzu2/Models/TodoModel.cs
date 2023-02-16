using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzu2.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(1000)]
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}
