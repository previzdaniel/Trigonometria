namespace Trigonometria
{
    partial class Fomenu
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
            this.btnAlapok = new System.Windows.Forms.Button();
            this.btnTerulet = new System.Windows.Forms.Button();
            this.btnPitagorasz = new System.Windows.Forms.Button();
            this.btnSzogfuggvenyek = new System.Windows.Forms.Button();
            this.btnAtvaltas = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlapok
            // 
            this.btnAlapok.Location = new System.Drawing.Point(12, 197);
            this.btnAlapok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlapok.Name = "btnAlapok";
            this.btnAlapok.Size = new System.Drawing.Size(145, 35);
            this.btnAlapok.TabIndex = 0;
            this.btnAlapok.Text = "Alapok";
            this.btnAlapok.UseVisualStyleBackColor = true;
            this.btnAlapok.Click += new System.EventHandler(this.btnAlapok_Click);
            // 
            // btnTerulet
            // 
            this.btnTerulet.Location = new System.Drawing.Point(12, 242);
            this.btnTerulet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerulet.Name = "btnTerulet";
            this.btnTerulet.Size = new System.Drawing.Size(145, 35);
            this.btnTerulet.TabIndex = 1;
            this.btnTerulet.Text = "Terület, kerület";
            this.btnTerulet.UseVisualStyleBackColor = true;
            this.btnTerulet.Click += new System.EventHandler(this.btnTerulet_Click);
            // 
            // btnPitagorasz
            // 
            this.btnPitagorasz.Location = new System.Drawing.Point(12, 287);
            this.btnPitagorasz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPitagorasz.Name = "btnPitagorasz";
            this.btnPitagorasz.Size = new System.Drawing.Size(145, 35);
            this.btnPitagorasz.TabIndex = 2;
            this.btnPitagorasz.Text = "Pitagorasz-tétel";
            this.btnPitagorasz.UseVisualStyleBackColor = true;
            this.btnPitagorasz.Click += new System.EventHandler(this.btnPitagorasz_Click);
            // 
            // btnSzogfuggvenyek
            // 
            this.btnSzogfuggvenyek.Location = new System.Drawing.Point(13, 332);
            this.btnSzogfuggvenyek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSzogfuggvenyek.Name = "btnSzogfuggvenyek";
            this.btnSzogfuggvenyek.Size = new System.Drawing.Size(145, 35);
            this.btnSzogfuggvenyek.TabIndex = 3;
            this.btnSzogfuggvenyek.Text = "Szögfüggvények";
            this.btnSzogfuggvenyek.UseVisualStyleBackColor = true;
            this.btnSzogfuggvenyek.Click += new System.EventHandler(this.btnSzogfuggvenyek_Click);
            // 
            // btnAtvaltas
            // 
            this.btnAtvaltas.Location = new System.Drawing.Point(13, 377);
            this.btnAtvaltas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtvaltas.Name = "btnAtvaltas";
            this.btnAtvaltas.Size = new System.Drawing.Size(145, 35);
            this.btnAtvaltas.TabIndex = 4;
            this.btnAtvaltas.Text = "Szögek átváltása";
            this.btnAtvaltas.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(299, 377);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(105, 35);
            this.btnKilepes.TabIndex = 6;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 158);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Fomenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 423);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtvaltas);
            this.Controls.Add(this.btnSzogfuggvenyek);
            this.Controls.Add(this.btnPitagorasz);
            this.Controls.Add(this.btnTerulet);
            this.Controls.Add(this.btnAlapok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fomenu";
            this.Text = "Fomenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlapok;
        private System.Windows.Forms.Button btnTerulet;
        private System.Windows.Forms.Button btnPitagorasz;
        private System.Windows.Forms.Button btnSzogfuggvenyek;
        private System.Windows.Forms.Button btnAtvaltas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKilepes;
    }
}