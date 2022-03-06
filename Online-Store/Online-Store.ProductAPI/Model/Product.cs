using Online_Store.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Store.ProductAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1,100000)]
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(800)]
        public string Description { get; set; }

        [Column("category_name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("image_url")]
        [StringLength(300)]
        public string ImageURL { get; set; }
    }
}