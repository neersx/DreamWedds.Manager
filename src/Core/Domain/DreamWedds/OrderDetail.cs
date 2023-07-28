namespace DreamWedds.Manager.Domain.Entities.DreamWedds
{
    public class OrderDetail : AuditableEntity, IAggregateRoot
    {
        public int? Discount { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Guid OrderID { get; set; }
        public int TemplateID { get; set; }
        public Guid? SubscrptionID { get; set; }
    
        public virtual OrderMaster OrderMaster { get; set; }
        public virtual SubscriptionMaster SubscriptionMaster { get; set; }
        public virtual TemplateMaster TemplateMaster { get; set; }
    }
}
