﻿namespace @interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texto1 = new System.Windows.Forms.Label();
            this.texto2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(215, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 116);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(315, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 116);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(411, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 115);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 26.25F);
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha o país para ver informações:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.label3.Location = new System.Drawing.Point(64, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "População:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.label2.Location = new System.Drawing.Point(64, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(175, 414);
            this.texto1.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(0, 13);
            this.texto1.TabIndex = 7;
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.Location = new System.Drawing.Point(228, 468);
            this.texto2.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(0, 13);
            this.texto2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(696, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 67);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 556);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.texto2);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.Button button4;
    }
}