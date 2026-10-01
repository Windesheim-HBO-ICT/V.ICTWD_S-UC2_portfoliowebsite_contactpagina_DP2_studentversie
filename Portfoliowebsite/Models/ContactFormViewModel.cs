using System.ComponentModel.DataAnnotations;

namespace Portfoliowebsite.Models;

public class ContactFormViewModel
{
    [Required(ErrorMessage = "Vul je naam in.")]
    [Display(Name = "Naam")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vul je e-mailadres in.")]

    [Display(Name = "E-mailadres")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vul een onderwerp in.")]
    [StringLength(80, ErrorMessage = "Gebruik maximaal 80 tekens.")]
    public string Subject { get; set; } = string.Empty;

    [Required(ErrorMessage = "Vul een bericht in.")]

    public string Message { get; set; } = string.Empty;

    public string Website { get; set; } = string.Empty;
}
