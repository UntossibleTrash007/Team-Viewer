using System.Windows.Forms;

namespace GatoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newFrm = new SSBU();
            newFrm.Location = this.Location;
            newFrm.StartPosition = FormStartPosition.Manual;
            newFrm.FormClosing += delegate { this.Show(); };
            newFrm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newFrm = new MK8();
            newFrm.Location = this.Location;
            newFrm.StartPosition = FormStartPosition.Manual;
            newFrm.FormClosing += delegate { this.Show(); };
            newFrm.Show();
            this.Hide();
        }
    }
}