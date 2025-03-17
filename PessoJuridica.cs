namespace controle_clientes;

class PessoJuridica : Clientes
{
    public string Cnpj { get; set; }    
    public string Ie { get; set; }

    // override: permite sobrescrever o método
    public override void PagarImposto(float vlr)
    {
        this.Valor = vlr;
        this.ValorImposto = this.Valor * 20 / 100;
        this.Total = this.Valor + this.ValorImposto;
    }
}