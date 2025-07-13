using Core.Abstracts.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Utilities.Helpers;

namespace Core.Concretes.Entities
{
    public class Reaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required int ProductId { get; set; }
        public virtual Product? Product { get; set; }

        [Required]
        public required string MemberId { get; set; }
        public virtual Member? Member { get; set; }

        [Required]
        public required ReactionType ReactionType { get; set; }
    }
    public class Review : BaseEntity 
    {
        [Required]
        public required int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        [Required]
        public required string MemberId { get; set; }
        public virtual Member? Member { get; set; }
        public required int Rating { get; set; }
        public string? Commennt { get; set; }
    }
}
