using FilmesAPI.Models;


namespace FilmesAPI.Data.Dtos.Sessao
{
    public class ReadSessaoDto
    {

        public int Id { get; set; }
        public Cinema Cinema { get; set; }
        public Models.Filme Filme { get; set; }

    }
}
