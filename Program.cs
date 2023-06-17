using SenaiApp.Entidades;
using SenaiBanco.Contexto;
using SenaiBanco.Entidades;

namespace SenaiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contexto = new SenaiContext();
            var escola = contexto.Escola.Where(c => c.Nome == "Senai").FirstOrDefault();


            //var escola = new Escola()
            //{
            //    Nome = "Bom pastor",
            //   Endereco = new Endereco()
            //   {
            //        Rua = "AV Nereu Ramod",
            //        Bairro = "Centro",
            //        Estado = "SC",
            //        Cidade = "Chapecó"
            //    }
            //};

            //contexto.Escola.Add(escola);
            //contexto.SaveChanges();

            var professor = new Professor()
            {
                Nome = "Keni Borges",
                EscolaId = escola.Id
            };
            

        }
    }
}