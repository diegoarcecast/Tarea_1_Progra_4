using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using BLL.BD;
using DAL.BD;
using DAL.CAT_MANT;

namespace BLL.CAT_MANT
{
    public class Cls_Operaciones_BLL
    {
        public void Listar_Operaciones(ref Cls_Operaciones_DAL Obj_Operaciones_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "OPERACIONES";
            Obj_BD_DAL.sSentencia = "SP_LISTAR_OPERACIONES";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Operaciones_DAL.sMsj_Error = string.Empty;
                Obj_Operaciones_DAL.Ds = Obj_BD_DAL.DS;
            }
            else
            {
                Obj_Operaciones_DAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                Obj_Operaciones_DAL.Ds = null;
            }
        }

        public void Filtrar_Operaciones(ref Cls_Operaciones_DAL Obj_Operaciones_DAL, string sFiltro)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "OPERACIONES";
            Obj_BD_DAL.sSentencia = "SP_FILTRAR_OPERACIONES";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Resultado", "1", sFiltro); // 1 es int
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Mensaje", "4", sFiltro); // 4 es Varchar
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EsValido", "3", sFiltro); // 3 es Binary

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_Operaciones_DAL.sMsj_Error = string.Empty;
                Obj_Operaciones_DAL.Ds = Obj_BD_DAL.DS;
            }
            else
            {
                Obj_Operaciones_DAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                Obj_Operaciones_DAL.Ds = null;
            }
        }

        public void Insertar_Operaciones(ref Cls_Operaciones_DAL Obj_Operaciones_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "";
            Obj_BD_DAL.sSentencia = "SP_INSERTAR_OPERACIONES";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Resultado", "1", Obj_Operaciones_DAL.iResultado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Mensaje", "4", Obj_Operaciones_DAL.SMessage);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EsValido", "3", Obj_Operaciones_DAL.BIsValid);





            Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {


                Obj_Operaciones_DAL.sMsj_Error = string.Empty;
                Obj_Operaciones_DAL.bEstAX = true;
                Obj_Operaciones_DAL.sAX = "U";
            }
            else
            {


                Obj_Operaciones_DAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                Obj_Operaciones_DAL.bEstAX = false;
                Obj_Operaciones_DAL.sAX = "I";
            }
        }

        public void Modificar_Operaciones(ref Cls_Operaciones_DAL Obj_Operaciones_DAL)
        {

            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "";
            Obj_BD_DAL.sSentencia = "SP_MODIFICAR_OPERACIONES";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Resultado", "1", Obj_Operaciones_DAL.iResultado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Mensaje", "4", Obj_Operaciones_DAL.SMessage);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EsValido", "3", Obj_Operaciones_DAL.BIsValid);


            Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {


                Obj_Operaciones_DAL.sMsj_Error = string.Empty;
                Obj_Operaciones_DAL.bEstAX = true;
                Obj_Operaciones_DAL.sAX = "U";
            }
            else
            {


                Obj_Operaciones_DAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                Obj_Operaciones_DAL.bEstAX = false;
                Obj_Operaciones_DAL.sAX = "U";
            }
        }

        public void Eliminar_Operaciones(ref Cls_Operaciones_DAL Obj_Operaciones_DAL)
        {


            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "";
            Obj_BD_DAL.sSentencia = "SP_ELIMINAR_OPERACIONES";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Resutado", "1", Obj_Operaciones_DAL.iResultado);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@Mensaje", "4", Obj_Operaciones_DAL.SMessage);
            Obj_BD_DAL.Dt_Parametros.Rows.Add("@EsValido", "3", Obj_Operaciones_DAL.BIsValid);



            Obj_BD_BLL.Exec_NonQuery(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {


                Obj_Operaciones_DAL.sMsj_Error = string.Empty;
                Obj_Operaciones_DAL.bEstAX = true;
                Obj_Operaciones_DAL.sAX = "D";
            }
            else
            {


                Obj_Operaciones_DAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                Obj_Operaciones_DAL.bEstAX = false;
                Obj_Operaciones_DAL.sAX = "D";
            }
        }
    }
}
