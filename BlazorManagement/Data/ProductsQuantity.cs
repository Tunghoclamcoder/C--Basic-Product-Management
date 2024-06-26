using System.ComponentModel.DataAnnotations;

namespace BlazorManagement.Data
{
    public class ProductsQuantity
    {

        public string ProductName { get; set; }
        public int Quantity { get; set; }


        public ProductsQuantity()
        {

        }

        public ProductsQuantity(string ProductName, int Quantity)
        {
            this.ProductName = ProductName;
            this.Quantity = Quantity;
        }
    }
}