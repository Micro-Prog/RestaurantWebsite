using RMS.Shared.Enums;
using RMS.Shared.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Shared.Models.User
{
    class CustomerPreferences
    {
    }
}


//public class CustomerPreferences
//{
//    [Key]
//    public int Id { get; set; }

//    [Required]
//    public string UserId { get; set; } = string.Empty;

//    // Dietary preferences
//    public bool IsVegetarian { get; set; } = false;
//    public bool IsVegan { get; set; } = false;
//    public bool IsGlutenFree { get; set; } = false;
//    public bool IsHalal { get; set; } = false;
//    public bool IsKosher { get; set; } = false;

//    // Spice level preference (1-5 scale)
//    public int SpiceLevel { get; set; } = 2;

//    // Allergies (comma-separated)
//    [StringLength(500)]
//    public string? Allergies { get; set; }

//    // Favorite cuisine types (comma-separated)
//    [StringLength(200)]
//    public string? FavoriteCuisines { get; set; }

//    // Default order preferences
//    public OrderType PreferredOrderType { get; set; } = OrderType.Delivery;

//    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
//    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

//    // Navigation property
//    [ForeignKey("UserId")]
//    public virtual ApplicationUser User { get; set; } = null!;
//}
