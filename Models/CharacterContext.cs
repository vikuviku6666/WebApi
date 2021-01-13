using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=DB/characters.db");
        public DbSet<Character> Characters { get; set; }

        

        
    }
}