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
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("server=LAPTOP-M6D6S6HL; database=DBUniCourses; integrated security=true;");
        //    //base.OnConfiguring(optionsBuilder);
        //}
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Member - Educator(1-1)
            modelBuilder.Entity<Member>().HasOne(a => a.Educator).WithOne(b => b.Member)
                .HasForeignKey<Educator>(b => b.MemberID);

            // Member - Picture(1-1)
            modelBuilder.Entity<Member>().HasOne(a => a.Picture).WithOne(b => b.Member)
                .HasForeignKey<Picture>(b =>b.MemberID);

            // Course - Image(1-1)
            modelBuilder.Entity<Course>().HasOne(a => a.Image).WithOne(b => b.Course)
                .HasForeignKey<Image>(b =>b.CourseID);

            //  Course - WishList ( N:N )
            modelBuilder.Entity<CourseWishList>()
            .HasKey(cw => new { cw.CourseId, cw.WishListId });

            //  Course - Category ( N:N )
            modelBuilder.Entity<CourseCategory>()
        .HasKey(cc => new { cc.CourseId, cc.CategoryId });

            //  Course - Member ( N:N )
            modelBuilder.Entity<CourseMember>()
        .HasKey(cc => new { cc.CourseId, cc.MemberId });

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
            .WithOne(c => c.Category).HasForeignKey(f => f.CategoryID).OnDelete(DeleteBehavior.SetNull);

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
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseCategory> CourseCategory { get; set; }
        public DbSet<CourseMember> CourseMember { get; set; }
        public DbSet<CourseWishList> CourseWishList { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<WishList> WishList { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Picture> Picture { get; set; }

    }


}
