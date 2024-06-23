﻿// <auto-generated />
using System;
using ItKariera.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ItKariera.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ItKariera.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d13194c7-2b53-49cd-bd66-55de4f520ad7",
                            EmailConfirmed = false,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEMzeik3I7537IBEt9QaRNhVZ6FZ7DtK8nNkfriaRNjrFQRadUo5caK7huJKn3rE8Ew==",
                            PhoneNumberConfirmed = false,
                            ProfilePicture = "data:image/png;base64,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8H/6059eGPbzMP/85z8/fe973zucffz3d7zjHWfvmhf84x//uDSco4FcPfMzn/nM9NnPfnb64Ac/OL3xjW+cvvCFL0zvf//7pw9/+MOX/340rUUGwjwWaWMRAgggsJjAv//97+mrX/3q4Tv72USOTyCnTyTzmnmAf/zjHz88hcxD/3e/+93lU8C89u1vf/vip5B5/69//evpn//85+UTyE1nvu1tb5ve/e53T8+ePZu+9KUvHQxrNqnZ3H76059e3n/WQJjH4nqwEAEEEFhMYB7c85/Hjx8f/jkbyNEw5u/45+/yr/796stdx79/8YtfPBjN/Of4EtN8/jzsT580fvKTn0wf+tCHpu985zuX//22M+enm1/96lfTL37xi+mXv/zl4eWuqy9/3WkgzGNxLViIAAIILCYwv5Q0f2f/rW99a/rhD394zUCOTxzzF06fMq4+cczmMBvQVfN5z3vec+3lrXnvBz7wgcNdp++B3HXmb37zm+nHP/7xIca3vvWth/dDvva1r03f//73D4Zyq4Ewj8W1YCECCCCwisBxmM8vS931ktUaA5nXnr7hffoG+/zk8Nvf/vZgNFefIu4ykHnt/NTyqU99anrnO985/e1vfztvIMxjVS1YjAACCCwmMA/5eSh//etfP3ya6SYDWfsS1tVPcD158uTypazjey2f/OQnL9/HuPoEcnwJ7WhYx78fzeZHP/rR9Oqrr05///vfD+ceXxa79gTCPBbXgYUIIIDAagKnH5k93Xz8iOy3v/3tyzfGb3oT/fiS1dWnk/nv88CfP0E1v9z0iU984vA+yulTyel973rXuw7vbTx8+PDyZbCrZ56+ZPWGN7zh8J7I/LHiH/zgBwfze8FAmMfqWrABAQQQ2EXg6pvYWz/Ge/yI7vw08pa3vOXWj/hefQnrro8Gn76JP3+Mdzan+VNfx58TuTSQl19+eXr06NH04MGDyx8g2UXFZgQQQACBswRS/CDh0Tzm91SOL2dd/RTWMZBzP0h49YcTr/4g4fzS21/+8peDV7z22mvTxePHj5/Nr28xj7NaW4AAAggMT+D4atUrr7wyXTx8+PDZ/C8vvfTSNTAXFxeHHyY59yf1unP3Rfn60ryjxCsOBBBAIAWB//73v4c31v8HNc4BbFytUj0AAAAASUVORK5CYII=",
                            SecurityStamp = "4b140efd-52b7-4e9c-b2ef-32c871482f5d",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("ItKariera.Models.Barber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Barbers", (string)null);
                });

            modelBuilder.Entity("ItKariera.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BarberId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("BarberId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            ConcurrencyStamp = "341743f0-asd2–42de-afbf-59kmkkmk72cf6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                            RoleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ItKariera.Models.Review", b =>
                {
                    b.HasOne("ItKariera.Models.Barber", "Barber")
                        .WithMany()
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItKariera.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");

                    b.Navigation("User");
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
                    b.HasOne("ItKariera.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ItKariera.Models.ApplicationUser", null)
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

                    b.HasOne("ItKariera.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ItKariera.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
