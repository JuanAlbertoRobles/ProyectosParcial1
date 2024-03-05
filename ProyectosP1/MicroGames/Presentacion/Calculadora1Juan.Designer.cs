namespace MicroGames.Presentacion
{
    partial class Calculadora1Juan
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
            this.operacion = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dato20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dato2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dato1 = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operacion
            // 
            this.operacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.FormattingEnabled = true;
            this.operacion.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operacion.Location = new System.Drawing.Point(144, 66);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(36, 26);
            this.operacion.TabIndex = 27;
            this.operacion.Text = "+";
            this.operacion.SelectedIndexChanged += new System.EventHandler(this.operacion_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(141, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dato20
            // 
            this.dato20.AutoSize = true;
            this.dato20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato20.Location = new System.Drawing.Point(57, 96);
            this.dato20.Name = "dato20";
            this.dato20.Size = new System.Drawing.Size(55, 18);
            this.dato20.TabIndex = 25;
            this.dato20.Text = "Dato 2";
            this.dato20.Click += new System.EventHandler(this.dato20_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Operacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dato2
            // 
            this.dato2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato2.Location = new System.Drawing.Point(141, 94);
            this.dato2.Name = "dato2";
            this.dato2.Size = new System.Drawing.Size(97, 22);
            this.dato2.TabIndex = 23;
            this.dato2.Text = "0";
            this.dato2.TextChanged += new System.EventHandler(this.dato2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(141, 122);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(97, 22);
            this.resultado.TabIndex = 21;
            this.resultado.Text = "0";
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dato 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dato1
            // 
            this.dato1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dato1.Location = new System.Drawing.Point(141, 38);
            this.dato1.Name = "dato1";
            this.dato1.Size = new System.Drawing.Size(97, 22);
            this.dato1.TabIndex = 19;
            this.dato1.Text = "0";
            this.dato1.TextChanged += new System.EventHandler(this.dato1_TextChanged);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Red;
            this.Home.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(282, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(32, 32);
            this.Home.TabIndex = 125;
            this.Home.Text = "X";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Calculadora1Juan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 204);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dato20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dato2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dato1);
            this.Name = "Calculadora1Juan";
            this.Text = "Calculadora1Juan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox operacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dato20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dato2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dato1;
        private System.Windows.Forms.Button Home;
    }
}