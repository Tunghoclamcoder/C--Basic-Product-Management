using System.ComponentModel.DataAnnotations;

namespace BlazorManagement.Data
{
    public class Products
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The min price is 1!")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Brand is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a brand!")]
        public int BrandId { get; set; }

      
        public string Image { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The min quantity is 0!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [Range(0, 1, ErrorMessage = "Status must be either 0 or 1")]
        public int Status { get; set; }

        public Products()
        {
        }

        public Products(int ProductId, string ProductName, float Price, int BrandId, string Image, int Quantity, int Status, string Description)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
            this.BrandId = BrandId;
            this.Image = Image;
            this.Quantity = Quantity;
            this.Status = Status;
            this.Description = Description;
        }
    }
}
