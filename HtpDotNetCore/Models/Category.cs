using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HowToPakistanNetCore.Models
{
    //[Table("tbl_Category")]     //name your table if you want else default class name will be selected as table name
    //otherwise table name can be generated from DbContext class also
    public class Category
    {
        [Key]   //set attribute as promary key
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual IEnumerable<Product> Product { get; set; }
    }
}
