using LayeredArchitecture.UOW;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitecture.UI.Controllers
{
    public class BaseController : Controller
    {
        public readonly IUow uow;

        public BaseController(IUow uow)
        {
            this.uow = uow;
        }
    }
}