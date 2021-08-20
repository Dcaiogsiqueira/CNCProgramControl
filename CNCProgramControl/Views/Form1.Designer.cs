
using System;
using System.Windows.Forms;

namespace CNCProgramControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listProgram = new System.Windows.Forms.ListBox();
            this.BtnCentro = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnTorno = new System.Windows.Forms.Button();
            this.PnlConteudo = new System.Windows.Forms.Panel();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.PnlProcurar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtProcurar = new System.Windows.Forms.TextBox();
            this.LblProcurar = new System.Windows.Forms.Label();
            this.RTBPrograma = new System.Windows.Forms.RichTextBox();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PnlConteudo.SuspendLayout();
            this.PnlLateral.SuspendLayout();
            this.PnlProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProgram
            // 
            this.listProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProgram.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProgram.FormattingEnabled = true;
            this.listProgram.ItemHeight = 17;
            this.listProgram.Location = new System.Drawing.Point(12, 58);
            this.listProgram.Name = "listProgram";
            this.listProgram.Size = new System.Drawing.Size(131, 667);
            this.listProgram.TabIndex = 4;
            this.listProgram.SelectedIndexChanged += new System.EventHandler(this.listProgram_SelectedIndexChanged);
            // 
            // BtnCentro
            // 
            this.BtnCentro.FlatAppearance.BorderSize = 0;
            this.BtnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCentro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCentro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCentro.Location = new System.Drawing.Point(6, 9);
            this.BtnCentro.Name = "BtnCentro";
            this.BtnCentro.Size = new System.Drawing.Size(75, 23);
            this.BtnCentro.TabIndex = 1;
            this.BtnCentro.Text = "Centro";
            this.BtnCentro.UseVisualStyleBackColor = true;
            this.BtnCentro.Click += new System.EventHandler(this.BtnCentro_Click);
            // 
            // BtnBackup
            // 
            this.BtnBackup.FlatAppearance.BorderSize = 0;
            this.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackup.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBackup.Location = new System.Drawing.Point(168, 9);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(75, 23);
            this.BtnBackup.TabIndex = 3;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.UseVisualStyleBackColor = true;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnTorno
            // 
            this.BtnTorno.FlatAppearance.BorderSize = 0;
            this.BtnTorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTorno.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTorno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTorno.Location = new System.Drawing.Point(87, 9);
            this.BtnTorno.Name = "BtnTorno";
            this.BtnTorno.Size = new System.Drawing.Size(75, 23);
            this.BtnTorno.TabIndex = 2;
            this.BtnTorno.Text = "Torno";
            this.BtnTorno.UseVisualStyleBackColor = true;
            this.BtnTorno.Click += new System.EventHandler(this.BtnTorno_Click);
            // 
            // PnlConteudo
            // 
            this.PnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PnlConteudo.Controls.Add(this.BtnCancelar);
            this.PnlConteudo.Controls.Add(this.BtnEditar);
            this.PnlConteudo.Controls.Add(this.BtnSalvar);
            this.PnlConteudo.Controls.Add(this.PnlLateral);
            this.PnlConteudo.Controls.Add(this.RTBPrograma);
            this.PnlConteudo.Controls.Add(this.PnlTop);
            this.PnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConteudo.Location = new System.Drawing.Point(0, 0);
            this.PnlConteudo.Name = "PnlConteudo";
            this.PnlConteudo.Size = new System.Drawing.Size(1119, 851);
            this.PnlConteudo.TabIndex = 0;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSalvar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvar.Location = new System.Drawing.Point(168, 47);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 33);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Visible = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PnlLateral.Controls.Add(this.PnlProcurar);
            this.PnlLateral.Controls.Add(this.listProgram);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLateral.Location = new System.Drawing.Point(0, 41);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(162, 810);
            this.PnlLateral.TabIndex = 6;
            // 
            // PnlProcurar
            // 
            this.PnlProcurar.Controls.Add(this.pictureBox1);
            this.PnlProcurar.Controls.Add(this.TxtProcurar);
            this.PnlProcurar.Controls.Add(this.LblProcurar);
            this.PnlProcurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlProcurar.Location = new System.Drawing.Point(0, 0);
            this.PnlProcurar.Name = "PnlProcurar";
            this.PnlProcurar.Size = new System.Drawing.Size(162, 52);
            this.PnlProcurar.TabIndex = 5;
            this.PnlProcurar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TxtProcurar
            // 
            this.TxtProcurar.Location = new System.Drawing.Point(12, 26);
            this.TxtProcurar.Name = "TxtProcurar";
            this.TxtProcurar.Size = new System.Drawing.Size(131, 23);
            this.TxtProcurar.TabIndex = 8;
            this.TxtProcurar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtProcurar_KeyUp);
            // 
            // LblProcurar
            // 
            this.LblProcurar.AutoSize = true;
            this.LblProcurar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProcurar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblProcurar.Location = new System.Drawing.Point(38, 6);
            this.LblProcurar.Name = "LblProcurar";
            this.LblProcurar.Size = new System.Drawing.Size(56, 17);
            this.LblProcurar.TabIndex = 9;
            this.LblProcurar.Text = "Procurar";
            // 
            // RTBPrograma
            // 
            this.RTBPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBPrograma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTBPrograma.Location = new System.Drawing.Point(168, 99);
            this.RTBPrograma.Name = "RTBPrograma";
            this.RTBPrograma.ReadOnly = true;
            this.RTBPrograma.Size = new System.Drawing.Size(939, 667);
            this.RTBPrograma.TabIndex = 7;
            this.RTBPrograma.Text = "";
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.PnlTop.Controls.Add(this.label1);
            this.PnlTop.Controls.Add(this.BtnFechar);
            this.PnlTop.Controls.Add(this.BtnMinimizar);
            this.PnlTop.Controls.Add(this.BtnRestaurar);
            this.PnlTop.Controls.Add(this.BtnMaximizar);
            this.PnlTop.Controls.Add(this.BtnTorno);
            this.PnlTop.Controls.Add(this.BtnBackup);
            this.PnlTop.Controls.Add(this.BtnCentro);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(1119, 41);
            this.PnlTop.TabIndex = 5;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(371, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFechar.BackgroundImage")));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(1092, 9);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(20, 20);
            this.BtnFechar.TabIndex = 9;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.BackgroundImage")));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Location = new System.Drawing.Point(1046, 11);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(17, 17);
            this.BtnMinimizar.TabIndex = 8;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.BackgroundImage")));
            this.BtnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.Location = new System.Drawing.Point(1069, 11);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(17, 17);
            this.BtnRestaurar.TabIndex = 7;
            this.BtnRestaurar.UseVisualStyleBackColor = true;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.BackgroundImage")));
            this.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.Location = new System.Drawing.Point(1069, 11);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(17, 17);
            this.BtnMaximizar.TabIndex = 6;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEditar.Location = new System.Drawing.Point(168, 47);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 33);
            this.BtnEditar.TabIndex = 9;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCancelar.Location = new System.Drawing.Point(249, 47);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(78, 33);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 851);
            this.Controls.Add(this.PnlConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlConteudo.ResumeLayout(false);
            this.PnlLateral.ResumeLayout(false);
            this.PnlProcurar.ResumeLayout(false);
            this.PnlProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ListBox listProgram;
        private System.Windows.Forms.Panel PnlConteudo;
        private System.Windows.Forms.Panel PnlLateral;
        private System.Windows.Forms.Panel PnlTop;
        private Button BtnMinimizar;
        private Button BtnRestaurar;
        private Button BtnMaximizar;
        private RichTextBox RTBPrograma;
        private ContextMenuStrip contextMenuStrip1;
        private Button BtnFechar;
        public Button BtnCentro;
        public Button BtnBackup;
        public Button BtnTorno;
        private Panel PnlProcurar;
        private PictureBox pictureBox1;
        private TextBox TxtProcurar;
        private Label LblProcurar;
        private Label label1;
        public Button BtnSalvar;
        public Button BtnEditar;
        public Button BtnCancelar;
    }
}

