namespace MicroGames.Presentacion
{
    partial class Calculadora1Axel
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
            this.button1 = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Numero_2 = new System.Windows.Forms.TextBox();
            this.Numero_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(124, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 62;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // operacion
            // 
            this.operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.FormattingEnabled = true;
            this.operacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operacion.Location = new System.Drawing.Point(124, 53);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(50, 24);
            this.operacion.TabIndex = 61;
            this.operacion.Text = "+";
            this.operacion.SelectedIndexChanged += new System.EventHandler(this.operacion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Operacion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Resultado
            // 
            this.Resultado.Enabled = false;
            this.Resultado.Location = new System.Drawing.Point(124, 143);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(152, 20);
            this.Resultado.TabIndex = 59;
            this.Resultado.Text = "0";
            this.Resultado.TextChanged += new System.EventHandler(this.Resultado_TextChanged);
            // 
            // Numero_2
            // 
            this.Numero_2.Location = new System.Drawing.Point(124, 102);
            this.Numero_2.Name = "Numero_2";
            this.Numero_2.Size = new System.Drawing.Size(152, 20);
            this.Numero_2.TabIndex = 58;
            this.Numero_2.Text = "0";
            this.Numero_2.TextChanged += new System.EventHandler(this.Numero_2_TextChanged);
            // 
            // Numero_1
            // 
            this.Numero_1.Location = new System.Drawing.Point(124, 18);
            this.Numero_1.Name = "Numero_1";
            this.Numero_1.Size = new System.Drawing.Size(152, 20);
            this.Numero_1.TabIndex = 57;
            this.Numero_1.Text = "0";
            this.Numero_1.TextChanged += new System.EventHandler(this.Numero_1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Resultado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Numero 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Numero 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Red;
            this.Home.BackgroundImage = global::MicroGames.Properties.Resources.flecha;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Home.Location = new System.Drawing.Point(329, 14);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(33, 33);
            this.Home.TabIndex = 53;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Calculadora1Axel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Numero_2);
            this.Controls.Add(this.Numero_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home);
            this.Name = "Calculadora1Axel";
            this.Text = "Calculadora1Axel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.TextBox Numero_2;
        private System.Windows.Forms.TextBox Numero_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}