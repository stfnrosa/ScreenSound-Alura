using ScreenSound_Classes;

public class Album
{
    private List<Musica> musicaLista = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public int DuracaoTotal => musicaLista.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicaLista.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");
        foreach (var musica in musicaLista)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
            Console.WriteLine($"Esse álbum possui a duração total de {DuracaoTotal} segundos");
    }
} 