
namespace CompanyManagement.Domain.DatabaseEntities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

