using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{
    public partial class WeddingEvent : AuditableEntity, IAggregateRoot
    {
        public WeddingEvent()
        {
            this.Venue = new EventVenue();
        }

        public DateTime EventDate { get; set; }
        [MaxLength(150)]
        public string? OrganiserName { get; set; }
        [MaxLength(20)]
        public string? OrganiserMobile { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        public Guid WeddingId { get; set; }
        [MaxLength(500)]
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        [MaxLength(1500)]
        public string? AboutEvent { get; set; }
        [MaxLength(500)]
        public string? BackGroundImage { get; set; }
    
        public virtual WeddingMaster Wedding { get; set; }
        public virtual EventVenue Venue { get; set; }
    }
}
