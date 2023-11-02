using System.ComponentModel.DataAnnotations;

namespace Gran_Prix.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }
    }
}