using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{
    public class Faq : AuditableEntity<int>, IAggregateRoot
    {
        [MaxLength(250)]
        [Required]
        public string Question { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Answer { get; set; }
        [MaxLength(200)]
        public string? Website { get; set; }
        public bool IsMainQue { get; set; } = false;
        public int? ParentQuestionId { get; set; }
        public int? Sequence { get; set; }
    }
}
