using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model.Abstract;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string Name { set; get; }
        [Required]
        public string Alias { set; get; }
        public int Category { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }
        public string Description { set; get; }
        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }        
        public int? ViewCount { set; get; }    

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
