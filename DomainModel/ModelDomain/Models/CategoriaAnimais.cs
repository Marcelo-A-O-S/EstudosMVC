using ModelDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDomain.Models
{
	public class CategoriaAnimais
	{
		//Para dados pertinentes de categorias entre varios animais distintos
		public int Id { get; set; }
		public string CategoriaAnimal { get; set; }//Ex: Cachorro
		public List<AnimalDomestico> AnimalDomesticos { get; set; }//Ex: Varios cachorros
    }
}
