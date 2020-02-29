using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required, ForeignKey("Product")]
        public int ProductID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [Required,MaxLength(500)]
        public string Comment { get; set; }

        public int Rate { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime DateTime { get; set; }

        public bool IsDeleted { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}