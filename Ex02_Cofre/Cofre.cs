public class Cofre
{
//Atributos: Dono, senha (string), estáAberto (bool) e número de tentativas erradas.
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public bool EstaAberto => estaAberto;
//Construtor: Recebe o nome do dono e a senha inicial. O cofre sempre começa fechado e com 0 tentativas erradas.
    public Cofre(string dono,string senha)
    {
        this.dono=dono;
        this.senha=senha;
    }
//Métodos:
//abrir(senhaInformada): Se a senha estiver correta, o cofre abre e as tentativas zeram. Se errar, incrementa o contador de erros.
    public void Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
        {
            Console.WriteLine("Cofre bloqueado!");
            return;
        }

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            Console.WriteLine("Cofre aberto com sucesso!");
        }
        else
        {
            tentativasErradas++;
            Console.WriteLine("Senha incorreta!");
        }
    }

//fechar(): Altera o estado para fechado.
    public void Fechar()
    {
        estaAberto = false;
        Console.WriteLine("Cofre fechado.");
    }

    //alterarSenha(senhaAntiga, novaSenha): Só permite trocar a senha se o cofre estiver aberto e a senha antiga for validada.
    public void AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
        {
            Console.WriteLine("O cofre precisa estar aberto!");
            return;
        }

        if (senhaAntiga == senha)
        {
            senha = novaSenha;
            Console.WriteLine("Senha alterada com sucesso!");
        }
        else
        {
            Console.WriteLine("Senha antiga incorreta!");
        }
    }
    public override string ToString()
    {
        return $"Dono: {dono}, Aberto: {estaAberto}, Tentativas Erradas: {tentativasErradas}";
    }
}