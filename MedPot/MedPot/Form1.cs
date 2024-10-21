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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            Program.cristal = Convert.ToInt32(CantC.Value);
            Form2 ven2 = new Form2();
            this.Hide();
            ven2.Show();
            int h = 160;
            int hp = 186;
            int hpt = 207;
            int hf = 103;

            for (int i = 0; i < Program.cristal; i++)
            {
                Program.atenuacion = 10 * (i + 1);
                Program.porcentajet = Program.porcentajet - Program.atenuacion;

                Program.potencia = (Program.porcentajet * Program.potencia) / 100;
                Program.atenuacion = 0;
                PictureBox c = new PictureBox();
                c.Image = System.Drawing.Image.FromFile("C:/Users/anahi/source/repos/MedPot/MedPot/Cristal.jpeg");
                c.Size = new System.Drawing.Size(73, 132);
                c.Location = new System.Drawing.Point(h, 161);
                c.SizeMode = PictureBoxSizeMode.StretchImage;
                c.Name = "Cristal" + (i + 1) + "";
                h = h + 133;
                ven2.Controls.Add(c);

                Label l = new Label();
                l.Text = Convert.ToString(Program.potencia)+ "MW";
                l.Location = new System.Drawing.Point(hp, 296);
                hp = hp + 141;
                l.Name = "Poten" + (i + 1);
                ven2.Controls.Add(l);

                Label la = new Label();
                la.Location = new System.Drawing.Point(hpt, 145);
                la.Text = Convert.ToString(Program.porcentajet)+ "%";
                hpt = hpt + 141;
                la.Name = "portot";
                ven2.Controls.Add(la);

                PictureBox f = new PictureBox();
                f.Image = System.Drawing.Image.FromFile("C:/Users/anahi/source/repos/MedPot/MedPot/flecha.jpg");
                f.Size = new System.Drawing.Size(51, 37);
                f.Location = new System.Drawing.Point(hf, 212);
                f.SizeMode = PictureBoxSizeMode.StretchImage;
                hf = hf + 136;
                ven2.Controls.Add(f);
            }
        }
    }
}
