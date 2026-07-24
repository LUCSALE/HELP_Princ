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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HELP_Princ
{
    public partial class FrmServicosForm : Form
    {
        public FrmServicosForm()
        {
            InitializeComponent();
        }

        private void FrmServicosForm_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = InfoApp.opcao;

            if (InfoApp.opcao == "Editar DADOS SERVIÇO")
            {
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.sERVICOSTableAdapter.FillByID(this.helpdesk01DataSet.SERVICOS, InfoPesq.ID);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }
            }

            if (InfoApp.opcao == "Incluir NOVO SERVIÇO")
            {
                try
                {
                    this.sERVICOSBindingSource.AddNew();

                    DateTime DataAtual = DateTime.Now;
                    string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                    string HoraFormat = DataAtual.ToString("HH:mm:ss");

                    // Atualiza DADOS da aplicação
                    txtData.Text = DataFormat;
                    txtHora.Text = HoraFormat;
                    aTIVO2ComboBox.Text = "SIM";
                    txtDATA_DES.Text = "01/01/1900";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar: " + ex.Message);
                    this.Close();
                }



                
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

            if (aTIVO2ComboBox.Text == "SIM")
            {
                txtDATA_DES.Text = "01/01/1900";  
            } 

            if (aTIVO2ComboBox.Text == "NÃO")
            {
                txtDATA_DES.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }


            try
            {
                this.Validate();
                this.sERVICOSBindingSource.EndEdit();
                this.sERVICOSTableAdapter.Update(this.helpdesk01DataSet);
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
            
        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void sERVICOSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aTIVO2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }

        private void txtDESCRCAO_SERVICO_Enter(object sender, EventArgs e)
        {
            txtDESCRCAO_SERVICO.BackColor = Color.LightYellow;
        }

        private void txtDESCRCAO_SERVICO_Leave(object sender, EventArgs e)
        {
            txtDESCRCAO_SERVICO.BackColor = Color.White;    
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
