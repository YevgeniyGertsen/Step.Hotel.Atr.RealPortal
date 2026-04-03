using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Step.Hotel.Atr.Admin.Models;

namespace Step.Hotel.Atr.Admin.Data;

public partial class HotelAtrDbContext : DbContext
{
    public HotelAtrDbContext()
    {
    }

    public HotelAtrDbContext(DbContextOptions<HotelAtrDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<AboutContactInfo> AboutContactInfos { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetRole1> AspNetRoles1 { get; set; }

    public virtual DbSet<AspNetRole2> AspNetRoles2 { get; set; }

    public virtual DbSet<AspNetRole3> AspNetRoles3 { get; set; }

    public virtual DbSet<AspNetRole4> AspNetRoles4 { get; set; }

    public virtual DbSet<AspNetRole5> AspNetRoles5 { get; set; }

    public virtual DbSet<AspNetRole6> AspNetRoles6 { get; set; }

    public virtual DbSet<AspNetRole7> AspNetRoles7 { get; set; }

    public virtual DbSet<AspNetRole8> AspNetRoles8 { get; set; }

    public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoleClaim1> AspNetRoleClaims1 { get; set; }

    public virtual DbSet<AspNetRoleClaim2> AspNetRoleClaims2 { get; set; }

    public virtual DbSet<AspNetRoleClaim3> AspNetRoleClaims3 { get; set; }

    public virtual DbSet<AspNetRoleClaim4> AspNetRoleClaims4 { get; set; }

    public virtual DbSet<AspNetRoleClaim5> AspNetRoleClaims5 { get; set; }

    public virtual DbSet<AspNetRoleClaim6> AspNetRoleClaims6 { get; set; }

    public virtual DbSet<AspNetRoleClaim7> AspNetRoleClaims7 { get; set; }

    public virtual DbSet<AspNetRoleClaim8> AspNetRoleClaims8 { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUser1> AspNetUsers1 { get; set; }

    public virtual DbSet<AspNetUser2> AspNetUsers2 { get; set; }

    public virtual DbSet<AspNetUser3> AspNetUsers3 { get; set; }

    public virtual DbSet<AspNetUser4> AspNetUsers4 { get; set; }

    public virtual DbSet<AspNetUser5> AspNetUsers5 { get; set; }

    public virtual DbSet<AspNetUser6> AspNetUsers6 { get; set; }

    public virtual DbSet<AspNetUser7> AspNetUsers7 { get; set; }

    public virtual DbSet<AspNetUser8> AspNetUsers8 { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserClaim1> AspNetUserClaims1 { get; set; }

    public virtual DbSet<AspNetUserClaim2> AspNetUserClaims2 { get; set; }

    public virtual DbSet<AspNetUserClaim3> AspNetUserClaims3 { get; set; }

    public virtual DbSet<AspNetUserClaim4> AspNetUserClaims4 { get; set; }

    public virtual DbSet<AspNetUserClaim5> AspNetUserClaims5 { get; set; }

    public virtual DbSet<AspNetUserClaim6> AspNetUserClaims6 { get; set; }

    public virtual DbSet<AspNetUserClaim7> AspNetUserClaims7 { get; set; }

    public virtual DbSet<AspNetUserClaim8> AspNetUserClaims8 { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserLogin1> AspNetUserLogins1 { get; set; }

    public virtual DbSet<AspNetUserLogin2> AspNetUserLogins2 { get; set; }

    public virtual DbSet<AspNetUserLogin3> AspNetUserLogins3 { get; set; }

    public virtual DbSet<AspNetUserLogin4> AspNetUserLogins4 { get; set; }

    public virtual DbSet<AspNetUserLogin5> AspNetUserLogins5 { get; set; }

    public virtual DbSet<AspNetUserLogin6> AspNetUserLogins6 { get; set; }

    public virtual DbSet<AspNetUserLogin7> AspNetUserLogins7 { get; set; }

    public virtual DbSet<AspNetUserLogin8> AspNetUserLogins8 { get; set; }

    public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }

    public virtual DbSet<AspNetUserToken1> AspNetUserTokens1 { get; set; }

    public virtual DbSet<AspNetUserToken2> AspNetUserTokens2 { get; set; }

    public virtual DbSet<AspNetUserToken3> AspNetUserTokens3 { get; set; }

    public virtual DbSet<AspNetUserToken4> AspNetUserTokens4 { get; set; }

    public virtual DbSet<AspNetUserToken5> AspNetUserTokens5 { get; set; }

    public virtual DbSet<AspNetUserToken6> AspNetUserTokens6 { get; set; }

    public virtual DbSet<AspNetUserToken7> AspNetUserTokens7 { get; set; }

    public virtual DbSet<AspNetUserToken8> AspNetUserTokens8 { get; set; }

    public virtual DbSet<BannerItem> BannerItems { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Booking1> Bookings1 { get; set; }

    public virtual DbSet<Booking2> Bookings2 { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<CartItem1> CartItems1 { get; set; }

    public virtual DbSet<CartItem2> CartItems2 { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Category1> Categories1 { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Client1> Clients1 { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<Contact1> Contacts1 { get; set; }

    public virtual DbSet<ContactForm> ContactForms { get; set; }

    public virtual DbSet<ContactForm1> ContactForms1 { get; set; }

    public virtual DbSet<ContactForm2> ContactForms2 { get; set; }

    public virtual DbSet<ContactForm3> ContactForms3 { get; set; }

    public virtual DbSet<ContactMessage> ContactMessages { get; set; }

    public virtual DbSet<ContactMessage1> ContactMessages1 { get; set; }

    public virtual DbSet<ContactMessage2> ContactMessages2 { get; set; }

    public virtual DbSet<ContactSubmission> ContactSubmissions { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseEnrollment> CourseEnrollments { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employees2> Employees2s { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<FitnessClass> FitnessClasses { get; set; }

    public virtual DbSet<FitnessClass1> FitnessClasses1 { get; set; }

    public virtual DbSet<GalleryImage> GalleryImages { get; set; }

    public virtual DbSet<MRoom> MRooms { get; set; }

    public virtual DbSet<Messag> Messags { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Order1> Orders1 { get; set; }

    public virtual DbSet<Order2> Orders2 { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Product1> Products1 { get; set; }

    public virtual DbSet<Product2> Products2 { get; set; }

    public virtual DbSet<Product3> Products3 { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<RClient> RClients { get; set; }

    public virtual DbSet<RRoom> RRooms { get; set; }

    public virtual DbSet<RTeam> RTeams { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Review1> Reviews1 { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Room1> Rooms1 { get; set; }

    public virtual DbSet<ScheduleItem> ScheduleItems { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Service1> Services1 { get; set; }

    public virtual DbSet<Service2> Services2 { get; set; }

    public virtual DbSet<Service3> Services3 { get; set; }

    public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }

    public virtual DbSet<ServicesDbfirst> ServicesDbfirsts { get; set; }

    public virtual DbSet<ShopProduct> ShopProducts { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subscriber> Subscribers { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<Team> Teams { get; set; }

    public virtual DbSet<Team1> Teams1 { get; set; }

    public virtual DbSet<Team2> Teams2 { get; set; }

    public virtual DbSet<TourOffer> TourOffers { get; set; }

    public virtual DbSet<Trainer> Trainers { get; set; }

    public virtual DbSet<Translation> Translations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<User2> Users2 { get; set; }

    public virtual DbSet<User3> Users3 { get; set; }

    public virtual DbSet<User4> Users4 { get; set; }

    public virtual DbSet<User5> Users5 { get; set; }

    public virtual DbSet<User6> Users6 { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<Users1> Users1s { get; set; }

    public virtual DbSet<UsersAEA> UsersAEAs { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=178.89.186.221, 1434;Database=hotelatr_db;User Id=hotelatr_user_db;Password=A1d8kn&66;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("hotelatr_user_db");

        modelBuilder.Entity<About>(entity =>
        {
            entity.ToTable("Abouts", "jomartov_user");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Accounts", "dbo");

            entity.HasIndex(e => e.AccountNo, "IX_Accounts_AccountNo");

            entity.HasIndex(e => e.ClientId, "IX_Accounts_ClientId");

            entity.HasIndex(e => e.AccountNo, "UQ_Accounts_AccountNo").IsUnique();

            entity.Property(e => e.AccountNo).HasMaxLength(20);
            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.OpenedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Client).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Accounts_Clients");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.ToTable("AspNetRoles", "alexey_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole1>(entity =>
        {
            entity.ToTable("AspNetRoles", "anzhelina");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole2>(entity =>
        {
            entity.ToTable("AspNetRoles", "azizov_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole3>(entity =>
        {
            entity.ToTable("AspNetRoles");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole4>(entity =>
        {
            entity.ToTable("AspNetRoles", "ismailov_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole5>(entity =>
        {
            entity.ToTable("AspNetRoles", "mushypharmacy_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole6>(entity =>
        {
            entity.ToTable("AspNetRoles", "nizamutdinov_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole7>(entity =>
        {
            entity.ToTable("AspNetRoles", "olzhassovetbekov_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRole8>(entity =>
        {
            entity.ToTable("AspNetRoles", "yefimenko_user");

            entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedName] IS NOT NULL)");

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetRoleClaim>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "alexey_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaims).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim1>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "anzhelina");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim1s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim2>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "azizov_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim2s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim3>(entity =>
        {
            entity.ToTable("AspNetRoleClaims");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim3s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim4>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "ismailov_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim4s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim5>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "mushypharmacy_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim5s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim6>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "nizamutdinov_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim6s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim7>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "olzhassovetbekov_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim7s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetRoleClaim8>(entity =>
        {
            entity.ToTable("AspNetRoleClaims", "yefimenko_user");

            entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetRoleClaim8s).HasForeignKey(d => d.RoleId);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.ToTable("AspNetUsers", "alexey_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "alexey_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser1>(entity =>
        {
            entity.ToTable("AspNetUsers", "anzhelina");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole1",
                    r => r.HasOne<AspNetRole1>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser1>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "anzhelina");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser2>(entity =>
        {
            entity.ToTable("AspNetUsers", "azizov_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole2",
                    r => r.HasOne<AspNetRole2>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser2>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "azizov_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser3>(entity =>
        {
            entity.ToTable("AspNetUsers");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole3",
                    r => r.HasOne<AspNetRole3>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser3>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser4>(entity =>
        {
            entity.ToTable("AspNetUsers", "ismailov_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole4",
                    r => r.HasOne<AspNetRole4>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser4>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "ismailov_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser5>(entity =>
        {
            entity.ToTable("AspNetUsers", "mushypharmacy_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole5",
                    r => r.HasOne<AspNetRole5>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser5>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "mushypharmacy_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser6>(entity =>
        {
            entity.ToTable("AspNetUsers", "nizamutdinov_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole6",
                    r => r.HasOne<AspNetRole6>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser6>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "nizamutdinov_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser7>(entity =>
        {
            entity.ToTable("AspNetUsers", "olzhassovetbekov_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole7",
                    r => r.HasOne<AspNetRole7>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser7>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "olzhassovetbekov_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUser8>(entity =>
        {
            entity.ToTable("AspNetUsers", "yefimenko_user");

            entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                .IsUnique()
                .HasFilter("([NormalizedUserName] IS NOT NULL)");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole8",
                    r => r.HasOne<AspNetRole8>().WithMany().HasForeignKey("RoleId"),
                    l => l.HasOne<AspNetUser8>().WithMany().HasForeignKey("UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId");
                        j.ToTable("AspNetUserRoles", "yefimenko_user");
                        j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "alexey_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim1>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "anzhelina");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim1s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim2>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "azizov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim2s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim3>(entity =>
        {
            entity.ToTable("AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim3s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim4>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "ismailov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim4s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim5>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "mushypharmacy_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim5s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim6>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "nizamutdinov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim6s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim7>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "olzhassovetbekov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim7s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserClaim8>(entity =>
        {
            entity.ToTable("AspNetUserClaims", "yefimenko_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaim8s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "alexey_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin1>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "anzhelina");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin1s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin2>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "azizov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin2s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin3>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin3s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin4>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "ismailov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin4s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin5>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "mushypharmacy_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin5s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin6>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "nizamutdinov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin6s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin7>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "olzhassovetbekov_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin7s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserLogin8>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

            entity.ToTable("AspNetUserLogins", "yefimenko_user");

            entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogin8s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "alexey_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserTokens).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken1>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "anzhelina");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken1s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken2>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "azizov_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken2s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken3>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken3s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken4>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "ismailov_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken4s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken5>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "mushypharmacy_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken5s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken6>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "nizamutdinov_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken6s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken7>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "olzhassovetbekov_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken7s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<AspNetUserToken8>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

            entity.ToTable("AspNetUserTokens", "yefimenko_user");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserToken8s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<BannerItem>(entity =>
        {
            entity.ToTable("BannerItems", "nazarov_ftp");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.ToTable("BlogPosts", "alexey_user");

            entity.HasIndex(e => e.CreatedAt, "IX_BlogPost_CreatedAt");

            entity.HasIndex(e => e.IsPublished, "IX_BlogPost_IsPublished");

            entity.Property(e => e.Author).HasMaxLength(100);
            entity.Property(e => e.Content).HasColumnType("ntext");
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.ShortDescription).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.ToTable("Books", "mixer_user");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.ToTable("Bookings", "amanbayev_user");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Booking1>(entity =>
        {
            entity.HasKey(e => new { e.PropertyId, e.BookingDateTime });

            entity.ToTable("Bookings", "olzhassovetbekov_user");

            entity.HasOne(d => d.Property).WithMany(p => p.Booking1s).HasForeignKey(d => d.PropertyId);
        });

        modelBuilder.Entity<Booking2>(entity =>
        {
            entity.ToTable("Bookings", "rustembek_user");

            entity.HasIndex(e => e.RoomId, "IX_Bookings_RoomId");

            entity.HasIndex(e => e.UserId, "IX_Bookings_UserId");

            entity.Property(e => e.RoomName).HasDefaultValue("");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Room).WithMany(p => p.Booking2s).HasForeignKey(d => d.RoomId);

            entity.HasOne(d => d.User).WithMany(p => p.Booking2s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.ToTable("CartItems", "gunkin_denis_user");

            entity.HasIndex(e => e.ProductId, "IX_CartItems_ProductId");

            entity.Property(e => e.SessionId).HasMaxLength(64);
            entity.Property(e => e.UserId).HasMaxLength(64);

            entity.HasOne(d => d.Product).WithMany(p => p.CartItems).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<CartItem1>(entity =>
        {
            entity.ToTable("CartItems", "Ibrakhim_user");

            entity.HasIndex(e => e.ProductId, "IX_CartItems_ProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.CartItem1s).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<CartItem2>(entity =>
        {
            entity.ToTable("CartItems", "rashid_user");

            entity.HasIndex(e => e.ProductId, "IX_CartItems_ProductId");

            entity.HasIndex(e => e.UserId, "IX_CartItems_UserId");

            entity.HasOne(d => d.Product).WithMany(p => p.CartItem2s).HasForeignKey(d => d.ProductId);

            entity.HasOne(d => d.User).WithMany(p => p.CartItem2s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Categories", "gunkin_denis_user");

            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Slug).HasMaxLength(50);
        });

        modelBuilder.Entity<Category1>(entity =>
        {
            entity.ToTable("Categories", "rashid_user");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.ToTable("Clients", "dbo");

            entity.HasIndex(e => e.Iin, "IX_Clients_Iin");

            entity.HasIndex(e => e.Iin, "UQ_Clients_Iin").IsUnique();

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.Iin).HasMaxLength(12);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Client1>(entity =>
        {
            entity.ToTable("Clients");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Contacts__3214EC07BACEC0BF");

            entity.ToTable("Contacts", "dbo");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Contact1>(entity =>
        {
            entity.ToTable("Contacts", "jomartov_user");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<ContactForm>(entity =>
        {
            entity.ToTable("ContactForm", "amanbayev_user");

            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ContactForm1>(entity =>
        {
            entity.ToTable("ContactForms");

            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<ContactForm2>(entity =>
        {
            entity.ToTable("ContactForms", "Ibrakhim_user");

            entity.Property(e => e.Message).HasMaxLength(2000);
        });

        modelBuilder.Entity<ContactForm3>(entity =>
        {
            entity.ToTable("ContactForms", "olzhassovetbekov_user");
        });

        modelBuilder.Entity<ContactMessage>(entity =>
        {
            entity.ToTable("ContactMessages", "gunkin_denis_user");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<ContactMessage1>(entity =>
        {
            entity.ToTable("ContactMessages", "ismailov_user");

            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Message).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<ContactMessage2>(entity =>
        {
            entity.ToTable("ContactMessages", "mushypharmacy_user");
        });

        modelBuilder.Entity<ContactSubmission>(entity =>
        {
            entity.ToTable("ContactSubmissions", "alexey_user");

            entity.HasIndex(e => e.Email, "IX_ContactSubmission_Email");

            entity.HasIndex(e => e.SubmittedAt, "IX_ContactSubmission_SubmittedAt");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Message).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Courses", "anzhelina");

            entity.Property(e => e.DescriptionEn).HasMaxLength(500);
            entity.Property(e => e.DescriptionRu).HasMaxLength(500);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TitleEn).HasMaxLength(200);
            entity.Property(e => e.TitleRu).HasMaxLength(200);
        });

        modelBuilder.Entity<CourseEnrollment>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.CourseId });

            entity.ToTable("CourseEnrollments", "anzhelina");

            entity.HasIndex(e => e.CourseId, "IX_CourseEnrollments_CourseId");

            entity.HasOne(d => d.Course).WithMany(p => p.CourseEnrollments).HasForeignKey(d => d.CourseId);

            entity.HasOne(d => d.User).WithMany(p => p.CourseEnrollments).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B853530E0E");

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BED7488CA9C");

            entity.Property(e => e.DepartmentId).ValueGeneratedNever();
            entity.Property(e => e.DepartmentName).HasMaxLength(100);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07800477DE");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Employees2>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11C20C06C6");

            entity.ToTable("Employees2");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<FitnessClass>(entity =>
        {
            entity.ToTable("FitnessClasses", "alexey_user");

            entity.HasIndex(e => e.Category, "IX_FitnessClass_Category");

            entity.HasIndex(e => e.IsActive, "IX_FitnessClass_IsActive");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.DayOfWeek).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrainerName).HasMaxLength(100);
        });

        modelBuilder.Entity<FitnessClass1>(entity =>
        {
            entity.ToTable("FitnessClasses", "ismailov_user");

            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<GalleryImage>(entity =>
        {
            entity.ToTable("GalleryImages", "alexey_user");

            entity.HasIndex(e => e.Category, "IX_GalleryImage_Category");

            entity.HasIndex(e => e.IsVisible, "IX_GalleryImage_IsVisible");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<MRoom>(entity =>
        {
            entity.ToTable("M_Rooms");
        });

        modelBuilder.Entity<Messag>(entity =>
        {
            entity.ToTable("Messag", "nazarov_ftp");

            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Number).HasMaxLength(20);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BAFD35D7665");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Amount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Order1>(entity =>
        {
            entity.ToTable("Orders", "Ibrakhim_user");

            entity.HasIndex(e => e.ProductId, "IX_Orders_ProductId");

            entity.HasOne(d => d.Product).WithMany(p => p.Order1s).HasForeignKey(d => d.ProductId);
        });

        modelBuilder.Entity<Order2>(entity =>
        {
            entity.ToTable("Orders", "rashid_user");

            entity.HasIndex(e => e.UserId, "IX_Orders_UserId");

            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.User).WithMany(p => p.Order2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("OrderItems", "rashid_user");

            entity.HasIndex(e => e.OrderId, "IX_OrderItems_OrderId");

            entity.HasIndex(e => e.ProductId, "IX_OrderItems_ProductId");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasForeignKey(d => d.OrderId);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.ToTable("Portfolios", "jomartov_user");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Client).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Products", "azizov_user");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Product1>(entity =>
        {
            entity.ToTable("Products", "gunkin_denis_user");

            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Product1s)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Product2>(entity =>
        {
            entity.ToTable("Products", "Ibrakhim_user");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Product3>(entity =>
        {
            entity.ToTable("Products", "rashid_user");

            entity.HasIndex(e => e.CategoryId, "IX_Products_CategoryId");

            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Product3s)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projects__3214EC074E702F44");

            entity.ToTable("Projects", "nizamutdinov_user");

            entity.Property(e => e.DescriptionKey).HasMaxLength(500);
            entity.Property(e => e.Image).HasMaxLength(500);
            entity.Property(e => e.LocationKey).HasMaxLength(100);
            entity.Property(e => e.NameKey).HasMaxLength(100);
            entity.Property(e => e.StatusKey).HasMaxLength(100);
            entity.Property(e => e.StyleKey).HasMaxLength(100);
            entity.Property(e => e.TypeKey).HasMaxLength(100);
            entity.Property(e => e.YearKey).HasMaxLength(10);
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.ToTable("Properties", "olzhassovetbekov_user");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RClient>(entity =>
        {
            entity.ToTable("R_Clients");
        });

        modelBuilder.Entity<RRoom>(entity =>
        {
            entity.ToTable("R_Rooms");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RTeam>(entity =>
        {
            entity.ToTable("R_Teams");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.ToTable("Reviews", "anzhelina");
        });

        modelBuilder.Entity<Review1>(entity =>
        {
            entity.ToTable("Reviews", "rustembek_user");

            entity.HasIndex(e => e.RoomId, "IX_Reviews_RoomId");

            entity.HasIndex(e => e.UserId, "IX_Reviews_UserId");

            entity.Property(e => e.Text).HasMaxLength(500);

            entity.HasOne(d => d.Room).WithMany(p => p.Review1s).HasForeignKey(d => d.RoomId);

            entity.HasOne(d => d.User).WithMany(p => p.Review1s).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Room1>(entity =>
        {
            entity.ToTable("Rooms", "rustembek_user");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ScheduleItem>(entity =>
        {
            entity.ToTable("ScheduleItems", "ismailov_user");

            entity.HasIndex(e => e.FitnessClassId, "IX_ScheduleItems_FitnessClassId");

            entity.HasIndex(e => e.TrainerId, "IX_ScheduleItems_TrainerId");

            entity.HasOne(d => d.FitnessClass).WithMany(p => p.ScheduleItems)
                .HasForeignKey(d => d.FitnessClassId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Trainer).WithMany(p => p.ScheduleItems).HasForeignKey(d => d.TrainerId);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Services", "amanbayev_user");
        });

        modelBuilder.Entity<Service1>(entity =>
        {
            entity.ToTable("Services", "jomartov_user");

            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Icon).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<Service2>(entity =>
        {
            entity.ToTable("Services", "mushypharmacy_user");
        });

        modelBuilder.Entity<Service3>(entity =>
        {
            entity.ToTable("Services", "yefimenko_user");

            entity.HasIndex(e => e.ServiceCategoryId, "IX_Services_ServiceCategoryId");

            entity.Property(e => e.DescriptionShort).HasMaxLength(3000);
            entity.Property(e => e.Photo).HasMaxLength(300);
            entity.Property(e => e.Title).HasMaxLength(200);

            entity.HasOne(d => d.ServiceCategory).WithMany(p => p.Service3s).HasForeignKey(d => d.ServiceCategoryId);
        });

        modelBuilder.Entity<ServiceCategory>(entity =>
        {
            entity.ToTable("ServiceCategories", "yefimenko_user");

            entity.Property(e => e.Title).HasMaxLength(200);
        });

        modelBuilder.Entity<ServicesDbfirst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("services_dbfirst_pkey");

            entity.ToTable("services_dbfirst", "mushypharmacy_user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate).HasColumnName("create_date");
            entity.Property(e => e.FullDesc).HasColumnName("full_desc");
            entity.Property(e => e.IconClass)
                .HasMaxLength(100)
                .HasColumnName("icon_class");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(300)
                .HasColumnName("short_desc");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Students", "shamilova_user");

            entity.Property(e => e.Department).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Subscriber>(entity =>
        {
            entity.ToTable("Subscribers", "anzhelina");

            entity.HasIndex(e => e.Email, "IX_Subscribers_Email").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(256);
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.ToTable("Subscriptions", "ismailov_user");

            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.ToTable("Team");
        });

        modelBuilder.Entity<Team1>(entity =>
        {
            entity.ToTable("Teams");
        });

        modelBuilder.Entity<Team2>(entity =>
        {
            entity.ToTable("Teams", "jomartov_user");

            entity.Property(e => e.FacebookUrl).HasMaxLength(200);
            entity.Property(e => e.ImagePath).HasMaxLength(200);
            entity.Property(e => e.LinkedInUrl).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.TwitterUrl).HasMaxLength(200);
        });

        modelBuilder.Entity<TourOffer>(entity =>
        {
            entity.ToTable("tourOffers", "nazarov_ftp");

            entity.Property(e => e.Heading).HasColumnName("heading");
        });

        modelBuilder.Entity<Trainer>(entity =>
        {
            entity.ToTable("Trainers", "ismailov_user");

            entity.Property(e => e.Bio).HasMaxLength(2000);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Specialization).HasMaxLength(500);
        });

        modelBuilder.Entity<Translation>(entity =>
        {
            entity.ToTable("Translations", "gunkin_denis_user");

            entity.HasIndex(e => new { e.Key, e.Culture, e.Scope }, "IX_Translations_Key_Culture_Scope");

            entity.Property(e => e.Culture).HasMaxLength(10);
            entity.Property(e => e.Key).HasMaxLength(150);
            entity.Property(e => e.Scope).HasMaxLength(100);
            entity.Property(e => e.Value).HasMaxLength(2000);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07009050E8");

            entity.ToTable("Users", "amanbayev_user");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.ToTable("Users", "gunkin_denis_user");

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<User2>(entity =>
        {
            entity.ToTable("Users", "Ibrakhim_user");

            entity.Property(e => e.Username).HasMaxLength(13);
        });

        modelBuilder.Entity<User3>(entity =>
        {
            entity.ToTable("Users", "jomartov_user");

            entity.HasIndex(e => e.Email, "IX_Users_Email").IsUnique();

            entity.HasIndex(e => e.Username, "IX_Users_Username").IsUnique();

            entity.Property(e => e.Role).HasMaxLength(20);
        });

        modelBuilder.Entity<User4>(entity =>
        {
            entity.ToTable("Users", "mixer_user");

            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<User5>(entity =>
        {
            entity.ToTable("Users", "rashid_user");

            entity.HasIndex(e => e.Email, "IX_Users_Email").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
        });

        modelBuilder.Entity<User6>(entity =>
        {
            entity.ToTable("Users", "rustembek_user");

            entity.Property(e => e.Role).HasDefaultValue("");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.ToTable("UserInfo", "nazarov_ftp");

            entity.Property(e => e.ConfirmPassword).HasMaxLength(16);
            entity.Property(e => e.Email).HasMaxLength(150);
            entity.Property(e => e.IsAgree).HasColumnName("isAgree");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Password).HasMaxLength(16);
        });

        modelBuilder.Entity<Users1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users_1__3214EC07E1D72EFE");

            entity.ToTable("Users_1", "amanbayev_user");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<UsersAEA>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users_A___3214EC07E0D85B14");

            entity.ToTable("Users_A_E_A", "amanbayev_user");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.ToTable("Wallets", "Ibrakhim_user");

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
