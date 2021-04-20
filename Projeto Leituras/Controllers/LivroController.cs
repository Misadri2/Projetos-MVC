using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Projeto_Leituras.Data;
using Projeto_Leituras.Models;

namespace Projeto_Leituras.Controllers
{
    public class LivroController : Controller  //!Importante nome do controller(Livro) ser o mesmo da pasta em Views(Livro)
    {
        private readonly ApplicationDbContext database;         //injeção de dependência para Banco de dados
        public LivroController(ApplicationDbContext database)    //injeção de dependência para Banco de dados
        {
            this.database = database;                           //injeção de dependência para Banco de dados
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Index()                         // vai retornar a view que está na View/Gestao/Index
        {
            var livro = database.Livro.ToList();             // método que vai listar os dados cadastrados
            return View(livro);
        }

        public IActionResult Editar(int id)  // tem que receber um parâmetro id
        {                        
            Livro livro = database.Livro.First(registro => registro.Id == id);   //para procurar o Id com essa condição
            return View("Cadastrar", livro);
        }

        public IActionResult Deletar(int id)
        {
            Livro livro = database.Livro.First(registro => registro.Id == id);
            database.Livro.Remove(livro);
            database.SaveChanges();
            return RedirectToAction("Index");}

            [HttpPost]            
            public IActionResult Salvar(Livro livro)   // tem que colocar método if e else para saber quando é para atualizar e quando é para salvar
            {
                if(livro.Id == 0){                     //se o campo Id for vazio, salva o novo livro
                database.Livro.Add(livro);              //método Add adiciona algo no banco de dados
                }else{
                var livroBcoDados = database.Livro.First(registro => registro.Id == livro.Id);
                livroBcoDados.Título = livro.Título;
                livroBcoDados.Autor = livro.Autor;
                livroBcoDados.Estrelas = livro.Estrelas;
                }                                  
                database.SaveChanges();                     //método que salva os dados
                return RedirectToAction("Index");    // mensagem que retorna 
            }
        }
    }


        