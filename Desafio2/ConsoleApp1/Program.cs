using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Dia
    {
        public int Faturamento { get; set; }
    }

    public class Ano
    {
        public List<Dia> DiasAno = new List<Dia>(365);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var anoFaturamento = new Ano();

            var diasFaturados = anoFaturamento.DiasAno.Where(d => d.Faturamento > 0);

            var faturamentoAnual = diasFaturados.Sum(d => d.Faturamento);

            var mediaFaturamentoAnual = faturamentoAnual / diasFaturados.Count();

            var diasFaturamentoSuperiorMedia = diasFaturados.Where(d => d.Faturamento > mediaFaturamentoAnual);

            var menorValorFaturadoAnual = diasFaturados.Min(d => d.Faturamento);

            var maiorValorFaturadoAnual = diasFaturados.Max(d => d.Faturamento);
        }
    }
}
