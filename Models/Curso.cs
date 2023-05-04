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
            var removido = Alunos.Remove(aluno);
            return removido;
        }

        public void ListarAlunos(){

            Console.WriteLine("Listando alunos");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public void ListarAlunosConcatenandoComMais(){

            Console.WriteLine("Listando alunos concatenados por +");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "N" + count + "-" + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
            
        }

        public void ListarAlunosInterpolando(){

            Console.WriteLine("Listando alunos interpolando");
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"N{count} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
        }
    }
}
