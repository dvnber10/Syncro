using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public UserEntity(uint id, Guid teamId, string userName, string email, string firstName, string lastName, string passwordHash, string phoneNumber)
        {
            Id = Guid.NewGuid();
            TeamId = teamId;
            UserName = userName;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            PasswordHash = passwordHash;
            PhoneNumber = phoneNumber;
        }
        
        public void AssignToTeam(Guid teamId)
        {
            TeamId = teamId;
        }
    }
}