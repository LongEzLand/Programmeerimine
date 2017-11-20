using System;

namespace RestaurantReceipt
{
    public class Restaurant
    {
        private string name;
        private string address;

        public Restaurant(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Receipt GetReceipt(Tab tab)
        {
            var receipt = new Receipt(name, address, tab);
            
            

            return receipt;
        }
    }
}