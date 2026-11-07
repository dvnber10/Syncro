using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Data.Models
{
    public class ProjectModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime FinishedAt { get; set; } = DateTime.UtcNow;
        public ProjectStatus Status { get; set; } = ProjectStatus.NotStarted;
        public ProjectTimes Time { get; set; } = ProjectTimes.OnTime;

        // Navigation property for the related teams
        public ICollection<TeamsModel> Teams { get; set; } = new List<TeamsModel>();


    }
}