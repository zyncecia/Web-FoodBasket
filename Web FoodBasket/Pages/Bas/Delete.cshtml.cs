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
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly Web_FoodBasket.Data.Web_FoodBasketContext _context;

        public DeleteModel(Web_FoodBasket.Data.Web_FoodBasketContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Basket = await _context.Basket.FindAsync(id);

            if (Basket != null)
            {
                _context.Basket.Remove(Basket);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8604
}
