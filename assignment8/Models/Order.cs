using System.ComponentModel.DataAnnotations;
namespace assignment8.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; } = string.Empty;
        public string OrderCustomer { get; set; } = string.Empty;
        public int OrderAmount { get; set; }
        public List<OrderDetail> OrderDetailList { get; set; } = new List<OrderDetail>();
    }
}
