using LayeredArchitecture.Core;
using LayeredArchitecture.DAL;
using LayeredArchitecture.ENT;
using LayeredArchitecture.REP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.REP.Concretes
{
    public class CatRepos<T> : BaseRepository<Categories>, ICatRepos
    {
        public CatRepos(Context context) : base(context)
        {
        }
    }
}