using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication1.Application.DTOs.Requests;

public record ChangePasswordRequest(
    [Required]
    string UserId,

    [Required, MinLength(8)]
    string OldPassword,

    [Required, MinLength(8)]
    string NewPassword 
    );