using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
