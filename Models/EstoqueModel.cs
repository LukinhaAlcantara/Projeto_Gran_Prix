﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gran_Prix.Models
{
    public class EstoqueModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o preço!")]
        public double Preco { get; set; }
        [Required(ErrorMessage = "Digite a quantidade!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Digite o código!")]
        public string Codigo { get; set; }
        public int Fornecedor_Id { get; set; }
        public FornecedorModel? Fornecedor { get; set; }
    }
}