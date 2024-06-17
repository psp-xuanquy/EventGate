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
        //IConfiguration _configuration;

        public AppDbContext()
        {

        }

        //public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
        //    : base(options)
        //{
        //    _configuration = configuration;
        //}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DatabaseFacade DatabaseFacade => base.Database;

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatHistory> ChatHistories { get; set; }
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventClub> EventClubs { get; set; }
        public DbSet<EventFeedback> EventFeedbacks { get; set; }
        public DbSet<EventHistory> EventHistories { get; set; }
        public DbSet<EventRule> EventRules { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentsInfo> PaymentsInfos { get; set; }
        public DbSet<Point> Points { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }
        public DbSet<UserEventHistory> UserEventHistories { get; set; }
        public DbSet<UserHistory> UserHistories { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var configuration = _configuration ?? throw new InvalidOperationException("Configuration is null.");
        //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"), 
        //            options => options.EnableRetryOnFailure());
        //    }
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            modelBuilder.Entity<Club>()
                .HasOne(c => c.President)
                .WithMany()
                .HasForeignKey(c => c.PresidentID);

            modelBuilder.Entity<EventClub>()
                .HasKey(ec => new { ec.EventID, ec.ClubID });

            modelBuilder.Entity<EventClub>()
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventClubs)
                .HasForeignKey(ec => ec.EventID);

            modelBuilder.Entity<EventClub>()
                .HasOne(ec => ec.Club)
                .WithMany(c => c.EventClubs)
                .HasForeignKey(ec => ec.ClubID);

            modelBuilder.Entity<UserEvent>()
                .HasKey(ue => new { ue.UserID, ue.EventID });

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.User)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(ue => ue.UserID);

            modelBuilder.Entity<UserEvent>()
                .HasOne(ue => ue.Event)
                .WithMany(e => e.UserEvents)
                .HasForeignKey(ue => ue.EventID);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.EventType)
                .WithMany(et => et.Events)
                .HasForeignKey(e => e.EventTypeID);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.PaymentsInfo)
                .WithOne(pi => pi.Event)
                .HasForeignKey<PaymentsInfo>(pi => pi.EventID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Tickets)
                .WithOne(t => t.Event)
                .HasForeignKey(t => t.EventID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventFeedbacks)
                .WithOne(ef => ef.Event)
                .HasForeignKey(ef => ef.EventID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventClubs)
                .WithOne(ec => ec.Event)
                .HasForeignKey(ec => ec.EventID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Blogs)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.ChatHistories)
                .WithOne(ch => ch.Sender)
                .HasForeignKey(ch => ch.SenderID);

            modelBuilder.Entity<ChatHistory>()
                .HasOne(ch => ch.Chat)
                .WithMany(c => c.ChatHistories)
                .HasForeignKey(ch => ch.ChatID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ChatHistory>()
                .HasOne(ch => ch.Sender)
                .WithMany()
                .HasForeignKey(ch => ch.SenderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChatHistory>()
                .HasOne(ch => ch.Receiver)
                .WithMany()
                .HasForeignKey(ch => ch.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Sender)
                .WithMany()
                .HasForeignKey(c => c.SenderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Receiver)
                .WithMany()
                .HasForeignKey(c => c.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserEvents)
                .WithOne(ue => ue.User)
                .HasForeignKey(ue => ue.UserID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Ticket)
                .WithMany()
                .HasForeignKey(od => od.TicketID);

            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserID);

            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Event)
                .WithMany()
                .HasForeignKey(v => v.EventID);

            modelBuilder.Entity<EventHistory>()
                .HasOne(eh => eh.EventType)
                .WithMany(et => et.EventHistories)
                .HasForeignKey(eh => eh.EventTypeID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EventHistory>()
                .HasOne(eh => eh.Event)
                .WithMany(e => e.EventHistories)
                .HasForeignKey(eh => eh.EventID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<EventRule>()
                .HasOne(er => er.EventType)
                .WithMany(et => et.EventRules)
                .HasForeignKey(er => er.EventTypeID);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new ApplicationException("Error saving changes.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Unexpected error occurred.", ex);
            }
        }


        public EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }
    }
}
