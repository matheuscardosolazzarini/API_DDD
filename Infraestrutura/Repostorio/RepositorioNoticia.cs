using Dominio.Interfaces;
using Entidades.Entidades;
using Infraestrutura.Configuracoes;
using Infraestrutura.Repostorio.Genericos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repostorio
{
	public class RepositorioNoticia : RepositorioGenerico<Noticia>, INoticia
	{

		private readonly DbContextOptions<Contexto> _OptionBuilder;

		public RepositorioNoticia()
		{
			_OptionBuilder = new DbContextOptions<Contexto>();
		}

		public async Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia, bool>> exNoticia)
		{
			using (var banco = new Contexto(_OptionBuilder))
			{
				return await banco.Noticia.Where(exNoticia).AsNoTracking().ToListAsync();
			}
		}
	}
}
