using System;

namespace AggregationOOP
{
    public class Address
    {
        public Address()
        {

        }
        public String Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        
        public void GetAddress()
        {
            Console.WriteLine($"Street={this.Street} \n City={this.City} \n State={this.State} \n PinCode={this.Pincode}");
        }
    }
}