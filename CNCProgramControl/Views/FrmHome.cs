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
    }
}
