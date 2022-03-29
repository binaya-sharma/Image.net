using Microsoft.EntityFrameworkCore;

namespace MVC_Image.Models
{
    public class ImageDbContext : DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options)
        {

        }

        public DbSet<ImageModel> Images { get; set; }

    }
}
   

      

