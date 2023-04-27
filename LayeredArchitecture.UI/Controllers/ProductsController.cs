using LayeredArchitecture.UI.Models.ViewModel;
using LayeredArchitecture.UOW;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitecture.UI.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly ProductsModel model;

        public ProductsController(IUow uow, ProductsModel model) : base(uow)
        {
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.prodRepos.GetProducts());
        }

        public IActionResult Add()
        {
            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "hover:shadow-indigo-500/40 bg-indigo-700 hover:bg-indigo-600 focus:ring-indigo-600";
            model.Categories = uow.catRepos.List();
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Add(ProductsModel m)
        {
            uow.prodRepos.Add(m.SelectedProducts);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelleme";
            model.Class = "hover:shadow-orange-500/40 bg-orange-700 hover:bg-orange-600 focus:ring-orange-600";
            model.SelectedProducts = uow.prodRepos.Find(Id);
            model.Categories = uow.catRepos.List();
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Update(ProductsModel m)
        {
            uow.prodRepos.Update(m.SelectedProducts);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            uow.prodRepos.Delete(uow.prodRepos.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}