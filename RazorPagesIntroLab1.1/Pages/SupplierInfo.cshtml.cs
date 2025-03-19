using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesIntroLab1._1.Models;

namespace RazorPagesIntroLab1._1.Pages
{
    public class SupplierInfoModel : PageModel
    {
        private readonly NorthwindContext _dbContext;

        public SupplierInfoModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
        }
    }
}
