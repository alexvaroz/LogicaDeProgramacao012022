using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecao_Ex3
{
    class OutofRangeException : ApplicationException
    {
        public OutofRangeException(string message) : base(message) {
        }
    }
}
