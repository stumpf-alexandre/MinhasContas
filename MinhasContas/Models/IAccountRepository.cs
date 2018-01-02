using System.Collections.Generic;
using minhas_contas.Models;

namespace minhas_contas.Models
{
    public interface IAccountRepository
    {
        void Create (Account account);

        void Update (Account account);

        void Delete (int id);

        List<Account> GetAll();

        Account GetById (int id);

        List<Account> GetByKwGastoMenor();
        
        List<Account> GetByKwGastoMaior();
    }
}