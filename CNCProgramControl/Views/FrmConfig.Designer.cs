
namespace CNCProgramControl.Views
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.LblCentro = new System.Windows.Forms.Label();
            this.LabelTorno = new System.Windows.Forms.Label();
            this.LblBackup = new System.Windows.Forms.Label();
            this.TxtTorno = new System.Windows.Forms.TextBox();
            this.TxtCentro = new System.Windows.Forms.TextBox();
            this.TxtBackup = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCentro
            // 
            this.LblCentro.AutoSize = true;
            this.LblCentro.BackColor = System.Drawing.Color.White;
            this.LblCentro.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCentro.Location = new System.Drawing.Point(27, 83);
            this.LblCentro.Name = "LblCentro";
            this.LblCentro.Size = new System.Drawing.Size(170, 17);
            this.LblCentro.TabIndex = 0;
            this.LblCentro.Text = "Centro de Usinagem";
            // 
            // LabelTorno
            // 
            this.LabelTorno.AutoSize = true;
            this.LabelTorno.BackColor = System.Drawing.Color.White;
            this.LabelTorno.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTorno.Location = new System.Drawing.Point(27, 120);
            this.LabelTorno.Name = "LabelTorno";
            this.LabelTorno.Size = new System.Drawing.Size(89, 17);
            this.LabelTorno.TabIndex = 0;
            this.LabelTorno.Text = "Torno CNC";
            // 
            // LblBackup
            // 
            this.LblBackup.AutoSize = true;
            this.LblBackup.BackColor = System.Drawing.Color.White;
            this.LblBackup.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblBackup.Location = new System.Drawing.Point(27, 156);
            this.LblBackup.Name = "LblBackup";
            this.LblBackup.Size = new System.Drawing.Size(62, 17);
            this.LblBackup.TabIndex = 0;
            this.LblBackup.Text = "Backup";
            // 
            // TxtTorno
            // 
            this.TxtTorno.Enabled = false;
            this.TxtTorno.Location = new System.Drawing.Point(203, 114);
            this.TxtTorno.Name = "TxtTorno";
            this.TxtTorno.Size = new System.Drawing.Size(687, 23);
            this.TxtTorno.TabIndex = 1;
            // 
            // TxtCentro
            // 
            this.TxtCentro.Enabled = false;
            this.TxtCentro.Location = new System.Drawing.Point(203, 77);
            this.TxtCentro.Name = "TxtCentro";
            this.TxtCentro.Size = new System.Drawing.Size(687, 23);
            this.TxtCentro.TabIndex = 1;
            // 
            // TxtBackup
            // 
            this.TxtBackup.Enabled = false;
            this.TxtBackup.Location = new System.Drawing.Point(203, 150);
            this.TxtBackup.Name = "TxtBackup";
            this.TxtBackup.Size = new System.Drawing.Size(687, 23);
            this.TxtBackup.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.Location = new System.Drawing.Point(392, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(153, 22);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Configurações";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Para alterar o caminho dos programas vá ao arquivo Json\r\nLocalizado em:\r\nC:\\CNCPr" +
    "ogramControl\\bin\\Debug\\net5.0-windows.";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(914, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 28);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnClose_MouseClick);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 433);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBackup);
            this.Controls.Add(this.TxtCentro);
            this.Controls.Add(this.TxtTorno);
            this.Controls.Add(this.LblBackup);
            this.Controls.Add(this.LabelTorno);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfig";
            this.Text = "FrmConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCentro;
        private System.Windows.Forms.Label LabelTorno;
        private System.Windows.Forms.Label LblBackup;
        private System.Windows.Forms.TextBox TxtTorno;
        private System.Windows.Forms.TextBox TxtCentro;
        private System.Windows.Forms.TextBox TxtBackup;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
    }
}