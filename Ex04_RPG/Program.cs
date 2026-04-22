Personagem p = new Personagem("Zahara", "Guerreiro");

Console.WriteLine(p);

p.ReceberDano(50);
Console.WriteLine(p);

p.Curar(30);
Console.WriteLine(p);

p.SubirNivel();
Console.WriteLine(p);

// matar personagem
p.ReceberDano(500);
Console.WriteLine(p);

// tentar curar morto
p.Curar(50);

// tentar subir nível morto
p.SubirNivel();