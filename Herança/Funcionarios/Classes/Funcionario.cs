namespace Funcionarios.Classes;
    internal class Funcionario
    {
        public virtual void ExibirInformacoes()
        {
            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Funcionário: {0}", nome);

            Console.Write("\nDigite o salário do funcionário: ");
            decimal salario = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine($"Salário: {salario:C}");
        }
    }

