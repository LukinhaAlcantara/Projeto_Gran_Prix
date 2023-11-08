using System.Security.Cryptography.X509Certificates;

namespace Projeto_Gran_Prix.Models
{
    public class CaixaFake
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
