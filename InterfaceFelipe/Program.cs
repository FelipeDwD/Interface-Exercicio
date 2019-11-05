using System;
using InterfaceFelipe.Entidades;
using Interface2.Serviços;
using System.Globalization;

namespace InterfaceFelipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato: ");

            Console.Write("Número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Valor total: ");
            double valorTotal = double.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valorTotal);

            Console.Write("Número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            ServicoContrato servico = new ServicoContrato();
            servico.ProcessarContrato(contrato, parcelas, new ServicoPayPal());

        }
    }
}
