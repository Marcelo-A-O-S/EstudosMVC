using Business.Repository.Interfaces;
using Business.Services.IServicesGeneric;
using Microsoft.AspNetCore.Mvc;
using ModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class GerenciadorEndereco : IServicesGeneric<Endereco>
    {
        private readonly IRepositoryGeneric<Endereco> gerenciadorEndereco;

        public GerenciadorEndereco(IRepositoryGeneric<Endereco> gerenciadorEndereco)
        {
            this.gerenciadorEndereco = gerenciadorEndereco;
        }

        public string Add(Endereco endereco)
        {
            var Erro = $"O Endereço foi adicionado com sucesso";
            try
            {
                if (endereco.Id == 0)
                {
                    gerenciadorEndereco.Add(endereco);
                }
                else
                {
                    gerenciadorEndereco.Update(endereco);
                }
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;
        }
        public string Delete(Endereco endereco)
        {
            var Erro = $"O Endereço foi deletado com sucesso ";
            try
            {
                gerenciadorEndereco.Delete(endereco);
            }
            catch (Exception erro)
            {
                Erro = erro.Message;
            }
            return Erro;

        }
        public Task<Endereco> Get(Expression<Func<Endereco, bool>> expression)
        {
            return gerenciadorEndereco.Get(expression);
        }

        public async Task<List<Endereco>> GetAll()
        {
            return await gerenciadorEndereco.GetAll();
        }

        
    }
}
