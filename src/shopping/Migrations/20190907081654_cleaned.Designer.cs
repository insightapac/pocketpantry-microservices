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
    [Migration("20190907081654_cleaned")]
    partial class cleaned
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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AllergieFoodItem");
                });

            modelBuilder.Entity("Shopping.Models.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AllergieFoodItemId");

                    b.Property<string>("Name");

                    b.Property<int?>("PantryItemId");

                    b.Property<int?>("RecipeItemId");

                    b.Property<int?>("ShoppingListItemId");

                    b.HasKey("Id");

                    b.HasIndex("AllergieFoodItemId");

                    b.HasIndex("PantryItemId");

                    b.HasIndex("RecipeItemId");

                    b.HasIndex("ShoppingListItemId");

                    b.ToTable("FoodItem");
                });

            modelBuilder.Entity("Shopping.Models.MealCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MealPlanID");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanID")
                        .IsUnique();

                    b.ToTable("MealCategory");
                });

            modelBuilder.Entity("Shopping.Models.MealPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUri");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MealPlan");
                });

            modelBuilder.Entity("Shopping.Models.MealPlanRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MealPlanId");

                    b.Property<string>("Name");

                    b.Property<int?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanId");

                    b.HasIndex("RecipeId");

                    b.ToTable("MealPlanRecipe");
                });

            modelBuilder.Entity("Shopping.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pantry");
                });

            modelBuilder.Entity("Shopping.Models.PantryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PantryId");

                    b.Property<int>("Qty");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("PantryId");

                    b.ToTable("PantryItem");
                });

            modelBuilder.Entity("Shopping.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarbsSugar");

                    b.Property<string>("CarbsTotal");

                    b.Property<string>("CookTime");

                    b.Property<double>("CookingTime");

                    b.Property<string>("Difficulty");

                    b.Property<string>("DifficultyLevel");

                    b.Property<string>("Energy");

                    b.Property<string>("FatTotal");

                    b.Property<string>("Fibre");

                    b.Property<string>("ImageURL");

                    b.Property<string>("ImageUri");

                    b.Property<int>("NumIngredients");

                    b.Property<string>("PreparationTime");

                    b.Property<string>("Protein");

                    b.Property<int>("RecipeCollectionID");

                    b.Property<string>("RecipeDescription");

                    b.Property<string>("RecipeName");

                    b.Property<string>("SaturatedFat");

                    b.Property<string>("Servings");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Sodium");

                    b.Property<double>("TotalCost");

                    b.HasKey("Id");

                    b.HasIndex("RecipeCollectionID")
                        .IsUnique();

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Shopping.Models.RecipeCollection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("RecipeCollection");
                });

            modelBuilder.Entity("Shopping.Models.RecipeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID");

                    b.Property<string>("Note");

                    b.Property<int?>("PantryItemId");

                    b.Property<int>("Qty");

                    b.Property<int?>("RecipeId");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("PantryItemId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeItem");
                });

            modelBuilder.Entity("Shopping.Models.RecipeSteps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("RecipeId");

                    b.Property<int>("StepNumber");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeSteps");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingListItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Qty");

                    b.Property<int?>("ShoppingListId");

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingListId");

                    b.ToTable("ShoppingListItem");
                });

            modelBuilder.Entity("Shopping.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Shopping.Models.AllergieFoodItem", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("AllergieFoodItems")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Shopping.Models.FoodItem", b =>
                {
                    b.HasOne("Shopping.Models.AllergieFoodItem")
                        .WithMany("FoodItems")
                        .HasForeignKey("AllergieFoodItemId");

                    b.HasOne("Shopping.Models.PantryItem", "PantryItem")
                        .WithMany("FoodItems")
                        .HasForeignKey("PantryItemId");

                    b.HasOne("Shopping.Models.RecipeItem", "RecipeItem")
                        .WithMany("FoodItems")
                        .HasForeignKey("RecipeItemId");

                    b.HasOne("Shopping.Models.ShoppingListItem", "ShoppingListItem")
                        .WithMany("FoodItems")
                        .HasForeignKey("ShoppingListItemId");
                });

            modelBuilder.Entity("Shopping.Models.MealCategory", b =>
                {
                    b.HasOne("Shopping.Models.MealPlan", "MealPlan")
                        .WithOne("MealCategory")
                        .HasForeignKey("Shopping.Models.MealCategory", "MealPlanID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shopping.Models.MealPlanRecipe", b =>
                {
                    b.HasOne("Shopping.Models.MealPlan", "MealPlan")
                        .WithMany("MealPlanRecipe")
                        .HasForeignKey("MealPlanId");

                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("MealPlanRecipe")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Shopping.Models.Pantry", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("Pantry")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Shopping.Models.PantryItem", b =>
                {
                    b.HasOne("Shopping.Models.Pantry", "Pantry")
                        .WithMany("PantryItem")
                        .HasForeignKey("PantryId");
                });

            modelBuilder.Entity("Shopping.Models.Recipe", b =>
                {
                    b.HasOne("Shopping.Models.RecipeCollection", "RecipeCollection")
                        .WithOne("Recipe")
                        .HasForeignKey("Shopping.Models.Recipe", "RecipeCollectionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shopping.Models.RecipeItem", b =>
                {
                    b.HasOne("Shopping.Models.PantryItem", "PantryItem")
                        .WithMany("RecipeItem")
                        .HasForeignKey("PantryItemId");

                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Shopping.Models.RecipeSteps", b =>
                {
                    b.HasOne("Shopping.Models.Recipe", "Recipe")
                        .WithMany("Steps")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingList", b =>
                {
                    b.HasOne("Shopping.Models.User", "User")
                        .WithMany("ShoppingList")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Shopping.Models.ShoppingListItem", b =>
                {
                    b.HasOne("Shopping.Models.ShoppingList", "ShoppingList")
                        .WithMany("ShoppingListItem")
                        .HasForeignKey("ShoppingListId");
                });
#pragma warning restore 612, 618
        }
    }
}
