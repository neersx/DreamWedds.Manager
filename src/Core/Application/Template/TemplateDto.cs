using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Application.Template;
public class TemplateDto : IDto
{
    [MaxLength(250)]
    public string Name { get; set; }
    public int Type { get; set; }
    public int Status { get; set; }
    public string Content { get; set; }
    [MaxLength(250)]
    public string? Subject { get; set; }
    [MaxLength(250)]
    public string? Tags { get; set; }
    [MaxLength(500)]
    public string? TemplateUrl { get; set; }
    [MaxLength(250)]
    public string? TemplateFolderPath { get; set; }
    [MaxLength(500)]
    public string? ThumbnailImageUrl { get; set; }
    [MaxLength(250)]
    public string? TagLine { get; set; }
    public int? Cost { get; set; }
    [MaxLength(150)]
    public string? AuthorName { get; set; }
    [MaxLength(1000)]
    public string? AboutTemplate { get; set; }
    [MaxLength(500)]
    public string? Features { get; set; }
    public int? TemplateCode { get; set; }
}
