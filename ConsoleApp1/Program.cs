using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            OutroMetodoAqui();
        }

        private static void OutroMetodoAqui()
        {
            Post p1 = new Post();
            p1.Titulo = "Post de novo";
            p1.Resumo = "resumindo";
            p1.Categoria = "filme";

            Post p2 = new Post();
            p2.Titulo = "Post de novo";
            p2.Resumo = "resumindo";
            p2.Categoria = "filme";

            Post p3 = new Post();
            p3.Titulo = "Post de novo";
            p3.Resumo = "resumindo";
            p3.Categoria = "filme";

            List<Post> posts = new List<Post>();
            posts.Add(p1);
            posts.Add(p2);
            posts.Add(p3);

            Usuario u = new Usuario();
            u.Nome = "teste";
            u.Email = "gabriel.ferreira@caelum.com.br";
            u.Posts = posts;

            var teste = JsonConvert.SerializeObject(u);
        }

        private static void FazRequisicaoComPostJson()
        {
            HttpClient client = new HttpClient();

            var endereco = new Uri("http://blogmls.azurewebsites.net/api/post/novo");

            Post p = new Post();
            p.Titulo = "Post de novo";
            p.Resumo = "resumindo";
            p.Categoria = "filme";

            var retorno = client.PostAsJsonAsync(endereco,
                p).Result;

            Console.ReadLine();
        }

        private static void FazRequisicao()
        {
            try
            {
                HttpClient client = new HttpClient();

                var endereco = new Uri("http://blogmls.azurewebsites.net/api/post/novo");

                Post p = new Post();

                var retorno = client.PostAsync(endereco,
                    new StringContent("{ \"titulo\":\"post via api no console\",\"resumo\":\"via api\", \"categoria\":\"qualquer uma\",\"dataPublicacao\":null,\"publicado\":false,\"autor\":null }", Encoding.UTF8, "text/json"));

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
