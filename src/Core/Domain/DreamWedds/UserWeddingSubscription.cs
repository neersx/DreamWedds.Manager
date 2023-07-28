using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{
    public class UserWeddingSubscription : AuditableEntity, IAggregateRoot
    {
        public int UserId { get; set; }
        public int TemplateId { get; set; }
        public Guid? InvoiceNo { get; set; }
        public Guid? WeddingId { get; set; }
        public int SubscriptionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(250)]
        public string? ReasonOfUpdate { get; set; }
        public int SubscriptionStatus { get; set; }
    
        public virtual OrderMaster OrderMaster { get; set; }
        public virtual SubscriptionMaster SubscriptionMaster { get; set; }
        public virtual TemplateMaster TemplateMaster { get; set; }
        public virtual WeddingMaster Wedding { get; set; }
    }
}
