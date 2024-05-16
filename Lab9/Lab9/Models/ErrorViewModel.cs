using Microsoft.AspNetCore.Mvc;

namespace Lab9.Models
{
    public class ErrorViewModel
    {
		public string ErrorMessage { get; set; } = "";

		public override string ToString()
		{
			return $"Ошибка: {ErrorMessage}";
		}
	}
}
