using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RMS.Shared.Enums;

namespace RMS.Shared.Models.User
{
    class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;


        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender gender { get; set; }

        public bool IsActive { get; set;  } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLoginAt { get; set; }

        [StringLength(500)]
        public string? ProfileImageUrl { get; set; }

        public bool EmailNotifications { get; set; } = false;

        public bool SMSNotifications { get; set; } = false;

        public bool PushNotifications { get; set; } = false;


        // customer preferences 
        public CustomerPreferences? CustomerPreferences { get; set; }

        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();


        //public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        //public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
        //public virtual ICollection<FavoriteItem> FavoriteItems { get; set; } = new List<FavoriteItem>();
        //public virtual ShoppingCart? ShoppingCart { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [NotMapped]
        public Address? DefaultAddress => Addresses.FirstOrDefault(a => a.IsDefault);










    }
}
