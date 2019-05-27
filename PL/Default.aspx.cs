using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Operaciones;
using BLL.CAT_MANT;
using DAL.CAT_MANT;

namespace PL
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {   
            Cls_OperacionesS_BLL Obj_OperacionesS_BLL = new Cls_OperacionesS_BLL();
            Cls_Operaciones_BLL Obj_Operaciones_BLL = new Cls_Operaciones_BLL();
            Cls_Operaciones_DAL Obj_Operaciones_DAL = new Cls_Operaciones_DAL();

            if (RegularExpressionValidator1.IsValid)
            {
                TextBox1.Text = Obj_OperacionesS_BLL.resolverOperacion(TextBox1.Text.ToString()).ToString();
                Obj_Operaciones_DAL.iResultado = Convert.ToInt32(TextBox1.Text);
                Obj_Operaciones_BLL.Insertar_Operaciones(ref Obj_Operaciones_DAL);

            }
            else
            {
                Obj_Operaciones_DAL.iResultado = 0;
                Obj_Operaciones_DAL.SMessage = "Error de sintaxis";
                Obj_Operaciones_BLL.Insertar_Operaciones(ref Obj_Operaciones_DAL);
            }
        }

        protected void btnData_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            
        }
    }
}