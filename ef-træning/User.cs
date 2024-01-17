using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public string Name { get; set; } 
        public long Id { get; set; }

        public User(string name)
        {
            this.Name = name;
            
        }
        public User() { }
    }
   
}
