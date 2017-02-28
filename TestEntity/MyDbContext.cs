using MyBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntity
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Projects\MyBlogProject\MyBlog\TestEntity\Persistence\MyDB.mdf;Integrated Security=True")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Posts Model
        //    #region           
        //    modelBuilder.Entity<Post>().HasKey(p => p.Id);
        //    modelBuilder.Entity<Post>().Property(p => p.Title).HasMaxLength(500); //add not nullable
        //    modelBuilder.Entity<Post>().Property(p => p.ShortDescription).HasMaxLength(5000); //add not nullable
        //    modelBuilder.Entity<Post>().Property(p => p.Description).HasMaxLength(5000); //add not nullable
        //    modelBuilder.Entity<Post>().Property(p => p.Meta).HasMaxLength(1000); //add non nullable
        //    modelBuilder.Entity<Post>().Property(p => p.UrlSlug).HasMaxLength(200); //add non nullable
        //    modelBuilder.Entity<Post>().Property(p => p.Published); //add non nullable
        //    modelBuilder.Entity<Post>().Property(p => p.PostedOn); //add non nullable
        //    modelBuilder.Entity<Post>().Property(p => p.Modified);
        //    //modelBuilder.Entity<Post>()
        //    //                   .HasRequired<Category>(p => p.Category) // Post entity requires Category
        //    //                   .WithMany(c => c.Posts); //Category entity includes many student entities
        //    ////todo  if linkage btw post and category will not appear, test another likange adding new prop to post: categoryId

        //    #endregion

        //    //Categories Model
        //    #region
        //    modelBuilder.Entity<Category>().HasKey(c => c.Id);
        //    modelBuilder.Entity<Category>().Property(c => c.Name).HasMaxLength(50); // add not nullable
        //    modelBuilder.Entity<Category>().Property(c => c.UrlSlug).HasMaxLength(50); // add not nullable
        //    modelBuilder.Entity<Category>().Property(c => c.Description).HasMaxLength(200);
        //    //add many to many
        //    #endregion

        //    //Tag Model
        //    #region
        //    modelBuilder.Entity<Tag>().HasKey(c => c.Id);
        //    modelBuilder.Entity<Tag>().Property(c => c.Name).HasMaxLength(50); // add not nullable
        //    modelBuilder.Entity<Tag>().Property(c => c.UrlSlug).HasMaxLength(50); // add not nullable
        //    modelBuilder.Entity<Tag>().Property(c => c.Description).HasMaxLength(200);
        //    //add many to many
        //    #endregion
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
