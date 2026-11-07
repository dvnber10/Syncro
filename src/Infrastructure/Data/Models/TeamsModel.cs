using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Models
{
    public class TeamsModel
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("ProjectModel")]
        public Guid ProjectId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation property for the related users
        public ICollection<UserModel> Users { get; set; } = new List<UserModel>();
        public ProjectModel Project { get; set; } = null!;
        
    }
}