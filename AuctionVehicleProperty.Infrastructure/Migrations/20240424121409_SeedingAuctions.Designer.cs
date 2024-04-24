﻿// <auto-generated />
using System;
using AuctionVehicleProperty.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuctionVehicleProperty.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240424121409_SeedingAuctions")]
    partial class SeedingAuctions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Agent identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Agent's Email");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasComment("Agent's Location");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User Identifier");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "yuliusap@pertoys.shop",
                            IsAdmin = true,
                            Location = "San Jose 3118 Thunder Road",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new
                        {
                            Id = 1,
                            Email = "Kolio@gmail.com",
                            IsAdmin = false,
                            Location = "",
                            UserId = "e43ce836-997d-4927-ac59-74e8c41bbfd3"
                        });
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
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

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bd207847-e022-4786-9772-bc5ccc99b18d",
                            Email = "agent@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Agent",
                            LastName = "Agentov",
                            LockoutEnabled = false,
                            NormalizedEmail = "agent@mail.com",
                            NormalizedUserName = "agent@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFIu2SUiaP0jKYk5RgKtHZ/Ha7V9HPkJ8QpoXqVDnsQ3KxM8TIdxhPVUVnF2knU41A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e27a609c-54ad-48eb-8e2d-5d72ba057088",
                            TwoFactorEnabled = false,
                            UserName = "agent@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f30a0b7-67f5-43b2-8fb8-de7e7b096c79",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "Guestov",
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELfp9cXyd5HC3DzwZ8MPVMNqqIq2EBvrELBbT108uktzIYVQ0K45Nv9RP9Co7nzy+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2bf4a022-16d8-45be-98cb-168b1e41dc40",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591s",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a848bd4a-97ae-46ea-b094-333005a2fc57",
                            Email = "Secondguest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "Secondguest@mail.com",
                            NormalizedUserName = "Secondguest@mail.com",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "09f62c49-8638-4331-982f-1da388aabd25",
                            TwoFactorEnabled = false,
                            UserName = "Secondguest@mail.com"
                        },
                        new
                        {
                            Id = "e43ce836-997d-4927-ac59-74e8c41bbfd3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "491ca45b-b7a6-42b6-b06a-62d91ffb40b0",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Great",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL2nGgS7MmWkJGTh9O+umsg+S0KJe4wyTc3kcsT0LVJtb3I90W4vhpianjW1in7Ntw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a6b3db6b-42dc-4052-8ada-68a3152bba2c",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Auction Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatorId")
                        .HasColumnType("int")
                        .HasComment("Creator agent Identyfier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2")
                        .HasComment("Ending Time");

                    b.Property<decimal>("MinimumBidIncrement")
                        .HasColumnType("decimal(12,2)")
                        .HasComment("Auction Min bid incrementing");

                    b.Property<decimal>("StartingPrice")
                        .HasColumnType("decimal(12,2)")
                        .HasComment("Starting price for auction");

                    b.Property<DateTime>("StartingTime")
                        .HasColumnType("datetime2")
                        .HasComment("Starting Time");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int")
                        .HasComment("Vehicle Identyfier");

                    b.Property<int?>("WinnerIdAgent")
                        .HasColumnType("int")
                        .HasComment("Winner agent Identyfier");

                    b.Property<string>("WinnerIdUser")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Winner user Identyfier");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Auctions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatorId = 1,
                            EndTime = new DateTime(2024, 4, 28, 18, 30, 0, 0, DateTimeKind.Unspecified),
                            MinimumBidIncrement = 500.00m,
                            StartingPrice = 25000.00m,
                            StartingTime = new DateTime(2024, 4, 28, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            VehicleId = 1
                        });
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Bid", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgentId")
                        .HasColumnType("int")
                        .HasComment("Agent Identifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(12,2)")
                        .HasComment("Bid Amount");

                    b.Property<int>("AuctionId")
                        .HasColumnType("int")
                        .HasComment("Auction identifier");

                    b.Property<DateTime>("BidTime")
                        .HasColumnType("datetime2")
                        .HasComment("Bid Date and Time");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("AuctionId");

                    b.ToTable("Bids");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgentId = 1,
                            Amount = 26000.00m,
                            AuctionId = 1,
                            BidTime = new DateTime(2024, 4, 25, 12, 42, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AgentId = 2,
                            Amount = 27000.00m,
                            AuctionId = 1,
                            BidTime = new DateTime(2024, 4, 25, 12, 43, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("VehicleType Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("VehicleType Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sport utility vehicle (SUV)"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Coupe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pickup Truck"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Convertible"
                        });
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Vehicle Identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<int?>("AverageDivingRange")
                        .HasColumnType("int")
                        .HasComment("If is electric range of driving in kilometers");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Vehicle Collor");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Vehicle Details");

                    b.Property<string>("ImageUrls")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Vehicle Images");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Location of the Vehicle");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Vehicle Make");

                    b.Property<int>("Mileage")
                        .HasColumnType("int")
                        .HasComment("Vehicle Milage in kilometers");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)")
                        .HasComment("Vehicle Model");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int")
                        .HasComment("Vehicle Power in horse power or in Kw");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Vehicle Price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Vehicle Title");

                    b.Property<int>("VehicleTypeId")
                        .HasColumnType("int")
                        .HasComment("VehicleType Identyfier");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2")
                        .HasComment("Vehicle year of production");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("VehicleTypeId");

                    b.ToTable("Vehicles");

                    b.HasComment("Vehicle to sell or buy in auction");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageDivingRange = 330,
                            Color = "Yellow",
                            Details = "Fuel Type: Electricity, Acceleration: 0 - 100 km/h: 8 sec, Maximum speed: 150 km/h (93.21 mph), Weight-to-power ratio: 9.7 kg/Hp, 103.4 Hp/tonne, Weight-to-torque ratio: 5.9 kg/Nm, 169 Nm",
                            ImageUrls = "https://www.auto-data.net/images/f46/Renault-5-E-Tech_1.jpg",
                            Location = "3118 Thunder Road, San Jose, CA, 95134",
                            Make = "Renault",
                            Mileage = 0,
                            Model = "5 E-Tech",
                            OwnerId = 1,
                            Power = 150,
                            Price = 32000.00m,
                            Title = "2024 Renault 5 E-Tech 52 kWh (150 hp) Electric",
                            VehicleTypeId = 3,
                            Year = new DateTime(2024, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AverageDivingRange = 209,
                            Color = "Green",
                            Details = "This is the electric version of Peugeot’s 208 supermini. It looks very much like the combustion-engined alternative: this isn’t a car for anyone who wants to show off their zero-emission, planet-saving credentials.",
                            ImageUrls = "https://ev-database.org/img/auto/Peugeot_e-208_2024/Peugeot_e-208_2024-01.jpg",
                            Location = "679 Grandrose Rd.,Somerset, NJ 08873",
                            Make = "Peugeot",
                            Mileage = 0,
                            Model = "e-208",
                            OwnerId = 1,
                            Power = 130,
                            Price = 73000.00m,
                            Title = "Peugeot e-208 50 kWh",
                            VehicleTypeId = 3,
                            Year = new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AverageDivingRange = 350,
                            Color = "Red",
                            Details = "The model shown on this page is the successor of the Ford Mustang Mach-E ER AWD, which was available to order from April 2022 until November 2022. The previous model had 40 km less range, 17% faster acceleration and was 9% less energy efficient.",
                            ImageUrls = "https://ev-database.org/img/auto/Ford_Mustang_Mach-E/Ford_Mustang_Mach-E-01.jpg",
                            Location = "44 Willow Street, Piqua, OH 45356",
                            Make = "Ford ",
                            Mileage = 10000,
                            Model = " Mustang Mach-E",
                            OwnerId = 1,
                            Power = 280,
                            Price = 122000.00m,
                            Title = "Ford Mustang Mach-E ER RWD",
                            VehicleTypeId = 1,
                            Year = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", "User")
                        .WithOne("Agent")
                        .HasForeignKey("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Auction", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Bid", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Auction", "Auction")
                        .WithMany("Bids")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Agent");

                    b.Navigation("Auction");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Vehicle", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", null)
                        .WithMany("Vehicles")
                        .HasForeignKey("AgentId");

                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.Category", "VehicleType")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("VehicleType");
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
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", null)
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

                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Agent", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.AppUser", b =>
                {
                    b.Navigation("Agent");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Auction", b =>
                {
                    b.Navigation("Bids");
                });

            modelBuilder.Entity("AuctionVehicleProperty.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
