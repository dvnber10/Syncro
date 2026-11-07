using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Data.Models
{
    public class TaskModel
    {
        [Key]
        public Guid Id {get; set;}
        [ForeignKey("ProjectModel")]
        public Guid ProjectId {get; set;}
        [ForeignKey("UserModel")]
        public Guid UserId {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
        public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;
        public StatusTask Status {get; set;} = StatusTask.Pending;
        public TimeTask Time {get; set;} = TimeTask.OnTime;

        // Navigation property for the related project
        public ProjectModel Project { get; set; } = null!;
        // Navigation property for the related user
        public UserModel User { get; set; } = null!;

    }
}