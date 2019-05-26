using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DAL.CAT_MANT
{
    public class Cls_Operaciones_DAL
    {

        #region VARIABLES PRIVADAS


        private string 
                       _sAX,
                       _sCadena,
                       _sMsj_Error,
                       _sSetencia,
                       _sNombreTabla,
                       _sMessage ;
        private int _iResultado;

        private Boolean _bEstAX, _bIsValid;


        #endregion

        #region VARIABLES PÚBLICAS

        public SqlConnection Obj_Sql_cnx;

        public SqlCommand Obj_Sql_Cmd;

        public SqlDataAdapter Obj_Sql_Dap;

        public System.Data.DataSet Ds = new System.Data.DataSet();

        public System.Data.DataTable dt_PARAMETROS = new System.Data.DataTable("PARAMETROS");

        public string sAX { get => _sAX; set => _sAX = value; }
        public string sCadena { get => _sCadena; set => _sCadena = value; }
        public string sMsj_Error { get => _sMsj_Error; set => _sMsj_Error = value; }
        public string sSetencia { get => _sSetencia; set => _sSetencia = value; }
        public string sNombreTabla { get => _sNombreTabla; set => _sNombreTabla = value; }
        public bool bEstAX { get => _bEstAX; set => _bEstAX = value; }
        public int iResultado { get => _iResultado; set => _iResultado = value; }

        #endregion
    }
}
