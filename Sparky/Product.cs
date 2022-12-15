﻿namespace Sparky
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public double GetPrice(Customer customer)
        {
            if (customer.IsPlatinum)
            {
                return Price * 0.8;
            }
            return Price;
        }
    }
}
