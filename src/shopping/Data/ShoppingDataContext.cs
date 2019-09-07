using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Shopping.Models;

namespace Shopping.Data
{
    public partial class ShoppingDataContext : DbContext
    {
        public ShoppingDataContext()
        {
        }

        public ShoppingDataContext(DbContextOptions<ShoppingDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllergieFoodItem> AllergieFoodItem { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<FoodItem> FoodItem { get; set; }
        public virtual DbSet<MealPlan> MealPlan { get; set; }
        public virtual DbSet<MealPlanRecipe> MealPlanRecipe { get; set; }
        public virtual DbSet<Pantry> Pantry { get; set; }
        public virtual DbSet<PantryItem> PantryItem { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeItem> RecipeItem { get; set; }
        public virtual DbSet<RecipeSteps> RecipeSteps { get; set; }
        public virtual DbSet<ShoppingList> ShoppingList { get; set; }
        public virtual DbSet<ShoppingListItem> ShoppingListItem { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:pocketpantrydb.database.windows.net,1433;Initial Catalog=pocketpantry;Persist Security Info=False;User ID=pocketpantryadmin;Password=1000Pantries;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllergieFoodItem>(entity =>
            {
                entity.HasIndex(e => e.FoodItemId)
                    .HasName("fkIdx_121");

                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_118");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoodItemId).HasColumnName("FoodItemID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.FoodItem)
                    .WithMany(p => p.AllergieFoodItem)
                    .HasForeignKey(d => d.FoodItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_121");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AllergieFoodItem)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_118");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<FoodItem>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MealPlan>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_102");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MealPlan)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_102");
            });

            modelBuilder.Entity<MealPlanRecipe>(entity =>
            {
                entity.ToTable("MealPLanRecipe");

                entity.HasIndex(e => e.MealPlanId)
                    .HasName("fkIdx_109");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fkIdx_112");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MealPlanId).HasColumnName("MealPlanID");

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.HasOne(d => d.MealPlan)
                    .WithMany(p => p.MealPlanRecipe)
                    .HasForeignKey(d => d.MealPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_109");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.MealPlanRecipe)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_112");
            });

            modelBuilder.Entity<Pantry>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_20");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pantry)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_20");
            });

            modelBuilder.Entity<PantryItem>(entity =>
            {
                entity.HasIndex(e => e.FoodItemId)
                    .HasName("fkIdx_71");

                entity.HasIndex(e => e.PantryId)
                    .HasName("fkIdx_68");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoodItemId).HasColumnName("FoodItemID");

                entity.Property(e => e.PantryId).HasColumnName("PantryID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FoodItem)
                    .WithMany(p => p.PantryItem)
                    .HasForeignKey(d => d.FoodItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_71");

                entity.HasOne(d => d.Pantry)
                    .WithMany(p => p.PantryItem)
                    .HasForeignKey(d => d.PantryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_68");
            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasIndex(e => e.RecipeCategoryId)
                    .HasName("fkIdx_44");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeCategoryId).HasColumnName("RecipeCategoryID");

                entity.HasOne(d => d.RecipeCategory)
                    .WithMany(p => p.Recipe)
                    .HasForeignKey(d => d.RecipeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_44");
            });

            modelBuilder.Entity<RecipeItem>(entity =>
            {
                entity.HasIndex(e => e.FoodItemId)
                    .HasName("fkIdx_82");

                entity.HasIndex(e => e.PantryItemId)
                    .HasName("fkIdx_85");

                entity.HasIndex(e => e.RecipeId)
                    .HasName("fkIdx_79");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoodItemId).HasColumnName("FoodItemID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.PantryItemId).HasColumnName("PantryItemID");

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FoodItem)
                    .WithMany(p => p.RecipeItem)
                    .HasForeignKey(d => d.FoodItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_82");

                entity.HasOne(d => d.PantryItem)
                    .WithMany(p => p.RecipeItem)
                    .HasForeignKey(d => d.PantryItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_85");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeItem)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_79");
            });

            modelBuilder.Entity<RecipeSteps>(entity =>
            {
                entity.HasIndex(e => e.RecipeId)
                    .HasName("fkIdx_94");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.RecipeId).HasColumnName("RecipeID");

                entity.HasOne(d => d.Recipe)
                    .WithMany(p => p.RecipeSteps)
                    .HasForeignKey(d => d.RecipeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_94");
            });

            modelBuilder.Entity<ShoppingList>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("fkIdx_12");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ShoppingList)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_12");
            });

            modelBuilder.Entity<ShoppingListItem>(entity =>
            {
                entity.ToTable("ShoppingListITem");

                entity.HasIndex(e => e.FoodItemId)
                    .HasName("fkIdx_65");

                entity.HasIndex(e => e.ShoppingListId)
                    .HasName("fkIdx_54");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoodItemId).HasColumnName("FoodItemID");

                entity.Property(e => e.ShoppingListId).HasColumnName("ShoppingListID");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FoodItem)
                    .WithMany(p => p.ShoppingListItem)
                    .HasForeignKey(d => d.FoodItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_65");

                entity.HasOne(d => d.ShoppingList)
                    .WithMany(p => p.ShoppingListItem)
                    .HasForeignKey(d => d.ShoppingListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_54");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");
            });
        }
    }
}
