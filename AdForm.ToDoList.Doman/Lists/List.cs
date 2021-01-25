using System;

namespace AdForm.ToDoList.Domain.Lists
{
    public class List : Entity<long>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}