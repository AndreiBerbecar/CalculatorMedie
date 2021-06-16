using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorMedie
{
    public partial class FrmMain : Form
    {
        double total;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            lstMedii.Items.Add(txtMedii.Text);
            if (txtMedii.Text.Trim() == "")
            {
                return;
            }
            txtMedii.Clear();
            txtMedii.Focus();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lstMedii.Items.Clear();
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            double med = 0;
            for (int i = 0; i < lstMedii.Items.Count; i++)
            {
                total += Convert.ToDouble(lstMedii.Items[i]);
                med = total / lstMedii.Items.Count;
            }
            txtMedie.Text = med.ToString();
            lblFinal.Text = med.ToString();
            if(rdbCuTeza.Checked==true)
            {
                double med1 = 0;
                double medTeza = 0;
                double notaTeza = Convert.ToDouble(txtMedie.Text);      
                med1 = total/ lstMedii.Items.Count;
                medTeza = ((med1 * 3) + notaTeza) / 4;
                txtMedie.Text = medTeza.ToString();
                lblFinal.Text = medTeza.ToString();
            }
        }

        private void lblTeza_Click(object sender, EventArgs e)
        {

        }

        private void rdbCuTeza_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbCuTeza.Checked==true)
            {
                pnlTeza.Visible = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlTeza.Visible=false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMedie.Clear();
            txtMedii.Clear();
            lstMedii.Items.Clear();
            rdbCuTeza.Checked = false;
            rdbFaraTeza.Checked = false;
            lblFinal.Visible = false;
        }
    }
}
