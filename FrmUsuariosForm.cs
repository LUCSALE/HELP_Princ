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
    public partial class FrmUsuariosForm : Form
    {
        public FrmUsuariosForm()
        {
            InitializeComponent();
        }

        private void FrmUsuariosForm_Load(object sender, EventArgs e)
        {
             lblTitulo.Text = InfoApp.opcao;

            if (InfoApp.opcao == "Editar DADOS USUÁRIO")
            {
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.uSUARIOSTableAdapter.FillByID(this.helpdesk01DataSet.USUARIOS, InfoPesq.ID);

                    //this.txtOBS_GERAL.DataBindings.Add("Text", this.uSUARIOSBindingSource, "OBS_GERAL");

                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }
            }

            if (InfoApp.opcao == "Incluir NOVO USUÁRIO")
            {
                try
                {
                    this.uSUARIOSBindingSource.AddNew();

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

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.uSUARIOSBindingSource.EndEdit();
                this.uSUARIOSTableAdapter.Update(this.helpdesk01DataSet);
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

        private void txtNOME_USUARIO_Enter(object sender, EventArgs e)
        {
            txtNOME_USUARIO.BackColor = Color.LightYellow;
        }

        private void txtNOME_USUARIO_Leave(object sender, EventArgs e)
        {
            txtNOME_USUARIO.BackColor = Color.White;
        }

        private void txtRAMAL_TEL_Enter(object sender, EventArgs e)
        {
            txtRAMAL_TEL.BackColor = Color.LightYellow;
        }

        private void txtRAMAL_TEL_Leave(object sender, EventArgs e)
        {
            txtRAMAL_TEL.BackColor = Color.White;
        }

        private void txtPREDIO_SETOR_Enter(object sender, EventArgs e)
        {
            txtPREDIO_SETOR.BackColor = Color.LightYellow;
        }

        private void txtPREDIO_SETOR_Leave(object sender, EventArgs e)
        {
            txtPREDIO_SETOR.BackColor = Color.White;
        }

        private void txtArea_Enter(object sender, EventArgs e)
        {
            txtArea.BackColor = Color.LightYellow;
        }

        private void txtArea_Leave(object sender, EventArgs e)
        {
            txtArea.BackColor = Color.White;
        }

        private void txtOBS_GERAL_Enter(object sender, EventArgs e)
        {
            txtOBS_GERAL.BackColor = Color.LightYellow;
        }

        private void txtOBS_GERAL_Leave(object sender, EventArgs e)
        {
            txtOBS_GERAL.BackColor = Color.White;
        }
    }
}
