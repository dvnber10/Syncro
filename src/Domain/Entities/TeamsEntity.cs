using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Entities
{
    public class TeamsEntity
    {
        public Guid Id {get; set;}
        public Guid ProjectId {get; set;}
        public Guid UserId {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
        public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;
        public StatusTask Status {get; set;} = StatusTask.Pending;
        public TimeTask Time {get; set;} = TimeTask.OnTime;

        public TeamsEntity(Guid id, Guid projectId, Guid userId, string name, string description, DateTime createdAt, DateTime updatedAt, StatusTask status, TimeTask time)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userId;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Status = status;
            Time = time;
        }
        public void UpdateStatus(StatusTask status)
        {
            Status = status;
        }
        public void UpdateTime(TimeTask time)
        {
            Time = time;
        }
        public void UpdateUpdatedAt(DateTime updatedAt)
        {
            UpdatedAt = updatedAt;
        }
        public void UpdateProjectId(Guid projectId)
        {
            ProjectId = projectId;
        }
    }
}