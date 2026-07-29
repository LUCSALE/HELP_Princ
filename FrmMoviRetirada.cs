using System;
using System.Drawing; // Necessário para Color
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Net;

namespace HELP_Princ
{
    public partial class FrmMoviRetirada : Form
    {
        public FrmMoviRetirada()
        {
            InitializeComponent();


            this.AutoScroll = true; // Habilita a barra de rolagem automática
            fcnConfigCampos(); //Conifigura campos para navegação com a tecla Enter e Destaque do campo ao entrar e restaura a cor ao sair

        }


        private void FrmMoviRetirada_Load(object sender, EventArgs e)
        {
            // Atualiza Tecnicos & Equpamentos
            fncAtualizaTecnicos();



            fcnAtualizaEquipamentos();

            tmiEfeitos.Start();
            txtDESCRICA_ATIVIDADE.DataBindings.Add("Text", mOVI_RETIRADABindingSource, "DESCRICA_ATIVIDADE", true, DataSourceUpdateMode.OnPropertyChanged);
            txtOBS_IMPORTANTES.DataBindings.Add("Text", mOVI_RETIRADABindingSource, "OBS_IMPORTANTES", true, DataSourceUpdateMode.OnPropertyChanged);   

            if (InfoApp.opcao == "Incluir RETIRADA DE EQUIPAMENTO")
            {
                fcnAtivaCampos();
                try
                {
                    this.mOVI_RETIRADABindingSource.AddNew();

                    DateTime DataAtual = DateTime.Now;
                    string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                    string HoraFormat = DataAtual.ToString("HH:mm:ss");

                    // Atualiza DADOS da aplicação
                    txtData.Text = DataFormat;
                    txtHora.Text = HoraFormat;
                    txtDATA_PREVISTA.Text = DataFormat;
                    txtHoraPrevista.Text = HoraFormat;

                    txtSITUACAO.Text = "PENDENTE";
                    txtMODALIDADE.Text = "RETIRADA DE EQUIPAMENTO";

                    fncPosicaoInicialRBT();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Salvar: " + ex.Message);
                    this.Close();
                }

            }

            if (InfoApp.opcao == "Editar RETIRADA DE EQUIPAMENTO")
            {
                fcnAtivaCampos();
                
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);

                    // Atualiza os campos de "cbx" com os dados da tabela MOVI_RETIRADA
                    cbxEquipamento.Text = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("EQUIPAMENTO");
                    cbxTecnicos.Text = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("TECNICO_SOLICITANTE");

                    //Ajusta cbxPrioridade para exibir o valor correto da prioridade, mesmo que haja espaços em branco
                    int posicao = cbxPrioridade.FindStringExact(helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("PRIORIDADE").Trim());
                    if (posicao >= 0)
                    {
                        cbxPrioridade.SelectedIndex = posicao;
                    }

                    fncEdicaoRBT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }
            }

