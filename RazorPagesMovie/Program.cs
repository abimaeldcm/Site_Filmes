using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RazorPagesMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RazorPagesMovieContext") ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // redireciona solicita��es HTTP para HTTPS.
app.UseStaticFiles(); //permite que arquivos est�ticos, como HTML, CSS, imagens e JavaScript sejam atendidos.

app.UseRouting(); //adiciona a correspond�ncia de rotas ao pipeline de middleware.

app.UseAuthorization(); //autoriza um usu�rio a acessar recursos seguros.

app.MapRazorPages(); //configura o roteamento de ponto de extremidade para Razor o Pages.

app.Run(); //executa o aplicativo.
