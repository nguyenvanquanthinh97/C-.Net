using System;

namespace InterfaceTestability
{
    public class Order
    {
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlace { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }
}