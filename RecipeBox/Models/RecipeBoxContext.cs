using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : IdentityDbContext<ApplicationUser> // ApplicationUser is the type of IdentityDbContext inherited in this class declaration
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<CategoryRecipe> CategoryRecipe { get; set; }
    public RecipeBoxContext(DbContextOptions options) : base(options) { }
  }
}

// Each DbSet will become a table in our database. CategoryRecipe represents the join table