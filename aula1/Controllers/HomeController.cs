using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aula1.Models;
using aula1.DataBase;
using Microsoft.EntityFrameworkCore;

namespace aula1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext database;
        public HomeController(ApplicationDbContext database){
            this.database = database;
        }

         public IActionResult Index()   // usuarios tem acesso a essas actions
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Teste (){
           /* Categoria c1 = new Categoria();
            c1.Nome = "Victor";            
            Categoria c2 = new Categoria();
            c2.Nome = "Victor";            
            Categoria c3 = new Categoria();
            c3.Nome = "Erick";            
            Categoria c4 = new Categoria();
            c4.Nome = "Wesley";            

            List<Categoria> catList = new List<Categoria>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);
            catList.Add(c4);
            

            database.AddRange(catList); 

            database.SaveChanges();   
              */

            var listaDeCategorias = database.Categorias.Where(cat => cat.Nome.Equals("Victor")).ToList();  //fomos no banco de dados e buscamos as categorias

            Console.WriteLine("-------Categorias---------");

            listaDeCategorias.ForEach(Categoria => {
                Console.WriteLine(Categoria.ToString());
            });

            Console.WriteLine("---------------------------");
            
            return Content("Dados Salvos");
        }

        public IActionResult Relacionamento(){    //método para salvar entidades com relacionamento no EF(categoria)
            /* Produto p = new Produto();
            p.Nome = "Doritos";
            p.Categoria = database.Categorias.First(c => c.Id ==1);
            Produto p2 = new Produto();
            p2.Nome = "Frango";
            p2.Categoria = database.Categorias.First(c => c.Id ==1);
            Produto p3 = new Produto();
            p3.Nome = "Bolo";
            p3.Categoria = database.Categorias.First(c => c.Id ==2);

            database.Add(p);
            database.Add(p2);
            database.Add(p3);

            database.SaveChanges();*/

           /* var listaDeProdutos = database.Produto.Include(p => p.Categoria).ToList();
            listaDeProdutos.ForEach(Produto => {
                Console.WriteLine(Produto.ToString());
            });*/

            //Abaixo uma forma de fazer uma consulta de um para muitos, ou seja, achar todos os dados dentro da Id
            var listaDeProdutosDeUmaCategoria = database.Produto.Include(p => p.Categoria).Where(p => p.Categoria.Id == 1).ToList();
               listaDeProdutosDeUmaCategoria.ForEach(Produto => {
                Console.WriteLine(Produto.ToString());
            });

            return Content("Relacionamento");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
