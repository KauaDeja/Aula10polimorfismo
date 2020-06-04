using System;

namespace Aula10Polimorfismo
{
    public class Relatorio
    {
        public DateTime data { get; set; }

        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("Mostrando Relatório geral");
        }
    }
}