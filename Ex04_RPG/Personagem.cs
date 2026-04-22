public class Personagem
{
    private string nome;
    private string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    // Construtor
    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.nivel = 1;

        if (classe == "Guerreiro")
        {
            vidaMaxima = 150;
        }
        else if (classe == "Mago")
        {
            vidaMaxima = 80;
        }
        else
        {
            Console.WriteLine("Classe inválida! Usando padrão Mago.");
            vidaMaxima = 80;
        }

        vidaAtual = vidaMaxima;
    }

    // Receber dano
    public void ReceberDano(double dano)
    {
        if (vidaAtual <= 0)
        {
            Console.WriteLine("Personagem está morto!");
            return;
        }

        if (dano > 0)
        {
            vidaAtual -= dano;

            if (vidaAtual < 0)
                vidaAtual = 0;
        }
    }

    // Curar
    public void Curar(double valor)
    {
        if (vidaAtual <= 0)
        {
            Console.WriteLine("Não é possível curar um personagem morto!");
            return;
        }

        if (valor > 0)
        {
            vidaAtual += valor;

            if (vidaAtual > vidaMaxima)
                vidaAtual = vidaMaxima;
        }
    }

    // Subir nível
    public void SubirNivel()
    {
        if (vidaAtual <= 0)
        {
            Console.WriteLine("Personagem morto não pode subir de nível!");
            return;
        }

        nivel++;
        vidaMaxima = vidaMaxima * 1.10; // aumenta 10%
        vidaAtual = vidaMaxima;

        Console.WriteLine("Subiu de nível!");
    }

    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual}/{vidaMaxima}";
    }
}