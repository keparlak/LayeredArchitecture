using LayeredArchitecture.ENT;

namespace LayeredArchitecture.UI.Models.ViewModel
{
    public class ProductsModel
    {
        public ProductsModel()
        {
            SelectedProducts = new Products();
        }

        public Products SelectedProducts { get; set; }
        public List<Categories> Categories { get; set; }
        public string Head { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
    }
}