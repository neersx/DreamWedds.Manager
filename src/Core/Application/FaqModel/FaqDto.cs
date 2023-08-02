using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Application.FaqModel;
public class FaqDto : IDto
{
    public int Id { get; set; }
    [MaxLength(250)]
    [Required]
    public string Question { get; set; }
    [Required]
    [MaxLength(1000)]
    public string Answer { get; set; }
    [MaxLength(200)]
    public string? Website { get; set; }
    public bool IsMainQue { get; set; } = false;
    public int? ParentQuestionId { get; set; }
    public int? Sequence { get; set; }
    public int? FaqType { get; set; }
}
