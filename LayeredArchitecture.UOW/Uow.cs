using LayeredArchitecture.DAL;
using LayeredArchitecture.REP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.UOW
{
    public class Uow : IUow
    {
        private readonly Context context;

        public Uow(Context context, ICatRepos catRepos, IProdRepos prodRepos)
        {
            this.context = context;
            this.prodRepos = prodRepos;
            this.catRepos = catRepos;
        }

        public ICatRepos catRepos { get; }

        public IProdRepos prodRepos { get; }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}