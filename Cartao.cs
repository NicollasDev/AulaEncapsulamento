using System;

namespace Aula7_encaçulamento
{
    public class Cartao
    {
        
        public string numero { get; set; }
        public string titular { get; set; }
        public string bandeira { get; set; }

        private string token = "diafhfwhfhifpwffuwpfwfddqwdqdwq";
        protected string cvv { get; set; }

        public void AprovarCompra(){
           Console.WriteLine("Compra aprovada!");
        }
        private bool ValidarToken(){
            if(token != null){
            return true;
            }
          return false;
        }
        private bool ValidarCompra(){
            return true;
    }
}
}

