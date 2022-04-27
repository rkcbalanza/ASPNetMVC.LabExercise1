namespace ASPNetMVC.LabExercise1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        private decimal _totalAmount = 0;
        public decimal TotalAmount
        {
            get => Quantity * Price;
            set => _totalAmount = value;
        }
    }
}
