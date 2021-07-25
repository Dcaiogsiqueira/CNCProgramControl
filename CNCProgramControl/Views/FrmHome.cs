using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                BtnSearch.BackColor = Color.FromArgb(204, 232, 249);
                PnlOpcoes.Visible = true;
            }
            else
            {
                procurar = false;
                BtnView.Visible = true;
                BtnFile.Visible = true;
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
                TxtSearch.Visible = true;
            }
            else
            {
                BtnSearch.Enabled = true;
                centro = false;
                BtnCentro.BackColor = Color.FromArgb(255, 255, 255);
                BtnTorno.Visible = true;
                BtnBackup.Visible = true;
                TxtSearch.Visible = false;
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
                TxtSearch.Visible = true;
            }
            else
            {
                BtnSearch.Enabled = true;
                torno = false;
                BtnTorno.BackColor = Color.FromArgb(255, 255, 255);
                BtnCentro.Visible = true;
                BtnBackup.Visible = true;
                TxtSearch.Visible = false;
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
            }
            else
            {
                BtnSearch.Enabled = true;
                backup = false;
                BtnBackup.BackColor = Color.FromArgb(255, 255, 255);
                BtnTorno.Visible = true;
                BtnCentro.Visible = true;
                TxtSearch.Visible = false;
            }
        }
    }

}
