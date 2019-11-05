using System;
using System.Collections.Generic;
using System.Text;
using InterfaceFelipe.Entidades;
using Interface2.Entidades;
namespace Interface2.Serviços
{
    class ServicoContrato
    {
        public IServicoPagamentoOnline ServicoPagamentoOnline;
               
        
        public void ProcessarContrato(Contrato contrato, int parcelas, IServicoPagamentoOnline servicoPagamentoOnline)
        {
            if (servicoPagamentoOnline is ServicoPayPal)
            {
                ServicoPayPal servicoPayPal = new ServicoPayPal();
                double valorParcela = contrato.ValorTotal / parcelas;

                for (int i = 1; i <= parcelas; i++)
                {
                    Parcela parcela = new Parcela(DateTime.Today, servicoPagamentoOnline.PagamentoParcelaPaypal(i, valorParcela));                    
                    contrato.AdicionarParcela(parcela);
                }
            }
        }
    }
}
