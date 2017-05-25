using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Index("UQ_ControlNumber", IsUnique = true)]
        public int ControlNumber { get; set; }

        [Required]
        public string FullName { get; set; }

        public int Semester { get; set; }

        public string Email { get; set; }

        #region Navigation Propertie

        public int SchoolId { get; set; }
        public School School { get; set; }

        public int? WorkshopId { get; set; }
        public Workshop Workshop { get; set; }
        #endregion
    }
}
