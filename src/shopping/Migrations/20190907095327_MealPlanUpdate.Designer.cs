﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shopping.Data;

namespace Shopping.Migrations
{
    [DbContext(typeof(ShoppingDataContext))]
    [Migration("20190907095327_MealPlanUpdate")]
    partial class MealPlanUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shopping.Models.AllergieFoodItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("FoodItemId")
                        .HasColumnName("FoodItemID");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId")
                        .HasName("fkIdx_121");

                    b.HasIndex("UserId")
                        .HasName("fkIdx_118");

                    b.ToTable("AllergieFoodItem");
                });

            modelBuilder.Entity("Shopping.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shopping.Models.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("FoodItem");
                });

            modelBuilder.Entity("Shopping.Models.MealPlan", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Filters");

                    b.Property<string>("ImageUri");

                    b.Property<string>("Name");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .HasName("fkIdx_102");

                    b.ToTable("MealPlan");
                });

            modelBuilder.Entity("Shopping.Models.MealPlanRecipe", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("MealPlanId")
                        .HasColumnName("MealPlanID");

                    b.Property<int>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanId")
                        .HasName("fkIdx_109");

                    b.HasIndex("RecipeId")
                        .HasName("fkIdx_112");

                    b.ToTable("MealPLanRecipe");
                });

            modelBuilder.Entity("Shopping.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .HasName("fkIdx_20");

                    b.ToTable("Pantry");
                });

            modelBuilder.Entity("Shopping.Models.PantryItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("FoodItemId")
                        .HasColumnName("FoodItemID");

                    b.Property<int>("PantryId")
                        .HasColumnName("PantryID");

                    b.Property<int>("Qty");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId")
                        .HasName("fkIdx_71");

                    b.HasIndex("PantryId")
                        .HasName("fkIdx_68");

                    b.ToTable("PantryItem");
                });

            modelBuilder.Entity("Shopping.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<double>("CarbsSugar");

                    b.Property<double>("CarbsTotal");

                    b.Property<int>("CookTime");

                    b.Property<byte[]>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Energy");

                    b.Property<double>("FatTotal");

                    b.Property<double>("Fibre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("NumIngredients");

                    b.Property<int>("PreperationTime");

                    b.Property<double>("Protein");

                    b.Property<int>("RecipeCategoryId")
                        .HasColumnName("RecipeCategoryID");

                    b.Property<double>("SaturatedFat");

                    b.Property<int>("Servings");

                    b.Property<double>("Sodium");

                    b.HasKey("Id");

                    b.HasIndex("RecipeCategoryId")
                        .HasName("fkIdx_44");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Shopping.Models.RecipeItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("FoodItemId")
                        .HasColumnName("FoodItemID");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PantryItemId")
                        .HasColumnName("PantryItemID");

                    b.Property<int>("Qty");

                    b.Property<int>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId")
                        .HasName("fkIdx_82");

                    b.HasIndex("PantryItemId")
                        .HasName("fkIdx_85");

                    b.HasIndex("RecipeId")
                        .HasName("fkIdx_79");

                    b.ToTable("RecipeItem");
                });

            modelBuilder.Entity("Shopping.Models.RecipeSteps", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RecipeId")
                        .HasColumnName("RecipeID");

                    b.Property<int>("StepNumber");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId")
                        .HasName("fkIdx_94");

                    b.ToTable("RecipeSteps");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .HasName("fkIdx_12");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingListItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<int>("FoodItemId")
                        .HasColumnName("FoodItemID");

                    b.Property<double>("Qty");

                    b.Property<int>("ShoppingListId")
                        .HasColumnName("ShoppingListID");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("FoodItemId")
                        .HasName("fkIdx_65");

                    b.HasIndex("ShoppingListId")
                        .HasName("fkIdx_54");

                    b.ToTable("ShoppingListITem");
                });

            modelBuilder.Entity("Shopping.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("ID");

                    b.Property<Guid>("ObjectId")
                        .HasColumnName("ObjectID");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Shopping.Models.AllergieFoodItem", b =>
                {
                    b.HasOne("Shopping.Models.FoodItem", "FoodItem")
                        .WithMany("AllergieFoodItem")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK_121");

                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("AllergieFoodItem")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_118");
                });

            modelBuilder.Entity("Shopping.Models.MealPlan", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("MealPlan")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_102");
                });

            modelBuilder.Entity("Shopping.Models.MealPlanRecipe", b =>
                {
                    b.HasOne("Shopping.Models.MealPlan", "MealPlan")
                        .WithMany("MealPlanRecipe")
                        .HasForeignKey("MealPlanId")
                        .HasConstraintName("FK_109");

                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("MealPlanRecipe")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_112");
                });

            modelBuilder.Entity("Shopping.Models.Pantry", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("Pantry")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_20");
                });

            modelBuilder.Entity("Shopping.Models.PantryItem", b =>
                {
                    b.HasOne("Shopping.Models.FoodItem", "FoodItem")
                        .WithMany("PantryItem")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK_71");

                    b.HasOne("Shopping.Models.Pantry", "Pantry")
                        .WithMany("PantryItem")
                        .HasForeignKey("PantryId")
                        .HasConstraintName("FK_68");
                });

            modelBuilder.Entity("Shopping.Models.Recipe", b =>
                {
                    b.HasOne("Shopping.Models.Category", "RecipeCategory")
                        .WithMany("Recipe")
                        .HasForeignKey("RecipeCategoryId")
                        .HasConstraintName("FK_44");
                });

            modelBuilder.Entity("Shopping.Models.RecipeItem", b =>
                {
                    b.HasOne("Shopping.Models.FoodItem", "FoodItem")
                        .WithMany("RecipeItem")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK_82");

                    b.HasOne("Shopping.Models.PantryItem", "PantryItem")
                        .WithMany("RecipeItem")
                        .HasForeignKey("PantryItemId")
                        .HasConstraintName("FK_85");

                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("RecipeItem")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_79");
                });

            modelBuilder.Entity("Shopping.Models.RecipeSteps", b =>
                {
                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("RecipeSteps")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_94");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingList", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("ShoppingList")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_12");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingListItem", b =>
                {
                    b.HasOne("Shopping.Models.FoodItem", "FoodItem")
                        .WithMany("ShoppingListItem")
                        .HasForeignKey("FoodItemId")
                        .HasConstraintName("FK_65");

                    b.HasOne("Shopping.Models.ShoppingList", "ShoppingList")
                        .WithMany("ShoppingListItem")
                        .HasForeignKey("ShoppingListId")
                        .HasConstraintName("FK_54");
                });
#pragma warning restore 612, 618
        }
    }
}
