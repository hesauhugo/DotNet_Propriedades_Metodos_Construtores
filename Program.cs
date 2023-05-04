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

var pessoa1  = new Pessoa(nome:"Hesau",sobrenome:"Hugo");
var pessoa2  = new Pessoa(nome:"Mario",sobrenome:"Andrade");

var cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";


cursoDeIngles.Alunos = new List<Pessoa>() ;
cursoDeIngles.AdicionarAluno(pessoa1) ;
cursoDeIngles.AdicionarAluno(pessoa2) ;
cursoDeIngles.ListarAlunos() ;
cursoDeIngles.ListarAlunosConcatenandoComMais();
cursoDeIngles.ListarAlunosInterpolando();