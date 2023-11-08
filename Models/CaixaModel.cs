﻿using System.Security.Cryptography.X509Certificates;

namespace Gran_Prix.Models
{
    public class CaixaModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

    }
}