Conta conta = new Conta(12345, "Zahara");

// depósito
conta.Depositar(300);

// saque normal
conta.Sacar(200);

// usando limite (vai ficar negativo)
conta.Sacar(600);

Console.WriteLine(conta);
Console.WriteLine($"Saldo Total: {conta.SaldoTotal}");
Console.WriteLine($"Status: {conta.StatusConta}");