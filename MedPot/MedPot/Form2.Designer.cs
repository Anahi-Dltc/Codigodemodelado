
namespace MedPot
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Poten = new System.Windows.Forms.Label();
            this.Crist = new System.Windows.Forms.PictureBox();
            this.flecha = new System.Windows.Forms.PictureBox();
            this.portot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "55MW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "100%";
            // 
            // Back
            // 
            this.Back.Image = global::MedPot.Properties.Resources.back2;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(55, 40);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 8;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedPot.Properties.Resources.Antena;
            this.pictureBox1.Location = new System.Drawing.Point(12, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Poten
            // 
            this.Poten.AutoSize = true;
            this.Poten.Location = new System.Drawing.Point(34, 12);
            this.Poten.Name = "Poten";
            this.Poten.Size = new System.Drawing.Size(0, 13);
            this.Poten.TabIndex = 7;
            // 
            // Crist
            // 
            this.Crist.Image = global::MedPot.Properties.Resources.Cristal;
            this.Crist.Location = new System.Drawing.Point(160, 161);
            this.Crist.Name = "Crist";
            this.Crist.Size = new System.Drawing.Size(73, 132);
            this.Crist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Crist.TabIndex = 4;
            this.Crist.TabStop = false;
            this.Crist.Visible = false;
            // 
            // flecha
            // 
            this.flecha.Image = global::MedPot.Properties.Resources.flecha;
            this.flecha.Location = new System.Drawing.Point(103, 212);
            this.flecha.Name = "flecha";
            this.flecha.Size = new System.Drawing.Size(51, 37);
            this.flecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flecha.TabIndex = 2;
            this.flecha.TabStop = false;
            this.flecha.Visible = false;
            // 
            // portot
            // 
            this.portot.AutoSize = true;
            this.portot.Location = new System.Drawing.Point(207, 145);
            this.portot.Name = "portot";
            this.portot.Size = new System.Drawing.Size(0, 13);
            this.portot.TabIndex = 6;
            this.portot.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Poten);
            this.Controls.Add(this.portot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Crist);
            this.Controls.Add(this.flecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Back;
        public System.Windows.Forms.Label Poten;
        public System.Windows.Forms.PictureBox Crist;
        public System.Windows.Forms.PictureBox flecha;
        public System.Windows.Forms.Label portot;
    }
}