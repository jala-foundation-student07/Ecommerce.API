using System;
using System.Collections;

namespace Ecommerce.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int IdCart { get; set; }
        public Cart Cart { get; set; }
    }
}
