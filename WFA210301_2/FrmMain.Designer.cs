
namespace WFA210301_2
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiVizsgak = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUjVizsgazo = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVizsgazok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgazok)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVizsgak,
            this.tsmiUjVizsgazo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiVizsgak
            // 
            this.tsmiVizsgak.Name = "tsmiVizsgak";
            this.tsmiVizsgak.Size = new System.Drawing.Size(82, 24);
            this.tsmiVizsgak.Text = "VIZSGÁK";
            this.tsmiVizsgak.Click += new System.EventHandler(this.tsmiVizsgak_Click);
            // 
            // tsmiUjVizsgazo
            // 
            this.tsmiUjVizsgazo.Name = "tsmiUjVizsgazo";
            this.tsmiUjVizsgazo.Size = new System.Drawing.Size(112, 24);
            this.tsmiUjVizsgazo.Text = "ÚJ VIZSGÁZÓ";
            // 
            // dgvVizsgazok
            // 
            this.dgvVizsgazok.AllowUserToAddRows = false;
            this.dgvVizsgazok.AllowUserToDeleteRows = false;
            this.dgvVizsgazok.AllowUserToResizeColumns = false;
            this.dgvVizsgazok.AllowUserToResizeRows = false;
            this.dgvVizsgazok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVizsgazok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVizsgazok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvVizsgazok.Location = new System.Drawing.Point(12, 31);
            this.dgvVizsgazok.Name = "dgvVizsgazok";
            this.dgvVizsgazok.RowHeadersVisible = false;
            this.dgvVizsgazok.RowHeadersWidth = 51;
            this.dgvVizsgazok.RowTemplate.Height = 24;
            this.dgvVizsgazok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVizsgazok.Size = new System.Drawing.Size(776, 407);
            this.dgvVizsgazok.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "VIZSGÁZÓ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NYELV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SZINT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVizsgazok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "nyelviskola";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVizsgazok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiVizsgak;
        private System.Windows.Forms.ToolStripMenuItem tsmiUjVizsgazo;
        private System.Windows.Forms.DataGridView dgvVizsgazok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

