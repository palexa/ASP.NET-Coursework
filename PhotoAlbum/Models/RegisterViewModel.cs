using System;
using System.ComponentModel.DataAnnotations;

namespace PhotoAlbum.Models
{
    public class RegisterViewModel
    {
        [ScaffoldColumn(false)]

        public int Id { get; set; }

        [Display(Name = "Введите логин :")]
        [Required]
        public string Login { get; set; }

        [Display(Name = "Введите e-mail :")]
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не может быть пустым")]
        [StringLength(100, ErrorMessage = "Пароль должен содержать как минимум {2} символов", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Введите пароль :")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердите пароль :")]
        [Compare("Password", ErrorMessage = "Пароли должен совпадать")]
        public string ConfirmPassword { get; set; }
    }
}