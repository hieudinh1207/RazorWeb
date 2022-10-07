using Microsoft.EntityFrameworkCore;

namespace razorweb.models
{

    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions options) : base(options)
        {
            //
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Article> articles { set; get; }

    }
}
/* dotnet aspnet-codegenerator razorpage -m razorweb.models.Article -dc razorweb.models.MyBlogContext -outDir Pages/Blog -udl --referenceScriptLibraries  */