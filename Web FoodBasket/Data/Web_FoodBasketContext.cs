#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_FoodBasket.Food;

namespace Web_FoodBasket.Data
{
    public class Web_FoodBasketContext : DbContext
    {
        public Web_FoodBasketContext (DbContextOptions<Web_FoodBasketContext> options)
            : base(options)
        {
        }

        public DbSet<Web_FoodBasket.Food.Basket> Basket { get; set; }
    }
}
