namespace WebApplication1.Models
{
    public class PurchaseRequest_Items
    {
        public int id { get; set; }
        public int PurchaseRequest_id { get; set; }
        public string Category_id { get; set; }
        public string Item_id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Contact { get; set; }
        public Nullable<double> Quantity { get; set; }
        public string Unit_id { get; set; }
        public Nullable<double> UnitPrice { get; set; }
    }
}
