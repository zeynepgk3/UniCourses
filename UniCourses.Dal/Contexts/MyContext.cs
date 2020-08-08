using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using UniCourses.Dal.Entities;
//using static System.Collections.Immutable.ImmutableArray<T>;

namespace UniCourses.Dal.Contexts
{
    public class MyContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-M6D6S6HL; database=DBUniCourses; integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Member - Educator(1-1)
            modelBuilder.Entity<Member>().HasOne(a => a.Educator).WithOne(b => b.Member)
                .HasForeignKey<Educator>(b =>b.MemberID);

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

            ////  Category - Category ( 1:N )
            modelBuilder.Entity<Category>()
            .HasOne(one => one.ParentCategory)
            .WithMany(many => many.SubCategories).HasForeignKey(fk => fk.ParentID).OnDelete(DeleteBehavior.NoAction);

            //  Course - Lesson ( 1:N )
            modelBuilder.Entity<Course>()
            .HasMany(L => L.Lessons)
            .WithOne(c => c.Course).OnDelete(DeleteBehavior.SetNull);
            //  Course - Category ( 1:N )
            modelBuilder.Entity<Category>()
            .HasMany(L => L.Courses)
            .WithOne(c => c.Category).OnDelete(DeleteBehavior.SetNull);

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

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Educator> Educator { get; set; }
        public DbSet<Admin> Admin { get; set; }
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
