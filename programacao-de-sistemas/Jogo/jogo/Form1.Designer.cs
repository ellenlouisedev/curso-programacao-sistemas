namespace jogo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxVidaJ1 = new System.Windows.Forms.TextBox();
            this.tbxVidaJ2 = new System.Windows.Forms.TextBox();
            this.btnAtaqueJ2 = new System.Windows.Forms.Button();
            this.btnAtaqueJ1 = new System.Windows.Forms.Button();
            this.btnDefesaJ2 = new System.Windows.Forms.Button();
            this.btnDefesaJ1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vida";
            // 
            // tbxVidaJ1
            // 
            this.tbxVidaJ1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxVidaJ1.Location = new System.Drawing.Point(147, 111);
            this.tbxVidaJ1.Name = "tbxVidaJ1";
            this.tbxVidaJ1.Size = new System.Drawing.Size(100, 20);
            this.tbxVidaJ1.TabIndex = 1;
            this.tbxVidaJ1.Text = "100";
            // 
            // tbxVidaJ2
            // 
            this.tbxVidaJ2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxVidaJ2.Location = new System.Drawing.Point(546, 115);
            this.tbxVidaJ2.Name = "tbxVidaJ2";
            this.tbxVidaJ2.Size = new System.Drawing.Size(100, 20);
            this.tbxVidaJ2.TabIndex = 1;
            this.tbxVidaJ2.Text = "100";
            // 
            // btnAtaqueJ2
            // 
            this.btnAtaqueJ2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtaqueJ2.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAtaqueJ2.Enabled = false;
            this.btnAtaqueJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueJ2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtaqueJ2.Location = new System.Drawing.Point(560, 208);
            this.btnAtaqueJ2.Name = "btnAtaqueJ2";
            this.btnAtaqueJ2.Size = new System.Drawing.Size(98, 30);
            this.btnAtaqueJ2.TabIndex = 2;
            this.btnAtaqueJ2.Text = "Ataque";
            this.btnAtaqueJ2.UseVisualStyleBackColor = false;
            this.btnAtaqueJ2.Click += new System.EventHandler(this.btnAtaqueJ2_Click);
            // 
            // btnAtaqueJ1
            // 
            this.btnAtaqueJ1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtaqueJ1.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAtaqueJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtaqueJ1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtaqueJ1.Location = new System.Drawing.Point(105, 208);
            this.btnAtaqueJ1.Name = "btnAtaqueJ1";
            this.btnAtaqueJ1.Size = new System.Drawing.Size(98, 30);
            this.btnAtaqueJ1.TabIndex = 2;
            this.btnAtaqueJ1.Text = "Ataque";
            this.btnAtaqueJ1.UseVisualStyleBackColor = false;
            this.btnAtaqueJ1.Click += new System.EventHandler(this.btnAtaqueJ1_Click);
            // 
            // btnDefesaJ2
            // 
            this.btnDefesaJ2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDefesaJ2.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDefesaJ2.Enabled = false;
            this.btnDefesaJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefesaJ2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDefesaJ2.Location = new System.Drawing.Point(560, 256);
            this.btnDefesaJ2.Name = "btnDefesaJ2";
            this.btnDefesaJ2.Size = new System.Drawing.Size(98, 30);
            this.btnDefesaJ2.TabIndex = 2;
            this.btnDefesaJ2.Text = "Defesa";
            this.btnDefesaJ2.UseVisualStyleBackColor = false;
            this.btnDefesaJ2.Click += new System.EventHandler(this.btnDefesaJ2_Click);
            // 
            // btnDefesaJ1
            // 
            this.btnDefesaJ1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDefesaJ1.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDefesaJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefesaJ1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDefesaJ1.Location = new System.Drawing.Point(105, 256);
            this.btnDefesaJ1.Name = "btnDefesaJ1";
            this.btnDefesaJ1.Size = new System.Drawing.Size(98, 30);
            this.btnDefesaJ1.TabIndex = 2;
            this.btnDefesaJ1.Text = "Defesa";
            this.btnDefesaJ1.UseVisualStyleBackColor = false;
            this.btnDefesaJ1.Click += new System.EventHandler(this.btnDefesaJ1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::jogo.Properties.Resources.meme_1_300x273__2_;
            this.pictureBox1.Location = new System.Drawing.Point(209, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::jogo.Properties.Resources.meme_1_300x273__1_;
            this.pictureBox2.Location = new System.Drawing.Point(442, 174);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDefesaJ1);
            this.Controls.Add(this.btnDefesaJ2);
            this.Controls.Add(this.btnAtaqueJ1);
            this.Controls.Add(this.btnAtaqueJ2);
            this.Controls.Add(this.tbxVidaJ2);
            this.Controls.Add(this.tbxVidaJ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxVidaJ1;
        private System.Windows.Forms.TextBox tbxVidaJ2;
        private System.Windows.Forms.Button btnAtaqueJ2;
        private System.Windows.Forms.Button btnAtaqueJ1;
        private System.Windows.Forms.Button btnDefesaJ2;
        private System.Windows.Forms.Button btnDefesaJ1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

