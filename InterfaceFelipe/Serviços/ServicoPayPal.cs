using System;
using System.Collections.Generic;
using System.Text;
using Interface2.Entidades;


namespace Interface2.Serviços
{
    class ServicoPayPal : IServicoPagamentoOnline
    {
        public int Parcelas { get; set; }

        private const double VALOR_JUROS = 0.01;
        private const double TAXA_PAGAMENTO = 0.02;

        public double PagamentoParcelaPaypal(int parcelas, double valor)
        {
            double taxa = 0.0;
            double valorParcela = valor;
            taxa = valorParcela * VALOR_JUROS;            
            taxa *= parcelas;
            valorParcela += taxa;
            taxa = valorParcela * TAXA_PAGAMENTO;
            valorParcela += taxa;
            return valorParcela;
        }
    }
}
