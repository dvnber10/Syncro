using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Models
{
    public class ProjectPhase
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("ProjectModel")]
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Navigation property for the related project
        public ProjectModel Project { get; set; } = null!;
    }
}