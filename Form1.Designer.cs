namespace @interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.texto = new System.Windows.Forms.Label();
            this.inserir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.texto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.texto.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.texto.Location = new System.Drawing.Point(36, 55);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(688, 49);
            this.texto.TabIndex = 0;
            // 
            // inserir
            // 
            this.inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inserir.BackgroundImage")));
            this.inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inserir.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.inserir.ForeColor = System.Drawing.Color.Red;
            this.inserir.Location = new System.Drawing.Point(36, 196);
            this.inserir.Name = "inserir";
            this.inserir.Size = new System.Drawing.Size(175, 154);
            this.inserir.TabIndex = 1;
            this.inserir.Text = "INSERIR";
            this.inserir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.inserir.UseVisualStyleBackColor = true;
            this.inserir.Click += new System.EventHandler(this.inserir_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(549, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 154);
            this.button1.TabIndex = 2;
            this.button1.Text = "LIMPAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inserir);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button inserir;
        private System.Windows.Forms.Button button1;
    }
}

