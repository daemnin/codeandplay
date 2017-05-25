using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeAndPlay.Model.Entities
{
    public class Contact
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        public bool IsClosed { get; set; }
    }
}
