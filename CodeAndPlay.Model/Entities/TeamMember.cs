using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class TeamMember
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        #region Navigation Properties
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [Index("UQ_StudentId", IsUnique = true)]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        #endregion
    }
}
