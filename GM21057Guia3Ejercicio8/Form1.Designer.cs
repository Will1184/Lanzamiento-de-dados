namespace GM21057Guia3Ejercicio8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dado1 = new System.Windows.Forms.Button();
            this.textImprecion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textDado1 = new System.Windows.Forms.TextBox();
            this.textDado2 = new System.Windows.Forms.TextBox();
            this.textDado3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dado1
            // 
            this.dado1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dado1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dado1.BackgroundImage")));
            this.dado1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dado1.CausesValidation = false;
            this.dado1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dado1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dado1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dado1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dado1.Location = new System.Drawing.Point(137, 51);
            this.dado1.Margin = new System.Windows.Forms.Padding(0);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(163, 69);
            this.dado1.TabIndex = 0;
            this.dado1.Text = "Presione Para Lanzar";
            this.dado1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.dado1.UseVisualStyleBackColor = false;
            this.dado1.Click += new System.EventHandler(this.dado1_Click);
            // 
            // textImprecion
            // 
            this.textImprecion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textImprecion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textImprecion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textImprecion.Location = new System.Drawing.Point(97, 233);
            this.textImprecion.Multiline = true;
            this.textImprecion.Name = "textImprecion";
            this.textImprecion.Size = new System.Drawing.Size(248, 55);
            this.textImprecion.TabIndex = 5;
            this.textImprecion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textImprecion.TextChanged += new System.EventHandler(this.textImprecion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lanzamiento de dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(136, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dado 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(186, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dado 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(236, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dado 3";
            // 
            // textDado1
            // 
            this.textDado1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textDado1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDado1.Location = new System.Drawing.Point(136, 170);
            this.textDado1.Multiline = true;
            this.textDado1.Name = "textDado1";
            this.textDado1.Size = new System.Drawing.Size(44, 42);
            this.textDado1.TabIndex = 13;
            this.textDado1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDado2
            // 
            this.textDado2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textDado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDado2.Location = new System.Drawing.Point(186, 170);
            this.textDado2.Multiline = true;
            this.textDado2.Name = "textDado2";
            this.textDado2.Size = new System.Drawing.Size(44, 42);
            this.textDado2.TabIndex = 14;
            this.textDado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDado3
            // 
            this.textDado3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textDado3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDado3.Location = new System.Drawing.Point(236, 170);
            this.textDado3.Multiline = true;
            this.textDado3.Name = "textDado3";
            this.textDado3.Size = new System.Drawing.Size(44, 42);
            this.textDado3.TabIndex = 15;
            this.textDado3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(186, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(416, 302);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDado3);
            this.Controls.Add(this.textDado2);
            this.Controls.Add(this.textDado1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textImprecion);
            this.Controls.Add(this.dado1);
            this.Name = "Form1";
            this.Text = "Casino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button dado1;
        private TextBox textImprecion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textDado1;
        private TextBox textDado2;
        private TextBox textDado3;
        private Label label5;
    }
}