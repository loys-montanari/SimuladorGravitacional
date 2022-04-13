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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnCarregar = new SimuladorGravitacional.RJButton();
            this.DgvCorpos = new System.Windows.Forms.DataGridView();
            this.Lblqtcorpos = new System.Windows.Forms.Label();
            this.LblQtIteracoes = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSimular = new SimuladorGravitacional.RJButton();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCorpos)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnCarregar
            // 
            this.BtnCarregar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCarregar.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.BtnCarregar.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCarregar.BorderColor1 = System.Drawing.Color.DarkGray;
            this.BtnCarregar.BorderRadius = 5;
            this.BtnCarregar.BorderRadius1 = 5;
            this.BtnCarregar.BorderSize = 0;
            this.BtnCarregar.BorderSize1 = 0;
            this.BtnCarregar.FlatAppearance.BorderSize = 0;
            this.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCarregar.ForeColor = System.Drawing.Color.White;
            this.BtnCarregar.Location = new System.Drawing.Point(291, 262);
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
            this.DgvCorpos.AllowUserToAddRows = false;
            this.DgvCorpos.AllowUserToDeleteRows = false;
            this.DgvCorpos.AllowUserToResizeColumns = false;
            this.DgvCorpos.AllowUserToResizeRows = false;
            this.DgvCorpos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvCorpos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCorpos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvCorpos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCorpos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCorpos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCorpos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCorpos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvCorpos.Location = new System.Drawing.Point(0, 115);
            this.DgvCorpos.Name = "DgvCorpos";
            this.DgvCorpos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCorpos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCorpos.RowHeadersVisible = false;
            this.DgvCorpos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvCorpos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.DgvCorpos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DgvCorpos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Navy;
            this.DgvCorpos.RowTemplate.Height = 25;
            this.DgvCorpos.ShowEditingIcon = false;
            this.DgvCorpos.Size = new System.Drawing.Size(700, 407);
            this.DgvCorpos.TabIndex = 1;
            // 
            // Lblqtcorpos
            // 
            this.Lblqtcorpos.AutoSize = true;
            this.Lblqtcorpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lblqtcorpos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lblqtcorpos.Location = new System.Drawing.Point(180, 47);
            this.Lblqtcorpos.Name = "Lblqtcorpos";
            this.Lblqtcorpos.Size = new System.Drawing.Size(0, 21);
            this.Lblqtcorpos.TabIndex = 2;
            // 
            // LblQtIteracoes
            // 
            this.LblQtIteracoes.AutoSize = true;
            this.LblQtIteracoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblQtIteracoes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblQtIteracoes.Location = new System.Drawing.Point(258, 46);
            this.LblQtIteracoes.Name = "LblQtIteracoes";
            this.LblQtIteracoes.Size = new System.Drawing.Size(0, 21);
            this.LblQtIteracoes.TabIndex = 2;
            // 
            // LblTempo
            // 
            this.LblTempo.AutoSize = true;
            this.LblTempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTempo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTempo.Location = new System.Drawing.Point(347, 46);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(0, 21);
            this.LblTempo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(180, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Corpos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(258, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(347, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Segundos";
            // 
            // BtnClose
            // 
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.Location = new System.Drawing.Point(662, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 23);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSimular
            // 
            this.BtnSimular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSimular.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSimular.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSimular.BorderColor1 = System.Drawing.Color.DarkGray;
            this.BtnSimular.BorderRadius = 5;
            this.BtnSimular.BorderRadius1 = 5;
            this.BtnSimular.BorderSize = 0;
            this.BtnSimular.BorderSize1 = 0;
            this.BtnSimular.FlatAppearance.BorderSize = 0;
            this.BtnSimular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BtnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSimular.ForeColor = System.Drawing.Color.White;
            this.BtnSimular.Location = new System.Drawing.Point(28, 42);
            this.BtnSimular.Name = "BtnSimular";
            this.BtnSimular.Size = new System.Drawing.Size(124, 33);
            this.BtnSimular.TabIndex = 0;
            this.BtnSimular.Text = "Simular Gravidade";
            this.BtnSimular.TextColor = System.Drawing.Color.White;
            this.BtnSimular.UseVisualStyleBackColor = false;
            this.BtnSimular.Click += new System.EventHandler(this.BtnSimulador_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTitulo.Location = new System.Drawing.Point(180, 164);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(327, 37);
            this.LblTitulo.TabIndex = 5;
            this.LblTitulo.Text = "Simulador Gravitacional";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescricao.Location = new System.Drawing.Point(73, 467);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(548, 15);
            this.LblDescricao.TabIndex = 6;
            this.LblDescricao.Text = "Leia um arquivo com dados de um universo e seus corpos celestiais e simule a atra" +
    "ção entre os corpos.";
            // 
            // FrmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 522);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.LblQtIteracoes);
            this.Controls.Add(this.Lblqtcorpos);
            this.Controls.Add(this.BtnSimular);
            this.Controls.Add(this.BtnCarregar);
            this.Controls.Add(this.DgvCorpos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmSimulador_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSimulador_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmSimulador_MouseUp);
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
        private Button BtnClose;
        private RJButton BtnSimular;
        private Label LblTitulo;
        private Label LblDescricao;
    }
}