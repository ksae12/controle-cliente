
namespace controle_clientes;

class Program
{
    static void Main(string[] args)
    {
        float valor_pago;
        Console.WriteLine("Informe o nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Informe o endereço: ");
        string? endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
        string? tipo = Console.ReadLine();

        // instância do objeto
        PessoaFisica pessoa1 = new PessoaFisica();
        pessoa1.Cpf = "123.873.323-43";
    }
}