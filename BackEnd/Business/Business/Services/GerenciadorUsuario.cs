using Business.Repository.Interfaces;
using Business.Services.IServicesGeneric;
using ModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    internal class GerenciadorUsuario : IServicesGeneric<Usuario>
    {
        private readonly IRepositoryGeneric<Usuario> repositoryUsuario;

        public GerenciadorUsuario(IRepositoryGeneric<Usuario> repositoryUsuario)
        {
            this.repositoryUsuario = repositoryUsuario;
        }
        public string Add(Usuario usuario)
        {
            var Erro = $"O Usuário foi adicionado com sucesso";
            try
            {
                if (usuario.Id == 0)
                {
                    repositoryUsuario.Add(usuario);
                }
                else
                {
                    repositoryUsuario.Update(usuario);
                }
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }

        public string Delete(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Get(Expression<Func<Usuario, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
