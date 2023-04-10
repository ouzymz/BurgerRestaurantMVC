using BurgerMVC.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.OrderID);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.UserID)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany<Dessert>(s => s.Desserts)
                   .WithMany(c => c.Orders);

            builder.HasMany<Menu>(s => s.Menus)
                   .WithMany(c => c.Orders); 

            builder.HasMany<Extra>(s => s.Extras)
                   .WithMany(c => c.Orders); 

            builder.HasMany<Drink>(s => s.Drinks)
                   .WithMany(c => c.Orders); 

            builder.HasMany<Sauce>(s => s.Sauces)
                   .WithMany(c => c.Orders);
               
        }
    }
}
