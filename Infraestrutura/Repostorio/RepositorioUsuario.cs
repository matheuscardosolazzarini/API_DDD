using Dominio.Interfaces;
using Entidades.Entidades;
using Infraestrutura.Configuracoes;
using Infraestrutura.Repostorio.Genericos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repostorio
{
	public class RepositorioUsuario : RepositorioGenerico<ApplicationUser>, IUsuario
	{

		private readonly DbContextOptions<Contexto> _OptionBuilder;

		public RepositorioUsuario()
		{
			_OptionBuilder = new DbContextOptions<Contexto>();
		}
		public async Task<bool> AdicionaUsuario(string email, string senha, int idade, string celular)
		{
			try
			{
				using (var data = new Contexto(_OptionBuilder))
				{
					await data.ApplicationUser.AddAsync(
						new ApplicationUser()
						{
							Email = email,
							PasswordHash = senha,
							Idade = idade,
							Celular = celular
						});
					await data.SaveChangesAsync();
				}
			}
			catch (Exception)
			{

				return false; 
			}

			return true;
		}
	}
}


