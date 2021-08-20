using CNCProgramControl.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCProgramControl
{
    public partial class Form1 : Form
    {
        bool move = false;
        Point startPosition;
        string endereco = "";
        public Form1()
        {
            InitializeComponent();
        }

        #region PanelMove

        private void PnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            startPosition = new Point(e.X, e.Y);
        }

        private void PnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void PnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point newpoint = PointToScreen(e.Location);
                Location = new Point(newpoint.X - startPosition.X, newpoint.Y - startPosition.Y);
            }
        }

        #endregion

        public void PreencherList(string escolha)
        {
            
            int i = 0;
             
            switch(escolha)
            {
                case "CENTRO":
                    i = 0;
                    if (BtnTorno.Visible)
                    {
                        BtnCentro.BackColor = Color.FromArgb(83, 147, 244);
                        BtnTorno.Visible = false;
                        BtnBackup.Visible = false;
                    }
                    else
                    {
                        BtnCentro.BackColor = Color.FromArgb(0, 80, 200);
                        BtnTorno.Visible = true;
                        BtnBackup.Visible = true;
                    }
                    break;
                case "TORNO":
                    i = 1;
                    if (BtnCentro.Visible)
                    {
                        BtnTorno.BackColor = Color.FromArgb(83, 147, 244);
                        BtnTorno.Location = new System.Drawing.Point(6, 9);
                        BtnCentro.Visible = false;
                        BtnBackup.Visible = false;
                    }
                    else
                    {
                        BtnTorno.BackColor = Color.FromArgb(0, 80, 200);
                        BtnTorno.Location = new System.Drawing.Point(87, 9);
                        BtnCentro.Visible = true;
                        BtnBackup.Visible = true;
                    }
                    break;
                case "BACKUP":
                    i = 2;
                    if (BtnCentro.Visible)
                    {
                        BtnBackup.BackColor = Color.FromArgb(83, 147, 244);
                        BtnBackup.Location = new System.Drawing.Point(6, 9);
                        BtnCentro.Visible = false;
                        BtnTorno.Visible = false;
                    }
                    else
                    {
                        BtnBackup.BackColor = Color.FromArgb(0, 80, 200);
                        BtnBackup.Location = new System.Drawing.Point(168, 9);
                        BtnCentro.Visible = true;
                        BtnTorno.Visible = true;
                    }
                    break;
            }
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
            var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
            endereco = diretorio[i].Endereco;
            DirectoryInfo dir_files = new DirectoryInfo(endereco);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
            listProgram.Items.Clear();
            foreach (var fil in files2) { listProgram.Items.Add(fil.Name); }
        }
        private void BtnCentro_Click(object sender, EventArgs e)
        {
            if (BtnTorno.Visible)
            {
                PreencherList("CENTRO");
            } else {
                PreencherList("CENTRO");
                listProgram.Items.Clear();
            }
        }

        private void BtnTorno_Click(object sender, EventArgs e)
        {
            if (BtnCentro.Visible)
            {
                PreencherList("TORNO");
            }
            else
            {
                PreencherList("TORNO");
                listProgram.Items.Clear();
            }
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (BtnCentro.Visible)
            {
                PreencherList("BACKUP");
            }
            else
            {
                PreencherList("BACKUP");
                listProgram.Items.Clear();
            }
        }


        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(endereco + "\\" + listProgram.SelectedItem.ToString());
            RTBPrograma.Text = sr.ReadToEnd();
        }
    }
}
