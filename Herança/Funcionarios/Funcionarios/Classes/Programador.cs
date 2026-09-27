namespace Funcionarios.Classes
{
    internal class Programador : Funcionario
    {
        public override void ExibirInformacoes()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("Informações do Programador");
            Console.WriteLine("**************************\n");
            base.ExibirInformacoes();

            Console.Write("\nDigite a linguagem que os programadores utilizam na empresa: ");
            string linguagem = Console.ReadLine()!;
            Console.WriteLine("Linguagem utilizada na empresa: {0}\n", linguagem);
        }
    }
}
