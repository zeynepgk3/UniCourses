using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UniCourses.Dal.Entities;

namespace UniCourses.Dal.Contexts
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-0DCUDOG; database=UniCourses.com; integrated security=true;");
        }
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //  Course - WishList ( N:N )
            modelBuilder.Entity<CourseWishList>()
            .HasKey(cw => new { cw.CourseId, cw.WishListId });

            //  Course - Category ( N:N )
            modelBuilder.Entity<CourseCategory>()
        .HasKey(cc => new { cc.CourseId, cc.CategoryId });

            //  Category - Tag ( N:N )
            modelBuilder.Entity<CategoryTag>()
            .HasKey(ct => new { ct.CategoryId, ct.TagId });

            // Course - Collection ( N:N )
            modelBuilder.Entity<CourseCollection>()
            .HasKey(cc => new { cc.CourseId, cc.CollectionId });


            //  Course - Lesson ( 1:N )
            modelBuilder.Entity<Course>()
            .HasMany(L => L.Lessons)
            .WithOne(c => c.Course).OnDelete(DeleteBehavior.SetNull);

            // Lesson - Exam ( 1:N )
            modelBuilder.Entity<Lesson>()
            .HasMany(e => e.Exams)
            .WithOne(L => L.Lesson); // Lesson silinince exam silinsin

            //  Exam - Question ( 1:N ) 
            modelBuilder.Entity<Exam>()
            .HasMany(q => q.Questions)
            .WithOne(e => e.Exam); // Exam silinince Question da silinsin

            // Lesson - Comment ( 1:N )
            modelBuilder.Entity<Lesson>()
            .HasMany(c => c.Comments)
            .WithOne(L => L.Lesson); // Lesson silinince Comment de silinsin

            // Member - Comment ( 1:N )
            modelBuilder.Entity<Member>()
            .HasMany(c => c.Comments)
            .WithOne(m => m.Member); // --> Member silinmesin diye ekleme yap !!!!

        }

        public DbSet<Cart> Cart { get; set; }
        // public DbSet<CartMember> CartMember { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryTag> CategoryTag { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<CourseCollection> CourseCollection { get; set; }
        public DbSet<CourseWishList> CourseWishList { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<WishList> WishList { get; set; }

    }


}
