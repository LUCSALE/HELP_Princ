using System;
using System.Drawing; // Necessário para Color
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics.Eventing.Reader;

namespace HELP_Princ
{
    public partial class FrmMoviRetiradaUpdate : Form
    {
        public FrmMoviRetiradaUpdate()
        {
            InitializeComponent();

            this.AutoScroll = true; // Habilita a barra de rolagem automática
            fcnConfigCampos(); //Conifigura campos para navegação com a tecla Enter e Destaque do campo ao entrar e restaura a cor ao sair
        }


        private void FrmMoviRetiradaUpdate_Load(object sender, EventArgs e)
        {
            fncAtualizaTecnico();
            tmiEfeitos.Start();

            if (InfoApp.opcao == "Incluir RETIRADA DE EQUIPAMENTO")
            {

                rtbTarefa_Bancada.Checked = true;
                button2.Focus();
            }
            else if (InfoApp.opcao == "Editar RETIRADA DE EQUIPAMENTO")
            {
                //Pesquisa para preencher o comboBox de MODALIDADE
                this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);

                if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "AGENDAMENTO")
                {
                    rbtAgendamento.Checked = true;
                }
                else if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "TAREFA BANCADA")
                {
                    rtbTarefa_Bancada.Checked = true;
                }
                else if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "SIMPLES RETIRADA")
                {
                    rtbSimples.Checked = true;
                }
                
            }
            
        }


        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";
            this.Close();
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

        private void txtNOME_USUARIO_Enter(object sender, EventArgs e)
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
            InfoWork.MoviRetiradaUpdate = "S";

            if (rbtAgendamento.Checked)
            {
                InfoWork.MoviRetiradaModalidade = "AGENDAMENTO";
                InfoWork.strWork_b = "NÃO ATUALIZA TAREFA BANCADA";
            }

            if (rtbTarefa_Bancada.Checked)
            {
                InfoWork.MoviRetiradaModalidade = "RETIRADA DE EQUIPAMENTO";
                InfoWork.strWork_b = "ATUALIZA TAREFA BANCADA";
            }

            if (rtbSimples.Checked)
            {
                InfoWork.MoviRetiradaModalidade = "SIMPLES RETIRADA";
                InfoWork.strWork_b = "NÃO ATUALIZA TAREFA BANCADA";
            }

            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";  
            this.Close();
        }

        private void txtRAMAL_TEL_Leave(object sender, EventArgs e)
        {

        }

        private void FrmMoviRetiradaUpdate_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }


        private void rbtSDDsim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRAMAL_TEL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtNOME_USUARIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtPREDIO_SETOR_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtArea_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtPATRIMONIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPATRIMONIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtSAI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbxEquipamento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtDESCRICA_ATIVIDADE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbtnNovoEquipamento_Click(object sender, EventArgs e)
        {

        }


        private void FrmMoviRetiradaUpdate_Activated(object sender, EventArgs e)
        {

        }

        private void txtDATA_PREVISTA_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSAI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDESCRICA_ATIVIDADE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";
            
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

        private void fncAtualizaTecnico()
        {


        }

        private void fcnConfigCampos()
        {

        }

        private void fcnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita o som "beep" 
                this.SelectNextControl((Control)sender, true,   // próximo controle
                                                        true,
                                                        true,
                                                        true);
            }
        }

        private void cbtnNovoTecnico_Click(object sender, EventArgs e)
        {

        }
    }
}
 
