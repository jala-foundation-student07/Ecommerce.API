using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public IList<Product> Products { get; set; }
    }
}
