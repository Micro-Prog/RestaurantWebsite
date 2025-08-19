using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Shared.Dtos.User
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Label { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string? Apartment { get; set; }
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public bool IsDefault { get; set; }
        public string? DeliveryInstructions { get; set; }
    }

}
