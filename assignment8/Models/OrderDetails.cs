using System.ComponentModel.DataAnnotations;

namespace assignment8.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Index { get; set; } = 0;
        public string ItemName { get; set; } = string.Empty;
        public int Number { get; set; } = 0;
        public int Amount { get; set; } = 0;
    }
}
