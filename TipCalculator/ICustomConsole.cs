using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator
{
    public interface ILanguage
    {
        // INTERFACE
        // Interfaces act as a contract - classes that IMPLEMENT this interface must contain the following methods with the same METHOD NAME, RETURN TYPE, and PARAMETERS.
        // PARAMETERS must have the same datatype - variables in parameters do not have to have the same name.

        void AskUserForTotalBill();

        void PrintTotalBillWithTip(decimal x);
    }


}

