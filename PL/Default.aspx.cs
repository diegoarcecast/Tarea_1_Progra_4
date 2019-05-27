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
                Obj_Operaciones_DAL.BIsValid = true;
                Obj_Operaciones_BLL.Insertar_Operaciones(ref Obj_Operaciones_DAL);

            }
            else
            {
                Obj_Operaciones_DAL.iResultado = 0;
                Obj_Operaciones_DAL.SMessage = "Error de sintaxis";
                Obj_Operaciones_DAL.BIsValid = false;
                Obj_Operaciones_BLL.Insertar_Operaciones(ref Obj_Operaciones_DAL);
            }
        }

        protected void btnData_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            GridView1.DataBind();
            
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";
        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";
        }

        protected void btndiv_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "/";
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "*";
        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
        }

        protected void btnMenos_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "-";
        }

        protected void btn0_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        protected void btnMas_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "+";
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            TextBox1.Text = string.Empty;
        }

        protected void btnPunto_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                TextBox1.Text = TextBox1.Text.Remove(0, 1);
            }
            else
            {
                //btnPunto.Enabled = false;
            }
           
        }
    }
}