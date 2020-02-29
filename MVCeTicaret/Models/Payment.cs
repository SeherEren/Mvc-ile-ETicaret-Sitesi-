using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Payment
    {
        [Key]
        public int  PaymentID { get; set; }

        [Required,ForeignKey("PaymentType")]
        public int Type { get; set; }

        [Column(TypeName ="money")]
        public decimal CreaidtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal DebidtAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime PaymentDateTime {get; set; }



        public virtual ICollection<Order> Orders { get; set; }

        public virtual PaymentType PaymentType { get; set; }

    }
}