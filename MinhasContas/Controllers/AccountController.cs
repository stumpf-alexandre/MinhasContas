using Microsoft.AspNetCore.Mvc;
using minhas_contas.Models;

namespace minhas_contas.Controllers
{
    public class AccountController:Controller
    {
        private readonly IAccountRepository _repository;

        public AccountController(IAccountRepository repository){
            _repository=repository;
        }

        public IActionResult Index(){
            var accounts=_repository.GetAll();
            return View(accounts);            
        }

        [HttpGet]
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account account){
            _repository.Create(account);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id){
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id){
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Account account){
            _repository.Update(account);
            return RedirectToAction("Index");
        }

        public IActionResult Pagar(int id){
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Pagar(Account account){
            _repository.Update(account);
            return RedirectToAction("Index");
        }

        public IActionResult MediaMenor(){
            var accounts=_repository.GetByKwGastoMenor();
            return View(accounts);
        }

        public IActionResult MediaMaior(){
            var accounts=_repository.GetByKwGastoMaior();
            return View(accounts);
        }
    }
}