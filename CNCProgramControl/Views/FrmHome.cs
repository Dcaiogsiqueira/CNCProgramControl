using CNCProgramControl.Serialization;
using CNCProgramControl.Views;
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
    public partial class FrmHome : Form
    {
        bool move = false;
        bool procurar = false;
        bool centro = false;
        bool torno = false;
        bool backup = false;
        Point startPosition;
        String Endereco = "";
        String Arquivo = "*";
        

        public FrmHome()
        {
            InitializeComponent();
        }

        private void AbrirFormulario<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;
            Formularios = PnlForms.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formularios == null)
            {
                Formularios = new FormularioAbrir();

                Formularios.TopLevel = false;
                Formularios.FormBorderStyle = FormBorderStyle.None;
                Formularios.Dock = DockStyle.Fill;
                PnlForms.Controls.Add(Formularios);
                PnlForms.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
                Formularios.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                Formularios.BringToFront();
            }
        }

        private void CloseForms(object senders, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FrmConItens"] == null)
            {
                
            }
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
                Location = new Point(newpoint.X- startPosition.X, newpoint.Y - startPosition.Y);
            }
        }

        #endregion

 
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMax_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnRest.Visible = true;
        }

        private void BtnRest_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRest.Visible = false;
            BtnMax.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (!procurar)
            {
                procurar = true;
                BtnView.Visible = false;
                BtnFile.Visible = false;
                BtnSettings.Visible = false;
                BtnSearch.BackColor = Color.FromArgb(204, 232, 249);
                PnlOpcoes.Visible = true;
            }
            else\sddddddddddddddddddddddddddddddddddddddddddddddddddddddddQSAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAXDEEEEEEEEEEW222222222222222222222222222222222SED322R
            {
                procurar = false;
                BtnView.Visible = true;
                BtnFile.Visible = true;
                BtnSettings.Visible = true;
                BtnSearch.BackColor = Color.FromArgb(255, 255, 255);
                PnlOpcoes.Visible = false;

            }
        }

        private void BtnCentro_MouseClick(object sender, MouseEventArgs e)
        {
            if(!centro)
            {
                BtnSearch.Enabled = false;
                centro = true;
                BtnCentro.BackColor = Color.FromArgb(204, 232, 249);
                BtnTorno.Visible = false;
                BtnBackup.Visible = false;
                BtnBuscar.Visible = true;
                LstProg.Visible = true;
                TxtSearch.Visible = true;
                RTBProgram.Visible = true;
                var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
                var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
                String enderecoCentro = diretorio[0].Endereco;
                DirectoryInfo dir_files = new DirectoryInfo(enderecoCentro);
                FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);

                foreach (var fil in files2) { LstProg.Items.Add(fil.Name); }
                Endereco = enderecoCentro;
            }
            else
            {
                Endereco = "";
                BtnSearch.Enabled = true;
                centro = false;
                BtnCentro.BackColor = Color.FromArgb(255, 255, 255);
                BtnTorno.Visible = true;
                BtnBackup.Visible = true;
                BtnBuscar.Visible = false;
                LstProg.Visible = false;
                TxtSearch.Visible = false;
                RTBProgram.Visible = false;
                LstProg.Items.Clear();
            }
        }

        private void BtnTorno_MouseClick(object sender, MouseEventArgs e)
        {
            if (!torno)
            {
                BtnSearch.Enabled = false;
                torno = true;
                BtnTorno.BackColor = Color.FromArgb(204, 232, 249);
                BtnCentro.Visible = false;
                BtnBackup.Visible = false;
                BtnBuscar.Visible = true;
                TxtSearch.Visible = true;
                LstProg.Visible = true;
                RTBProgram.Visible = true;
                var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
                var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
                String enderecoTorno = diretorio[1].Endereco;
                DirectoryInfo dir_files = new DirectoryInfo(enderecoTorno);
                FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
                foreach (var fil in files2) { LstProg.Items.Add(fil.Name); }
                Endereco = enderecoTorno;
            }
            else
            {
                Endereco = "";
                BtnSearch.Enabled = true;
                torno = false;
                BtnTorno.BackColor = Color.FromArgb(255, 255, 255);
                BtnCentro.Visible = true;
                BtnBackup.Visible = true;
                BtnBuscar.Visible = false;
                TxtSearch.Visible = false;
                LstProg.Visible = false;
                RTBProgram.Visible = false;
                LstProg.Items.Clear();
            }
        }

        private void BtnBackup_MouseClick(object sender, MouseEventArgs e)
        {
            if (!backup)
            {
                BtnSearch.Enabled = false;
                backup = true;
                BtnBackup.BackColor = Color.FromArgb(204, 232, 249);
                BtnCentro.Visible = false;
                BtnTorno.Visible = false;
                TxtSearch.Visible = true;
                BtnBuscar.Visible = true;
                LstProg.Visible = true;
                RTBProgram.Visible = true;
                var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
                var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
                String enderecoBackup = diretorio[2].Endereco;
                DirectoryInfo dir_files = new DirectoryInfo(enderecoBackup);
                FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
                foreach (var fil in files2) { LstProg.Items.Add(fil.Name); }
                Endereco = enderecoBackup;
            }
            else
            {
                Endereco = "";
                BtnSearch.Enabled = true;
                backup = false;
                BtnBackup.BackColor = Color.FromArgb(255, 255, 255);
                BtnTorno.Visible = true;
                BtnCentro.Visible = true;
                BtnBuscar.Visible = false;
                TxtSearch.Visible = false;
                LstProg.Visible = false;
                RTBProgram.Visible = false;
                LstProg.Items.Clear();

            }
        }

        private void BtnSettings_MouseClick(object sender, MouseEventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.Show();
        }

        private void BtnBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            LstProg.Items.Clear();
            RTBProgram.Text = null;
            TxtSearch.Text = TxtSearch.Text.ToUpper();
            Arquivo = TxtSearch.Text;

            DirectoryInfo dir_files = new DirectoryInfo(Endereco);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);

            foreach (var fil in files2)
            {
                for (var i = 0; i < files2.Length; i++)
                {
                    var contem = files2[i];
                    
                }
                using (StreamReader streamreader = new StreamReader(fil.FullName))
                {
                    String str = streamreader.ReadToEnd().ToUpper();
                    if (str.Contains(TxtSearch.Text))
                    {
                        LstProg.Items.Add(fil.Name);
                    }

                }
            }
            BtnBuscar.Visible = false;
        }

        private void LstProg_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Endereco + "\\" + LstProg.SelectedItem.ToString());

            RTBProgram.Text = sr.ReadToEnd();
        }
    }

}
