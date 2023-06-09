﻿// <auto-generated />
using BookKeeping.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookKeeping.Migrations
{
    [DbContext(typeof(BookKeepingContext))]
    partial class BookKeepingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookKeeping.Entities.CostDynamic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CostName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CostValueJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearlyIncomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YearlyIncomeId");

                    b.ToTable("CostDynamics");
                });

            modelBuilder.Entity("BookKeeping.Entities.IncomeDynamic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IncomeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncomeValueJson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearlyIncomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YearlyIncomeId");

                    b.ToTable("IncomeDynamics");
                });

            modelBuilder.Entity("BookKeeping.Entities.MonthlyCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("YearlyIncomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YearlyIncomeId");

                    b.ToTable("MonthlyCosts");
                });

            modelBuilder.Entity("BookKeeping.Entities.MonthlyIncome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("YearlyIncomeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YearlyIncomeId");

                    b.ToTable("MonthlyIncomes");
                });

            modelBuilder.Entity("BookKeeping.Entities.YearlyIncome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("TotalIncome")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YearlyIncomes");
                });

            modelBuilder.Entity("BookKeeping.Entities.CostDynamic", b =>
                {
                    b.HasOne("BookKeeping.Entities.YearlyIncome", "YearlyIncome")
                        .WithMany("CostDynamics")
                        .HasForeignKey("YearlyIncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YearlyIncome");
                });

            modelBuilder.Entity("BookKeeping.Entities.IncomeDynamic", b =>
                {
                    b.HasOne("BookKeeping.Entities.YearlyIncome", "YearlyIncome")
                        .WithMany("IncomeDynamics")
                        .HasForeignKey("YearlyIncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YearlyIncome");
                });

            modelBuilder.Entity("BookKeeping.Entities.MonthlyCost", b =>
                {
                    b.HasOne("BookKeeping.Entities.YearlyIncome", "YearlyIncome")
                        .WithMany("MonthlyCosts")
                        .HasForeignKey("YearlyIncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YearlyIncome");
                });

            modelBuilder.Entity("BookKeeping.Entities.MonthlyIncome", b =>
                {
                    b.HasOne("BookKeeping.Entities.YearlyIncome", "YearlyIncome")
                        .WithMany("MonthlyIncomes")
                        .HasForeignKey("YearlyIncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YearlyIncome");
                });

            modelBuilder.Entity("BookKeeping.Entities.YearlyIncome", b =>
                {
                    b.Navigation("CostDynamics");

                    b.Navigation("IncomeDynamics");

                    b.Navigation("MonthlyCosts");

                    b.Navigation("MonthlyIncomes");
                });
#pragma warning restore 612, 618
        }
    }
}
