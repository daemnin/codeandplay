using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class Workshop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string Instructor { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Location { get; set; }

        // Cupo del grupo
        public int GroupSize { get; set; }

        #region Navigation Properties
        public virtual ICollection<Requirement> Requirements { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        #endregion
    }
}
