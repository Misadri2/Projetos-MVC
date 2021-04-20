using Projeto_Leituras.Models;
using System.Collections.Generic;

namespace Projeto_Leituras.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public int Estrelas { get; set; }
        
        public Livro() { }

        public Livro(int id, string título, string autor, int estrelas)
        {
            Id = id;
            Título = título;
            Autor = autor;
            Estrelas = estrelas;
        }       
    }
}
