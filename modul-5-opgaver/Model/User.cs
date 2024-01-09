using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public User(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public long Userid { get; set; }
    }

}
