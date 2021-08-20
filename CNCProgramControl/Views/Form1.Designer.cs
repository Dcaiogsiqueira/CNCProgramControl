
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
            this.RTBPrograma = new System.Windows.Forms.RichTextBox();
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnFechar = new System.Windows.Forms.Button();
            this.PnlConteudo.SuspendLayout();
            this.PnlLateral.SuspendLayout();
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
            this.listProgram.Location = new System.Drawing.Point(12, 20);
            this.listProgram.Name = "listProgram";
            this.listProgram.Size = new System.Drawing.Size(131, 684);
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
            this.PnlConteudo.Controls.Add(this.PnlLateral);
            this.PnlConteudo.Controls.Add(this.RTBPrograma);
            this.PnlConteudo.Controls.Add(this.PnlTop);
            this.PnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConteudo.Location = new System.Drawing.Point(0, 0);
            this.PnlConteudo.Name = "PnlConteudo";
            this.PnlConteudo.Size = new System.Drawing.Size(1052, 787);
            this.PnlConteudo.TabIndex = 0;
            // 
            // RTBPrograma
            // 
            this.RTBPrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBPrograma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RTBPrograma.Location = new System.Drawing.Point(168, 61);
            this.RTBPrograma.Name = "RTBPrograma";
            this.RTBPrograma.ReadOnly = true;
            this.RTBPrograma.Size = new System.Drawing.Size(872, 684);
            this.RTBPrograma.TabIndex = 7;
            this.RTBPrograma.Text = "";
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PnlLateral.Controls.Add(this.listProgram);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLateral.Location = new System.Drawing.Point(0, 41);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(162, 746);
            this.PnlLateral.TabIndex = 6;
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
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
            this.PnlTop.Size = new System.Drawing.Size(1052, 41);
            this.PnlTop.TabIndex = 5;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.BackgroundImage")));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Location = new System.Drawing.Point(979, 11);
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
            this.BtnRestaurar.Location = new System.Drawing.Point(1002, 11);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(1002, 11);
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
            // BtnFechar
            // 
            this.BtnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFechar.BackgroundImage")));
            this.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Location = new System.Drawing.Point(1025, 9);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(20, 20);
            this.BtnFechar.TabIndex = 9;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 787);
            this.Controls.Add(this.PnlConteudo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlConteudo.ResumeLayout(false);
            this.PnlLateral.ResumeLayout(false);
            this.PnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        public System.Windows.Forms.ListBox listProgram;
        private System.Windows.Forms.Button BtnCentro;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button BtnTorno;
        private System.Windows.Forms.Panel PnlConteudo;
        private System.Windows.Forms.Panel PnlLateral;
        private System.Windows.Forms.Panel PnlTop;
        private Button BtnMinimizar;
        private Button BtnRestaurar;
        private Button BtnMaximizar;
        private RichTextBox RTBPrograma;
        private ContextMenuStrip contextMenuStrip1;
        private Button BtnFechar;
    }
}

