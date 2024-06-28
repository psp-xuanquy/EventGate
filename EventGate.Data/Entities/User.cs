using EventGate.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventGate.Data.Entity
{
    public class User : IdentityUser
    {
        public string? Avatar { get; set; }
        public string? Address { get; set; }
        public string? IdentityCard { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsDeleted { get; set; } = false;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DefaultValue("GETDATE()")]
        public DateTime? CreatedTime { get; set; } = DateTime.Now;
        public DateTime? DeletedTime { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? LastUpdatedTime { get; set; }
        public string? ResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        public string? VerificationToken { get; set; }
        public DateTime? VerificationTokenExpires { get; set; }
        public bool isConfirmed { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Blog>? Blogs { get; set; }
        public ICollection<UserEvent>? UserEvents { get; set; }
        public ICollection<UserChatRoom>? UserChatRooms { get; set; }
        public ICollection<EventFeedback>? EventFeedbacks { get; set; }
        public ICollection<UserHistory>? UserHistories { get; set; }
        public ICollection<ChatHistory>? ChatHistories { get; set; }
    }
}
