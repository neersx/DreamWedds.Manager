using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations.Application
{
    /// <inheritdoc />
    public partial class templateSettingsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemplateMaster_WeddingTemplateSettings_WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BannerSettings_BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BestManSettings_BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BrideMaidSettings_BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_CoupleSettings_CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_EventsSettings_EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GallerySettings_GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GiftRegistrySettings_GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GroomsMenSettings_GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_InvitationSettings_InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_RsvpSettings_RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_TimeLineSettings_TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_VenueSettings_VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.AlterColumn<int>(
                name: "VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CopyRightText",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImageResolution",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaxResolution",
                schema: "Catalog",
                table: "TimeLineSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "DefaultResolution",
                schema: "Catalog",
                table: "TimeLineSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundColor",
                schema: "Catalog",
                table: "InvitationSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "GroomsMenSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "MaxImagesCount",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MaxImageResolution",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DefaultImagesCount",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "GroomImageResolution",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "CssStyle",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "BrideImageResolution",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "BrideMaidSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "BestManSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "MaxResolution",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "DefaultResolution",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "CssStyle",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateMaster_WeddingTemplateSettings_WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster",
                column: "WeddingTemplateSettingsId",
                principalSchema: "Catalog",
                principalTable: "WeddingTemplateSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BannerSettings_BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BannerSettingsId",
                principalSchema: "Catalog",
                principalTable: "BannerSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BestManSettings_BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BestManSettingsId",
                principalSchema: "Catalog",
                principalTable: "BestManSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BrideMaidSettings_BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BrideMaidSettingsId",
                principalSchema: "Catalog",
                principalTable: "BrideMaidSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_CoupleSettings_CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "CoupleSettingsId",
                principalSchema: "Catalog",
                principalTable: "CoupleSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_EventsSettings_EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "EventsSettingsId",
                principalSchema: "Catalog",
                principalTable: "EventsSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GallerySettings_GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GallerySettingsId",
                principalSchema: "Catalog",
                principalTable: "GallerySettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GiftRegistrySettings_GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GiftRegistrySettingsId",
                principalSchema: "Catalog",
                principalTable: "GiftRegistrySettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GroomsMenSettings_GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GroomsMenSettingsId",
                principalSchema: "Catalog",
                principalTable: "GroomsMenSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_InvitationSettings_InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "InvitationSettingsId",
                principalSchema: "Catalog",
                principalTable: "InvitationSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_RsvpSettings_RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "RsvpSettingsId",
                principalSchema: "Catalog",
                principalTable: "RsvpSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_TimeLineSettings_TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "TimeLineSettingsId",
                principalSchema: "Catalog",
                principalTable: "TimeLineSettings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_VenueSettings_VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "VenueSettingsId",
                principalSchema: "Catalog",
                principalTable: "VenueSettings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemplateMaster_WeddingTemplateSettings_WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BannerSettings_BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BestManSettings_BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_BrideMaidSettings_BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_CoupleSettings_CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_EventsSettings_EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GallerySettings_GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GiftRegistrySettings_GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_GroomsMenSettings_GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_InvitationSettings_InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_RsvpSettings_RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_TimeLineSettings_TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_WeddingTemplateSettings_VenueSettings_VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings");

            migrationBuilder.AlterColumn<int>(
                name: "VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CopyRightText",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundImageResolution",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaxResolution",
                schema: "Catalog",
                table: "TimeLineSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DefaultResolution",
                schema: "Catalog",
                table: "TimeLineSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackgroundColor",
                schema: "Catalog",
                table: "InvitationSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "GroomsMenSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaxImagesCount",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaxImageResolution",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DefaultImagesCount",
                schema: "Catalog",
                table: "GallerySettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GroomImageResolution",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CssStyle",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrideImageResolution",
                schema: "Catalog",
                table: "CoupleSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "BrideMaidSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageResolution",
                schema: "Catalog",
                table: "BestManSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Placement",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MaxResolution",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DefaultResolution",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CssStyle",
                schema: "Catalog",
                table: "BannerSettings",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateMaster_WeddingTemplateSettings_WeddingTemplateSettingsId",
                schema: "Catalog",
                table: "TemplateMaster",
                column: "WeddingTemplateSettingsId",
                principalSchema: "Catalog",
                principalTable: "WeddingTemplateSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BannerSettings_BannerSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BannerSettingsId",
                principalSchema: "Catalog",
                principalTable: "BannerSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BestManSettings_BestManSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BestManSettingsId",
                principalSchema: "Catalog",
                principalTable: "BestManSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_BrideMaidSettings_BrideMaidSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "BrideMaidSettingsId",
                principalSchema: "Catalog",
                principalTable: "BrideMaidSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_CoupleSettings_CoupleSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "CoupleSettingsId",
                principalSchema: "Catalog",
                principalTable: "CoupleSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_EventsSettings_EventsSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "EventsSettingsId",
                principalSchema: "Catalog",
                principalTable: "EventsSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GallerySettings_GallerySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GallerySettingsId",
                principalSchema: "Catalog",
                principalTable: "GallerySettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GiftRegistrySettings_GiftRegistrySettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GiftRegistrySettingsId",
                principalSchema: "Catalog",
                principalTable: "GiftRegistrySettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_GroomsMenSettings_GroomsMenSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "GroomsMenSettingsId",
                principalSchema: "Catalog",
                principalTable: "GroomsMenSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_InvitationSettings_InvitationSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "InvitationSettingsId",
                principalSchema: "Catalog",
                principalTable: "InvitationSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_RsvpSettings_RsvpSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "RsvpSettingsId",
                principalSchema: "Catalog",
                principalTable: "RsvpSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_TimeLineSettings_TimeLineSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "TimeLineSettingsId",
                principalSchema: "Catalog",
                principalTable: "TimeLineSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeddingTemplateSettings_VenueSettings_VenueSettingsId",
                schema: "Catalog",
                table: "WeddingTemplateSettings",
                column: "VenueSettingsId",
                principalSchema: "Catalog",
                principalTable: "VenueSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
