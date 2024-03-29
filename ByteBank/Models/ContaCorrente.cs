namespace ByteBank.Models
{
    public class ContaCorrente
    {

        public Cliente Titular {get; set;}
        public string Agencia {get; set;}
        public int Conta {get; set;}
        public double Saldo {get; set;}

        public ContaCorrente(string Agencia, int Conta, Cliente Titular){
            this.Agencia = Agencia;
            this.Conta = Conta;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public double Deposito(double valor){
            this.Saldo += valor;
            return this.Saldo;
        }

        public bool Saque(double valor){
            if(valor <= this.Saldo){
                this.Saldo -= valor;
                return true;
            } else{
                return false;
            }
        }

        public bool Transferencia(ContaCorrente destino, double valor){
            if (this.Saque(valor)){
                destino.Deposito(valor);
                return true;
            } else {
                return false;
            }
        }

        
    }

}