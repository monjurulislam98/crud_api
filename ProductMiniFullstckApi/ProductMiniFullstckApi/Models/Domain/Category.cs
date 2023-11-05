using System.ComponentModel.DataAnnotations;

namespace ProductMiniFullstckApi.Models.Domain
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string ? Name { get; set; }
    }
}
