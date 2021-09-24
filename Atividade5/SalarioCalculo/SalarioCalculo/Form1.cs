using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioCalculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btncalculated_Click(object sender, EventArgs e)
        {
            double Sal;
            double Dep;
            double SF = 0;
            double INSS;
            double IPRF;
            string INSSAliq;
            string IPRFAliq;

            if ((double.TryParse(maskedtxtSalario.Text, out Sal)) &&
                (double.TryParse(maskedtxtDep.Text, out Dep)))
            {
                if (Sal == 0 && Dep == 0)
                {
                    MessageBox.Show("Valores Invalidos");
                }
                else

                if (Sal <= 435.52)
                    SF = 22.23 * Dep;
                else if (Sal <= 654.61)
                    SF = 15.74 * Dep;

                maskedtxtSF.Text = SF.ToString("N2");

            }
            else
                MessageBox.Show("Valores invalidos");

            if (Sal <= 800.47)
                INSS = Sal * 0.0765;
            else if (Sal <= 1050)
                INSS = Sal * 0.0865;
            else if (Sal <= 1400.77)
                INSS = Sal * 0.09;
            else if (Sal <= 2801.56)
                INSS = Sal * 0.11;
            else
                INSS = 308.17;

            maskedtxtINSS.Text = Convert.ToString(INSS);


            if (Sal <= 1257.12)
                IPRF = Sal * 0;
            else if (Sal <= 2512.08)
                IPRF = Sal * 0.15;
            else
                IPRF = Sal * 0.275;

            maskedtxtIRPF.Text = Convert.ToString(IPRF);

            if (Sal <= 800.47)
                INSSAliq = "7.65%";
            else if (Sal <= 1050)
                INSSAliq = "8.65%";
            else if (Sal <= 1400.77)
                INSSAliq = "9%";
            else if (Sal <= 2801.56)
                INSSAliq = "11%";
            else
                INSSAliq = "0%";

            maskedtxtINSSaliq.Text = Convert.ToString(INSSAliq);


            if (Sal <= 1257.12)
                IPRFAliq = "0";
            else if (Sal <= 2512.08)
                IPRFAliq = "15";
            else
                IPRFAliq = "27.5";

            maskedtxtIRPFaliq.Text = IPRFAliq;

            if (rbtnM.Checked)  
            {
                if(rbtnEC.Checked)
                    MessageBox.Show("O desconto do senhor " + txtname.Text + " que é casado, e tem " + maskedtxtDep.Text + " filhos(a) é: ");
            else
                    MessageBox.Show("O desconto do senhor " + txtname.Text + " que e solteiro, e tem " + maskedtxtDep.Text + " filhos(a) é: ");
            }            
            if (rbtnF.Checked)
            {
               
               if (rbtnEC.Checked)
                    MessageBox.Show("O desconto da senhora " + txtname.Text + " que e casada e tem" + maskedtxtDep.Text + " filhos(a) é: ");
                else
                    MessageBox.Show("O desconto da senhora " + txtname.Text + " que e solteira e tem" + maskedtxtDep.Text + " filhos(a) é: ");

            }
              
                
            
        }
          
        
    

        private void maskedtxtDep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedtxtSalario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            maskedtxtDep.Clear();
            maskedtxtINSS.Clear();
            maskedtxtINSSaliq.Clear();
            maskedtxtIRPF.Clear();
            maskedtxtIRPFaliq.Clear();
            maskedtxtSF.Clear();
            maskedtxtSalario.Clear();
            txtname.Clear();
            maskedtxtSalario.Clear();
            txtname.Focus();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rtxtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
