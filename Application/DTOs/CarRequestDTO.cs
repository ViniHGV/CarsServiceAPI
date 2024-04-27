using System.ComponentModel.DataAnnotations;

namespace CarServiceAPI.Application.DTOs
{
    public class CarRequestDTO
    {
        [Required(ErrorMessage = "Informar o nome é obrigatório!")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inserido não é valido!")]
        [Required(ErrorMessage = "Informar o E-mail é obrigatório!")]
        public string Email { get; set; }
    }
}