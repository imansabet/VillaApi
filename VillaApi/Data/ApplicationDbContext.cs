using Microsoft.EntityFrameworkCore;
using VillaApi.Models;

namespace VillaApi.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa() 
                {
                    Id= 1,
                    Name= "Royal Lux" ,
                    Details = "This a super fancy villa that very good for honeymoon",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 500,
                    Sqft = 550,
                    Amenity = "100 23%",
                    CreatedDate = DateTime.Now,
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Jungle Lux",
                    Details = "This a super fancy villa that is in jungle",
                    ImageUrl = "",
                    Occupancy = 6,
                    Rate = 600,
                    Sqft = 650,
                    Amenity = "200 23%",
                    CreatedDate = DateTime.Now,

                }
                );
        }


    }
}
