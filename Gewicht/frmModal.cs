using System;
using System.Windows.Forms;

namespace BalanzaW
{
    public partial class frmModal : Form
    {
        public frmModal()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            Double total = Convert.ToDouble(lbl_total.Text);
            total = total - 1;
            lbl_total.Text = total.ToString();
            if (Convert.ToDouble(lbl_total.Text) == 1)
            {
                timer1.Stop();
                this.Close();                
                FrmPrincipal.SaveRegistros();

            }

        }

        private void frmModal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
    }
}
