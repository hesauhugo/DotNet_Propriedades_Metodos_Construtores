using Explorando.Models;

// var pessoa  = new Pessoa();
// pessoa.Nome = "Hesau";
// pessoa.Idade = 28;
// pessoa.Apresentar();

// var pessoa  = new Pessoa();
// pessoa.Nome = ""; // VAZIO
// pessoa.Idade = 28;
// pessoa.Apresentar();

// var pessoa  = new Pessoa();
// pessoa.Nome = "Hesau"; 
// pessoa.Idade = -1; //valor menor que zero
// pessoa.Apresentar();

var pessoa1  = new Pessoa();
pessoa1.Nome = "Hesau";
pessoa1.Sobrenome = "Hugo";

var pessoa2  = new Pessoa();
pessoa2.Nome = "Mario";
pessoa2.Sobrenome = "Andrade";

var cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";


cursoDeIngles.Alunos = new List<Pessoa>() ;
cursoDeIngles.AdicionarAluno(pessoa1) ;
cursoDeIngles.AdicionarAluno(pessoa2) ;
cursoDeIngles.ListarAlunos() ;

