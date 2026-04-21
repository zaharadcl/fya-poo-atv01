public class Lampada
{
    //Atributos: Marca, tecnologia (LED, Incandescente, etc.), estado (ligada/desligada) e brilho (0 a 100).
    private string marca;
    private readonly string tecnologia;
    private bool ligada;
    private int brilho;

    // Construtor: Informar obrigatoriamente a marca e tecnologia. A lâmpada inicia desligada e com brilho em 100%.
    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false;
        this.brilho = 100;
    }

    // Método alternar(): Se estiver ligada, desliga. Se estiver desligada, liga.
    public void Alternar()
    {
        ligada = !ligada;
    }

    // Método ajustarBrilho(novoBrilho): Altera o brilho apenas se o valor estiver entre 0 e 100.
    public void AjustarBrilho(int novoBrilho)
    {
        if (ligada && novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
        else
        {
            Console.WriteLine("Não foi possível ajustar o brilho.");
        }
    }

    public override string ToString()
    {
        return $"Marca: {marca}, Tecnologia: {tecnologia}, Ligada: {ligada}, Brilho: {brilho}";
    }
}