using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{
    public class WeddingGalleryImages : AuditableEntity, IAggregateRoot
    {
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Title { get; set; }
        public Guid WeddingId { get; set; }
        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public DateTime? DateTaken { get; set; }
        [MaxLength(100)]
        public string? Place { get; set; }

        public virtual WeddingMaster Wedding { get; set; }
    }
}
