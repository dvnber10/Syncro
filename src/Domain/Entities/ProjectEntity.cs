using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class ProjectEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime FinishedAt { get; set; } = DateTime.UtcNow;
        public ProjectStatus Status { get; set; } = ProjectStatus.NotStarted;
        public ProjectTimes Time { get; set; } = ProjectTimes.OnTime;

        public ProjectEntity(Guid id, string name, string description, DateTime createdAt, DateTime finishedAt, ProjectStatus status, ProjectTimes time)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            FinishedAt = finishedAt;
            Status = status;
            Time = time;
        }
        public void UpdateStatus(ProjectStatus status)
        {
            Status = status;
        }

    }
}