namespace Trigonometria
{
    partial class Form1
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
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFelhasznalo = new System.Windows.Forms.TextBox();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Location = new System.Drawing.Point(208, 196);
            this.btnBejelentkezes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(142, 35);
            this.btnBejelentkezes.TabIndex = 0;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = true;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Felhasználónév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszó:";
            // 
            // tbFelhasznalo
            // 
            this.tbFelhasznalo.Location = new System.Drawing.Point(249, 112);
            this.tbFelhasznalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbFelhasznalo.Name = "tbFelhasznalo";
            this.tbFelhasznalo.Size = new System.Drawing.Size(148, 26);
            this.tbFelhasznalo.TabIndex = 3;
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(249, 148);
            this.tbJelszo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(148, 26);
            this.tbJelszo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trigonometria.Properties.Resources.pattern;
            this.ClientSize = new System.Drawing.Size(567, 356);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBejelentkezes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBejelentkezes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFelhasznalo;
        private System.Windows.Forms.TextBox tbJelszo;
    }
}

