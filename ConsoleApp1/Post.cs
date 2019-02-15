using System;

namespace ConsoleApp1
{
    public class Post
    {
        public Post()
        {
        }
            public int Id { get; set; }


        public string Titulo { get; set; }


        public string Resumo { get; set; }


        public string Categoria { get; set; }

        public DateTime? DataPublicacao { get; set; }

        public bool Publicado { get; set; }

        public Usuario Autor { get; set; }
    }
}
