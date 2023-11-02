using System.Security.Cryptography.X509Certificates;

namespace Gran_Prix.Models
{
    public class CaixaModel
    {
        public int Id { get; set; }
        public double Entrada { get; set; }
        public double Saida { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public int Pedido_Id { get; set; }

    }
}