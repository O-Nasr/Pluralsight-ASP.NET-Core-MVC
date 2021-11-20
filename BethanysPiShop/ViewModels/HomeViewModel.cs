using BethanysPiShop.Models;
using System.Collections.Generic;

namespace BethanysPiShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
