using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowToPakistanNetCore.Models
{
    //[Table("tbl_Product")]  //name your table if you want else default class name will be selected as table name
    //otherwise table name can be generated from DbContext class also
    public class Product
    {
        [Key]   //set attribute as promary key
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal SalePrice { get; set; }
        public int Qty { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}
