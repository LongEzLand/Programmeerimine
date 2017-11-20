using System;
using System.Text;

namespace RestaurantReceipt
{
    public class Receipt
    {
        private string name;
        private string address;
        private Tab tab;

        public Receipt(string name, string address, Tab tab)
        {
            this.name = name;
            this.address = address;
            this.tab = tab;            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            double subtotal = 0;
            sb.AppendLine(name);
            sb.AppendLine(address);
            sb.AppendLine("----------------------------------------");
            foreach (var item in tab.Items)
            {
                sb.AppendLine($"Price of food item: {item}");
                subtotal += item;
            }
            sb.AppendLine("----------------------------------------");
            sb.AppendLine($"Subtotal: €{subtotal}");
            sb.AppendLine($"15,00% Gratuity: €{subtotal * 0.15:F2}");
            sb.AppendLine($"Total: €{subtotal - (subtotal * 0.15):F2}");


            return sb.ToString();
        }
    }
}