using ScreenSound_Classes;

class Album
{
    private List<Musica> musicaLista = new List<Musica>();
    public string Nome { get; set; }

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