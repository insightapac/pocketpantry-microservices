using MicroServiceOCR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceOCR.DBContexts
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseCosmos(
        //      "https://pocketpantry.documents.azure.com:443/",
        //      "3rSEy2pj67ZlyOC0dcswyHn2UFHuQLiToyt0ErffPVBLSZABuh09fI9RCnbnEBAPYoXfWViyobknTmXaDid2sQ==",
        //      "pocketpantrydb"
        //  );
        //}



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                
                new Category
                {
                    id = 1,
                    name = "Baby"
                }, 
                new Category
                {
                    id = 2,
                    name = "Beer, Wine & Spirits"
                },
                new Category
                {
                    id = 3,
                    name = "Beverages"
                },
                new Category
                {
                    id = 4,
                    name = "Bread & Bakery"
                }
                
          );
        }
    }
}
