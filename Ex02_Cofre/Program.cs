Cofre cofre = new Cofre("Zahara", "1234");

// Tentativas erradas
cofre.Abrir("1111");
cofre.Abrir("2222");
cofre.Abrir("3333");

// Vai bloquear
cofre.Abrir("1234");

// Criando outro cofre pra testar normal
Cofre cofre2 = new Cofre("Zahara", "1234");

cofre2.Abrir("1234"); // correto
cofre2.AlterarSenha("1234", "9999");
cofre2.Fechar();

Console.WriteLine(cofre2);