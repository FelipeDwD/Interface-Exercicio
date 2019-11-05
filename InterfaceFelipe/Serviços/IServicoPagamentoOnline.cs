using System;
using System.Collections.Generic;
using System.Text;
using Interface2.Entidades;

namespace Interface2.Serviços
{
    interface IServicoPagamentoOnline
    {
        double PagamentoParcelaPaypal(int parcelas, double valor);
    }
}
