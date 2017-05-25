using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class Team
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        #region Navigation Properties
        public int LeaderId { get; set; }
        public Student Leader { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public virtual ICollection<TeamMember> TeamMembers { get; set; } 
        #endregion
    }
}