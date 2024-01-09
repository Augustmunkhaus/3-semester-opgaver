using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TodoTask.cs
namespace Model
{
    public class TodoTask
    {
        public TodoTask(string text, bool done, string category)
        {
            this.Text = text;
            this.Done = done;
            this.Category = category;
            

        }
        public long TodoTaskId { get; set; }
        public string? Text { get; set; }
        public bool Done { get; set; }

        public string Category { get; set; }

        [Required]
        public User User { get; set; }
    }
}

