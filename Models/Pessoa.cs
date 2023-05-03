using System;
using System.Threading.Tasks;

namespace Explorando.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Pessoa
    {
        private string _nome;

        public string Nome { 
            
            get => _nome;

            set {

                if(value =="")
                    throw new ArgumentException("O nome não pode ser vazio");

                _nome = value;
            } 

        }

        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade {Idade}");
        }
    }
}
