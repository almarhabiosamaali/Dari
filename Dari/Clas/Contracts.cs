using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Contracts
    {
        // دالة للحصول على الرقم التالي للعقد
        public string GET_NEXT_CONTRACT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Contracts", "ContractNo");
        }
    }
}
