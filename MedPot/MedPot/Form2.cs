using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedPot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Program.atenuacion = 0;
            Program.porcentajet =100;
            Program.potencia = 55;
            this.Hide();
            Form1 ven1 = new Form1();
            ven1.Show();

        }
    }
}
