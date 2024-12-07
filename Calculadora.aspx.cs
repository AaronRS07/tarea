using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calcu
{
    public partial class Calculadora1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            string resultado = "";
            switch (ddlOperaciones.SelectedValue)
            {
                case "Suma":
                    resultado += $"Suma (Dropdown): {numero1 + numero2}<br />";
                    break;
                case "Resta":
                    resultado += $"Resta (Dropdown): {numero1 - numero2}<br />";
                    break;
                case "Multiplicacion":
                    resultado += $"Multiplicación (Dropdown): {numero1 * numero2}<br />";
                    break;
                case "Division":
                    if (numero2 != 0)
                        resultado += $"División (Dropdown): {numero1 / numero2}<br />";
                    else
                        resultado += "División (Dropdown): No se puede dividir entre 0<br />";
                    break;

            }
            lblResultado.Text = resultado;



        }

        protected void chkResta_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            string resultado = "";
            
            if (chkSuma.Checked)
                resultado += $"Suma: {numero1 + numero2}<br />";
            if (chkResta.Checked)
                resultado += $"Resta: {numero1 - numero2}<br />";
            if (chkMultiplicacion.Checked)
                resultado += $"Multiplicación: {numero1 * numero2}<br />";
            if (chkDivision.Checked)
            {
                if (numero2 != 0)
                    resultado += $"División: {numero1 / numero2}<br />";
                else
                    resultado += "División: No se puede dividir entre 0<br />";
            }
        }

        protected void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
        }

        protected void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            double numero2 = Convert.ToDouble(txtNumero2.Text);
        }

        protected void rbSuma_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
            string resultado = "";
            
            if (rbSuma.Checked)
                resultado += $"Suma (Radio): {numero1 + numero2}<br />";
            else if (rbResta.Checked)
                resultado += $"Resta (Radio): {numero1 - numero2}<br />";
            else if (rbMultiplicacion.Checked)
                resultado += $"Multiplicación (Radio): {numero1 * numero2}<br />";
            else if (rbDivision.Checked)
            {
                if (numero2 != 0)
                    resultado += $"División (Radio): {numero1 / numero2}<br />";
                else
                    resultado += "División (Radio): No se puede dividir entre 0<br />";
            }
        }
    }
}