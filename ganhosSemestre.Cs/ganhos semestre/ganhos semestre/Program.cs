using System;

namespace ganhos_semestre
{
    class Program
    {
        static void Main(string[] args)
        {
            double ganhoJaneiro;
            double gastoJaneiro;
            double totalJaneiro;

            Console.WriteLine("Digite o valor recebido do mês de Janeiro: ");
            ganhoJaneiro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor descontado do mês de Janeiro: ");
            gastoJaneiro = Convert.ToDouble(Console.ReadLine());

            totalJaneiro = ganhoJaneiro - gastoJaneiro;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");


            double ganhoFevereiro, gastoFevereiro, totalFevereiro;

            Console.WriteLine("Digite o valor recebido do mês de fevereiro: ");
            ganhoFevereiro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite agora o valor descontado do mês de fevereiro: ");
            gastoFevereiro = Convert.ToDouble(Console.ReadLine());

            totalFevereiro = ganhoFevereiro - gastoFevereiro;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            double ganhoMar, gastoMar, totalMar;

            Console.WriteLine("Digite o valor recebido do mês de março: ");
            ganhoMar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor descontado do mês de março");
            gastoMar = Convert.ToDouble(Console.ReadLine());

            totalMar = ganhoMar - gastoMar;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");


            double ganhoAbril, gastoabril, totalAbril;

            Console.WriteLine("Digite o valor recebido no mês de Abril: ");
            ganhoAbril = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor descontado no mês de abril: ");
            gastoabril = Convert.ToDouble(Console.ReadLine());

            totalAbril = ganhoAbril - gastoabril;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            double ganhoMaio, gastoMaio, totalMaio;

            Console.WriteLine("digite o valor recebido no mês de Maio: ");
            ganhoMaio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o valor descontado do mês de maio : ");
            gastoMaio = Convert.ToDouble(Console.ReadLine());

            totalMaio = ganhoMaio - gastoMaio;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");


            double ganhoJunho, gastoJunho, totalJunho;

            Console.WriteLine("digite o valor recebido no mês de junho: ");
            ganhoJunho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor descontado no mês de junho: ");
            gastoJunho = Convert.ToDouble(Console.ReadLine());

            totalJunho = ganhoJunho - gastoJunho;

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------------");

            double totalSemestre;

            totalSemestre = totalJaneiro + totalFevereiro + totalMar + totalAbril + totalMaio + totalJunho;

            Console.WriteLine("O valor acumulado no semestre é R$: " + totalSemestre + " Reais ");

            if (totalSemestre > 3000)
            {
                Console.WriteLine("Você está acima da meta semestral");
            }
            else
            {
                Console.WriteLine("Você está abaixo da meta semestral");
            }

            Console.WriteLine(" Obrigado por usar a TechnoSIS! ");






        }
    }
}
