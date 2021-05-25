using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Alias { get; set; }
        public int CatrgoryID { get; set; }
        public int Image { get; set; }
        public int Morelmages { get; set; }
        public int Price { get; set; }
        public int Promotion { get; set; }        
        public int Warranty { get; set; }
        public int Description { get; set; }
        public int Content { get; set; }
        public int MetaKeyword { get; set; }
        public int MetaDescription { get; set; }
        public int CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public int Status { get; set; }
        public int HomeFlag { get; set; }
        public int HotFlag { get; set; }
        public int ViewCount { get; set; }

    }
}
