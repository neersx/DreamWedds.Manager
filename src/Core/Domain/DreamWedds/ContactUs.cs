﻿using System.ComponentModel.DataAnnotations;

namespace DreamWedds.Manager.Domain.Entities.DreamWedds;

public class ContactUs : AuditableEntity, IAggregateRoot
{
    [MaxLength(50)]
    public string? FirstName { get; set; }
    [MaxLength(50)]
    public string? LastName { get; set; }
    [MaxLength(150)]
    public string? Email { get; set; }

    [MaxLength(15)]
    public string? Mobile { get; set; }
    [MaxLength(1000)]
    public string? Message { get; set; }
    [MaxLength(250)]
    public string? Subject { get; set; }
    [MaxLength(20)]
    public string? ContactFor { get; set; } // Wedding, Billing, Account

    public ContactUs(string firstName, string lastName, string message, string mobile, string? email)
    {
        FirstName = firstName;
        LastName = lastName;
        Message = message;
        Email = email;
        Mobile = mobile;
        Subject= $"Contact Us form request from {firstName} {lastName}";
        ContactFor = "Wedding";
    }
}
