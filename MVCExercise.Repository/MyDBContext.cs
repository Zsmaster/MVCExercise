using Microsoft.EntityFrameworkCore;
using MVCExercise.Model.Membership;

namespace MVCExercise.Repository
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        { 
        
        }

        public DbSet<UserModel> Users { get; set; }
    }
}
