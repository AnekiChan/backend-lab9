namespace Lab9
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();
			builder.Services.AddControllers();

			var app = builder.Build();

			app.Environment.EnvironmentName = "Production";

			if (app.Environment.IsDevelopment())
			{
				app.UseDeveloperExceptionPage(); // Использование страницы ошибок для разработки
			}
			else
			{
				// Обработка ошибок в режиме production
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			// Определяем пользовательскую страницу для ошибки HTTP 404
			app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();
			app.MapControllers();

			app.Run();
		}
	}
}
