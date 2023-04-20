﻿using System.Globalization;

namespace ProposedExercise142.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        

        public virtual string PriceTag()
        {
            return  "Price" + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
