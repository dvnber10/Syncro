using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Infrastructure.Data.Models
{
    public class AgentIAModel
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("UserModel")]
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Name { get; set; } = string.Empty; // Name of the la sugerencia
        public string Description { get; set; } = string.Empty; // Description of the la sugerencia
        public SuggestionStatus Status { get; set; } = SuggestionStatus.Pending; // Status of the la sugerencia

        // Navigation property for the related user
        public UserModel User { get; set; } = null!;
    }
}