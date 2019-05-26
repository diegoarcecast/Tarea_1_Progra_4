using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Operaciones;

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

            if (RegularExpressionValidator1.IsValid)
            {
                TextBox1.Text = Obj_OperacionesS_BLL.resolverOperacion(TextBox1.Text.ToString()).ToString();
               // TextBox1.Text

            }
            else
            {
               
            }
        }
    }
}