namespace FinalHotCold.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDes { get; set; }
        public int? ProductPrice { get; set; } 
        public string? ProductImg { get; set; }
        public int CategoryId { get; set; }
    }
}
