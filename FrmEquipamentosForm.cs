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
    public partial class FrmEquipamentosForm : Form
    {
        public FrmEquipamentosForm()
        {
            InitializeComponent();
        }

        private void FrmEquipamentosForm_Load(object sender, EventArgs e)
        {
            if (InfoApp.opcao == "Editar DADOS DO EQUIPAMENTO")
            {
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.eQUIPAMENTOSTableAdapter.FillByID(this.helpdesk01DataSet.EQUIPAMENTOS, InfoPesq.ID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }
            }

            if (InfoApp.opcao == "Incluir NOVO EQUIPAMENTO")
            {
                try
                {
                    this.eQUIPAMENTOSBindingSource.AddNew();

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
            txtDESCRICAO_EQUIPAMENTO.Focus();
            lblTitulo.Text = InfoApp.opcao;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            InfoWork.strWork = txtDESCRICAO_EQUIPAMENTO.Text;   
            try
            {
                this.Validate();
                this.eQUIPAMENTOSBindingSource.EndEdit();
                this.eQUIPAMENTOSTableAdapter.Update(this.helpdesk01DataSet);
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

        private void txtDESCRICAO_EQUIPAMENTO_Enter(object sender, EventArgs e)
        {
            txtDESCRICAO_EQUIPAMENTO.BackColor = Color.LightYellow;
        }

        private void txtDESCRICAO_EQUIPAMENTO_Leave(object sender, EventArgs e)
        {
            txtDESCRICAO_EQUIPAMENTO.BackColor = Color.White;   
        }

        private void txtDATA_DES_Enter(object sender, EventArgs e)
        {
            txtDATA_DES.BackColor = Color.LightYellow;
        }

        private void txtDATA_DES_Leave(object sender, EventArgs e)
        {
            txtDATA_DES.BackColor = Color.White;
        }
    }
}
