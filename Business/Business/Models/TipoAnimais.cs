using EstudoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
	public class TipoAnimais
	{
		public int Id { get; set; }
		public string TipoAnimal { get; set; }
		public List<AnimalDomestico> AnimalDomesticos { get; set; }
	}
}
