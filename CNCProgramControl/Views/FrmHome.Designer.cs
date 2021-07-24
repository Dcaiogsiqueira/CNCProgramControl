
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
            this.PnlTop = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.PnlFull = new System.Windows.Forms.Panel();
            this.PnlTop.SuspendLayout();
            this.PnlFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.Color.White;
            this.PnlTop.Controls.Add(this.BtnRegister);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(998, 38);
            this.PnlTop.TabIndex = 0;
            this.PnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            this.PnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseMove);
            this.PnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseUp);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.White;
            this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.Location = new System.Drawing.Point(0, 0);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(99, 38);
            this.BtnRegister.TabIndex = 0;
            this.BtnRegister.Text = "Arquivo";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // PnlFull
            // 
            this.PnlFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlFull.Controls.Add(this.PnlTop);
            this.PnlFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFull.Location = new System.Drawing.Point(0, 0);
            this.PnlFull.Name = "PnlFull";
            this.PnlFull.Size = new System.Drawing.Size(1000, 750);
            this.PnlFull.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Panel PnlFull;
    }
}

