using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication1.Application.DTOs.Requests;

public record LoginRequest(
    [Required, EmailAddress]
    string Email,

    [Required, MinLength(6)]
    string Password
);