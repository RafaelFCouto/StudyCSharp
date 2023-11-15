
namespace Pensionato
{
    internal class ControlePensionato
    {

        public bool Alugado {  get; private set; } 
        public int NumeroQuarto {  get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }






        // controladores
        public ControlePensionato() { }

        public ControlePensionato(int numQuarto) { 
            
            NumeroQuarto = numQuarto;
            
        }

        public ControlePensionato (string nome, string email, int numQuarto) { 
        
            Nome = nome;
            Email = email;
            NumeroQuarto = numQuarto;
        
        }

        public ControlePensionato(string nome, string email, int numQuarto, bool alugado) : this(nome, email, numQuarto) {

            Alugado = alugado;

        }

        //metodos

        public void AlugarQuarto(int numQuarto, string nome, string email) {
            
            if(NumeroQuarto == numQuarto)
            {
                Nome = nome;
                Email = email;
                Alugado = true;
            }        
        
        }


    }
}
