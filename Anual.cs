namespace Aula10Polimorfismo
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();

            System.Console.WriteLine("Mostrando Relatório por ano");
        }
    }
}