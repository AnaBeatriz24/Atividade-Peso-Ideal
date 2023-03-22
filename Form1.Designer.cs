
namespace Peso_Ideal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPesoIdeal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(537, 69);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);
            this.txtAltura.TabIndex = 0;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(6, 75);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbnMasculino.TabIndex = 2;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(537, 51);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(39, 15);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Location = new System.Drawing.Point(105, 75);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(75, 19);
            this.rbnFeminino.TabIndex = 4;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            this.rbnFeminino.CheckedChanged += new System.EventHandler(this.rbnFeminino_CheckedChanged);
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(298, 181);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(60, 15);
            this.lblPesoIdeal.TabIndex = 5;
            this.lblPesoIdeal.Text = "Peso Ideal";
            this.lblPesoIdeal.Click += new System.EventHandler(this.lblPesoIdeal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnMasculino);
            this.groupBox1.Controls.Add(this.rbnFeminino);
            this.groupBox1.Location = new System.Drawing.Point(29, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Location = new System.Drawing.Point(280, 213);
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.Size = new System.Drawing.Size(100, 23);
            this.txtPesoIdeal.TabIndex = 8;
            this.txtPesoIdeal.TextChanged += new System.EventHandler(this.txtPesoIdeal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPesoIdeal;
    }
}

