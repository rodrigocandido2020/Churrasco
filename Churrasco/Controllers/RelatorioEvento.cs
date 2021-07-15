using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Churrasco.Data;
using System.Linq;
using Churrasco.Models;

namespace Churrasco.Controllers
{
	public class RelatorioEventoController : Controller
	{
		private readonly ChurrascoContext _context;

		public RelatorioEventoController(ChurrascoContext context)
        {
			_context = context;
        }

		public async Task<IActionResult> Index()
		{
			var listaDeFuncionariosNoEvento = await _context.Evento.ToListAsync();

			var totalArrecadado = 0;
			//Percorre todos confirmados no evento para calcular o total arrecadado
			foreach (var funcionarioEvento in listaDeFuncionariosNoEvento)
			{
				totalArrecadado += funcionarioEvento.Bebida ? 20 : 10;

				if (funcionarioEvento.ConfirmaConvidado)
				{
					totalArrecadado += funcionarioEvento.BebidaConvidado ? 20 : 10;
				}
			}

			// 30% do valor arrecadado vai para comida
			var totalGastoEmComida = totalArrecadado * 0.30;
			// 60% do valor arrecadado vai para bebida
			var totalGastoEmBebida = totalArrecadado * 0.60;
			// 10% do valor arrecadado guardado para imprevistos, ou seja, 90% do valor arrecadado foi gasto
			var totalGasto = totalArrecadado * 0.90;

			var relatorioEvento = new RelatorioEvento();
			relatorioEvento.TotalArrecadado = totalArrecadado;
			relatorioEvento.TotalGastoComida = totalGastoEmComida;
			relatorioEvento.TotalGastoBebida = totalGastoEmBebida;
			relatorioEvento.TotalGasto = totalGasto;
			relatorioEvento.NomeFuncionarios = listaDeFuncionariosNoEvento.Select(evento => evento.Nome).ToList();

			return View(relatorioEvento);
		}
	}
}