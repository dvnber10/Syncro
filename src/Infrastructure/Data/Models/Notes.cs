using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Models
{
    public class Notes
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserModel")]
        public Guid UserId { get; set; }
        [ForeignKey("ProjectModel")]
        public Guid ProjectId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        // Navigation property for the related user
        public UserModel User { get; set; } = null!;
        // Navigation property for the related project
        public ProjectModel Project { get; set; } = null!;
    }
}