﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniCourses.Dal.Contexts;

namespace UniCourses.Dal.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TownID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.HasIndex("TownID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NameSurname")
                        .HasColumnType("Varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("Varchar(32)")
                        .HasMaxLength(23);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("MemberId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("Varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CategoryTag", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("CategoryTag");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Collection", b =>
                {
                    b.Property<int>("CollectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollectionName")
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("CollectionId");

                    b.HasIndex("MemberId");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CommentState")
                        .HasColumnType("int");

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("LessonID")
                        .HasColumnType("int");

                    b.Property<int?>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("UserComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("LessonID");

                    b.HasIndex("MemberID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Categoryi")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("Varchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Duzey")
                        .HasColumnType("Varchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("EducatorID")
                        .HasColumnType("int");

                    b.Property<int>("Educatori")
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("Varchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Name")
                        .HasColumnType("Varchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("NumberOfStudent")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("Varchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EducatorID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseCategory", b =>
                {
                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CourseCategory");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseCollection", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CollectionId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "CollectionId");

                    b.HasIndex("CollectionId");

                    b.ToTable("CourseCollection");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseWishList", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("WishListId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "WishListId");

                    b.HasIndex("WishListId");

                    b.ToTable("CourseWishList");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Educator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("Varchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Depart")
                        .HasColumnType("Varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Instagram")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Job")
                        .HasColumnType("Varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Linkedin")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Mail")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<string>("NameSurname")
                        .HasColumnType("Varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .HasColumnType("Varchar(32)")
                        .HasMaxLength(32);

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("TotalStudent")
                        .HasColumnType("int");

                    b.Property<string>("Twitter")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("University")
                        .HasColumnType("Varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("WebSite")
                        .HasColumnType("Varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Youtube")
                        .HasColumnType("Varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("MemberID")
                        .IsUnique();

                    b.ToTable("Educator");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ExamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonID")
                        .HasColumnType("int");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("LessonID");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int>("LastPoint")
                        .HasColumnType("int");

                    b.Property<string>("LessonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("IP")
                        .HasColumnType("char(21)")
                        .HasMaxLength(21);

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NameSurName")
                        .IsRequired()
                        .HasColumnType("varchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("char(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("RegisteryDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("RoleNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RecDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TcNo")
                        .HasColumnType("char(10)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<bool>("IsTrue")
                        .HasColumnType("bit");

                    b.Property<int>("Line")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("ExamId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("TagName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Town", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("Town");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.WishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WishList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Address", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Member", "Member")
                        .WithMany("Addresses")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.Town", "Town")
                        .WithMany("Addresses")
                        .HasForeignKey("TownID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Cart", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.Member", "member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Category", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentID")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CategoryTag", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.City", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Collection", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Member", null)
                        .WithMany("Collections")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Comment", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID");

                    b.HasOne("UniCourses.Dal.Entities.Lesson", "Lesson")
                        .WithMany("Comments")
                        .HasForeignKey("LessonID");

                    b.HasOne("UniCourses.Dal.Entities.Member", "Member")
                        .WithMany("Comments")
                        .HasForeignKey("MemberID");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Course", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Category", "Category")
                        .WithMany("Courses")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("UniCourses.Dal.Entities.Educator", "Educator")
                        .WithMany("Courses")
                        .HasForeignKey("EducatorID");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseCategory", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseCollection", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Collection", "collection")
                        .WithMany()
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.CourseWishList", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniCourses.Dal.Entities.WishList", "WishList")
                        .WithMany()
                        .HasForeignKey("WishListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Educator", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Member", "Member")
                        .WithOne("Educator")
                        .HasForeignKey("UniCourses.Dal.Entities.Educator", "MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Exam", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Lesson", "Lesson")
                        .WithMany("Exams")
                        .HasForeignKey("LessonID");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Lesson", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Question", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.Exam", "Exam")
                        .WithMany("Questions")
                        .HasForeignKey("ExamId");
                });

            modelBuilder.Entity("UniCourses.Dal.Entities.Town", b =>
                {
                    b.HasOne("UniCourses.Dal.Entities.City", "City")
                        .WithMany("Towns")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
