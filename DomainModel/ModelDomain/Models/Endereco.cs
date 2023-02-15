using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomain.Models
{
    public class Endereco
    {
        //Classe para dados pertinentes de endereço do usuário
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public int NumeroDaCasa { get; set; }
        //Vinculo com a Tabela de Usuarios usando DataAnnotations
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }//Variavel para identificação do usuário vinculado ao endereço
        public Usuario usuario { get; set; }
    }
}
