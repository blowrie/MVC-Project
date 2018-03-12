using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CerealReview.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        //Navigation Property
        public virtual ICollection<Brand> Brands { get; set; }
    }
}