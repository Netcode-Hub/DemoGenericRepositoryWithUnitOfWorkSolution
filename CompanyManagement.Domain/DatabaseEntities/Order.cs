
namespace CompanyManagement.Domain.DatabaseEntities
{
    public class Order
    {
        public int Id { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public int CustomerId { get; set; }
    }
}
