using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Interface2.Entidades
{
    class Parcela
    {
        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public Parcela() { }

        public Parcela(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Data.Day);
            sb.Append("/");
            sb.Append(Data.Month);
            sb.Append("/");
            sb.Append(Data.Year);
            sb.Append(" - ");
            sb.Append(Valor.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
