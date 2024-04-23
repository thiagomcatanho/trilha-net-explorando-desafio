using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacidadeExcedida
    {
        public CapacidadeExcedida()
        {
            throw new Exception("A quantidade de hospedes é maior que a capacidade da suite.");
        }
    }
}