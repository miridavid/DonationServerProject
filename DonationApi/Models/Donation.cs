using System.ComponentModel.DataAnnotations;

namespace DonationApi.Models
{
    public class Donation
    {
        [Required(ErrorMessage = "An Album Title is required")]
        [RegularExpression(@"^[a-zA-Z\u0590-\u05FF\u200f\u200e ]+$")]
        public virtual string ForeignPoliticalEntityName { get; set; }
       
        [Required(ErrorMessage = "An Album Title is required")]
        public virtual string DonationAmount { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        public virtual string[] ForeignPoliticalEntityType { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        public virtual string DonationDesignation { get; set; }
        public virtual string DonationConditions { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        public virtual string[] CurrencyType { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        public virtual string ConversionRate { get; set; }

    }
}
