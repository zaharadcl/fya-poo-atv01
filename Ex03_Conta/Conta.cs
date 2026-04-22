public class Conta
{
//Atributos: Número da conta, titular, saldo, limite de cheque especial.
    private readonly int numero;
    private string titular;
    private double saldo;
    private double limite;

    // Propriedade para alterar titular (pode mudar)
    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    // Propriedade somente leitura
    public int Numero => numero;

    // Campo calculado
    public double SaldoTotal => saldo + limite;

    // Campo calculado
    public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

    //Construtor: Recebe número e titular. O saldo inicial é 0 e o limite inicial é 500.
    public Conta(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = 0;
        this.limite = 500;
    }

    //depositar(valor): Aumenta o saldo (apenas valores positivos).
    public bool Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            return true;
        }
        return false;
    }

    //sacar(valor): Só permite o saque se o valor for menor ou igual ao SaldoTotal. Se o saque usar o limite, o saldo ficará negativo.
    public bool Sacar(double valor)
    {
        if (valor > 0 && valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Conta: {numero} | Titular: {titular} | Saldo: {saldo} | Limite: {limite}";
    }
}