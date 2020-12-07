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
        public FrmCalculatrice()
        {
            InitializeComponent();
        }

       public void Button_Click(object sender, EventArgs e)
        {

            Button bouton = sender as Button;

            string texte = bouton.Text;

            int chiffre = Convert.ToInt32(texte);

            MessageBox.Show(texte);

            txtResult.Text = texte;






        }
    }

}
