using System;
using System.Collections.Generic;

namespace RestaurantReceipt
{
    public class Tab
    {
        public Tab()
        {
        }

        public List<double> Items = new List<double>();

        public void Add(double v)
        {
            Items.Add(v);

        }
    }
}