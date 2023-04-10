using BurgerMVC.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Configuration
{
    public class DessertConfiguration : IEntityTypeConfiguration<Dessert>
    {
        public void Configure(EntityTypeBuilder<Dessert> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Price)
                   .HasColumnType("money");

        }
    }
}
