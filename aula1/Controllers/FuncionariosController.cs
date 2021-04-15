using System;
using System.Linq;
using aula1.Models;
using aula1.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace aula1.Controllers
{          //*Sempre que a classe for controler tem que estender e colocar o nome "controller" no fim da classe
    public class FuncionariosController : Controller   
    {   
        private readonly ApplicationDbContext database;
        public FuncionariosController(ApplicationDbContext database){
            this.database=database;
        }

        public IActionResult Index (){
            var funcionarios  = database.Funcionarios.ToList();
            return View(funcionarios);
        }
        public IActionResult Cadastrar (){
            return View();
        }
       
        public IActionResult Editar (int id){
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id); //* Em registro é possível colocar condições lógicas.
            return View("Cadastrar", funcionario);
        }
         public IActionResult Deletar (int id){
            Funcionario funcionario = database.Funcionarios.First(registro => registro.Id == id); 
            database.Funcionarios.Remove(funcionario);
            database.SaveChanges();
            return RedirectToAction("Index");
         }
        [HttpPost]
        public IActionResult Salvar(Funcionario funcionario){
            if(funcionario.Id == 0){
                database.Funcionarios.Add(funcionario);  //*salve um novo funcionário
            }else{                                        
                var funcionarioDoBanco = database.Funcionarios.First(registro => registro.Id == funcionario.Id);
                funcionarioDoBanco.Nome = funcionario.Nome;         //*Alterar dados de um funcionário
                funcionarioDoBanco.CPF = funcionario.CPF;
                funcionarioDoBanco.Salario = funcionario.Salario;
            }            
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}