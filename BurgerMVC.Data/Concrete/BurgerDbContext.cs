using BurgerMVC.EntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Concrete
{
    public class BurgerDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options)
        {

        }
        public BurgerDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<Menu>().HasData(
                new Menu { ID = 1, Description = "Burger(Balık+Domates+Peynir+Turşu)+Patates(200 gr)+İçecek(Kola)", Name = "Balık Burger Menu", Price = 100, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/BalikBurger.jpg" },
                new Menu { ID = 2, Description = "Burger(2 Köfte+Marul+Peynir+Mayonez)+Patates(200gr)+İçecek(Ice Tea)", Name = "Double Burger Menu", Price = 95, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/DoubleBurger.jpg" },
                new Menu { ID = 3, Description = "Burger(Tavuk+Marul+Domates+Çıtır Soğan)+Patates(200gr)+İçecek(Ayran)", Name = "Tavuk Burger Menu", Price = 55, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/TavukBurger.jpg" },
                new Menu { ID = 4, Description = "Burger(Siyah Ekmek+240gr Köfte+Turşu+Karamelize Soğan)+Patates(200gr)+İçecek(Fanta)", Name = "Black Burger Menu", Price = 120, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/BlackBurger.jpg" }
                );
            builder.Entity<Sauce>().HasData
                (
                new Sauce { ID = 1, Name = "Ketçap", Price = 3, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/Ketcap.png" },
                new Sauce { ID = 2, Name = "Acı Sos", Price = 3, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Acisos.png" },
                new Sauce { ID = 3, Name = "Barbekü Sosu", Price = 3, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Barbakü.png" },
                new Sauce { ID = 4, Name = "Buffalo Sosu", Price = 3, CreatedTime = DateTime.Now, Stock = 400, Status = true, Image = "/ProjeResimler/Buffalo.png" },
                new Sauce { ID = 5, Name = "Hardal Sosu", Price = 3, CreatedTime = DateTime.Now, Stock = 150, Status = true, Image = "/ProjeResimler/Hardal.png" },
                new Sauce { ID = 6, Name = "Ranch Sosu", Price = 3, CreatedTime = DateTime.Now, Stock = 650, Status = true, Image = "/ProjeResimler/Ranch.png" },
                new Sauce { ID = 7, Name = "Mayonez", Price = 3, CreatedTime = DateTime.Now, Stock = 220, Status = true, Image = "/ProjeResimler/Mayonez.png" },
                new Sauce { ID = 8, Name = "Sarımsaklı Mayonez", Price = 3, CreatedTime = DateTime.Now, Stock = 345, Status = true, Image = "/ProjeResimler/Sarımsaklı.png" }
                );
            builder.Entity<Extra>().HasData
                (
                new Extra { ID = 1, Name = "Patates Kızartması", Price = 12, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Patates.jpg" },
                new Extra { ID = 2, Name = "Tavuk Tender", Price = 20, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Tender.png" },
                new Extra { ID = 3, Name = "Soğan Halkası", Price = 17, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/sogan.jpg" },
                new Extra { ID = 4, Name = "Nugget", Price = 16, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Nugget.png" },
                new Extra { ID = 5, Name = "Çıtır Tavuk", Price = 22, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Citir.png" }
                );
            builder.Entity<Dessert>().HasData
                (
                new Dessert { ID = 1, Name = "Çikolata Cookie", Price = 10, CreatedTime = DateTime.Now, Stock = 50, Status = true, Image = "/ProjeResimler/Cikolata.png" },
                new Dessert { ID = 2, Name = "Dondurma", Price = 10, CreatedTime = DateTime.Now, Stock = 10, Status = true, Image = "/ProjeResimler/Dondurma.png" },
                new Dessert { ID = 3, Name = "Elmalı Turta", Price = 25, CreatedTime = DateTime.Now, Stock = 70, Status = true, Image = "/ProjeResimler/Elmali.png" },
                new Dessert { ID = 4, Name = "Sufle", Price = 30, CreatedTime = DateTime.Now, Stock = 45, Status = true, Image = "/ProjeResimler/sufle.png" },
                new Dessert { ID = 5, Name = "Sundae", Price = 17, CreatedTime = DateTime.Now, Stock = 100, Status = true, Image = "/ProjeResimler/sundae.png" }
                );
            builder.Entity<Drink>().HasData
                (
                new Drink { ID = 1, Name = "Ayran", Price = 12, CreatedTime = DateTime.Now, Stock = 250, Status = true, Image = "/ProjeResimler/Ayran.png" },
                new Drink { ID = 2, Name = "Kola", Price = 16, CreatedTime = DateTime.Now, Stock = 450, Status = true, Image = "/ProjeResimler/Cola.png" },
                new Drink { ID = 3, Name = "Fanta", Price = 16, CreatedTime = DateTime.Now, Stock = 350, Status = true, Image = "/ProjeResimler/Fanta.png" },
                new Drink { ID = 4, Name = "Ice Tea", Price = 14, CreatedTime = DateTime.Now, Stock = 270, Status = true, Image = "/ProjeResimler/Icetea.png" },
                new Drink { ID = 5, Name = "Meyve Suyu", Price = 10, CreatedTime = DateTime.Now, Stock = 400, Status = true, Image = "/ProjeResimler/MeyveSuyu.png" },
                new Drink { ID = 6, Name = "Sprite", Price = 14, CreatedTime = DateTime.Now, Stock = 130, Status = true, Image = "/ProjeResimler/Sprite.png" }
                );
            builder.Entity<AppRole>().HasData(new AppRole {Id=new Guid("1CE9E927-2D41-4770-9816-EDF5129FA0CC") , Name = "Admin" , NormalizedName="ADMIN" }, new AppRole { Id = new Guid("5DF094BA-45BE-4736-A78E-935F949FA388"), Name ="Customer" , NormalizedName="CUSTOMER"});

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer("Server=DESKTOP-S2C7UGO;Database=BurgerMVCProjectDB;User ID=sa;Password=arkadas1");
            optionsBuilder.UseSqlServer("Server =.; Database = BurgerProjectSonDB; Trusted_Connection = True; TrustServerCertificate = True");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-81CS8R3;Database=BurgerMVCProjectSonDB;User ID=sa;Password=3157261Ho");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
