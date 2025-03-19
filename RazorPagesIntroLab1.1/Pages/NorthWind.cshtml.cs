using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesIntroLab1._1.Models;

namespace RazorPagesIntroLab1._1.Pages
{
    public class NorthWindModel : PageModel
    {
        
        private readonly NorthwindContext _dbContext;

        public NorthWindModel(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }
        public class SupplierViewModel
        {
            
            public int Id { get; set; }
            public string CompanyName { get; set; }
            public string Region { get; set; }
        }
        public List<SupplierViewModel> Suppliers { get; set; } = new();
        public void OnGet()
        {
            Suppliers = _dbContext.Suppliers.Select(s => new SupplierViewModel
            {
                Id = s.SupplierId,
                CompanyName = s.CompanyName,
                Region = s.Region
            }).ToList();
        }

    }



}
