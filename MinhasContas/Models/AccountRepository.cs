using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using minhas_contas.Models;

namespace minhas_contas.Models
{
    public class AccountRepository:IAccountRepository
    {
        private DataContext context;

        public AccountRepository(DataContext context){
            this.context=context;
        }

        public void Create(Account account){
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public void Delete(int id){
            context.Accounts.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Account account){
            context.Entry(account).State=EntityState.Modified;
            context.SaveChanges();
        }

        public Account GetById(int id){
            return context.Accounts.SingleOrDefault(x=>x.id==id);
        }

        public List<Account> GetAll(){
            return context.Accounts.ToList();
        }

        public List<Account> GetByKwGastoMenor(){
            return context.Accounts.OrderByDescending(x => x.KwGasto).ToList();
        }

        public List<Account> GetByKwGastoMaior(){
            return context.Accounts.OrderBy(x => x.KwGasto).ToList();
        }    
    }
}