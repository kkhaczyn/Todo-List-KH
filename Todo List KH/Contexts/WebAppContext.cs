using Microsoft.EntityFrameworkCore;
using System;
using Todo_List_KH.Models;

namespace Todo_List_KH.AppContext
{
    public class WebAppContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(
                //tuesday
                new ToDoItem() { Id = 1, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 3, 28, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 2, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 3, 28, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 3, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 3, 28, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 4, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 3, 28, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 5, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 3, 28, 20, 0, 0), IsCompleted = false },
                //wednesday
                new ToDoItem() { Id = 6, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 3, 29, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 7, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 3, 29, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 8, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 3, 29, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 9, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 3, 29, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 10, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 3, 29, 20, 0, 0), IsCompleted = false },
                //thursday
                new ToDoItem() { Id = 11, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 3, 30, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 12, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 3, 30, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 13, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 3, 30, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 14, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 3, 30, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 15, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 3, 30, 20, 0, 0), IsCompleted = false },
                //friday
                new ToDoItem() { Id = 16, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 3, 31, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 17, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 3, 31, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 18, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 3, 31, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 19, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 3, 31, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 20, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 3, 31, 20, 0, 0), IsCompleted = false },
                //saturday
                new ToDoItem() { Id = 21, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 4, 1, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 22, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 4, 1, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 23, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 4, 1, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 24, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 4, 1, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 25, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 4, 1, 20, 0, 0), IsCompleted = false },
                //sunday
                new ToDoItem() { Id = 26, Name = "Podlać kwiaty", ExecutionTime = new DateTime(2023, 4, 2, 12, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 27, Name = "Zjeść obiad", ExecutionTime = new DateTime(2023, 4, 2, 14, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 28, Name = "Wyprowadzić psa na spacer", ExecutionTime = new DateTime(2023, 4, 2, 16, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 29, Name = "Zrobić zakupy", ExecutionTime = new DateTime(2023, 4, 2, 18, 0, 0), IsCompleted = false },
                new ToDoItem() { Id = 30, Name = "Zjeść kolację", ExecutionTime = new DateTime(2023, 4, 2, 20, 0, 0), IsCompleted = false }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
