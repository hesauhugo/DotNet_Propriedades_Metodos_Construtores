using System;
using System.Threading.Tasks;

namespace Explorando.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count();
            return quantidade;
        }

        public bool Remover(Pessoa aluno){
            var removido = Alunos.Remover(aluno);
            return removido;
        }
    }
}
