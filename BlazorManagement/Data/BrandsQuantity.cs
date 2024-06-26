using System.ComponentModel.DataAnnotations;

namespace BlazorManagement.Data
{
    public class BrandsQuantity
    {

        public string BrandName { get; set; }
        public int Quantity { get; set; }


        public BrandsQuantity()
        {

        }

        public BrandsQuantity(string BrandName, int Quantity)
        {
            this.BrandName = BrandName;
            this.Quantity = Quantity;
        }
    }
}