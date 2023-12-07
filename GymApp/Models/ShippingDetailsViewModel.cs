using EntityLayer.Concrete;

namespace GymApp.Models
{
    public class ShippingDetailsViewModel
    {
        public string? FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public List<CartItem>? CartItems { get; set; }
    }
}
