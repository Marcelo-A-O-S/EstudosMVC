using Business.Repository.Interfaces;
using Business.Services.IServicesGeneric;
using ModelDomain.Models;
using System.Linq.Expressions;

namespace Business.Services
{
    public class DataAuthentication : IServicesGeneric<Autenticacao>
    {
        private readonly IRepositoryGeneric<Autenticacao> repositoryAuth;

        public DataAuthentication(IRepositoryGeneric<Autenticacao> repositoryAuth)
        {
            this.repositoryAuth = repositoryAuth;
        }
        public string Add(Autenticacao auth)
        {
            var Erro = $"O Endereço foi adicionado com sucesso";
            try
            {
                if (auth.Id == 0)
                {
                    repositoryAuth.Add(auth);
                }
                else
                {
                    repositoryAuth.Update(auth);
                }
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }

        public string Delete(Autenticacao auth)
        {
            var Erro = $"O Endereço foi deletado com sucesso ";
            try
            {
                repositoryAuth.Delete(auth);
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }

        public Task<Autenticacao> Get(Expression<Func<Autenticacao, bool>> expression)
        {
            return repositoryAuth.Get(expression);
        }

        public async Task<List<Autenticacao>> GetAll()
        {
            return await repositoryAuth.GetAll();
        }
    }
}
