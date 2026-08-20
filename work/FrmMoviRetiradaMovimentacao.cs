using System;
using System.Drawing; // Necessário para Color
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics.Eventing.Reader;
using Guna.UI2.WinForms;

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
            button2.Enabled = false;
            fncAtualizaTecnico();
            tmiEfeitos.Start();

            this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);
            fncEdicaoRBT();

            if (InfoApp.opcao == "Baixa RETIRADA DE EQUIPAMENTO")
            {
                DateTime DataAtual = DateTime.Now;
                string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                string HoraFormat = DataAtual.ToString("HH:mm:ss");

                fcnAtivaCampos();

                // Atualiza DADOS da aplicação
                txtDataRetirada.Text = DataFormat;
                txtHoraRetirada.Text = HoraFormat;
                txtDataRetirada.Focus();
                button2.Enabled = true;
                
            }
            else if (InfoApp.opcao == "Baixa RETIRADA DE EQUIPAMENTO (CONSULTA)")
            {
                button2.Enabled = false;
                fcnDesativaCampos();
                cbxTecnico_Atuante.Text = this.helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("TECNICO_ATUANTE").Trim();
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

            if (this.ValidateChildren())
            {

                //Interpretaçlão dos RBTs para salvar no banco de dados
                DataRowView row = (DataRowView)mOVI_RETIRADABindingSource.Current;
                if (rbtSDDsim.Checked)
                {

                    row["SSD"] = "SIM";
                }
                else
                {
                    row["SSD"] = "NAO";
                }

                if (rbtOFFICE365sim.Checked)
                {
                    row["OFFICE_365"] = "SIM";
                }
                else
                {
                    row["OFFICE_365"] = "NAO";
                }

                if (rbtMAINFRAMEsim.Checked)
                {
                    row["MAINFRAME"] = "SIM";
                }
                else
                {
                    row["MAINFRAME"] = "NAO";
                }

                if (rbtCNSEsim.Checked)
                {
                    row["CNS"] = "SIM";
                }
                else
                {
                    row["CNS"] = "NAO";
                }

                if (rbtBOTAOEMERGENCIAEsim.Checked)
                {
                    row["BOTAO_EMERGENCIA"] = "SIM";
                }
                else
                {
                    row["BOTAO_EMERGENCIA"] = "NAO";
                }

                if (rbtPLANILHAsim.Checked)
                {
                    row["OFFICE_365_PLAN"] = "SIM";
                }
                else if (rbtPLANILHAnao.Checked)
                {
                    row["OFFICE_365_PLAN"] = "NAO";
                }
                else if (rbtPLANILHAnsaplica.Checked)
                {
                    row["OFFICE_365_PLAN"] = "N/A";
                }


                //// Teste de atualização utilizando o método Update do TableAdapter, passando o DataSet atualizado   
                try
                {
                    this.mOVI_RETIRADABindingSource.EndEdit();
                    this.mOVI_RETIRADATableAdapter.UpdateQuery(cbxTecnico_Atuante.Text.Trim(),
                                                                txtDataRetirada.Text.ToString(),
                                                                txtHoraRetirada.Text.ToString(),
                                                                "CONCLUÍDO",
                                                                txtSAI.Text.ToString().Trim(),
                                                                row["SSD"].ToString(),
                                                                row["OFFICE_365"].ToString(),
                                                                row["MAINFRAME"].ToString(),
                                                                row["CNS"].ToString(),
                                                                row["BOTAO_EMERGENCIA"].ToString(),
                                                                row["OFFICE_365_PLAN"].ToString(),
                                                                txtPATRIMONIO.Text.ToString(),
                                                                InfoPesq.ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ATUALIZAR: MOVI_RETIRADA: " + ex.Message);
                }

                // IMPRESSÃO do registro
                // 
                InfoWork.strWork = "BAIXA";
                FrmMoviRetiradaImpressao MoviRetiradaImpressao = new FrmMoviRetiradaImpressao();
                MoviRetiradaImpressao.ShowDialog();
                
                
                this.Close();
            }
            

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";
            this.Close();
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

        private void fcnAtivaCampos()
        {
            foreach (Control c in this.gbxRetirada.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true; // Ativa o campo  
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair
                }
            }

            foreach (Control c in this.gbxDadosSolicitacao.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true; // Ativa o campo  
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair
                }

                // Ativa os RadioButtons
                rbtSDDsim.Enabled = true;
                rbtSDDnao.Enabled = true;


                rbtOFFICE365sim.Enabled = true;
                rbtOFFICE365nao.Enabled = true;


                rbtMAINFRAMEsim.Enabled = true;
                rbtMAINFRAMEnao.Enabled = true;

                rbtCNSEsim.Enabled = true;
                rbtCNSEnao.Enabled = true;

                rbtBOTAOEMERGENCIAEsim.Enabled = true;
                rbtBOTAOEMERGENCIAEnao.Enabled = true;

                rbtPLANILHAsim.Enabled = true;
                rbtPLANILHAnao.Enabled = true;
                rbtPLANILHAnsaplica.Enabled = true;
            }

        }



        private void fcnDesativaCampos()
        {
            foreach (Control c in this.gbxRetirada.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; // Desativa o campo  
                }
            }

            foreach (Control c in this.gbxDadosSolicitacao.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; // Desativa o campo  
                }
            }
            // Desativa os RadioButtons
            rbtSDDsim.Enabled = false;
            rbtSDDnao.Enabled = false;


            rbtOFFICE365sim.Enabled = false;
            rbtOFFICE365nao.Enabled = false;


            rbtMAINFRAMEsim.Enabled = false;
            rbtMAINFRAMEnao.Enabled = false;

            rbtCNSEsim.Enabled = false;
            rbtCNSEnao.Enabled = false;

            rbtBOTAOEMERGENCIAEsim.Enabled = false;
            rbtBOTAOEMERGENCIAEnao.Enabled = false;

            rbtPLANILHAsim.Enabled = false;
            rbtPLANILHAnao.Enabled = false;
            rbtPLANILHAnsaplica.Enabled = false;
            
            cbxTecnico_Atuante.Enabled = false;
            cbtnNovoTecnico.Enabled = false;

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

        private void fncEdicaoRBT()
        {
            // Pesquisa valores da TABELA: MOVI_RETIRADA 
            DataRowView rowWork = (DataRowView)mOVI_RETIRADABindingSource.Current;


            string strWork = (string)rowWork["SSD"];
            if (strWork.Trim() == "SIM")
            {
                rbtSDDsim.Checked = true;
                rbtSDDnao.Checked = false;

            }
            else
            {
                rbtSDDsim.Checked = false;
                rbtSDDnao.Checked = true;

            }

            strWork = (string)rowWork["OFFICE_365"];
            if (strWork.Trim() == "SIM")
            {
                rbtOFFICE365sim.Checked = true;
                rbtOFFICE365nao.Checked = false;

            }
            else
            {
                rbtOFFICE365sim.Checked = false;
                rbtOFFICE365nao.Checked = true;

            }


            strWork = (string)rowWork["MAINFRAME"];
            if (strWork.Trim() == "SIM")
            {
                rbtMAINFRAMEsim.Checked = true;
                rbtMAINFRAMEnao.Checked = false;

            }
            else
            {
                rbtMAINFRAMEsim.Checked = false;
                rbtMAINFRAMEnao.Checked = true;

            }

            strWork = (string)rowWork["CNS"];
            if (strWork.Trim() == "SIM")
            {
                rbtCNSEsim.Checked = true;
                rbtCNSEnao.Checked = false;

            }
            else
            {
                rbtCNSEsim.Checked = false;
                rbtCNSEnao.Checked = true;


            }

            strWork = (string)rowWork["BOTAO_EMERGENCIA"];
            if (strWork.Trim() == "SIM")
            {
                rbtBOTAOEMERGENCIAEsim.Checked = true;
                rbtBOTAOEMERGENCIAEnao.Checked = false;

            }
            else
            {
                rbtBOTAOEMERGENCIAEsim.Checked = false;
                rbtBOTAOEMERGENCIAEnao.Checked = true;

            }

            strWork = (string)rowWork["OFFICE_365_PLAN"];
            if (strWork.Trim() == "SIM")
            {
                rbtPLANILHAsim.Checked = true;
                rbtPLANILHAnao.Checked = false;
                rbtPLANILHAnsaplica.Checked = false;

            }
            else if (strWork.Trim() == "NAO")
            {
                rbtPLANILHAsim.Checked = false;
                rbtPLANILHAnao.Checked = true;
                rbtPLANILHAnsaplica.Checked = false;

            }
            else if (strWork.Trim() == "N/A")
            {
                rbtPLANILHAsim.Checked = false;
                rbtPLANILHAnao.Checked = false;
                rbtPLANILHAnsaplica.Checked = true;

            }

        }

        private void cbtnNovoEquipamento_Click(object sender, EventArgs e)
        {
            
        }


        private void txtPATRIMONIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPATRIMONIO.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtPATRIMONIO, "Patrimonio Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPATRIMONIO, "");
            }
        }

        private void txtSAI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSAI.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtSAI, "'SAI' Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSAI, "");
            }
        }

        private void cbxTecnico_Atuante_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxTecnico_Atuante.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(cbxTecnico_Atuante, "Técnico Atuante Invalido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbxTecnico_Atuante, "");
            }
        }
    }
        

}
 
