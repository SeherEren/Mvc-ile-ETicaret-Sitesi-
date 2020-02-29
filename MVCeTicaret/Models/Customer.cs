using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required,MaxLength(50)]
        public string FirstName { get; set; }

        [Required,MaxLength(50)]
        public string LastName { get; set; }
        
        [Required,MaxLength(50)]
        public string UserName { get; set; }

        [Required,MaxLength(50)]
        public string Password { get; set; }

        public bool Gender { get; set; }

        [Column(TypeName="date")]
        public DateTime BirthDate { get; set; }

        [MaxLength(50)]
        public string Organization { get; set; }
        
        [MaxLength(20)]
        public string Country { get; set; }

        [MaxLength(20)]
        public string State { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string PostalCode { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string AltEmail { get; set; }

        [MaxLength(20)]
        public string Phone1 { get; set; }

        [MaxLength(20)]
        public string Phone2 { get; set; }

        [MaxLength(20)]
        public string Mobile1 { get; set; }

        [MaxLength(20)]
        public string Mobile2 { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        [MaxLength(500)]
        public string Picture { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } //durum, online-offline

        [Column(TypeName ="datetime2")]
        public DateTime LastLogin { get; set; }

        [Column(TypeName ="date")]
        public DateTime CreateDate { get; set; }

        [MaxLength(250)]
        public string Notes { get; set; }



        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }

    }
}