﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class Rule
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        #region Navigation Properties
        public virtual ICollection<Event> Events { get; set; }
        #endregion
    }
}
