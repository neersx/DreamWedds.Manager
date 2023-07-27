using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class dreamwedds_nullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingImages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingEvent",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Quote",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "IconUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FbPageUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImage",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Wedding",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "VenueSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Venue",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "UserWeddingSubscription",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TimeLineSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TimeLine",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateMergeField",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailImageUrl",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "TemplateUrl",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "TemplateFolderPath",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "TagLine",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "AboutTemplate",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateImage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "SubscriptionMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "RsvpSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "RsvpDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "OrderMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "OrderDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "TypeId",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "TagPrefix",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Property",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PageTitle",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "MetaTags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "InvitationSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GroomsMenSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GroomAndMan",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GiftRegistrySettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GallerySettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Faqs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "EventsSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "ContactUs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BrideMaidSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "LinkedinUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "InstagramUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "GoogleUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "FbUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(1250)",
                maxLength: 1250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1250)",
                oldMaxLength: 1250);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Brands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Quote",
                schema: "Catalog",
                table: "Blogs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                schema: "Catalog",
                table: "BlogComments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                schema: "Catalog",
                table: "BlogComments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BlogComments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BestManSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BannerSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingImages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "VenueSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Venue");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "UserWeddingSubscription");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TimeLineSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TimeLine");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateMergeField");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateMaster");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateImage");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "TemplateComments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "SubscriptionMaster");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "RsvpSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "RsvpDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "OrderMaster");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "MetaTags");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "InvitationSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GroomsMenSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GroomAndMan");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GiftRegistrySettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "GallerySettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "EventsSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "CoupleSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BrideMaidSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BrideAndMaid");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Brands");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BestManSettings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Catalog",
                table: "BannerSettings");

            migrationBuilder.AlterColumn<string>(
                name: "VideoUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Quote",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IconUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FbPageUrl",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImage",
                schema: "Catalog",
                table: "Wedding",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailImageUrl",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TemplateUrl",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TemplateFolderPath",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tags",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TagLine",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Features",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AboutTemplate",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeId",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TagPrefix",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Property",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PageTitle",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PageName",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                schema: "Catalog",
                table: "MetaTags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkedinUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstagramUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GoogleUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FbUrl",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                schema: "Catalog",
                table: "BrideAndMaid",
                type: "nvarchar(1250)",
                maxLength: 1250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1250)",
                oldMaxLength: 1250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Quote",
                schema: "Catalog",
                table: "Blogs",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                schema: "Catalog",
                table: "BlogComments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Icon",
                schema: "Catalog",
                table: "BlogComments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
