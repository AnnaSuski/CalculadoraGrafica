namespace aula2202
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCalculos = new System.Windows.Forms.GroupBox();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbPerimetro = new System.Windows.Forms.RadioButton();
            this.rbVolume = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.pnDesenho = new System.Windows.Forms.Panel();
            this.gbCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalculos
            // 
            this.gbCalculos.Controls.Add(this.rbVolume);
            this.gbCalculos.Controls.Add(this.rbPerimetro);
            this.gbCalculos.Controls.Add(this.rbArea);
            this.gbCalculos.Location = new System.Drawing.Point(27, 12);
            this.gbCalculos.Name = "gbCalculos";
            this.gbCalculos.Size = new System.Drawing.Size(259, 214);
            this.gbCalculos.TabIndex = 0;
            this.gbCalculos.TabStop = false;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Checked = true;
            this.rbArea.Location = new System.Drawing.Point(23, 36);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(160, 32);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area Circulo";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // rbPerimetro
            // 
            this.rbPerimetro.AutoSize = true;
            this.rbPerimetro.Location = new System.Drawing.Point(23, 93);
            this.rbPerimetro.Name = "rbPerimetro";
            this.rbPerimetro.Size = new System.Drawing.Size(218, 32);
            this.rbPerimetro.TabIndex = 1;
            this.rbPerimetro.Text = "Perimetro Circulo";
            this.rbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rbVolume
            // 
            this.rbVolume.AutoSize = true;
            this.rbVolume.Location = new System.Drawing.Point(23, 147);
            this.rbVolume.Name = "rbVolume";
            this.rbVolume.Size = new System.Drawing.Size(188, 32);
            this.rbVolume.TabIndex = 2;
            this.rbVolume.Text = "Volume Circulo";
            this.rbVolume.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Raio";
            // 
            // txtRaio
            // 
            this.txtRaio.BackColor = System.Drawing.SystemColors.Window;
            this.txtRaio.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaio.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtRaio.Location = new System.Drawing.Point(308, 96);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(148, 41);
            this.txtRaio.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCalcular.Location = new System.Drawing.Point(324, 147);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 42);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.BackColor = System.Drawing.Color.White;
            this.lbResultado.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lbResultado.Location = new System.Drawing.Point(27, 243);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(427, 44);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "Resultado = 0";
            this.lbResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDesenho
            // 
            this.pnDesenho.BackColor = System.Drawing.Color.White;
            this.pnDesenho.Location = new System.Drawing.Point(27, 303);
            this.pnDesenho.Name = "pnDesenho";
            this.pnDesenho.Size = new System.Drawing.Size(429, 197);
            this.pnDesenho.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(493, 512);
            this.Controls.Add(this.pnDesenho);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCalculos);
            this.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora  Grafica";
            this.gbCalculos.ResumeLayout(false);
            this.gbCalculos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalculos;
        private System.Windows.Forms.RadioButton rbVolume;
        private System.Windows.Forms.RadioButton rbPerimetro;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Panel pnDesenho;
    }
}

