﻿namespace MyTodo.Tables
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public DateTime UpdatedDate { get; set;}
    }
}
