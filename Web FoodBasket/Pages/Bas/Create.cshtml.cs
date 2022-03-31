#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web_FoodBasket.Data;
using Web_FoodBasket.Food;

namespace Web_FoodBasket.Pages.Bas
{
    public class CreateModel : PageModel
    {
        private readonly Web_FoodBasket.Data.Web_FoodBasketContext _context;

        public CreateModel(Web_FoodBasket.Data.Web_FoodBasketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Basket Basket { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Basket.Add(Basket);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
