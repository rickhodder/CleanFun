﻿using CleanFun.Core.Events;
using CleanFun.SharedKernel;

namespace CleanFun.Core.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }
        public bool IsDone { get; private set; }

        public void MarkComplete()
        {
            IsDone = true;
            Events.Add(new ToDoItemCompletedEvent(this));
        }
    }
}
