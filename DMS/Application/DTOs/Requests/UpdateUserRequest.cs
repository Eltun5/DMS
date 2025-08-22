using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication1.Application.DTOs.Requests;


public record UpdateUserRequest(
    [Required, MinLength(3)]
    string FullName,

    [Required, EmailAddress]
    string Email,
    
    [Required]
    int Age,

    [Required, MinLength(8)]
    string PhoneNumber,
    
    string Location,

    string AdditionalInfo
);