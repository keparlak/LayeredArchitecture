using LayeredArchitecture.Core;
using LayeredArchitecture.DTO;
using LayeredArchitecture.ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.REP.Abstracts
{
    public interface IProdRepos : IBaseRepository<Products>
    {
        //Eğer ek metodları yapacaksak burada tanımlıyor olacağız.
        decimal VATPrice(Guid Id);

        decimal PriceDiscount(Guid Id);

        List<ProductsDTO> GetProducts();
    }
}