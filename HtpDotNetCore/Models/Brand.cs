using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowToPakistanNetCore.Models
{
    //[Table("tbl_Brand")]    //name your table if you want else default class name will be selected as table name
    //otherwise table name can be generated from DbContext class also
    public class Brand
    {
        [Key]   //set attribute as promary key
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public virtual IEnumerable<Product> Product { get; set; }
    }
}
