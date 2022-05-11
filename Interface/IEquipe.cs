using EJogos.Models;
using System.Collections.Generic;

namespace EJogos.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatoris em
        // em uma classe.

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();


    }
}