using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyTodo.Configurations.Entities;
using MyTodo.Tables;
using MyTodoClassLibrary.Tables;

namespace MyTodo.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
                        : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Todo> Todoes { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration( new TodoSeedConfiguration() );
            builder.ApplyConfiguration(new TodolistSeedConfiguration());

        }
    }

    
}
