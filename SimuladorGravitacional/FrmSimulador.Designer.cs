namespace SimuladorGravitacional
{
    partial class FrmSimulador
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCarregar = new SimuladorGravitacional.RJButton();
            this.DgvCorpos = new System.Windows.Forms.DataGridView();
            this.Lblqtcorpos = new System.Windows.Forms.Label();
            this.LblQtIteracoes = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCorpos)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCarregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.BtnCarregar.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCarregar.BorderColor1 = System.Drawing.Color.DarkGray;
            this.BtnCarregar.BorderRadius = 10;
            this.BtnCarregar.BorderRadius1 = 10;
            this.BtnCarregar.BorderSize = 0;
            this.BtnCarregar.BorderSize1 = 0;
            this.BtnCarregar.FlatAppearance.BorderSize = 0;
            this.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregar.ForeColor = System.Drawing.Color.White;
            this.BtnCarregar.Location = new System.Drawing.Point(12, 42);
            this.BtnCarregar.Name = "BtnCarregar";
            this.BtnCarregar.Size = new System.Drawing.Size(124, 33);
            this.BtnCarregar.TabIndex = 0;
            this.BtnCarregar.Text = "Carregar Arquivo";
            this.BtnCarregar.TextColor = System.Drawing.Color.White;
            this.BtnCarregar.UseVisualStyleBackColor = false;
            this.BtnCarregar.Click += new System.EventHandler(this.BtnCarregar_Click);
            // 
            // DgvCorpos
            // 
            this.DgvCorpos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvCorpos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvCorpos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCorpos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCorpos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvCorpos.Location = new System.Drawing.Point(0, 115);
            this.DgvCorpos.Name = "DgvCorpos";
            this.DgvCorpos.RowTemplate.Height = 25;
            this.DgvCorpos.Size = new System.Drawing.Size(719, 407);
            this.DgvCorpos.TabIndex = 1;
            // 
            // Lblqtcorpos
            // 
            this.Lblqtcorpos.AutoSize = true;
            this.Lblqtcorpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lblqtcorpos.Location = new System.Drawing.Point(180, 47);
            this.Lblqtcorpos.Name = "Lblqtcorpos";
            this.Lblqtcorpos.Size = new System.Drawing.Size(0, 21);
            this.Lblqtcorpos.TabIndex = 2;
            // 
            // LblQtIteracoes
            // 
            this.LblQtIteracoes.AutoSize = true;
            this.LblQtIteracoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQtIteracoes.Location = new System.Drawing.Point(258, 46);
            this.LblQtIteracoes.Name = "LblQtIteracoes";
            this.LblQtIteracoes.Size = new System.Drawing.Size(0, 21);
            this.LblQtIteracoes.TabIndex = 2;
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTempo.Location = new System.Drawing.Point(347, 46);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(0, 21);
            this.LblTempo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Corpos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundos";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.LblQtIteracoes);
            this.Controls.Add(this.Lblqtcorpos);
            this.Controls.Add(this.DgvCorpos);
            this.Controls.Add(this.BtnCarregar);
            this.MaximizeBox = false;
            this.Name = "FrmSimulador";
            this.Text = "Arquivo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCorpos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private RJButton BtnCarregar;
        private DataGridView DgvCorpos;
        private Label Lblqtcorpos;
        private Label LblQtIteracoes;
        private Label LblTempo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}