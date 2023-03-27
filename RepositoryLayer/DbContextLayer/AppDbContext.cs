using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DbContextLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions con):base(con)
        {

        }
        public DbSet<User> tblUser { get; set; }
    }
}
