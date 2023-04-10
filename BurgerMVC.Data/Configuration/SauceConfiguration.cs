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
    public class SauceConfiguration : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.HasKey(x => x.ID);

        }
    }
}
