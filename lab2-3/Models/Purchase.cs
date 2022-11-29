namespace lab2_3.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
    }
}
