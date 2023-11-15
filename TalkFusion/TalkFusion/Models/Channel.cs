﻿using System.ComponentModel.DataAnnotations;

namespace TalkFusion.Models
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Channel title is mandatory")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Channel description is mandatory")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Channel user is mandatory")]
        public int UserId { get; set;}

        [Required(ErrorMessage = "Channel category is mandatory")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

    }
}
