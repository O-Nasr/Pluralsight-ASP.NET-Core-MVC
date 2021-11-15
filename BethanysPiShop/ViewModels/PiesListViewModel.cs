using BethanysPiShop.Models;
using System.Collections.Generic;

namespace BethanysPiShop.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
