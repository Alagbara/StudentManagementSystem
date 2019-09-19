using StudentManagementSystem.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentManagementSystem.Models.Entities
{
    [Table(nameof(Role))]
    public class Role : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string RoleType { get; set; }
    }
}
