using CadastroAlunos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Cria a conexão com o banco de dados. Neste caso, utilizando
//o banco de dados SQLite.
builder.Services.AddDbContext<CadastroAlunosDBContext>(
    options => options.UseSqlite("Data source=cadastroalunos.db" ) );


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
