using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Data.Models
{
    public class UserModel: IdentityUser<Guid>
    {
        [ForeignKey("TeamsModel")]
        public Guid TeamId { get; set; }

        // Navigation property for the related team
        public TeamsModel Team { get; set; } = null!;
    }
}