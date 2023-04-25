using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.ENT
{
    public class Products : Base
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Categories Categories { get; set; }

        //IProdRepo içerisinde tanımladığımız ek metotları kullanmak için buraya yazıyoruz.
        public decimal PriceDiscount()
        {
            return Price * .85m;
        }

        public decimal VATPrice()
        {
            return Price * 1.18m;
        }
    }
}