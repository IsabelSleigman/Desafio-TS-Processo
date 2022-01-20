using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp2
{
    public class FaturamentoEstado
    {
        public double Valor { get; set; }
        public string Estado { get; set; }
    }

    public class Distribuidora
    {
        List<FaturamentoEstado> FaturamentoMensalDetalhado = new List<FaturamentoEstado>();

        public Distribuidora()
        {
            FaturamentoMensalDetalhado.Add(new FaturamentoEstado { Estado = "SP", Valor = 67836.43 });
            FaturamentoMensalDetalhado.Add(new FaturamentoEstado { Estado = "RJ", Valor = 36678.66 });
            FaturamentoMensalDetalhado.Add(new FaturamentoEstado { Estado = "MG", Valor = 29229.88 });
            FaturamentoMensalDetalhado.Add(new FaturamentoEstado { Estado = "ES", Valor = 27167.48 });
            FaturamentoMensalDetalhado.Add(new FaturamentoEstado { Estado = "OUTROS", Valor = 19849.53 });
        }

        public void CalcularPercentualPorEstado()
        {
            var totalFaturado = FaturamentoMensalDetalhado.Sum(f => f.Valor);
            Console.WriteLine("Total Faturado: R$" + totalFaturado.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("");

            foreach(var fat in FaturamentoMensalDetalhado)
            {
                Console.WriteLine("Estado: " + fat.Estado +  " Faturado: R$" + fat.Valor.ToString(CultureInfo.InvariantCulture));
                var porcentagemParticipacao = (fat.Valor * 100) / totalFaturado;
                Console.WriteLine("Porcentagem de paricipação: " + porcentagemParticipacao.ToString(CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var Distribuidora = new Distribuidora();
            Distribuidora.CalcularPercentualPorEstado();
            Console.ReadLine();
        }
    }
}
