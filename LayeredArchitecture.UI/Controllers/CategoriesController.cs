using LayeredArchitecture.UI.Models.ViewModel;
using LayeredArchitecture.UOW;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitecture.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly IUow uow;
        private readonly CategoriesModel model;

        public CategoriesController(IUow uow, CategoriesModel model) : base(uow)
        {
            this.uow = uow;
            this.model = model;
        }

        public IActionResult List()
        {
            return View(uow.catRepos.List());
        }

        public IActionResult Update(Guid Id)
        {
            model.Head = "Güncelleme";
            model.Text = "Güncelle";
            model.Class = "bg-orange-600 hover:bg-orange-900";
            model.SelectedCat = uow.catRepos.Find(Id);
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Update(CategoriesModel model)
        {
            uow.catRepos.Update(model.SelectedCat);
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(Guid Id)
        {
            var cat = uow.catRepos.Delete(uow.catRepos.Find(Id));
            uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Add()
        {
            model.Head = "Yeni Giriş";
            model.Text = "Kaydet";
            model.Class = "bg-blue-600 hover:bg-blue-900";
            return View("Crud", model);
        }

        [HttpPost]
        public IActionResult Add(CategoriesModel model)
        {
            uow.catRepos.Add(model.SelectedCat);
            uow.Commit();
            return RedirectToAction("List");
        }
    }
}