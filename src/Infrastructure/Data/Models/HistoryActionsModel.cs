using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Data.Models
{
    public class HistoryActionsModel
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserModel")]
        public Guid UserId { get; set; }
        [ForeignKey("ProjectModel")]
        public Guid ProjectId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public ActionType ActionType { get; set; }

        // Navigation property for the related user
        public UserModel User { get; set; } = null!;
        // Navigation property for the related project
        public ProjectModel Project { get; set; } = null!;

    }
}