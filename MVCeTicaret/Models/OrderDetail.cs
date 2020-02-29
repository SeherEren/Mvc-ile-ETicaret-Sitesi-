using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        [Required,ForeignKey("Product")]
        public int ProductID { get; set; }

        [Required, ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public bool  IsCompleted { get; set; }

        [Column(TypeName ="money")]
        public decimal  UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime OrderDate { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }


        //public class OrderDetail : Base
        //{
        //    [Required, ForeignKey("Product")]
        //    public int ProductID { get; set; }

        //    [Required, ForeignKey("Customer")]
        //    public int CustomerID { get; set; }

        //    public bool IsCompleted { get; set; } //onaylandı mı

        //    [Column(TypeName = "money")]
        //    public decimal UnitPrice { get; set; }  //birim fiyatı

        //    public int Quantity { get; set; }  //miktar

        //    public decimal Discount { get; set; }  //indirim

        //    [Column(TypeName = "money")]
        //    public decimal TotalAmount { get; set; }  //toplam fiyat

        //    [Column(TypeName = "datetime2")]
        //    public DateTime OrderDate { get; set; }  //sipariş tarihi


        //    public virtual ICollection<Order> Orders { get; set; }
        //    public virtual Product Product { get; set; }
        //    public virtual Customer Customer { get; set; }
        //}

    }
}