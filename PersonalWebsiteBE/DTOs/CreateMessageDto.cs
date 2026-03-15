namespace PersonalWebsiteBE.DTOs;
using System.ComponentModel.DataAnnotations;
public class CreateMessageDto
{
    [Required]
    public string Nombres { get; set; }
    
    [Required]
    public string Apellidos { get; set; }

    [Required]
    public string Telefono { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    [MaxLength(500)]
    public string Mensaje { get; set; }  
       
}