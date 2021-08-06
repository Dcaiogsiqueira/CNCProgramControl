
namespace CNCProgramControl
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnRest = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.PnlFull = new System.Windows.Forms.Panel();
            this.PnlForms = new System.Windows.Forms.Panel();
            this.LstProg = new System.Windows.Forms.ListBox();
            this.RTBProgram = new System.Windows.Forms.RichTextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.PnlOpcoes = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBackup = new System.Windows.Forms.Button();
            this.BtnTorno = new System.Windows.Forms.Button();
            this.BtnCentro = new System.Windows.Forms.Button();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlTop.SuspendLayout();
            this.PnlFull.SuspendLayout();
            this.PnlForms.SuspendLayout();
            this.PnlOpcoes.SuspendLayout();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.BtnSettings);
            this.PnlTop.Controls.Add(this.BtnSearch);
            this.PnlTop.Controls.Add(this.BtnMin);
            this.PnlTop.Controls.Add(this.BtnRest);
            this.PnlTop.Controls.Add(this.BtnMax);
            this.PnlTop.Controls.Add(this.BtnClose);
            this.PnlTop.Controls.Add(this.BtnView);
            this.PnlTop.Controls.Add(this.BtnFile);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(998, 38);
            this.PnlTop.TabIndex = 0;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackColor = System.Drawing.Color.White;
            this.BtnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettings.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSettings.Location = new System.Drawing.Point(297, 0);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(136, 38);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "Configurações";
            this.BtnSettings.UseVisualStyleBackColor = false;
            this.BtnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSettings_MouseClick);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearch.Location = new System.Drawing.Point(198, 0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(99, 38);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Procurar";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSearch_MouseClick);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackColor = System.Drawing.Color.White;
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(894, 5);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(28, 28);
            this.BtnMin.TabIndex = 2;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnRest
            // 
            this.BtnRest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRest.BackColor = System.Drawing.Color.White;
            this.BtnRest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRest.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRest.Image = ((System.Drawing.Image)(resources.GetObject("BtnRest.Image")));
            this.BtnRest.Location = new System.Drawing.Point(928, 5);
            this.BtnRest.Name = "BtnRest";
            this.BtnRest.Size = new System.Drawing.Size(28, 28);
            this.BtnRest.TabIndex = 2;
            this.BtnRest.UseVisualStyleBackColor = false;
            this.BtnRest.Visible = false;
            this.BtnRest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnRest_MouseClick);
            // 
            // BtnMax
            // 
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackColor = System.Drawing.Color.White;
            this.BtnMax.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(928, 5);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(28, 28);
            this.BtnMax.TabIndex = 2;
            this.BtnMax.UseVisualStyleBackColor = false;
            this.BtnMax.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnMax_MouseClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(962, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 28);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnView
            // 
            this.BtnView.BackColor = System.Drawing.Color.White;
            this.BtnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnView.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnView.Location = new System.Drawing.Point(99, 0);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(99, 38);
            this.BtnView.TabIndex = 1;
            this.BtnView.Text = "Exibir";
            this.BtnView.UseVisualStyleBackColor = false;
            // 
            // BtnFile
            // 
            this.BtnFile.BackColor = System.Drawing.Color.White;
            this.BtnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFile.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFile.Location = new System.Drawing.Point(0, 0);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(99, 38);
            this.BtnFile.TabIndex = 0;
            this.BtnFile.Text = "Arquivo";
            this.BtnFile.UseVisualStyleBackColor = false;
            // 
            // PnlFull
            // 
            this.PnlFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFull.Controls.Add(this.PnlForms);
            this.PnlFull.Controls.Add(this.PnlTop);
            this.PnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFull.Location = new System.Drawing.Point(0, 0);
            this.PnlFull.Name = "PnlFull";
            this.PnlFull.Size = new System.Drawing.Size(1000, 750);
            this.PnlFull.TabIndex = 1;
            // 
            // PnlForms
            // 
            this.PnlForms.Controls.Add(this.LstProg);
            this.PnlForms.Controls.Add(this.RTBProgram);
            this.PnlForms.Controls.Add(this.TxtSearch);
            this.PnlForms.Controls.Add(this.PnlOpcoes);
            this.PnlForms.Controls.Add(this.PnlFooter);
            this.PnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlForms.Location = new System.Drawing.Point(0, 38);
            this.PnlForms.Name = "PnlForms";
            this.PnlForms.Size = new System.Drawing.Size(998, 710);
            this.PnlForms.TabIndex = 2;
            // 
            // LstProg
            // 
            this.LstProg.FormattingEnabled = true;
            this.LstProg.ItemHeight = 15;
            this.LstProg.Location = new System.Drawing.Point(12, 77);
            this.LstProg.Name = "LstProg";
            this.LstProg.Size = new System.Drawing.Size(171, 574);
            this.LstProg.TabIndex = 5;
            this.LstProg.Visible = false;
            this.LstProg.SelectedIndexChanged += new System.EventHandler(this.LstProg_SelectedIndexChanged);
            // 
            // RTBProgram
            // 
            this.RTBProgram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBProgram.Location = new System.Drawing.Point(435, 84);
            this.RTBProgram.Name = "RTBProgram";
            this.RTBProgram.Size = new System.Drawing.Size(552, 564);
            this.RTBProgram.TabIndex = 4;
            this.RTBProgram.Text = "";
            this.RTBProgram.Visible = false;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearch.Location = new System.Drawing.Point(0, 38);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(998, 29);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.Visible = false;
            // 
            // PnlOpcoes
            // 
            this.PnlOpcoes.Controls.Add(this.BtnBuscar);
            this.PnlOpcoes.Controls.Add(this.BtnBackup);
            this.PnlOpcoes.Controls.Add(this.BtnTorno);
            this.PnlOpcoes.Controls.Add(this.BtnCentro);
            this.PnlOpcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOpcoes.Location = new System.Drawing.Point(0, 0);
            this.PnlOpcoes.Name = "PnlOpcoes";
            this.PnlOpcoes.Size = new System.Drawing.Size(998, 38);
            this.PnlOpcoes.TabIndex = 2;
            this.PnlOpcoes.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(297, 0);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(35, 38);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Visible = false;
            this.BtnBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnBuscar_MouseClick);
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackColor = System.Drawing.Color.White;
            this.BtnBackup.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackup.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBackup.Location = new System.Drawing.Point(198, 0);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.Size = new System.Drawing.Size(99, 38);
            this.BtnBackup.TabIndex = 6;
            this.BtnBackup.Text = "Backup";
            this.BtnBackup.UseVisualStyleBackColor = false;
            this.BtnBackup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnBackup_MouseClick);
            // 
            // BtnTorno
            // 
            this.BtnTorno.BackColor = System.Drawing.Color.White;
            this.BtnTorno.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnTorno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnTorno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnTorno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTorno.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTorno.Location = new System.Drawing.Point(99, 0);
            this.BtnTorno.Name = "BtnTorno";
            this.BtnTorno.Size = new System.Drawing.Size(99, 38);
            this.BtnTorno.TabIndex = 5;
            this.BtnTorno.Text = "Torno";
            this.BtnTorno.UseVisualStyleBackColor = false;
            this.BtnTorno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnTorno_MouseClick);
            // 
            // BtnCentro
            // 
            this.BtnCentro.BackColor = System.Drawing.Color.White;
            this.BtnCentro.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCentro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCentro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.BtnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCentro.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCentro.Location = new System.Drawing.Point(0, 0);
            this.BtnCentro.Name = "BtnCentro";
            this.BtnCentro.Size = new System.Drawing.Size(99, 38);
            this.BtnCentro.TabIndex = 4;
            this.BtnCentro.Text = "Centro";
            this.BtnCentro.UseVisualStyleBackColor = false;
            this.BtnCentro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnCentro_MouseClick);
            // 
            // PnlFooter
            // 
            this.PnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFooter.Controls.Add(this.label2);
            this.PnlFooter.Controls.Add(this.label1);
            this.PnlFooter.Location = new System.Drawing.Point(0, 669);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(998, 38);
            this.PnlFooter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(39, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "©";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "2021 - CNC-ProgramControl";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.PnlFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHome";
            this.Text = "Form1";
            this.PnlTop.ResumeLayout(false);
            this.PnlFull.ResumeLayout(false);
            this.PnlForms.ResumeLayout(false);
            this.PnlForms.PerformLayout();
            this.PnlOpcoes.ResumeLayout(false);
            this.PnlFooter.ResumeLayout(false);
            this.PnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Panel PnlFull;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnRest;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Panel PnlForms;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel PnlOpcoes;
        private System.Windows.Forms.Button BtnBackup;
        private System.Windows.Forms.Button BtnTorno;
        private System.Windows.Forms.Button BtnCentro;
        private System.Windows.Forms.RichTextBox RTBProgram;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.ListBox LstProg;
        private System.Windows.Forms.Button BtnBuscar;
    }
}

