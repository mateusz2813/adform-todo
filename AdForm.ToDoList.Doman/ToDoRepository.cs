using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using AdForm.ToDoList.Domain.Items;
using AdForm.ToDoList.Domain.Lists;

namespace AdForm.ToDoList.Domain
{
    public class ToDoRepository : DbContext
    {
        public const string ConnectionStringKey = "DefaultConnection";

        public DbSet<Item> Items { get; set; }

        public DbSet<List> Lists { get; set; }

        public ToDoRepository(DbContextOptions<ToDoRepository> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\DEV2008;Initial Catalog=ToDoLists;Integrated Security=True;pooling=false");
          
        }
    }
}