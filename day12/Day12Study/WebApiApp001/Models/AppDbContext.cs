using Microsoft.EntityFrameworkCore;
using WebApiApp001.Models;

namespace WebApiApp001.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        // 테이블 연결
        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
