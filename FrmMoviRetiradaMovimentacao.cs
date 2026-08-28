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
            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.TAREFA_BANCADA'. Você pode movê-la ou removê-la conforme necessário.
            this.tAREFA_BANCADATableAdapter.Fill(this.helpdesk01DataSet.TAREFA_BANCADA);
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
                    if (InfoWork.strWork_b == "ATUALIZA TAREFA BANCADA")
                    {
                        fcnAtualiza();
                    }
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
                this.tAREFA_BANCADABindingSource.AddNew();
                
                // Atualiza TABELA: MOVI_RETIRADA com os dados 
                DataRowView rowMOVI_RETIRADA = (DataRowView)mOVI_RETIRADABindingSource.Current;
                DataRowView rowTAREFA_BANCADA = (DataRowView)tAREFA_BANCADABindingSource.Current;

                rowTAREFA_BANCADA["ID"] = rowMOVI_RETIRADA["ID"];
                rowTAREFA_BANCADA["DATA"] = rowMOVI_RETIRADA["DATA"];
                rowTAREFA_BANCADA["HORA"] = rowMOVI_RETIRADA["HORA"];

                rowTAREFA_BANCADA["ESTAGIO"] = rowMOVI_RETIRADA["ESTAGIO"];
                rowTAREFA_BANCADA["RAMAL_TEL"] = rowMOVI_RETIRADA["RAMAL_TEL"];
                rowTAREFA_BANCADA["NOME_USUARIO"] = rowMOVI_RETIRADA["NOME_USUARIO"];
                rowTAREFA_BANCADA["PREDIO_SETOR"] = rowMOVI_RETIRADA["PREDIO_SETOR"];
                rowTAREFA_BANCADA["AREA"] = rowMOVI_RETIRADA["AREA"];
                rowTAREFA_BANCADA["NUMERO_OS"] = rowMOVI_RETIRADA["NUMERO_OS"];
                rowTAREFA_BANCADA["EQUIPAMENTO"] = rowMOVI_RETIRADA["EQUIPAMENTO"];
                rowTAREFA_BANCADA["SAI"] = rowMOVI_RETIRADA["SAI"];
                rowTAREFA_BANCADA["SSD"] = rowMOVI_RETIRADA["SSD"];
                rowTAREFA_BANCADA["OFFICE_365"] = rowMOVI_RETIRADA["OFFICE_365"];
                rowTAREFA_BANCADA["MAINFRAME"] = rowMOVI_RETIRADA["MAINFRAME"];
                rowTAREFA_BANCADA["CNS"] = rowMOVI_RETIRADA["CNS"];
                rowTAREFA_BANCADA["BOTAO_EMERGENCIA"] = rowMOVI_RETIRADA["BOTAO_EMERGENCIA"];
                rowTAREFA_BANCADA["OFFICE_365_PLAN"] = rowMOVI_RETIRADA["OFFICE_365_PLAN"];
                rowTAREFA_BANCADA["DESCRICA_ATIVIDADE"] = rowMOVI_RETIRADA["DESCRICA_ATIVIDADE"];
                rowTAREFA_BANCADA["OBS_IMPORTANTES"] = rowMOVI_RETIRADA["OBS_IMPORTANTES"];
                rowTAREFA_BANCADA["PATRIMONIO"] = rowMOVI_RETIRADA["PATRIMONIO"];
                rowTAREFA_BANCADA["TECNICO_SOLICITANTE"] = rowMOVI_RETIRADA["TECNICO_SOLICITANTE"];
                rowTAREFA_BANCADA["TECNICO_ATUANTE"] = rowMOVI_RETIRADA["TECNICO_ATUANTE"];
                rowTAREFA_BANCADA["DATA_RETIRADA"] = rowMOVI_RETIRADA["DATA_RETIRADA"];
                rowTAREFA_BANCADA["HORA_RETIRADA"] = rowMOVI_RETIRADA["HORA_RETIRADA"];
                rowTAREFA_BANCADA["SITUACAO"] = "PENDENTE";
                rowTAREFA_BANCADA["MODALIDADE"] = "TAREFA BANCADA";
                rowTAREFA_BANCADA["PRIORIDADE"] = rowMOVI_RETIRADA["PRIORIDADE"];
                rowTAREFA_BANCADA["DATA_PREVISTA"] = rowMOVI_RETIRADA["DATA_PREVISTA"];
                rowTAREFA_BANCADA["HORA_PREVISTA"] = rowMOVI_RETIRADA["HORA_PREVISTA"];
                rowTAREFA_BANCADA["ID_TECNICO_SOLICITANTE"] = rowMOVI_RETIRADA["ID_TECNICO_SOLICITANTE"];

                // Atualiza os dados da tabela TAREFA_BANCADA
                try
                {

                    this.tAREFA_BANCADABindingSource.EndEdit();
                    this.tAREFA_BANCADATableAdapter.Update(this.helpdesk01DataSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar: TAREFA_BANCADA: " + ex.Message);
                }

            }
        }
    }
}
 
