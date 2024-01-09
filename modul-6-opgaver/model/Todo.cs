using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Todo
    {

        public Todo(string name, string category)
        {
            this.Name = name;
            this.Category = category;
        }

        public string Name { get; set; }

        public string Category { get; set; }
    }
}
