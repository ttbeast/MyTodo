﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyTodo.Tables;
using MyTodoClassLibrary.Tables;

namespace MyTodo.Configurations.Entities
{
    public class TodolistSeedConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasData(
                new Todo
                {
                    Id = 1,
                    CreatedBy = "Test",
                    UpdatedBy = "Test",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Title = "Finish Program",
                    Description = "Trying finish database"
                },
                new Todo
                {
                    Id = 2,
                    CreatedBy = "Test",
                    UpdatedBy = "Test",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Title = "Get new card",
                    Description = "getting a brand new Toyota Supra"
                }
            );
        }
    }
}
