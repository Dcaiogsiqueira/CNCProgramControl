using CNCProgramControl.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CNCProgramControl.Views
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
            LerJson();
        }

        public void LerJson()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
            var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
            String enderecoCentro = diretorio[0].Endereco;
            String enderecoTorno = diretorio[1].Endereco;
            String enderecoBackup = diretorio[2].Endereco;
            TxtCentro.Text = enderecoCentro;
            TxtTorno.Text = enderecoTorno;
            TxtBackup.Text = enderecoBackup;
        }

        private void BtnClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
