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
        Point startPosition;

        public FrmHome()
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
                Location = new Point(newpoint.X- startPosition.X, newpoint.Y - startPosition.Y);
            }
        }

        #endregion

        private void BtnFile_MouseClick(object sender, MouseEventArgs e)
        {
            ControllPnl();
        }

        private void BtnCentro_MouseClick(object sender, MouseEventArgs e)
        {
            ControllPnl();
            Buscador();

        }

        private void ControllPnl()
        {
            if (PnlFile.Visible)
            {
                BtnFile.BackColor = Color.FromArgb(255, 255, 255);
                PnlFile.Visible = false;
            }
            else
            {
                BtnFile.BackColor = Color.FromArgb(245, 246, 247);
                PnlFile.Visible = true;
            }
        }

        private void Buscador()
        {
            TxtSearch.Visible = true;
        }

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
    }
}
