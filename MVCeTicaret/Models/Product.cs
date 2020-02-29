using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required,MaxLength(200)]
        public string Name { get; set; }

        [Required,ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        [Required,ForeignKey("SubCategory")]
        public int SubCategoryID { get; set; }

        [Required,MaxLength(20)]
        public string QuantityPerUnit { get; set; } //Birimi

        [Required,Column(TypeName ="money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName ="money")]
        public decimal? OldPrice { get; set; } // ? zorunsuz hale dönüştürür

        [MaxLength(20)]
        public string UnitWeight { get; set; }

        [MaxLength(20)]
        public string Size { get; set; }

        public decimal Discount { get; set; }

        public int UnitInStock { get; set; }

        public int? UnitOnOrder { get; set; }

        public bool? ProductAvailable { get; set; }

        [Required,MaxLength(500)]
        public string ImageUrl { get; set; }

        [Required,MaxLength(200)]
        public string AltText { get; set; }

        [Required,MaxLength(300)]
        public string ShortDescription { get; set; }

        [Required,MaxLength(2000)]
        public string LongDescription { get; set; }
        
        [MaxLength(500)]
        public string Picture1{ get; set; }

        [MaxLength(500)]
        public string Picture2 { get; set; }

        [MaxLength(500)]
        public string Picture3 { get; set; }

        [MaxLength(500)]
        public string Picture4 { get; set; }

        [MaxLength(250)]
        public string Notes { get; set; }

        //not : foreignkey yapılan tekildir bağlantıda


        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        public int UnitsInStock { get; internal set; }
    }
}