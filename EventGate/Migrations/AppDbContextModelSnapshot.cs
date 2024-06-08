﻿// <auto-generated />
using System;
using EventGate.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventGate.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventGate.Data.Entity.Blog", b =>
                {
                    b.Property<string>("BlogID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.HasIndex("AuthorID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Club", b =>
                {
                    b.Property<string>("ClubID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoClub")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresidentID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ClubID");

                    b.HasIndex("PresidentID");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Event", b =>
                {
                    b.Property<string>("EventID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketQuantity")
                        .HasColumnType("int");

                    b.HasKey("EventID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventClub", b =>
                {
                    b.Property<string>("EventClubID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClubID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventClubID");

                    b.HasIndex("ClubID");

                    b.HasIndex("EventID");

                    b.ToTable("EventClubs");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventFeedback", b =>
                {
                    b.Property<string>("EventFeedbackID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventFeedbackID");

                    b.HasIndex("EventID");

                    b.HasIndex("UserID");

                    b.ToTable("EventFeedbacks");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventFinancials", b =>
                {
                    b.Property<string>("EventFinID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("NetRevenue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ServiceFeeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ServiceFeePercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalRevenue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EventFinID");

                    b.HasIndex("EventID")
                        .IsUnique();

                    b.ToTable("EventFinancials");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventRule", b =>
                {
                    b.Property<string>("EventRuleID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventTypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RuleContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventRuleID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("EventRules");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventType", b =>
                {
                    b.Property<string>("EventTypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TypeEventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventTypeID");

                    b.ToTable("EventTypes");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Order", b =>
                {
                    b.Property<string>("OrderID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EventGate.Data.Entity.OrderDetail", b =>
                {
                    b.Property<string>("OrderDetailID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrderID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("TicketID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("TicketID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EventGate.Data.Entity.PaymentsInfo", b =>
                {
                    b.Property<string>("PaymentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PaymentID");

                    b.HasIndex("EventID")
                        .IsUnique();

                    b.ToTable("PaymentsInfos");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Sponsor", b =>
                {
                    b.Property<string>("SponsorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPersonID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SponsorID");

                    b.HasIndex("ContactPersonID");

                    b.ToTable("Sponsors");
                });

            modelBuilder.Entity("EventGate.Data.Entity.SponsorshipContribution", b =>
                {
                    b.Property<string>("ContributionID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("AmountSponsored")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ContributionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SponsorID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TypeID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ContributionID");

                    b.HasIndex("EventID");

                    b.HasIndex("SponsorID");

                    b.HasIndex("TypeID");

                    b.ToTable("SponsorshipContributions");
                });

            modelBuilder.Entity("EventGate.Data.Entity.SponsorshipType", b =>
                {
                    b.Property<string>("TypeID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeID");

                    b.ToTable("SponsorshipTypes");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Ticket", b =>
                {
                    b.Property<string>("TicketID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketID");

                    b.HasIndex("EventID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("EventGate.Data.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("IdentityCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EventGate.Data.Entity.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Blog", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", "Author")
                        .WithMany("Blogs")
                        .HasForeignKey("AuthorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Club", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", "President")
                        .WithMany()
                        .HasForeignKey("PresidentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("President");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Event", b =>
                {
                    b.HasOne("EventGate.Data.Entity.EventType", "EventType")
                        .WithMany("Events")
                        .HasForeignKey("EventTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventClub", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Club", "Club")
                        .WithMany("EventClubs")
                        .HasForeignKey("ClubID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithMany("EventClubs")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Club");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventFeedback", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithMany("EventFeedbacks")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventGate.Data.Entity.User", "User")
                        .WithMany("EventFeedbacks")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventFinancials", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithOne("EventFinancials")
                        .HasForeignKey("EventGate.Data.Entity.EventFinancials", "EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventRule", b =>
                {
                    b.HasOne("EventGate.Data.Entity.EventType", "EventType")
                        .WithMany("EventRules")
                        .HasForeignKey("EventTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventType");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Order", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EventGate.Data.Entity.OrderDetail", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventGate.Data.Entity.Ticket", "Ticket")
                        .WithMany("OrderDetails")
                        .HasForeignKey("TicketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("EventGate.Data.Entity.PaymentsInfo", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithOne("PaymentsInfo")
                        .HasForeignKey("EventGate.Data.Entity.PaymentsInfo", "EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Sponsor", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", "ContactPerson")
                        .WithMany()
                        .HasForeignKey("ContactPersonID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ContactPerson");
                });

            modelBuilder.Entity("EventGate.Data.Entity.SponsorshipContribution", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithMany("SponsorshipContributions")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventGate.Data.Entity.Sponsor", "Sponsor")
                        .WithMany("SponsorshipContributions")
                        .HasForeignKey("SponsorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EventGate.Data.Entity.SponsorshipType", "SponsorshipType")
                        .WithMany("SponsorshipContributions")
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Sponsor");

                    b.Navigation("SponsorshipType");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Ticket", b =>
                {
                    b.HasOne("EventGate.Data.Entity.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
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
                    b.HasOne("EventGate.Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", null)
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

                    b.HasOne("EventGate.Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EventGate.Data.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EventGate.Data.Entity.Club", b =>
                {
                    b.Navigation("EventClubs");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Event", b =>
                {
                    b.Navigation("EventClubs");

                    b.Navigation("EventFeedbacks");

                    b.Navigation("EventFinancials")
                        .IsRequired();

                    b.Navigation("PaymentsInfo")
                        .IsRequired();

                    b.Navigation("SponsorshipContributions");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("EventGate.Data.Entity.EventType", b =>
                {
                    b.Navigation("EventRules");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Sponsor", b =>
                {
                    b.Navigation("SponsorshipContributions");
                });

            modelBuilder.Entity("EventGate.Data.Entity.SponsorshipType", b =>
                {
                    b.Navigation("SponsorshipContributions");
                });

            modelBuilder.Entity("EventGate.Data.Entity.Ticket", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("EventGate.Data.Entity.User", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("EventFeedbacks");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
