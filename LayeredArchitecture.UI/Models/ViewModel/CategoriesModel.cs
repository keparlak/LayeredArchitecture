using LayeredArchitecture.ENT;

namespace LayeredArchitecture.UI.Models.ViewModel
{
    public class CategoriesModel
    {
        public CategoriesModel()
        {
            SelectedCat = new Categories();
        }

        public Categories SelectedCat { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
    }
}