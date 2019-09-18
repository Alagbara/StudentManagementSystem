using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conponents.Parts
{
    public class Role
    {
            [ForeignKey("User")]

            public int Id { get; set; }
            public string RoleType { get; set; }

            public virtual User User { get; set; }

        
        
    }
}
