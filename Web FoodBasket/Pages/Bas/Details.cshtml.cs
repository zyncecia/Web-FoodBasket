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
    public class DetailsModel : PageModel
    {
        private readonly Web_FoodBasket.Data.Web_FoodBasketContext _context;

        public DetailsModel(Web_FoodBasket.Data.Web_FoodBasketContext context)
        {
            _context = context;
        }

        public Basket Basket { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Basket = await _context.Basket.FirstOrDefaultAsync(m => m.ID == id);

            if (Basket == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
