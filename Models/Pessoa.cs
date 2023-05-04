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
            
            get => _nome.ToUpper();

            set {

                if(value =="")
                    throw new ArgumentException("O nome não pode ser vazio");

                _nome = value;
            } 

        }

        private int _idade ;
        public int Idade { 
            get => _idade;
            set{
                if(value <0)
                    throw new ArgumentException("A idade não pode ser menor que zero");
            }
        }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade {Idade}");
        }
    }
}
