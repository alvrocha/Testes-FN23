using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public IList<Post> Posts { get; set; }
    }
}