            if (InfoApp.opcao == "Consultar RETIRADA DE EQUIPAMENTO")
            {
                fcnDesativaCampos();
                try
                {
                    // TODO: esta linha de código carrega dados na tabela 'db_ab2460_SALDOS_LCTO_DataSet.SALDOS'. Você pode movê-la ou removê-la conforme necessário.
                    this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);

                    // Atualiza os campos de "cbx" com os dados da tabela MOVI_RETIRADA
                    cbxEquipamento.Text = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("EQUIPAMENTO");
                    cbxTecnicos.Text = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("TECNICO_SOLICITANTE");

                    //Ajusta cbxPrioridade para exibir o valor correto da prioridade, mesmo que haja espaços em branco
                    int posicao = cbxPrioridade.FindStringExact(helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("PRIORIDADE").Trim());
                    if (posicao >= 0)
                    {
                        cbxPrioridade.SelectedIndex = posicao;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pesquisar: " + ex.Message);
                }
            }
        }


        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
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

            //if (this.ValidateChildren())
            //{
            //    if (InfoApp.opcao == "Incluir RETIRADA DE EQUIPAMENTO")
            //    {
            //        this.Enabled = false;
            //        FrmMoviRetiradaUpdate MoviRetiradaUpdate = new FrmMoviRetiradaUpdate();
            //        MoviRetiradaUpdate.ShowDialog();
            //        this.Enabled = true;
            //    }
            //    else
            //    {
            //        InfoWork.MoviRetiradaUpdate = "S";
            //    }


            if (this.ValidateChildren())
            {
                this.Enabled = false;
                FrmMoviRetiradaUpdate MoviRetiradaUpdate = new FrmMoviRetiradaUpdate();
                MoviRetiradaUpdate.ShowDialog();
                this.Enabled = true;

                if (InfoWork.MoviRetiradaUpdate == "S")
                {

                    // Atualiza TABELA:Usuário pelo RAMAL
                    this.uSUARIOSTableAdapter.FillByRAMAL_TEL(this.helpdesk01DataSet.USUARIOS, txtRAMAL_TEL.Text);

                    if (this.helpdesk01DataSet.USUARIOS.Count > 0)
                    {
                        this.uSUARIOSTableAdapter.Update_por_RAMAL_TEL(txtNOME_USUARIO.Text, txtPREDIO_SETOR.Text, txtArea.Text, txtRAMAL_TEL.Text);
                    }
                    else
                    {
                        DateTime DataAtual = DateTime.Now;
                        string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                        string HoraFormat = DataAtual.ToString("HH:mm:ss");
                        string strNome_Usuario = txtNOME_USUARIO.Text;
                        string strRamal = txtRAMAL_TEL.Text;
                        string strPredio_Setor = txtPREDIO_SETOR.Text;

                        this.uSUARIOSTableAdapter.USUARIOSInsert(DataFormat, HoraFormat, strRamal.ToUpper(), strNome_Usuario.ToUpper(), strPredio_Setor.ToUpper(), "SIM", "-> Incluído via RETIRADA , em: " + DataFormat);
                    }

                    // Atualiza TABELA: MOVI_RETIRADA com os dados dos Comboboxes: Técnico Solicitante e Equipamento e chave principal: ID_RETIRADA   
                    DataRowView row = (DataRowView)mOVI_RETIRADABindingSource.Current;
                    row["EQUIPAMENTO"] = cbxEquipamento.Text.Trim();
                    row["TECNICO_SOLICITANTE"] = cbxTecnicos.Text.Trim();
                    row["MODALIDADE"] = InfoWork.MoviRetiradaModalidade;
                    row["PRIORIDADE"] = cbxPrioridade.Text.Trim();

                    // Atualiza Campo: ID_TECNICO_SOLICITANTE
                    string strWork = cbxTecnicos.Text;
                    strWork = strWork.Trim();
                    strWork = strWork.Substring(0, strWork.IndexOf("-")).Trim(); // Extrai o ID do técnico antes do hífen   
                    //row["ID_TECNICO_SOLICITANTE"] = Convert.ToInt32(strWork); // Converte para inteiro e atribui ao campo ID_TECNICO_SOLICITANTE
                    row["ID_TECNICO_SOLICITANTE"] = 13;

                    if (InfoWork.MoviRetiradaModalidade == "AGENDAMENTO")
                    {
                        row["SITUACAO"] = "PENDENTE";
                        row["TECNICO_ATUANTE"] = "";
                        row["DATA_RETIRADA"] = "01/01/1900";
                        row["HORA_RETIRADA"] = "00:00:00";

                    }
                    else
                    {
                        row["SITUACAO"] = "CONCLUÍDO";
                        row["TECNICO_ATUANTE"] = cbxTecnicos.Text.Trim();
                        row["DATA_RETIRADA"] = txtData.Text;
                        row["HORA_RETIRADA"] = txtHora.Text;

                    }


                    // Interpretaçlão dos RBTs para salvar no banco de dados
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



                    // Atualiza os dados da tabela MOVI_RETIRADA
                    try
                    {

                        this.mOVI_RETIRADABindingSource.EndEdit();
                        this.mOVI_RETIRADATableAdapter.Update(this.helpdesk01DataSet);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Salvar: MOVI_RETIRADA: " + ex.Message);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operação CANCELADA pelo usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Existem campos inválidos!");
            }
        }
   
        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRAMAL_TEL_Leave(object sender, EventArgs e)
        {
            // Pesquisa Usuário pelo RAMAL
            this.uSUARIOSTableAdapter.FillByRAMAL_TEL(this.helpdesk01DataSet.USUARIOS, txtRAMAL_TEL.Text);

            if (this.helpdesk01DataSet.USUARIOS.Count > 0)
            {
                txtNOME_USUARIO.Text = helpdesk01DataSet.USUARIOS.Rows[0].Field<String>("NOME_USUARIO");
                txtPREDIO_SETOR.Text = helpdesk01DataSet.USUARIOS.Rows[0].Field<String>("PREDIO_SETOR");
                txtArea.Text = helpdesk01DataSet.USUARIOS.Rows[0].Field<String>("AREA");



            }
            else
            {
                MessageBox.Show("Ramal / Telefone NÃO ENCONTRADO !", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void txtNUMERO_OS_Validated(object sender, EventArgs e)
        {

        }

        private void txtNUMERO_OS_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNUMERO_OS.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtNUMERO_OS, "Número da Ordem de seviço OBRIGATORIO !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNUMERO_OS, "");
            }
        }

        private void FrmMoviRetirada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // evita "bip"
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void fncPosicaoInicialRBT()
        {
            rbtSDDsim.Checked = true;
            rbtSDDnao.Checked = false;

            rbtOFFICE365sim.Checked = true;
            rbtOFFICE365nao.Checked = false;

            rbtMAINFRAMEsim.Checked = true;
            rbtMAINFRAMEnao.Checked = false;

            rbtCNSEsim.Checked = true;
            rbtCNSEnao.Checked = false;

            rbtBOTAOEMERGENCIAEsim.Checked = true;
            rbtBOTAOEMERGENCIAEnao.Checked = false;

            rbtPLANILHAsim.Checked = true;
            rbtPLANILHAnao.Checked = false;
            rbtPLANILHAnsaplica.Checked = false;
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

        private void fncAtualizaTecnicos()
        {

            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.TECNICOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tECNICOSTableAdapter.FillByATIVO(this.helpdesk01DataSet.TECNICOS);

            cbxTecnicos.Items.Clear();
            for (int i = 0; i < this.helpdesk01DataSet.TECNICOS.Count; i++)
            {
                //string strNOME_ENTIDADE = this.helpdesk01DataSet.TECNICOS.Rows[i].Field<string>("NOME_COMPLETO").Trim();
                string strNOME_ENTIDADE = this.helpdesk01DataSet.TECNICOS.Rows[i].Field<int>("ID").ToString() + " - " + this.helpdesk01DataSet.TECNICOS.Rows[i].Field<string>("NOME_COMPLETO").Trim();
                cbxTecnicos.Items.Add(strNOME_ENTIDADE);
            }
            cbxTecnicos.SelectedIndex = -1; // Limpa a seleção do ComboBox  

        }

        private void fcnAtualizaEquipamentos()
        {
            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.EQUIPAMENTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.eQUIPAMENTOSTableAdapter.FillByATIVO(this.helpdesk01DataSet.EQUIPAMENTOS);

            cbxEquipamento.Items.Clear();
            for (int i = 0; i < this.helpdesk01DataSet.EQUIPAMENTOS.Count; i++)
            {
                string strNOME_ENTIDADE = this.helpdesk01DataSet.EQUIPAMENTOS.Rows[i].Field<string>("DESCRICAO_EQUIPAMENTO").Trim();
                cbxEquipamento.Items.Add(strNOME_ENTIDADE);
            }



            cbxEquipamento.SelectedIndex = -1; // Limpa a seleção do ComboBox  

        }

        private void rbtSDDsim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbtnNovoTecnico_Click(object sender, EventArgs e)
        {
            cbxTecnicos.SelectedIndex = -1; // Limpa a seleção do ComboBox   

            this.Enabled = false;
            InfoApp.opcao = "Incluir NOVO TÉCNICO";
            FrmTecnicosForm TecnicosForm = new FrmTecnicosForm();
            TecnicosForm.ShowDialog();
            this.Enabled = true;

            fncAtualizaTecnicos();

            int posicao = cbxTecnicos.FindStringExact(InfoWork.strWork.Trim());
            if (posicao >= 0)
            {
                cbxTecnicos.SelectedIndex = posicao;
            }
        }

        private void txtDATA_PREVISTA_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDATA_PREVISTA.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtDATA_PREVISTA, "Data Prevista Inválida ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDATA_PREVISTA, "");
            }
        }

        private void txtHoraPrevista_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoraPrevista.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtHoraPrevista, "Hora Prevista Invalida ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHoraPrevista, "");
            }
        }

        private void cbxTecnicos_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxTecnicos.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(cbxTecnicos, "Técnico Solicitante Invalido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbxTecnicos, "");
            }
        }

        private void txtRAMAL_TEL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRAMAL_TEL.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtRAMAL_TEL, "Ramal/Telefone Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtRAMAL_TEL, "");
            }
        }

        private void txtNOME_USUARIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOME_USUARIO.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtNOME_USUARIO, "Usuário Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNOME_USUARIO, "");
            }
        }

        private void txtPREDIO_SETOR_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPREDIO_SETOR.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtPREDIO_SETOR, "Usuário Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPREDIO_SETOR, "");
            }
        }

        private void txtArea_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtArea, "Usuário Inválido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtArea, "");
            }
        }

        private void txtPATRIMONIO_TextChanged(object sender, EventArgs e)
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

        private void cbxEquipamento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxEquipamento.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(cbxEquipamento, "Equipamento Invalido ! (vazio)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbxEquipamento, "");
            }
        }

        private void txtDESCRICA_ATIVIDADE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDESCRICA_ATIVIDADE.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(txtDESCRICA_ATIVIDADE, "Descriçao da Atividade Inválida ! (em Branco)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDESCRICA_ATIVIDADE, "");
            }

        }

        private void txtDATA_PREVISTA_Enter(object sender, EventArgs e)
        {
            txtDATA_PREVISTA.BackColor = Color.LightYellow;
        }

        private void txtDATA_PREVISTA_Leave(object sender, EventArgs e)
        {
            txtDATA_PREVISTA.BackColor = Color.White;
        }

        private void cbtnNovoEquipamento_Click(object sender, EventArgs e)
        {
            cbxEquipamento.SelectedIndex = -1; // Limpa a seleção do ComboBox   

            this.Enabled = false;
            InfoApp.opcao = "Incluir NOVO EQUIPAMENTO";
            FrmEquipamentosForm EquipamentosForm = new FrmEquipamentosForm();
            EquipamentosForm.ShowDialog();
            this.Enabled = true;

            fcnAtualizaEquipamentos();

            int posicao = cbxEquipamento.FindStringExact(InfoWork.strWork.Trim());
            if (posicao >= 0)
            {
                cbxEquipamento.SelectedIndex = posicao;
            }


        }


        private void FrmMoviRetirada_Activated(object sender, EventArgs e)
        {
            txtDATA_PREVISTA.Focus();

        }

        private void txtNUMERO_OS_Leave(object sender, EventArgs e)
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

        private void fcnConfigCampos()
        {
            foreach (Control c in this.gbxIdentificacao.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }


            foreach (Control c in this.gbxUsuario.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }

            foreach (Control c in this.gbxDadosSolicitacao.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }

            foreach (Control c in this.gbxDescricao_Atividade.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }

            foreach (Control c in this.gbxObservacoes_Importantes.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair  
                }
            }
        }

        

       
        private void cbxTecnicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRAMAL_TEL.Focus();   
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab) 
            { 
                txtPATRIMONIO.Focus();
            }
        }

        private void txtSAI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtDESCRICA_ATIVIDADE.Focus();
            }
        }

        private void txtDESCRICA_ATIVIDADE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                txtOBS_IMPORTANTES.Focus();
            }
        }

        private void txtNUMERO_OS_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtRAMAL_TEL.Focus();
            }

        }

        private void txtNUMERO_OS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRAMAL_TEL.Focus();
            }
        }

        private void txtArea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPATRIMONIO.Focus();
            }
        }

        private void txtSAI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDESCRICA_ATIVIDADE.Focus();
            }
        }

        private void txtDESCRICA_ATIVIDADE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOBS_IMPORTANTES.Focus();
            }
        }

        private void txtOBS_IMPORTANTES_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void txtOBS_IMPORTANTES_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void lblTitulo_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cbxPrioridade_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxPrioridade.Text))
            {
                e.Cancel = true; // impede sair do campo
                errorProvider1.SetError(cbxPrioridade, "PRIORIDADE Invalida ! (indefinida)");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbxPrioridade, "");
            }

        }

        private void fcnAtivaCampos()
        {
            foreach (Control c in this.gbxIdentificacao.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true; // Ativa o campo  
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair
                }
            }

            foreach (Control c in this.gbxUsuario.Controls)
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
            }

            foreach (Control c in this.gbxDescricao_Atividade.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true; // Ativa o campo  
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair
                }
            }

            foreach (Control c in this.gbxObservacoes_Importantes.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = true; // Ativa o campo  
                    c.KeyDown += fcnEnter;
                    c.Enter += (s, e) => { c.BackColor = Color.LightYellow; }; // Destaca o campo ao entrar
                    c.Leave += (s, e) => { c.BackColor = Color.White; }; // Restaura a cor ao sair
                }
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


            // Ativa os ComboBox´s
            cbxTecnicos.Enabled = true;
            cbxPrioridade.Enabled = true;
            cbxEquipamento.Enabled = true;

            //Ativa "btnSalvar"
            btnSalvar.Enabled = true;
            cbtnNovoTecnico.Enabled = true;
            cbtnNovoEquipamento.Enabled = true;

            // Ativa campos MULTI-LINE
            txtDESCRICA_ATIVIDADE.Enabled = true;
            txtOBS_IMPORTANTES.Enabled = true;
        }



        private void fcnDesativaCampos()
        {
            foreach (Control c in this.gbxIdentificacao.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; // Desativa o campo  
                }
            }

            foreach (Control c in this.gbxUsuario.Controls)
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

            foreach (Control c in this.gbxDescricao_Atividade.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; // Desativa o campo  
                }


            }

            foreach (Control c in this.gbxObservacoes_Importantes.Controls)
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

            // Ativa os ComboBox´s
            cbxTecnicos.Enabled = false;
            cbxPrioridade.Enabled = false;
            cbxEquipamento.Enabled = false;

            //Ativa "btnSalvar"
            btnSalvar.Enabled = false;
            cbtnNovoTecnico.Enabled = false;
            cbtnNovoEquipamento.Enabled = false;

            // Desativa campos MULTI-LINE
            txtDESCRICA_ATIVIDADE.Enabled = false;
            txtOBS_IMPORTANTES.Enabled = false; 
        }
    }
}
 
