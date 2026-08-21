using System;
using System.Drawing; // Necessário para Color
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics.Eventing.Reader;
using Guna.UI2.WinForms;
using System.Threading.Tasks;

namespace HELP_Princ
{
    public partial class FrmMoviRetiradaMovimentacao : Form
    {
        public FrmMoviRetiradaMovimentacao()
        {
            InitializeComponent();

            this.AutoScroll = true; // Habilita a barra de rolagem automática
            //fcnConfigCampos(); //Conifigura campos para navegação com a tecla Enter e Destaque do campo ao entrar e restaura a cor ao sair
        }


        private void FrmMoviRetiradaMovimentacao_Load(object sender, EventArgs e)
        {
            tmiEfeitos.Start();
            fcnAtualiza_ASYNC();
            guna2WinProgressIndicator1.Visible = true;
            guna2WinProgressIndicator1.AutoStart = true;



            //this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);


        }


        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dbgTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


        }

        private void dbgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {


        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtESTAGIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmiEfeitos_Tick(object sender, EventArgs e)
        {
            // Alterna entre Vermelho e a cor SlateGray
            lblTitulo.ForeColor = (lblTitulo.ForeColor == Color.SlateGray) ? Color.Red : Color.SlateGray;


            // Opcional: Alternar a visibilidade em vez da cor
            // label1.Visible = !label1.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
        }

        private void FrmMoviRetiradaMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {

        }


        private void txtDESCRICA_ATIVIDADE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void FrmMoviRetiradaMovimentacao_Activated(object sender, EventArgs e)
        {

        }

        private void txtDATA_PREVISTA_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDESCRICA_ATIVIDADE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbtAgendamento_Click(object sender, EventArgs e)
        {

        }

        private void rtbSimples_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbSimples_Click(object sender, EventArgs e)
        {

        }

        private void rtbSubstituicao_Click(object sender, EventArgs e)
        {

        }

        private void rbtManutencao_Click(object sender, EventArgs e)
        {

        }


        private void cbtnNovoTecnico_Click(object sender, EventArgs e)
        {

        }


        private void cbtnNovoEquipamento_Click(object sender, EventArgs e)
        {

        }


        private void txtPATRIMONIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtSAI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbxTecnico_Atuante_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private async void fcnAtualiza_ASYNC()
        {



            try
            {
                await fcnAtualiza_ASYNC_ASYNC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                guna2WinProgressIndicator1.AutoStart = false;
                guna2WinProgressIndicator1.Visible = false;
                this.Close();

            }
        }


        private async Task fcnAtualiza_ASYNC_ASYNC()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(500);

                // Seu processamento aqui
                if (i == 5)
                {
                    fcnAtualiza();
                }
            }
        }

        private void fcnAtualiza()
        {
            // Simula um processamento demorado
            //System.Threading.Thread.Sleep(5000);

            try
            {

                this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar Consultar: MOVI_RETIRADA: " + ex.Message);
            }
            if (this.helpdesk01DataSet.MOVI_RETIRADA.Count > 0)
            {
                this.mOVI_RETIRADABindingSource.AddNew();



            }
        }
    }
}
 
