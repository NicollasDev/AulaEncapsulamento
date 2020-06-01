using System;

namespace Aula7_encaçulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }
        public void ComprarComDescontoMasterCard(float desconto){
            
            //ultilizando encapsulamento com assinatura "protected"
            cvv = "456";
            
            Console.WriteLine($"Compra realizada com {parcelas} parcelas e R$ {desconto} de desconto");
        }
    }
}