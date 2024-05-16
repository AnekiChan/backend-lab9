using Lab9.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab9.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HomeController : ControllerBase
	{
		[HttpGet]
		public IActionResult Index()
		{
			throw new Exception("Test error");
			return Ok("Добро пожаловать на главную страницу!");
		}

		[HttpGet("Error")]
		public IActionResult Error(int? statusCode)
		{
			var errorViewModel = new ErrorViewModel();

			if (statusCode.HasValue)
			{
				if (statusCode.Value == 404)
				{
					errorViewModel.ErrorMessage = "Страница не найдена";
				}
				else
				{
					// Другие обработки для различных кодов ошибок
					errorViewModel.ErrorMessage = "Произошла ошибка";
				}
			}
			else
			{
				errorViewModel.ErrorMessage = "Произошла ошибка";
			}

			return NotFound(errorViewModel.ToString()); // Используем NotFound для ошибки 404
		}
	}
}
