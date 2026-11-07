using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data.Models
{
    public class MeetingModel
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("projectModel")]
        public Guid ProjectId { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        // Navigation property for the related users
        public ICollection<UserModel> Users { get; set; } = new List<UserModel>(); // lista de participantes
    }
}