﻿// <auto-generated />
using System;
using Bakcend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bakcend.Migrations
{
    [DbContext(typeof(WebshopContext))]
    partial class WebshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_general_ci")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("Aspnetuserrole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");

                    b.ToTable("aspnetuserroles", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetrole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "NormalizedName" }, "RoleNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetroles", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetroleclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "RoleId" }, "IX_AspNetRoleClaims_RoleId");

                    b.ToTable("aspnetroleclaims", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int(11)");

                    b.Property<int>("Age")
                        .HasColumnType("int(11)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LockoutEnd")
                        .HasMaxLength(6)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "NormalizedEmail" }, "EmailIndex");

                    b.HasIndex(new[] { "NormalizedUserName" }, "UserNameIndex")
                        .IsUnique();

                    b.ToTable("aspnetusers", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuserclaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserClaims_UserId");

                    b.ToTable("aspnetuserclaims", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuserlogin", b =>
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

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "UserId" }, "IX_AspNetUserLogins_UserId");

                    b.ToTable("aspnetuserlogins", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetusertoken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                    b.ToTable("aspnetusertokens", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Efmigrationshistory", b =>
                {
                    b.Property<string>("MigrationId")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("ProductVersion")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("MigrationId")
                        .HasName("PRIMARY");

                    b.ToTable("__efmigrationshistory", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<int>("Price")
                        .HasColumnType("int(50)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int(11)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int(110)");

                    b.Property<string>("SerialName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "UserId");

                    b.ToTable("merchant", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Passwordresetrequest", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UpdatesPassword")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.ToTable("passwordresetrequest", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<int>("Price")
                        .HasColumnType("int(100)");

                    b.Property<string>("SerialName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<string>("AspnetuserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BillingName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BillingPostalCode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("current_timestamp()");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex("AspnetuserId");

                    b.HasIndex(new[] { "UserId" }, "UserId")
                        .HasDatabaseName("UserId1");

                    b.ToTable("purchase", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<int>("Existing")
                        .HasColumnType("int(20)");

                    b.Property<int>("Sold")
                        .HasColumnType("int(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("storage", (string)null);
                });

            modelBuilder.Entity("Bakcend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)");

                    b.Property<DateOnly?>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int(20)");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Aspnetuserrole", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetrole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                    b.HasOne("Bakcend.Models.Aspnetuser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetroleclaim", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetrole", "Role")
                        .WithMany("Aspnetroleclaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuserclaim", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetuser", "User")
                        .WithMany("Aspnetuserclaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuserlogin", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetuser", "User")
                        .WithMany("Aspnetuserlogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetusertoken", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetuser", "User")
                        .WithMany("Aspnetusertokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bakcend.Models.Merchant", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetuser", "User")
                        .WithMany("Merchants")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("merchant_ibfk_1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bakcend.Models.Purchase", b =>
                {
                    b.HasOne("Bakcend.Models.Aspnetuser", null)
                        .WithMany("Purchases")
                        .HasForeignKey("AspnetuserId");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetrole", b =>
                {
                    b.Navigation("Aspnetroleclaims");
                });

            modelBuilder.Entity("Bakcend.Models.Aspnetuser", b =>
                {
                    b.Navigation("Aspnetuserclaims");

                    b.Navigation("Aspnetuserlogins");

                    b.Navigation("Aspnetusertokens");

                    b.Navigation("Merchants");

                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
