#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Web_FoodBasket.Data;
using Web_FoodBasket.Food;

namespace Web_FoodBasket.Pages.Bas
{
    #pragma warning restore CS8618
#pragma warning restore CS8604
    public class IndexModel : PageModel
    {
        private readonly Web_FoodBasket.Data.Web_FoodBasketContext _context;

        public IndexModel(Web_FoodBasket.Data.Web_FoodBasketContext context)
        {
            _context = context;
        }

        public IList<Basket> Basket { get;set; }

        public async Task OnGetAsync()
        {
            Basket = await _context.Basket.ToListAsync();
        }
    }
}
