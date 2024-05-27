using System;
using System.Collections.Generic;

namespace Project_Prn221_Shop.Model
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Position { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
