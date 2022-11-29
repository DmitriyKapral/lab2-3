using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab2_3.Models
{
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
    }
}
