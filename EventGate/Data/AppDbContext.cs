using EventGate.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EventGate.Data
{
    public class AppDbContext : IdentityDbContext<User>, IAppDbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DatabaseFacade DatabaseFacade => Database;

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<EventFeedback> EventFeedbacks { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<SponsorshipContribution> SponsorshipContributions { get; set; }
        public DbSet<SponsorshipType> SponsorshipTypes { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<EventClub> EventClubs { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventRule> EventRules { get; set; }
        public DbSet<EventFinancials> EventFinancials { get; set; }
        public DbSet<PaymentsInfo> PaymentsInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_configuration == null)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"),
                    options => options.EnableRetryOnFailure());
            }
            else
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"),
                    options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Role)
            //    .WithMany(r => r.Users)
            //    .HasForeignKey(u => u.RoleID);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Ticket)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(od => od.TicketID);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Event)
                .WithMany(e => e.Tickets)
                .HasForeignKey(t => t.EventID);

            modelBuilder.Entity<EventFeedback>()
                .HasOne(ef => ef.User)
                .WithMany(u => u.EventFeedbacks)
                .HasForeignKey(ef => ef.UserID);

            modelBuilder.Entity<EventFeedback>()
                .HasOne(ef => ef.Event)
                .WithMany(e => e.EventFeedbacks)
                .HasForeignKey(ef => ef.EventID);

            modelBuilder.Entity<Blog>()
                .HasOne(b => b.Author) 
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.AuthorID);

            modelBuilder.Entity<Sponsor>()
                .HasOne(s => s.ContactPerson)
                .WithMany()
                .HasForeignKey(s => s.ContactPersonID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SponsorshipContribution>()
                .HasOne(sc => sc.Sponsor)
                .WithMany(s => s.SponsorshipContributions)
                .HasForeignKey(sc => sc.SponsorID);

            modelBuilder.Entity<SponsorshipContribution>()
                .HasOne(sc => sc.Event)
                .WithMany(e => e.SponsorshipContributions)
                .HasForeignKey(sc => sc.EventID);

            modelBuilder.Entity<SponsorshipContribution>()
                .HasOne(sc => sc.SponsorshipType)
                .WithMany(st => st.SponsorshipContributions)
                .HasForeignKey(sc => sc.TypeID);

            modelBuilder.Entity<Club>()
                .HasOne(c => c.President)
                .WithMany()
                .HasForeignKey(c => c.PresidentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventClub>()
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventClubs)
                .HasForeignKey(ec => ec.EventID);

            modelBuilder.Entity<EventClub>()
                .HasOne(ec => ec.Club)
                .WithMany(c => c.EventClubs)
                .HasForeignKey(ec => ec.ClubID);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(et => et.Events)
                .HasForeignKey(e => e.EventTypeID);

            modelBuilder.Entity<EventRule>()
                .HasOne(er => er.EventType)
                .WithMany(et => et.EventRules) 
                .HasForeignKey(er => er.EventTypeID);

            modelBuilder.Entity<EventFinancials>()
                .HasOne(ef => ef.Event)
                .WithOne(e => e.EventFinancials)
                .HasForeignKey<EventFinancials>(ef => ef.EventID);

            modelBuilder.Entity<PaymentsInfo>()
                .HasOne(pi => pi.Event)
                .WithOne(e => e.PaymentsInfo)
                .HasForeignKey<PaymentsInfo>(pi => pi.EventID);
        }

        public EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }
    }
}
