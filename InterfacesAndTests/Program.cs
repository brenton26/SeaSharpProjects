using System;

namespace InterfacesAndTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var OrderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            OrderProcessor.Process(order);
        }
    }
    // class OrderProcessor
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
    // interface IShippingCalculator
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    // class ShippingCalculator
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice >= 30f) { return 0; }
            return order.TotalPrice * 0.1f;
        }
    }
    // class Order
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }

    }// class Shipment
    public class Shipment
    {
        public float Cost;
        
    }
}
