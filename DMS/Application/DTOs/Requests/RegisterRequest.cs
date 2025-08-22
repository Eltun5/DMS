using System.ComponentModel.DataAnnotations;

public record RegisterRequest(
    [Required, MinLength(3)]
    string FullName,

    [Required, EmailAddress]
    string Email,

    [Required, MinLength(8)]
    string Password,
    
    [Required]
    int Age,
    
    [Required, MinLength(8)]
    string PhoneNumber,

    string Location,

    string AdditionalInfo
);