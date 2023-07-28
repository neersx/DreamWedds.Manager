using Finbuckle.MultiTenant;
using DreamWedds.Manager.Application.Common.Events;
using DreamWedds.Manager.Application.Common.Interfaces;
using DreamWedds.Manager.Domain.Catalog;
using DreamWedds.Manager.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using DreamWedds.Manager.Domain.Entities.DreamWedds;

namespace DreamWedds.Manager.Infrastructure.Persistence.Context;

public class ApplicationDbContext : BaseDbContext
{
    public ApplicationDbContext(ITenantInfo currentTenant, DbContextOptions options, ICurrentUser currentUser, ISerializerService serializer, IOptions<DatabaseSettings> dbSettings, IEventPublisher events)
        : base(currentTenant, options, currentUser, serializer, dbSettings, events)
    {
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Brand> Brands => Set<Brand>();


    #region Region | DreamWedds database entities
    public DbSet<BrideAndMaid> BrideAndMaid { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogComments> BlogComments { get; set; }
    public DbSet<Faq> Faqs { get; set; }
    public DbSet<GroomAndMan> GroomAndMan { get; set; }
    public DbSet<OrderDetail> OrderDetail { get; set; }
    public DbSet<OrderMaster> OrderMaster { get; set; }
    public DbSet<RsvpDetail> RsvpDetail { get; set; }
    public DbSet<SubscriptionMaster> SubscriptionMaster { get; set; }
    public DbSet<TemplateImage> TemplateImage { get; set; }
    public DbSet<TemplateMaster> TemplateMaster { get; set; }
    public DbSet<TemplateComments> TemplateComments { get; set; }
    public DbSet<TemplateMergeField> TemplateMergeField { get; set; }
    public DbSet<StoryTimeLine> TimeLine { get; set; }
    public DbSet<UserWeddingSubscription> UserWeddingSubscription { get; set; }
    public DbSet<EventVenue> Venue { get; set; }
    public DbSet<WeddingMaster> Wedding { get; set; }
    public DbSet<WeddingEvent> WeddingEvent { get; set; }
    public DbSet<WeddingGalleryImages> WeddingImages { get; set; }
    public DbSet<MetaTags> MetaTags { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }

    public DbSet<WeddingTemplateSettings> WeddingTemplateSettings { get; set; }
    public DbSet<BannerSettings> BannerSettings { get; set; }
    public DbSet<CoupleSettings> CoupleSettings { get; set; }
    public DbSet<BrideMaidSettings> BrideMaidSettings { get; set; }
    public DbSet<GroomsMenSettings> GroomsMenSettings { get; set; }
    public DbSet<TimeLineSettings> TimeLineSettings { get; set; }
    public DbSet<VenueSettings> VenueSettings { get; set; }
    public DbSet<EventsSettings> EventsSettings { get; set; }
    public DbSet<GallerySettings> GallerySettings { get; set; }
    public DbSet<GiftRegistrySettings> GiftRegistrySettings { get; set; }
    public DbSet<RsvpSettings> RsvpSettings { get; set; }

    #endregion


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema(SchemaNames.Catalog);
    }
}