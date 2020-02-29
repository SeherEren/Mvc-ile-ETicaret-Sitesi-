using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class RecentlyView   //en son görüntülenenler
    {
        [Key]
        public int RViewID { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required, ForeignKey("Product")]
        public int ProductID { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime ViewDate { get; set; }

        [MaxLength(150)]
        public string Notes { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}