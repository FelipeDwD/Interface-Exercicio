using System;
using System.Collections.Generic;
using System.Text;
using Interface2.Entidades;


namespace Interface2.Serviços
{
    class ServicoPayPal : IServicoPagamentoOnline
    {
        public int Parcelas { get; set; }

      

        public double PagamentoParcelaPaypal(int parcelas, double valor)
        {
            double jurosSimples = 0.01;
            double valorParcela = valor * jurosSimples;
            valorParcela *= parcelas;
            double taxaPagamento = valorParcela * 0.02;
            return valorParcela + taxaPagamento;
        }
    }
}
