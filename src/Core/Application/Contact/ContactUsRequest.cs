using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Application.Contact;
public class ContactUsRequest : IRequest<Guid>
{
    [MaxLength(50)]
    [Required]
    public string? FirstName { get; set; }
    [MaxLength(50)]
    public string? LastName { get; set; }
    [MaxLength(150)]
    public string? Email { get; set; }

    [MaxLength(15)]
    [Required]
    public string? Mobile { get; set; }
    [MaxLength(1000)]
    public string? Message { get; set; }
    [MaxLength(250)]
    public string? Subject { get; set; }
    [MaxLength(20)]
    public string? ContactFor { get; set; } // Wedding, Billing, Account
}
