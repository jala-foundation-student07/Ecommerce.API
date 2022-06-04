using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
