using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CerealReview.Models
{
    public class Review
    {
        [Key]
        public int CerealID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date Reviewed")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateReviewed { get; set; }
        public int Score { get; set; }
        [Display(Name = "Eat Again? ")]
        public bool Again { get; set; }
        public string Description { get; set; }

        [ForeignKey("Brand"), Display(Name = "Brand")]
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}