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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.CommentId);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.AppUserId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Sauce)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.SauceId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Dessert)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.DessertId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Extra)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.ExtraId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Menu)
                   .WithMany(x => x.Comments)
                   .HasForeignKey(x => x.MenuId)
                   .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
