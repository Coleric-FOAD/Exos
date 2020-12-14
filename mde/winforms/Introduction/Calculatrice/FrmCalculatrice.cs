using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class FrmCalculatrice : Form
    {
        int tmpResult = 0;

        string enCoursDeSaisie = "";

        //string operateur;

        public FrmCalculatrice()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, EventArgs e)
        {
            Button bouton = sender as Button;

            enCoursDeSaisie += bouton.Text;

            txtResult.Text += bouton.Text;
        }



        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(enCoursDeSaisie != "")
            {
                tmpResult = tmpResult + Convert.ToInt32(enCoursDeSaisie);

                enCoursDeSaisie = "";

                txtResult.Text = tmpResult.ToString() + "+";
            }
        }
    }
}
