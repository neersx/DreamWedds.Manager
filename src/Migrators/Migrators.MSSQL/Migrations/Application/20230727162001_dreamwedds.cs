using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class dreamwedds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims");

            migrationBuilder.CreateTable(
                name: "BannerSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    Placement = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    DefaultResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MaxResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsCarousel = table.Column<bool>(type: "bit", nullable: false),
                    MaxImages = table.Column<int>(type: "int", nullable: false),
                    CssStyle = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BestManSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    ImageResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContainsSocialBio = table.Column<bool>(type: "bit", nullable: false),
                    ContainImage = table.Column<bool>(type: "bit", nullable: false),
                    ContainText = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestManSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BlogSubject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Quote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BlogType = table.Column<int>(type: "int", nullable: false),
                    SpecialNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrideMaidSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    ImageResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContainsSocialBio = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrideMaidSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ContactFor = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoupleSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    BrideImageResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    GroomImageResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Placement = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DisplayDescription = table.Column<bool>(type: "bit", nullable: false),
                    CssStyle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoupleSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventsSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    DefaultEventsCount = table.Column<int>(type: "int", nullable: false),
                    MaxEventsCount = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventsSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsMainQue = table.Column<bool>(type: "bit", nullable: false),
                    ParentQuestionId = table.Column<int>(type: "int", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GallerySettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    ImageResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxImageResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultImagesCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxImagesCount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GallerySettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiftRegistrySettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftRegistrySettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroomsMenSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    ImageResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContainsSocialBio = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroomsMenSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvitationSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CanSendEmail = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvitationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderMaster",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequiredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CGST = table.Column<int>(type: "int", nullable: true),
                    SGST = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMode = table.Column<int>(type: "int", nullable: true),
                    PaymentTerms = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OderNote = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RsvpSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    CanUploadGuestList = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RsvpSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionMaster",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubsType = table.Column<int>(type: "int", nullable: false),
                    SubsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubsCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeLineSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    IsSingleSide = table.Column<bool>(type: "bit", nullable: false),
                    DefaultResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MaxResolution = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ContainsEndTitle = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLineSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VenueSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sequence = table.Column<int>(type: "int", nullable: false),
                    IsBackgroundImage = table.Column<bool>(type: "bit", nullable: false),
                    LocationMapEnabled = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsHtml = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BlogId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogId1",
                        column: x => x.BlogId1,
                        principalSchema: "Catalog",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeddingTemplateSettings",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackgroundImageResolution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMultiplePage = table.Column<bool>(type: "bit", nullable: false),
                    ContainsFooter = table.Column<bool>(type: "bit", nullable: false),
                    CopyRightText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnableNotification = table.Column<bool>(type: "bit", nullable: false),
                    BannerSettingsId = table.Column<int>(type: "int", nullable: false),
                    CoupleSettingsId = table.Column<int>(type: "int", nullable: false),
                    BrideMaidSettingsId = table.Column<int>(type: "int", nullable: false),
                    GroomsMenSettingsId = table.Column<int>(type: "int", nullable: false),
                    BestManSettingsId = table.Column<int>(type: "int", nullable: false),
                    TimeLineSettingsId = table.Column<int>(type: "int", nullable: false),
                    InvitationSettingsId = table.Column<int>(type: "int", nullable: false),
                    VenueSettingsId = table.Column<int>(type: "int", nullable: false),
                    EventsSettingsId = table.Column<int>(type: "int", nullable: false),
                    GiftRegistrySettingsId = table.Column<int>(type: "int", nullable: false),
                    GallerySettingsId = table.Column<int>(type: "int", nullable: false),
                    RsvpSettingsId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingTemplateSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_BannerSettings_BannerSettingsId",
                        column: x => x.BannerSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "BannerSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_BestManSettings_BestManSettingsId",
                        column: x => x.BestManSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "BestManSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_BrideMaidSettings_BrideMaidSettingsId",
                        column: x => x.BrideMaidSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "BrideMaidSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_CoupleSettings_CoupleSettingsId",
                        column: x => x.CoupleSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "CoupleSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_EventsSettings_EventsSettingsId",
                        column: x => x.EventsSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "EventsSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_GallerySettings_GallerySettingsId",
                        column: x => x.GallerySettingsId,
                        principalSchema: "Catalog",
                        principalTable: "GallerySettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_GiftRegistrySettings_GiftRegistrySettingsId",
                        column: x => x.GiftRegistrySettingsId,
                        principalSchema: "Catalog",
                        principalTable: "GiftRegistrySettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_GroomsMenSettings_GroomsMenSettingsId",
                        column: x => x.GroomsMenSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "GroomsMenSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_InvitationSettings_InvitationSettingsId",
                        column: x => x.InvitationSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "InvitationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_RsvpSettings_RsvpSettingsId",
                        column: x => x.RsvpSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "RsvpSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_TimeLineSettings_TimeLineSettingsId",
                        column: x => x.TimeLineSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "TimeLineSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingTemplateSettings_VenueSettings_VenueSettingsId",
                        column: x => x.VenueSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "VenueSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateMaster",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TemplateUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TemplateFolderPath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ThumbnailImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TagLine = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AboutTemplate = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Features = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TemplateCode = table.Column<int>(type: "int", nullable: true),
                    WeddingTemplateSettingsId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateMaster_WeddingTemplateSettings_WeddingTemplateSettingsId",
                        column: x => x.WeddingTemplateSettingsId,
                        principalSchema: "Catalog",
                        principalTable: "WeddingTemplateSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaTags",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Property = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TagPrefix = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PageTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsImage = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MetaTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalSchema: "Catalog",
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetaTags_TemplateMaster_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    SubscrptionID = table.Column<int>(type: "int", nullable: true),
                    OrderMasterId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionMasterId = table.Column<int>(type: "int", nullable: false),
                    TemplateMasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_OrderMaster_OrderMasterId",
                        column: x => x.OrderMasterId,
                        principalSchema: "Catalog",
                        principalTable: "OrderMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_SubscriptionMaster_SubscriptionMasterId",
                        column: x => x.SubscriptionMasterId,
                        principalSchema: "Catalog",
                        principalTable: "SubscriptionMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_TemplateMaster_TemplateMasterId",
                        column: x => x.TemplateMasterId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateComments",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsHtml = table.Column<bool>(type: "bit", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateComments_TemplateMaster_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateImage",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TagLine = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FolderPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsBannerImage = table.Column<bool>(type: "bit", nullable: false),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    ImageType = table.Column<int>(type: "int", nullable: true),
                    TemplateMasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateImage_TemplateMaster_TemplateMasterId",
                        column: x => x.TemplateMasterId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TemplateMergeField",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MERGEFIELD_NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SRC_FIELD = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SRC_FIELD_VALUE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TemplateID = table.Column<int>(type: "int", nullable: true),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    TemplateCode = table.Column<int>(type: "int", nullable: true),
                    TemplateMasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateMergeField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateMergeField_TemplateMaster_TemplateMasterId",
                        column: x => x.TemplateMasterId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wedding",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WeddingStyle = table.Column<int>(type: "int", nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: true),
                    IsLoveMarriage = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BackgroundImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FbPageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wedding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wedding_TemplateMaster_TemplateId",
                        column: x => x.TemplateId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BrideAndMaid",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WeddingId = table.Column<int>(type: "int", nullable: false),
                    IsBride = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RelationWithBride = table.Column<int>(type: "int", nullable: true),
                    About = table.Column<string>(type: "nvarchar(1250)", maxLength: 1250, nullable: false),
                    FbUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GoogleUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrideAndMaid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrideAndMaid_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroomAndMan",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateofBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WeddingId = table.Column<int>(type: "int", nullable: false),
                    IsGroom = table.Column<bool>(type: "bit", nullable: false),
                    RelationWithGroom = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    About = table.Column<string>(type: "nvarchar(1250)", maxLength: 1250, nullable: false),
                    FbUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GoogleUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    InstagramUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LinkedinUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroomAndMan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroomAndMan_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RsvpDetail",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsComing = table.Column<bool>(type: "bit", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GuestCount = table.Column<int>(type: "int", nullable: true),
                    PreferredFood = table.Column<byte>(type: "tinyint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SpecialNote = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WeddingID = table.Column<int>(type: "int", nullable: false),
                    ParticipatingInEvents = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ComingFromCity = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PreferredStayIn = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RsvpDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RsvpDetail_Wedding_WeddingID",
                        column: x => x.WeddingID,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeLine",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Story = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WeddingId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeLine_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWeddingSubscription",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    InvoiceNo = table.Column<int>(type: "int", nullable: true),
                    WeddingId = table.Column<int>(type: "int", nullable: true),
                    SubscriptionType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReasonOfUpdate = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SubscriptionStatus = table.Column<int>(type: "int", nullable: false),
                    OrderMasterId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionMasterId = table.Column<int>(type: "int", nullable: false),
                    TemplateMasterId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWeddingSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscription_OrderMaster_OrderMasterId",
                        column: x => x.OrderMasterId,
                        principalSchema: "Catalog",
                        principalTable: "OrderMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscription_SubscriptionMaster_SubscriptionMasterId",
                        column: x => x.SubscriptionMasterId,
                        principalSchema: "Catalog",
                        principalTable: "SubscriptionMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscription_TemplateMaster_TemplateMasterId",
                        column: x => x.TemplateMasterId,
                        principalSchema: "Catalog",
                        principalTable: "TemplateMaster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWeddingSubscription_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WeddingEvent",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganiserName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OrganiserMobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    WeddingId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AboutEvent = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    BackGroundImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeddingEvent_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeddingImages",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WeddingId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DateTaken = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeddingImages_Wedding_WeddingId",
                        column: x => x.WeddingId,
                        principalSchema: "Catalog",
                        principalTable: "Wedding",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BannerImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    WeddingEventId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GoogleMapUrl = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PinCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venue_WeddingEvent_WeddingEventId",
                        column: x => x.WeddingEventId,
                        principalSchema: "Catalog",
                        principalTable: "WeddingEvent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId1",
                schema: "Catalog",
                table: "BlogComments",
                column: "BlogId1");

            migrationBuilder.CreateIndex(
                name: "IX_BrideAndMaid_WeddingId",
                schema: "Catalog",
                table: "BrideAndMaid",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_GroomAndMan_WeddingId",
                schema: "Catalog",
                table: "GroomAndMan",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaTags_BlogId",
                schema: "Catalog",
                table: "MetaTags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaTags_TemplateId",
                schema: "Catalog",
                table: "MetaTags",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderMasterId",
                schema: "Catalog",
                table: "OrderDetail",
                column: "OrderMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_SubscriptionMasterId",
                schema: "Catalog",
                table: "OrderDetail",
                column: "SubscriptionMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_TemplateMasterId",
                schema: "Catalog",
                table: "OrderDetail",
                column: "TemplateMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_RsvpDetail_WeddingID",
                schema: "Catalog",
                table: "RsvpDetail",
                column: "WeddingID");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateComments_TemplateId",
                schema: "Catalog",
                table: "TemplateComments",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateImage_TemplateMasterId",
                schema: "Catalog",
                table: "TemplateImage",
                column: "TemplateMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateMaster_WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster",
                column: "WeddingTemplateSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateMergeField_TemplateMasterId",
                schema: "Catalog",
                table: "TemplateMergeField",
                column: "TemplateMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeLine_WeddingId",
                schema: "Catalog",
                table: "TimeLine",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscription_OrderMasterId",
                schema: "Catalog",
                table: "UserWeddingSubscription",
                column: "OrderMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscription_SubscriptionMasterId",
                schema: "Catalog",
                table: "UserWeddingSubscription",
                column: "SubscriptionMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscription_TemplateMasterId",
                schema: "Catalog",
                table: "UserWeddingSubscription",
                column: "TemplateMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeddingSubscription_WeddingId",
                schema: "Catalog",
                table: "UserWeddingSubscription",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_Venue_WeddingEventId",
                schema: "Catalog",
                table: "Venue",
                column: "WeddingEventId",
                unique: true,
                filter: "[WeddingEventId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Wedding_TemplateId",
                schema: "Catalog",
                table: "Wedding",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingEvent_WeddingId",
                schema: "Catalog",
                table: "WeddingEvent",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingImages_WeddingId",
                schema: "Catalog",
                table: "WeddingImages",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BannerSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BestManSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BrideMaidSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "CoupleSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "EventsSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GallerySettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GiftRegistrySettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GroomsMenSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "InvitationSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "RsvpSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "TimeLineSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingTemplateSettings_VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "VenueSettingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BrideAndMaid",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ContactUs",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Faqs",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "GroomAndMan",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "MetaTags",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "OrderDetail",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RsvpDetail",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TemplateComments",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TemplateImage",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TemplateMergeField",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TimeLine",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "UserWeddingSubscription",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Venue",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WeddingImages",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Blogs",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "OrderMaster",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "SubscriptionMaster",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WeddingEvent",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Wedding",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TemplateMaster",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "WeddingTemplateSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BannerSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BestManSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "BrideMaidSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "CoupleSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "EventsSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "GallerySettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "GiftRegistrySettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "GroomsMenSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "InvitationSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RsvpSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "TimeLineSettings",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "VenueSettings",
                schema: "Catalog");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Group",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                schema: "Identity",
                table: "RoleClaims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                schema: "Identity",
                table: "RoleClaims",
                type: "datetime2",
                nullable: true);
        }
    }
}
