using CadastroAlunos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Ativa o uso dos controllers e vincula as views(páginas) com os
//controllers responsáveis pela requisições.
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

//Cria a conexão com o banco de dados. Neste caso, utilizando
//o banco de dados SQLite.
builder.Services.AddDbContext<CadastroAlunosDBContext>(
    options => options.UseSqlite("Data source=cadastroalunos.db" ) );

var app = builder.Build();

app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();

//Definindo qual será a página principal  a ser chamada.
app.MapControllerRoute(name: "default",
    pattern : "{controller=Home}/{action=Index}");

app.Run();
