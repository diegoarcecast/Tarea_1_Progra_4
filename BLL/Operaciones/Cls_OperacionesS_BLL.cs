using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;
using System.Web.UI;

namespace BLL.Operaciones
{
   public class Cls_OperacionesS_BLL
    {

        public int resolverOperacion(string valor1)
        {
            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";
            object result = sc.Eval(valor1);
           return Convert.ToInt32(result);
        }
    }
}
