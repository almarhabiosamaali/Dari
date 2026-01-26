using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dari.Clas
{
    class Tenants
    {
        // دالة للحصول على الرقم التالي للمستأجر
        public string GET_NEXT_TENANT_CODE()
        {
            return AutoNumberHelper.GetNextNumber("Tenants", "TenantNo");
        }
    }
}
