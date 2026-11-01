
using System.ComponentModel.DataAnnotations;

namespace TechDesk.Models
{
    public class Device
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the device asset tag.")]
        [StringLength(10, ErrorMessage = "The asset tag cannot exceed 10 characters.")]
        [Display(Name = "Asset tag")]
        public string AssetTag { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the device name.")]
        [StringLength(50, ErrorMessage = "The device name cannot exceed 50 characters.")]
        [Display(Name = "Device name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the device category.")]
        [StringLength(20, ErrorMessage = "The category cannot exceed 20 characters.")]
        [Display(Name = "Category")]
        public string Category { get; set; } = string.Empty;

        [Range(2015, 2026,
            ErrorMessage = "The year bought must be from 2015 to 2026.")]
        [Display(Name = "Year bought")]
        public int PurchaseYear { get; set; }

        [Display(Name = "Currently on loan")]
        public bool IsOnLoan { get; set; }
    }
}
