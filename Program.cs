
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
        string? tipo = Console.ReadLine().ToLower();

        if(tipo == "f"){
            // instância do objeto
            PessoaFisica pessoa = new PessoaFisica();
            pessoa.Nome = nome;
            pessoa.Endereco = endereco;
            Console.WriteLine("Informar CPF: ");
            pessoa.Cpf = Console.ReadLine();
            Console.WriteLine("Informe o RG: ");
            pessoa.Rg = Console.ReadLine();
            Console.WriteLine("Informe o valor da compra: ");
            valor_pago = float.Parse(Console.ReadLine());
            pessoa.PagarImposto(valor_pago);
            Console.WriteLine("---------Pessoa Física--------");
            Console.WriteLine("---------Nome:------" + pessoa.Nome);
            Console.WriteLine("---------Endereço:------" + pessoa.Endereco);
            Console.WriteLine("---------CPF:------" + pessoa.Cpf);
            Console.WriteLine("---------RG:------" + pessoa.Rg);
            Console.WriteLine("---------Valor da Compra:------" + pessoa.Valor.ToString("C")); // formatando a saída em Moeda
            Console.WriteLine("---------Imposto:------" + pessoa.ValorImposto.ToString("C"));
            Console.WriteLine("---------Total:------" + pessoa.Total.ToString("C"));
            

        }
    }
}