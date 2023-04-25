using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.ENT
{
    public class Categories : Base
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public ICollection<Products> Products { get; set; }
    }
}