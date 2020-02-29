using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCeTicaret.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [Required,MaxLength(50)]
        public string CompanyName { get; set; }

        [MaxLength(50)]
        public string ContactName { get; set; }

        [MaxLength(50)]
        public string ContactTitle { get; set; }

        [MaxLength(150)]
        public string Adress { get; set; }

        [MaxLength(20)]
        public string Mobile { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(20)]
        public string Fax { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Country { get; set; }


        public virtual ICollection<Product> Products { get; set; }


    }
}