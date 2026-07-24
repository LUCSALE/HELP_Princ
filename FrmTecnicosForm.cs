using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_Princ
{
    public partial class FrmTecnicosForm : Form
    {
        public FrmTecnicosForm()
        {
            InitializeComponent();

            txtNOME_COMPLETO.Enter += txtNOME_COMPLETO_Enter;
            txtNOME_COMPLETO.Leave += txtNOME_COMPLETO_Leave;

        }

        private void FrmTecnicosForm_Load(object sender, EventArgs e)
        {
            pbxAssinatura.Image = null;

            if (InfoApp.opcao == "Editar DADOS DO TÉCNICO")
            {
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.tECNICOSTableAdapter.FillByID(this.helpdesk01DataSet.TECNICOS, InfoPesq.ID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }

             
                
                string arqAssinatura = this.helpdesk01DataSet.TECNICOS.Rows[0].Field<string>("ARQ_ASSINATURA");
                if (!string.IsNullOrEmpty(arqAssinatura))
                {
                     pbxAssinatura.Image = Image.FromFile(arqAssinatura);
                     pbxAssinatura.SizeMode = PictureBoxSizeMode.Zoom;
                }
                   
            }

            if (InfoApp.opcao == "Incluir NOVO TÉCNICO")
            {
                try
                {
                    this.tECNICOSBindingSource.AddNew();

                    DateTime DataAtual = DateTime.Now;
                    string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                    string HoraFormat = DataAtual.ToString("HH:mm:ss");

                    // Atualiza DADOS da aplicação
                    txtData.Text = DataFormat;
                    txtHora.Text = HoraFormat;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar: " + ex.Message);
                    this.Close();
                }
            }
            txtNOME_COMPLETO.Focus();
            lblTitulo.Text = InfoApp.opcao;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            InfoWork.strWork = txtNOME_COMPLETO.Text.Trim();
            try
            {
                this.Validate();
                this.tECNICOSBindingSource.EndEdit();
                this.tECNICOSTableAdapter.Update(this.helpdesk01DataSet);
                MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar: " + ex.Message);
            }
            this.Close();

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtDATA_DES.Value = DateTime.Parse("01/01/1900");
            }

            if (comboBox1.SelectedIndex == 1)
            {
                
                // Atualiza DADOS da aplicação
               txtDATA_DES.Value = DateTime.Now;
               
            }
        }

        private void FrmTecnicosForm_Enter(object sender, EventArgs e)
        {

        }

        private void txtNOME_COMPLETO_Enter(object sender, EventArgs e)
        {
            txtNOME_COMPLETO.BackColor = Color.LightYellow;
        }

        private void txtNOME_COMPLETO_Leave(object sender, EventArgs e)
        {
            txtNOME_COMPLETO.BackColor = Color.White;   
        }

        

        private void txtDRT_ID_Enter_1(object sender, EventArgs e)
        {
            txtDRT_ID.BackColor = Color.LightYellow;
        }

        private void txtDRT_ID_Leave(object sender, EventArgs e)
        {
            txtDRT_ID.BackColor = Color.White;
        }

        private void txtAREA_Enter(object sender, EventArgs e)
        {
            txtAREA.BackColor = Color.LightYellow;
        }

        private void txtAREA_Leave(object sender, EventArgs e)
        {
            txtAREA.BackColor = Color.White;
        }

        private void txtEMAIL_Enter(object sender, EventArgs e)
        {
            txtEMAIL.BackColor = Color.LightYellow;
        }

        private void txtEMAIL_Leave(object sender, EventArgs e)
        {
            txtEMAIL.BackColor = Color.White;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxAssinatura.Image = Image.FromFile(ofd.FileName);
                pbxAssinatura.SizeMode = PictureBoxSizeMode.Zoom;
                txtArq_Assinatura.Text = ofd.FileName;
            }

        }
    }
}
