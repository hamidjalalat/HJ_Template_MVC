using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class Role:BaseEntity
    {
        public Role() : base()
        {

        }
        public string Name { get; set; }
        public virtual IList<User> Users { get; set; }
    }
}
