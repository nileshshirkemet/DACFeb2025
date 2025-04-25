using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Shopping.Data;

[Table("CustomerInfo")]
public class Customer
{
    [Column("UserName")]
    public string Id { get; set; }

    public decimal Credit { get; set; }

    public ICollection<Order> Orders { get; set; } = [];
}
