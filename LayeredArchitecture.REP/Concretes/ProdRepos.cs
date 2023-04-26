using LayeredArchitecture.Core;
using LayeredArchitecture.DAL;
using LayeredArchitecture.DTO;
using LayeredArchitecture.ENT;
using LayeredArchitecture.REP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.REP.Concretes
{
    public class ProdRepos<T> : BaseRepository<Products>, IProdRepos
    {
        public ProdRepos(Context context) : base(context)
        {
        }

        public List<ProductsDTO> GetProducts()
        {
            return Set().Select(x => new ProductsDTO
            {
                Id = x.Id,
                CategoryName = x.Categories.Name,
                ProductName = x.Name,
                UnitPrice = x.Price,
            }).ToList();
        }

        public decimal PriceDiscount(Guid Id)
        {
            var p = Find(Id);
            return p.PriceDiscount(); //Aşağıdaki yazım ile buradaki yazımın döndürdüğü sonuç tamamen aynı
        }

        public decimal VATPrice(Guid Id)
        {
            return Find(Id).VATPrice();
        }
    }
}