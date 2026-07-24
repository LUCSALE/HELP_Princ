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
    public partial class FrmMoviRetiradaImpressao : Form
    {
        public FrmMoviRetiradaImpressao()
        {
            InitializeComponent();

            this.AutoScroll = true; // Habilita a barra de rolagem automática
            fcnConfigCampos(); //Conifigura campos para navegação com a tecla Enter e Destaque do campo ao entrar e restaura a cor ao sair
        }


        private void FrmMoviRetiradaImpressao_Load(object sender, EventArgs e)
        {
            fncAtualizaTecnico();
            tmiEfeitos.Start();

            if (InfoApp.opcao == "Incluir RETIRADA DE EQUIPAMENTO")
            {
                gbxRetirada.Enabled = false;
                rbtAgendamento.Checked = true;
                rbtAgendamento.Focus();
            }
            else if (InfoApp.opcao == "Editar RETIRADA DE EQUIPAMENTO")
            {
                //Pesquisa para preencher o comboBox de MODALIDADE
                this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);

                if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "AGENDAMENTO")
                {
                    rbtAgendamento.Checked = true;
                }
                else if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "MANUTENÇÃO")
                {
                    rbtManutencao.Checked = true;
                }
                else if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "SUBS./PREPARAÇÃO")
                {
                    rtbSubstituicao.Checked = true;
                }
                else if (helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MODALIDADE").Trim() == "SIMPLES RETIRADA")
                {
                    rtbSimples.Checked = true;
                }
                cbxTecnico_Atuante.Text = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("TECNICO_ATUANTE").Trim();
                gbxRetirada.Enabled = true;
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
            }

            if (rbtManutencao .Checked)
            {
                InfoWork.MoviRetiradaModalidade = "MANUTENÇÃO";
            }

            if (rtbSubstituicao.Checked)
            {
                InfoWork.MoviRetiradaModalidade = "SUBS./PREPARAÇÃO";
            }

            if (rtbSimples.Checked)
            {
                InfoWork.MoviRetiradaModalidade = "SIMPLES RETIRADA";
            }
            InfoWork.TecnicoAtuante = cbxTecnico_Atuante.Text.Trim();
            InfoWork.DataRetirada = txtDataRetirada.Text.Trim();
            InfoWork.HoraRetirada = txtHoraRetirada.Text.Trim();    

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

        private void FrmMoviRetiradaImpressao_KeyDown(object sender, KeyEventArgs e)
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


        private void FrmMoviRetiradaImpressao_Activated(object sender, EventArgs e)
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
            gbxRetirada.Enabled = false;
            txtDataRetirada.Clear();
            txtHoraRetirada.Clear();
            cbxTecnico_Atuante.SelectedIndex = -1;

        }

        private void rtbSimples_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rtbSimples_Click(object sender, EventArgs e)
        {
            gbxRetirada.Enabled = true;
        }

        private void rtbSubstituicao_Click(object sender, EventArgs e)
        {
            gbxRetirada.Enabled = true;
        }

        private void rbtManutencao_Click(object sender, EventArgs e)
        {
            gbxRetirada.Enabled = true;
        }

        private void fncAtualizaTecnico()
        {

            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.TECNICOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tECNICOSTableAdapter.FillByATIVO(this.helpdesk01DataSet.TECNICOS);

            cbxTecnico_Atuante.Items.Clear();
            for (int i = 0; i < this.helpdesk01DataSet.TECNICOS.Count; i++)
            {
                string strNOME_ENTIDADE = this.helpdesk01DataSet.TECNICOS.Rows[i].Field<string>("NOME_COMPLETO").Trim();
                cbxTecnico_Atuante.Items.Add(strNOME_ENTIDADE);
            }
            cbxTecnico_Atuante.SelectedIndex = -1; // Limpa a seleção do ComboBox  

        }

        private void fcnConfigCampos()
        {
            foreach (Control c in this.gbxRetirada.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }
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
            cbxTecnico_Atuante.SelectedIndex = -1; // Limpa a seleção do ComboBox   

            this.Enabled = false;
            InfoApp.opcao = "Incluir NOVO TÉCNICO";
            FrmTecnicosForm TecnicosForm = new FrmTecnicosForm();
            TecnicosForm.ShowDialog();
            this.Enabled = true;

            fncAtualizaTecnico();

            int posicao = cbxTecnico_Atuante.FindStringExact(InfoWork.strWork.Trim());
            if (posicao >= 0)
            {
                cbxTecnico_Atuante.SelectedIndex = posicao;
            }

        }
    }
}
 
