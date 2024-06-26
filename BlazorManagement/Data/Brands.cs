using System.ComponentModel.DataAnnotations;

namespace BlazorManagement.Data
{
    public class Brands
    {
        public int BrandId { get; set; }
        [Required]
        public string BrandName { get; set; }

        [Required]
        [Range(0, 1)]
        public int IsDeleted { get; set; }

        public Brands()
        {

        }

        public Brands(int BrandId, string BrandName, int IsDeleted)
        {
            this.BrandId = BrandId;
            this.BrandName = BrandName;
            this.IsDeleted = IsDeleted;
        }
    }
}