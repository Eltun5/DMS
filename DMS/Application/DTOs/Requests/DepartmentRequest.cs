using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication1.Application.DTOs.Requests;

public record DepartmentRequest(
    [Required, MinLength(2)]
    string Name,

    string Description,

    [Required]
    string ManagerId
);
