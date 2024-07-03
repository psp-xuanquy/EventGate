using EventGate.Data.Entities;
using EventGate.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace EventGate.Data
{
    public class AppDbContext : IdentityDbContext<User>, IAppDbContext
    {
        public AppDbContext()
        {
        }

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
        public DbSet<UserChatRoom> UserChatRooms { get; set; }
        public DbSet<ChatReceiver> ChatReceivers { get; set; }

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
                .HasOne(ec => ec.Event)
                .WithMany(e => e.EventClubs)
                .HasForeignKey(ec => ec.EventID);

            modelBuilder.Entity<EventClub>()
                .HasOne(ec => ec.Club)
                .WithMany(c => c.EventClubs)
                .HasForeignKey(ec => ec.ClubID);

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

            modelBuilder.Entity<EventFeedback>()
                .HasOne(ef => ef.User)
                .WithMany(u => u.EventFeedbacks)
                .HasForeignKey(ef => ef.UserID);

            modelBuilder.Entity<EventFeedback>()
                .HasOne(ef => ef.Event)
                .WithMany(e => e.EventFeedbacks)
                .HasForeignKey(ef => ef.EventID);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.EventClubs)
                .WithOne(ec => ec.Event)
                .HasForeignKey(ec => ec.EventID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Blogs)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorID);

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.ChatHistories)
            //    .WithOne(ch => ch.Sender)
            //    .HasForeignKey(ch => ch.SenderID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserChatRooms)
                .WithOne(ucr => ucr.User)
                .HasForeignKey(ucr => ucr.UserID);

            modelBuilder.Entity<User>()
                .HasMany(u => u.UserEvents)
                .WithOne(ue => ue.User)
                .HasForeignKey(ue => ue.UserID);

            modelBuilder.Entity<ChatRoom>()
                .HasMany(cr => cr.UserChatRooms)
                .WithOne(ucr => ucr.ChatRoom)
                .HasForeignKey(ucr => ucr.ChatRoomID);

            //modelBuilder.Entity<ChatHistory>()
            //    .HasOne(ch => ch.Sender)
            //    .WithMany()
            //    .HasForeignKey(ch => ch.SenderID)
            //    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Sender)
                .WithMany()
                .HasForeignKey(c => c.SenderID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chat>()
                .HasMany(c => c.ChatReceivers)
                .WithOne(cr => cr.Chat)
                .HasForeignKey(cr => cr.ChatID);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserID);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.ChatRoom)
                .WithMany(cr => cr.Chats)
                .HasForeignKey(c => c.ChatRoomID);

            modelBuilder.Entity<UserChatRoom>()
                .HasOne(ucr => ucr.User)
                .WithMany(u => u.UserChatRooms)
                .HasForeignKey(ucr => ucr.UserID);

            modelBuilder.Entity<UserChatRoom>()
                .HasOne(ucr => ucr.ChatRoom)
                .WithMany(cr => cr.UserChatRooms)
                .HasForeignKey(ucr => ucr.ChatRoomID);

            modelBuilder.Entity<ChatReceiver>()
                .HasOne(cr => cr.Chat)
                .WithMany(c => c.ChatReceivers)
                .HasForeignKey(cr => cr.ChatID);

            modelBuilder.Entity<ChatReceiver>()
                .HasOne(cr => cr.Receiver)
                .WithMany()
                .HasForeignKey(cr => cr.ReceiverID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderID);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Ticket)
                .WithMany(t => t.OrderDetails)
                .HasForeignKey(od => od.TicketID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Event)
                .WithMany(e => e.Vouchers)
                .HasForeignKey(v => v.EventID);

            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserID)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<EventHistory>()
            //    .HasMany(eh => eh.UserEventHistories)
            //    .WithOne()
            //    .HasForeignKey(ueh => ueh.EventHistoryID);

            modelBuilder.Entity<EventRule>()
                .HasOne(er => er.EventType)
                .WithMany(et => et.EventRules)
                .HasForeignKey(er => er.EventTypeID);

            modelBuilder.Entity<Seat>().HasData(GenerateSeats());

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

        private Seat[] GenerateSeats()
        {
            var seats = new List<Seat>();
            var halls = new[] { "Alpha", "Beta", "Ceasar" };
            var rows = new[] { "A", "B", "C", "D", "E" };

            foreach (var hall in halls)
            {
                foreach (var row in rows)
                {
                    for (int number = 1; number <= 6; number++)
                    {
                        seats.Add(new Seat
                        {
                            SeatID = Guid.NewGuid().ToString(),
                            Hall = hall,
                            Row = row,
                            Number = number,
                            IsAvailable = true,
                            CreatedBy = "System",
                            LastUpdatedBy = "System",
                            LastUpdatedTime = DateTime.Now
                        });
                    }
                }
            }

            return seats.ToArray();
        }

        public EntityEntry Add(object entity)
        {
            return base.Add(entity);
        }
    }
}
