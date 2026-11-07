using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Data.Models
{
    public class NotificationsModel
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserModel")]
        public Guid UserId { get; set; }
        [ForeignKey("ProjectModel")]
        public Guid ProjectId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public NotificationType Type { get; set; }

    }
}