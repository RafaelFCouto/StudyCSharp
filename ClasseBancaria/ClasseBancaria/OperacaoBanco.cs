using System.Globalization;



namespace ClasseBancaria
{
    internal class OperacaoBanco
    {

        //Atributos
        private string _nomeTitular;
        public int IdConta {  get; private set; }

        public double SaldoConta { get; set; }


        //Construtores
        public  OperacaoBanco() { }



        public OperacaoBanco(string nome, int idConta)
        {
            _nomeTitular = nome;
            IdConta = idConta;
        }

        public OperacaoBanco(string nome, int idConta ,double saldoConta): this (nome, idConta)
        {
            SaldoConta = saldoConta;

        }

        

        // AutoProprietes


        public string Nome {

            get { return _nomeTitular; }

            set {
                if (value != null && value.Length > 1)
                {

                    _nomeTitular = value;


                }
            }  
     
        }

        //Metodos

        public void Depositar (double valorDeposito)
        {

            SaldoConta += valorDeposito;

        }

        public bool ValidarSaque(double valorSaque)
        {
            bool permitido = false;

            if (SaldoConta - (valorSaque + 5.0) >= 0) {

                permitido = true;            
            
            }

            return permitido;

        }

        public void Sacar(double valorSaque)
        {

            SaldoConta -= (valorSaque + 5);


        }



        public override string ToString()
        {
            return "Conta "
                + IdConta
                + ", Titular: "
                + _nomeTitular
                + ", Saldo: $ "
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture);
        }








    }
}
