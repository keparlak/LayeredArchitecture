using LayeredArchitecture.REP.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredArchitecture.UOW
{
    public interface IUow
    {
        ICatRepos catRepos { get; }
        IProdRepos prodRepos { get; }

        void Commit();
    }
}