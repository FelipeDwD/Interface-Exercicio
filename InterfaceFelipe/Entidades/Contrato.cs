using System;
using System.Collections.Generic;
using System.Text;
using Interface2.Entidades;

namespace InterfaceFelipe.Entidades
{
    class Contrato
    {
        public int Numero { get; set; }

        public DateTime Data { get; set; }

        public double ValorTotal { get; set; }

        public List<Parcela> Parcelas { get; set; } = new List<Parcela>();
        public Contrato() { }

        public Contrato(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
        }

        public void AdicionarParcela(Parcela parcela)
        {
            Parcelas.Add(parcela);
        }
    }
}
