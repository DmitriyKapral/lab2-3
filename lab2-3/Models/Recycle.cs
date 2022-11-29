using System.ComponentModel.DataAnnotations.Schema;

namespace lab2_3.Models
{
    public class Recycle
    {
        public int ID { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Products { get; set; }
    }
}
