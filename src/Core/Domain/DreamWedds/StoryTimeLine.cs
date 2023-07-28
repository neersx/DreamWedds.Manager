using System.ComponentModel.DataAnnotations;
namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{

    public class StoryTimeLine : AuditableEntity, IAggregateRoot
    {
        public System.DateTime StoryDate { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Story { get; set; }
        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public Guid WeddingId { get; set; }
        [MaxLength(100)]
        public string? Location { get; set; }
    
        public virtual WeddingMaster Wedding { get; set; }
    }
}
