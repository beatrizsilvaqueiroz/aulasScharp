namespace aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int idade = 19;
            string nomeCompleto = "Beatriz Silva Queiroz";

            var variavelSemTipo = "Beatriz";

            Console.WriteLine(variavelSemTipo.GetType());


            Console.WriteLine("digite seu nome: ");

            string nomeUsuario = Console.ReadLine();

            Console.WriteLine("digite a sua idade: ");
            string idadeUsuario = Console.ReadLine();

            Console.WriteLine($"meu nome é {nomeUsuario} e a minha idade é {idade}");
        }
    }
}
