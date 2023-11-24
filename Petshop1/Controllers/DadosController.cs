using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petshop1.Models;

namespace Petshop1.Controllers
{
    public class DadosController : Controller
    {
        private readonly Contexto contexto;

        public DadosController(Contexto context)
        {
            contexto = context; 
        }

        public IActionResult Index()
        {
            contexto.Database.ExecuteSqlRaw("delete from clientes");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('clientes', RESEED, 0)");

            contexto.Database.ExecuteSqlRaw("delete from animais");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('animais', RESEED, 0)");

            Random randNum = new Random();

            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };
            string[] vCidade = { "Assis", "Candido Mota", "Taruma", "Paraguaçu Paulista", "Palmital", "Pedrinhas", "Maracai", "Cruzalia" };
            
            for (int i = 0; i < 100; i++)
            {
                Cliente cliente = new Cliente();

                cliente.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                cliente.cidade = vCidade[randNum.Next() % 8];
                contexto.Clientes.Add(cliente);
            }
            for (int i = 1; i <= 10; i++)
            {
                Animal Animal = new Animal();

                Animal.nome = "Animal " + i;
                Animal.tipoAnimal = "tipo" + i;

                contexto.Animais.Add(Animal);
            }
            contexto.SaveChanges();

            return View();
        }
    }
}
