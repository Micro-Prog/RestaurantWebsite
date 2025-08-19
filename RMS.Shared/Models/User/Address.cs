using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Shared.Models.User
{
    class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Label { get; set; } = string.Empty;

        [Required]
        [StringLength(200)]
        public string Street { get; set; } = string.Empty;


        [StringLength(100)]
        public string? Apartment { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string State { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        // Coordinates for delivery optimization
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public bool IsDefault { get; set; } = false;

        [StringLength(500)]
        public string? DeliveryInstructions { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; } = null!;

        [NotMapped]
        public string FullAddress => $"{Street}, {(!string.IsNullOrEmpty(Apartment) ? Apartment + ", " : "")}{City}, {State} {PostalCode}";


    }
}
