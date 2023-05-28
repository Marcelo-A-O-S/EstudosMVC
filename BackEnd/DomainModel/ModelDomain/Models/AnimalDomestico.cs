using System.Buffers.Text;

namespace ModelDomain.Models
{
    public class AnimalDomestico
    {
        public int Id { get; set; }
        //Caracteristicas
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raca { get; set; }
        public byte ImagePerfil { get; set; }
        public string Descricao { get; set; }
        public CategoriaAnimais Categoria { get; set; }

    }
}
