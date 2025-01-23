using System.ComponentModel.DataAnnotations;

namespace ProjeTakipSistemi.Models
{
    public class User
    {
         [Key]
    public int UserID { get; set; }

    [Required(ErrorMessage = "Email alanı zorunludur.")]
    public string UserEmail { get; set; }

    [Required(ErrorMessage = "Şifre alanı zorunludur.")]
    public string UserPassword { get; set; }

    [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
    public string UserNameSurname { get; set; }
    }
}
