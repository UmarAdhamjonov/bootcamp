using System;

namespace tasks.Entity
{
    public class Tasks
    {
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public string Tags { get; set; }
        
        public DateTimeOffset OnAday { get; set; }
        
        public DateTimeOffset AtATime {get; set; }

        public ETaskStatus Status { get; set; }
        
        public ETaskRepeat Repeat { get; set; }
        
        public string Location { get; set; }
        
        public string Url { get; set; }    
    }
}