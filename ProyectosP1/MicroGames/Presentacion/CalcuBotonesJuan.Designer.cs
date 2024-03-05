namespace MicroGames.Presentacion
{
    partial class CalcuBotonesJuan
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
            this.Home = new System.Windows.Forms.Button();
            this.operacion = new System.Windows.Forms.TextBox();
            this.pantalla = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.resoculto = new System.Windows.Forms.TextBox();
            this.delfin = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.Dellete = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.rest = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Red;
            this.Home.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(209, 20);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(32, 32);
            this.Home.TabIndex = 124;
            this.Home.Text = "X";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // operacion
            // 
            this.operacion.BackColor = System.Drawing.SystemColors.MenuText;
            this.operacion.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacion.ForeColor = System.Drawing.SystemColors.Window;
            this.operacion.Location = new System.Drawing.Point(111, 15);
            this.operacion.Name = "operacion";
            this.operacion.Size = new System.Drawing.Size(80, 23);
            this.operacion.TabIndex = 123;
            this.operacion.TextChanged += new System.EventHandler(this.operacion_TextChanged);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pantalla.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.ForeColor = System.Drawing.Color.Black;
            this.pantalla.Location = new System.Drawing.Point(25, 44);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(166, 35);
            this.pantalla.TabIndex = 122;
            this.pantalla.Text = "0";
            this.pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // valor
            // 
            this.valor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.Location = new System.Drawing.Point(163, 18);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(10, 20);
            this.valor.TabIndex = 121;
            this.valor.Text = "0";
            this.valor.TextChanged += new System.EventHandler(this.valor_TextChanged);
            // 
            // resoculto
            // 
            this.resoculto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resoculto.Location = new System.Drawing.Point(163, 18);
            this.resoculto.Name = "resoculto";
            this.resoculto.Size = new System.Drawing.Size(10, 20);
            this.resoculto.TabIndex = 120;
            this.resoculto.Text = "0";
            this.resoculto.TextChanged += new System.EventHandler(this.resoculto_TextChanged);
            // 
            // delfin
            // 
            this.delfin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delfin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delfin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delfin.Location = new System.Drawing.Point(111, 89);
            this.delfin.Name = "delfin";
            this.delfin.Size = new System.Drawing.Size(37, 37);
            this.delfin.TabIndex = 119;
            this.delfin.Text = "<-";
            this.delfin.UseVisualStyleBackColor = false;
            this.delfin.Click += new System.EventHandler(this.delfin_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Orange;
            this.div.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.ControlText;
            this.div.Location = new System.Drawing.Point(154, 218);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(37, 37);
            this.div.TabIndex = 118;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Dellete
            // 
            this.Dellete.BackColor = System.Drawing.Color.Red;
            this.Dellete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dellete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dellete.Location = new System.Drawing.Point(25, 89);
            this.Dellete.Name = "Dellete";
            this.Dellete.Size = new System.Drawing.Size(80, 37);
            this.Dellete.TabIndex = 117;
            this.Dellete.Text = "DELETE";
            this.Dellete.UseVisualStyleBackColor = false;
            this.Dellete.Click += new System.EventHandler(this.Dellete_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.Orange;
            this.calcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.calcular.Location = new System.Drawing.Point(154, 261);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(37, 37);
            this.calcular.TabIndex = 116;
            this.calcular.Text = "=";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.punto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.punto.Location = new System.Drawing.Point(111, 261);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(37, 37);
            this.punto.TabIndex = 115;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.Orange;
            this.mult.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mult.Location = new System.Drawing.Point(154, 175);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(37, 37);
            this.mult.TabIndex = 114;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.Orange;
            this.rest.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rest.Location = new System.Drawing.Point(154, 132);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(37, 37);
            this.rest.TabIndex = 113;
            this.rest.Text = "-";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.Orange;
            this.sum.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sum.Location = new System.Drawing.Point(154, 89);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(37, 37);
            this.sum.TabIndex = 112;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.SystemColors.Highlight;
            this.num0.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num0.Location = new System.Drawing.Point(25, 261);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(80, 37);
            this.num0.TabIndex = 111;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.SystemColors.Highlight;
            this.num9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num9.Location = new System.Drawing.Point(111, 132);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(37, 37);
            this.num9.TabIndex = 110;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.SystemColors.Highlight;
            this.num8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num8.Location = new System.Drawing.Point(68, 132);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(37, 37);
            this.num8.TabIndex = 109;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.SystemColors.Highlight;
            this.num7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num7.Location = new System.Drawing.Point(25, 132);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(37, 37);
            this.num7.TabIndex = 108;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.SystemColors.Highlight;
            this.num6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num6.Location = new System.Drawing.Point(111, 175);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(37, 37);
            this.num6.TabIndex = 107;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.SystemColors.Highlight;
            this.num5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num5.Location = new System.Drawing.Point(68, 175);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(37, 37);
            this.num5.TabIndex = 106;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.SystemColors.Highlight;
            this.num4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num4.Location = new System.Drawing.Point(25, 175);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(37, 37);
            this.num4.TabIndex = 105;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.SystemColors.Highlight;
            this.num3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num3.Location = new System.Drawing.Point(111, 218);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(37, 37);
            this.num3.TabIndex = 104;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.Highlight;
            this.num2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num2.Location = new System.Drawing.Point(68, 218);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(37, 37);
            this.num2.TabIndex = 103;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.Highlight;
            this.num1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1.Location = new System.Drawing.Point(25, 218);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(37, 37);
            this.num1.TabIndex = 102;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // CalcuBotonesJuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 318);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.operacion);
            this.Controls.Add(this.pantalla);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.resoculto);
            this.Controls.Add(this.delfin);
            this.Controls.Add(this.div);
            this.Controls.Add(this.Dellete);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "CalcuBotonesJuan";
            this.Text = "CalcuBotonesJuan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox operacion;
        private System.Windows.Forms.TextBox pantalla;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.TextBox resoculto;
        private System.Windows.Forms.Button delfin;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button Dellete;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num1;
    }
}