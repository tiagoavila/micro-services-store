using System;

namespace Catalog.Domain
{
    public class Product
    {
        public Product(
            Guid id,
            string title,
            string description,
            string image,
            decimal price,
            int quantity)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = image;
            Price = price;
            AvailableStock = quantity;
        }

        public Product()
        {

        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AvailableStock { get; set; }
        public string ImageUrl { get; set; }

        public void RemoveStock(int quantityDesired)
        {
            if (AvailableStock == 0)
            {
                throw new ArgumentException($"Empty stock, product item {Title} is sold out");
            }

            if (quantityDesired <= 0)
            {
                throw new ArgumentException($"Item units desired should be greater than cero");
            }

            this.AvailableStock -= quantityDesired;
        }
    }
}
