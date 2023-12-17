namespace Testability
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        //public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }   

        public bool IsShipped
        {
            get { return Shipment != null; }
        }

    class Program
    {
        static void Main(string[] args)
        {
            var orderProccessor = new OrderProcessor(new ShippingCalculator);
            var order = new Order {DatePlaced = DateTime.Now, TotalPrice = 100f};
            orderProccessor.Process(order); 
        }
    }

}
