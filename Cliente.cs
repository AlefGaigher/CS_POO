using System;

namespace Aprendendo_c_
{
    public class Cliente
    {
        public string _cpf;
        public string Nome{get; set;}
        public string CPF{get{
            return _cpf;
        } set{
            //Escrever logica de validação cpf
            _cpf =value;
        }}
        public string Profissao{get; set;}        
    }
}
