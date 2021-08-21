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
        string escolha = "";
        int i = 0;
        string enderecoCompleto = "";
        bool isnovo;
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.F4:
                    Application.Exit();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Região responsavel pelo movimento do programa quando segurado pelo mouse no
        /// painel superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Através da escolha do usuario modifica o comportamento do programa
        /// </summary>
        /// <param name="escolha"></param>
        /// <returns></returns>
        public int Escolha(string escolha)
        {
            

            switch (escolha)
            {
                case "CENTRO":
                    i = 0;
                    if (BtnTorno.Visible)
                    {
                        PnlProcurar.Visible = true;
                        BtnCentro.BackColor = Color.FromArgb(83, 147, 244);
                        BtnTorno.Visible = false;
                        BtnBackup.Visible = false;
                    }
                    else
                    {
                        RTBPrograma.Clear();
                        PnlProcurar.Visible = false;
                        BtnCentro.BackColor = Color.FromArgb(0, 80, 200);
                        BtnTorno.Visible = true;
                        BtnBackup.Visible = true;
                    }
                    break;
                case "TORNO":
                    i = 1;
                    if (BtnCentro.Visible)
                    {
                        PnlProcurar.Visible = true;
                        BtnTorno.BackColor = Color.FromArgb(83, 147, 244);
                        BtnTorno.Location = new System.Drawing.Point(6, 9);
                        BtnCentro.Visible = false;
                        BtnBackup.Visible = false;
                    }
                    else
                    {
                        RTBPrograma.Clear();
                        PnlProcurar.Visible = false;
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
                        PnlProcurar.Visible = true;
                        BtnBackup.BackColor = Color.FromArgb(83, 147, 244);
                        BtnBackup.Location = new System.Drawing.Point(6, 9);
                        BtnCentro.Visible = false;
                        BtnTorno.Visible = false;
                    }
                    else
                    {
                        RTBPrograma.Clear();
                        PnlProcurar.Visible = false;
                        BtnBackup.BackColor = Color.FromArgb(0, 80, 200);
                        BtnBackup.Location = new System.Drawing.Point(168, 9);
                        BtnCentro.Visible = true;
                        BtnTorno.Visible = true;
                    }
                    break;
            }
            return i;
        }

        /// <summary>
        /// Acessando o método de escolha recebe o diretorio a ser acessado
        /// preenchendo a lista de programas.
        /// </summary>
        /// <param name="escolha"></param>
        public void PreencherList(string escolha)
        {
            int i = Escolha(escolha);
            
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
            var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
            endereco = diretorio[i].Endereco;
            DirectoryInfo dir_files = new DirectoryInfo(endereco);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
            listProgram.Items.Clear();
            foreach (var fil in files2) { listProgram.Items.Add(fil.Name); }
        }

        /// <summary>
        /// Através do clique do botão é chamado o método PreencherList passando a string
        /// "CENTRO" caso o botão já tenha sido clicado a lista de programa é apagada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCentro_Click(object sender, EventArgs e)
        {
            if (BtnTorno.Visible)
            {
                escolha = "CENTRO";
                PreencherList(escolha);
                BtnNovo.Visible = true;
            } else {
                PreencherList(escolha);
                escolha = "";
                listProgram.Items.Clear();
                BtnEditar.Visible = false;
                BtnNovo.Visible = false;
            }
        }

        /// <summary>
        /// Através do clique do botão é chamado o método PreencherList passando a string
        /// "TORNO" caso o botão já tenha sido clicado a lista de programa é apagada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnTorno_Click(object sender, EventArgs e)
        {
            if (BtnCentro.Visible)
            {
                escolha = "TORNO";
                PreencherList(escolha);
                BtnNovo.Visible = true;
            }
            else
            {
                PreencherList(escolha);
                escolha = "";
                listProgram.Items.Clear();
                BtnEditar.Visible = false;
                BtnNovo.Visible = false;
            }
        }

        /// <summary>
        /// Através do clique do botão é chamado o método PreencherList passando a string
        /// "BACKUP" caso o botão já tenha sido clicado a lista de programa é apagada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackup_Click(object sender, EventArgs e)
        {
            if (BtnCentro.Visible)
            {
                BtnNovo.Visible = true;
                escolha = "BACKUP";
                PreencherList(escolha);
            }
            else
            {
                PreencherList("BACKUP");
                escolha = "";
                listProgram.Items.Clear();
                BtnNovo.Visible = false;
                BtnEditar.Visible = false;
                BtnNovo.Visible = false;
            }
        }

        /// <summary>
        /// Maximiza a aplicação preenchendo a tela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        /// <summary>
        /// Restaura o tamanho da aplicação ao padrão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        /// <summary>
        /// Minimiza a aplicação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Fecha a aplicação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Preenche o texto dentro do RTB conforme o arquivo selecionado na lista de programas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnEditar.Visible = true;
            enderecoCompleto = endereco + "\\" + listProgram.SelectedItem.ToString();
            StreamReader sr = new StreamReader(enderecoCompleto);
            RTBPrograma.Text = sr.ReadToEnd();
            sr.Dispose();
        }

        public void ProcurarPrograma(string escolha)
        {
            int i = Escolha(escolha);

            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
            var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
            endereco = diretorio[i].Endereco;
            DirectoryInfo dir_files = new DirectoryInfo(endereco);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
            listProgram.Items.Clear();

            foreach (var fil in files2) {
                using (StreamReader stream = new StreamReader(fil.FullName))
                {
                    string str = stream.ReadToEnd().ToUpper();
                    if (str.Contains(TxtProcurar.Text))
                    {
                        listProgram.Items.Add(fil.Name);
                    }
                }
            } 
        }

        private void TxtProcurar_KeyUp(object sender, KeyEventArgs e)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\diretorios.json");
            var diretorio = JsonConvert.DeserializeObject<List<Diretorio>>(json);
            endereco = diretorio[i].Endereco;
            DirectoryInfo dir_files = new DirectoryInfo(endereco);
            FileInfo[] files2 = dir_files.GetFiles("*", SearchOption.TopDirectoryOnly);
            listProgram.Items.Clear();

            foreach (var fil in files2)
            {
                using (StreamReader stream = new StreamReader(fil.FullName))
                {
                    string str = stream.ReadToEnd().ToUpper();
                    if (str.Contains(TxtProcurar.Text))
                    {
                        listProgram.Items.Add(fil.Name);
                    }
                }
            }
        }

        private void CriarNovo()
        {
            try
            {
                if(!string.IsNullOrEmpty(this.RTBPrograma.Text))
                {
                    this.RTBPrograma.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Não tem conteudo para salvar!");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
        }

        private void SalvarArquivo()
        {
            DialogResult decisao = MessageBox.Show("Deseja Salvar as Alterações?", "Salvar", MessageBoxButtons.YesNo);
            if (decisao == DialogResult.Yes)
            {
                File.WriteAllText(enderecoCompleto, this.RTBPrograma.Text);
            }
            else
            {
                MessageBox.Show("O arquivo não foi salvo!");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            isnovo = false;
            DialogResult decisao = MessageBox.Show("Deseja editar o programa: " + listProgram.SelectedItem.ToString() + "?", "Editar", MessageBoxButtons.YesNo);
            if (decisao == DialogResult.Yes)
            {
                RTBPrograma.ReadOnly = false;
                BtnEditar.Visible = false;
                BtnSalvar.Visible = true;
                BtnCancelar.Visible = true;
            }
            else
            {
                MessageBox.Show("Edição Cancelada!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (!isnovo)
            {
                DialogResult decisao = MessageBox.Show("Deseja cancelar a edição do programa: " + listProgram.SelectedItem.ToString() + "?", "Cancelar", MessageBoxButtons.YesNo);
                if (decisao == DialogResult.Yes)
                {
                    RTBPrograma.ReadOnly = true;
                    BtnSalvar.Visible = false;
                    BtnCancelar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Edição Cancelada!");
                }
            }
            else
            {
                DialogResult decisao = MessageBox.Show("Deseja cancelar o novo programa? ", "Cancelar", MessageBoxButtons.YesNo);
                if (decisao == DialogResult.Yes)
                {
                    RTBPrograma.ReadOnly = true;
                    BtnNovo.Visible = true;
                    BtnSalvar.Visible = false;
                    BtnCancelar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Edição Cancelada!");
                }
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            isnovo = true;
            DialogResult decisao = MessageBox.Show("Deseja criar um novo programa?","Novo", MessageBoxButtons.YesNo);
            if (decisao == DialogResult.Yes)
            {
                if (BtnCentro.Visible == true) BtnCentro_Click(sender, e);
                if (BtnTorno.Visible == true) BtnTorno_Click(sender, e);
                if (BtnBackup.Visible == true) BtnBackup_Click(sender, e);

                RTBPrograma.ReadOnly = false;
                BtnNovo.Visible = false;
                BtnSalvar.Visible = true;
                BtnCancelar.Visible = true;
            }
            else
            {
                MessageBox.Show("Edição Cancelada!");
            }
            if (!string.IsNullOrEmpty(this.RTBPrograma.Text))
            {

                RTBPrograma.Clear();
            }
            else
            {

            }
        }
    }
}
