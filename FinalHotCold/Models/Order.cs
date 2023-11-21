namespace FinalHotCold.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? NameCustomer { get; set; }
        public string? PhoneCustomer { get; set;}
        public string? AddressCustomer { get; set; }
        public string? NameProduct { get; set; }
        public int? PriceProduct { get; set;}

    }
}
