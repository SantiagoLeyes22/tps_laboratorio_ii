using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicializa el formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            CenterToParent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.cmbOperador.Items.AddRange(new object[] { "+", "-", "/", "*"});
            //this.cmbOperador.SelectedIndex = 0;
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// "Limpia" todos los componentes del formulario y los deja como cuando se inicializó
        /// </summary>
        public void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.ResetText();
            this.lblResultado.Text = "0";
        }
        /// <summary>
        /// Realiza el cálculo de lo ingresado por el usuario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);

            if (resultado == double.MinValue)
            {
                lstOperaciones.Items.Add(this.txtNumero1.Text + this.cmbOperador.Text + this.txtNumero2.Text + " = syntax error");
                lblResultado.Text = "No se puede dividir por 0";
                this.btnConvertirABinario.Enabled = false;
                this.btnConvertirADecimal.Enabled = false;
            }
            else
            {
                lblResultado.Text = resultado.ToString();
                lstOperaciones.Items.Add(this.txtNumero1.Text + this.cmbOperador.Text + this.txtNumero2.Text + " = " + resultado);
                this.btnConvertirABinario.Enabled = true;
                this.btnConvertirADecimal.Enabled = true;
            }
        }

        /// <summary>
        /// Deja al formulario como cuando se inicializó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte el resultado a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            this.lblResultado.Text = numero.DecimalBinario(Convert.ToDouble(this.lblResultado.Text));
        }

        /// <summary>
        /// Convierte el resultado a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando();
            this.lblResultado.Text = numero.BinarioDecimal(this.lblResultado.Text);
        }
        /// <summary>
        /// Realiza la operación con los elementos pasados por parámetro
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operador que indica tipo de operación</param>
        /// <returns>Retorna el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Operando num1 = new Operando();
            Operando num2 = new Operando();
            num1.Numero = numero1;
            num2.Numero = numero2;
            if(operador == "")
            {
                operador = "+";
            }
            resultado = Calculadora.Operar(num1, num2, Convert.ToChar(operador));
            
            return resultado;
        }

        /// <summary>
        /// Pone una advertencia al usuario para saber si quiere salir del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Cerrar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }

}
