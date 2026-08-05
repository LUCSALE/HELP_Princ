using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMoviRetirada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviRetirada));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.nUMERACAO_IDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.gbxObservacoes_Importantes = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtOBS_IMPORTANTES = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbxDescricao_Atividade = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtDESCRICA_ATIVIDADE = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbxDadosSolicitacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbxPrioridade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxEquipamento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbtnNovoEquipamento = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtPLANILHAnsaplica = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtPLANILHAnao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtPLANILHAsim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtBOTAOEMERGENCIAEnao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtBOTAOEMERGENCIAEsim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtCNSEnao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtCNSEsim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtMAINFRAMEnao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtMAINFRAMEsim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtOFFICE365nao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtOFFICE365sim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbtSDDnao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtSDDsim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtSAI = new System.Windows.Forms.TextBox();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPATRIMONIO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtMODALIDADE = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSITUACAO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxUsuario = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtRAMAL_TEL = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPREDIO_SETOR = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNOME_USUARIO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxIdentificacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbtnNovoTecnico = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtHoraPrevista = new System.Windows.Forms.TextBox();
            this.txtDATA_PREVISTA = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxTecnicos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNUMERO_OS = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.eQUIPAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tECNICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSUARIOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.USUARIOSTableAdapter();
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.tECNICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TECNICOSTableAdapter();
            this.eQUIPAMENTOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.EQUIPAMENTOSTableAdapter();
            this.nUMERACAO_IDTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.NUMERACAO_IDTableAdapter();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUMERACAO_IDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.gbxObservacoes_Importantes.SuspendLayout();
            this.gbxDescricao_Atividade.SuspendLayout();
            this.gbxDadosSolicitacao.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox6.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            this.gbxStatus.SuspendLayout();
            this.gbxUsuario.SuspendLayout();
            this.gbxIdentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel17);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Controls.Add(this.guna2PictureBox2);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1186, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(553, 71);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel17.TabIndex = 7;
            this.guna2HtmlLabel17.TabStop = false;
            this.guna2HtmlLabel17.Text = "(Registrar)";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.CausesValidation = false;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1156, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(9, 6);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2PictureBox2.ShadowDecoration.Enabled = true;
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(428, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "Retirada de Equipamento";
            this.lblTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTitulo_Paint);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.btnVoltar);
            this.pnlFooter.Controls.Add(this.btnSalvar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 619);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1186, 51);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(84, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(9, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // nUMERACAO_IDBindingSource
            // 
            this.nUMERACAO_IDBindingSource.DataMember = "NUMERACAO_ID";
            this.nUMERACAO_IDBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "helpdesk01DataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlGrid.BorderRadius = 10;
            this.pnlGrid.BorderThickness = 1;
            this.pnlGrid.Controls.Add(this.gbxObservacoes_Importantes);
            this.pnlGrid.Controls.Add(this.gbxDescricao_Atividade);
            this.pnlGrid.Controls.Add(this.gbxDadosSolicitacao);
            this.pnlGrid.Controls.Add(this.gbxStatus);
            this.pnlGrid.Controls.Add(this.gbxUsuario);
            this.pnlGrid.Controls.Add(this.gbxIdentificacao);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 114);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1186, 505);
            this.pnlGrid.TabIndex = 4;
            // 
            // gbxObservacoes_Importantes
            // 
            this.gbxObservacoes_Importantes.BackColor = System.Drawing.Color.Transparent;
            this.gbxObservacoes_Importantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxObservacoes_Importantes.BorderColor = System.Drawing.Color.Black;
            this.gbxObservacoes_Importantes.BorderRadius = 10;
            this.gbxObservacoes_Importantes.Controls.Add(this.txtOBS_IMPORTANTES);
            this.gbxObservacoes_Importantes.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxObservacoes_Importantes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxObservacoes_Importantes.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxObservacoes_Importantes.ForeColor = System.Drawing.Color.Black;
            this.gbxObservacoes_Importantes.Location = new System.Drawing.Point(3, 391);
            this.gbxObservacoes_Importantes.Name = "gbxObservacoes_Importantes";
            this.gbxObservacoes_Importantes.Size = new System.Drawing.Size(1163, 123);
            this.gbxObservacoes_Importantes.TabIndex = 45;
            this.gbxObservacoes_Importantes.TabStop = false;
            this.gbxObservacoes_Importantes.Text = "Observações Importantes:";
            // 
            // txtOBS_IMPORTANTES
            // 
            this.txtOBS_IMPORTANTES.AcceptsReturn = true;
            this.txtOBS_IMPORTANTES.AcceptsTab = true;
            this.txtOBS_IMPORTANTES.Animated = true;
            this.txtOBS_IMPORTANTES.AutoScroll = true;
            this.txtOBS_IMPORTANTES.BorderRadius = 10;
            this.txtOBS_IMPORTANTES.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOBS_IMPORTANTES.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOBS_IMPORTANTES.DefaultText = "";
            this.txtOBS_IMPORTANTES.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOBS_IMPORTANTES.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOBS_IMPORTANTES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOBS_IMPORTANTES.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOBS_IMPORTANTES.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS_IMPORTANTES.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOBS_IMPORTANTES.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOBS_IMPORTANTES.Location = new System.Drawing.Point(6, 28);
            this.txtOBS_IMPORTANTES.Multiline = true;
            this.txtOBS_IMPORTANTES.Name = "txtOBS_IMPORTANTES";
            this.txtOBS_IMPORTANTES.PlaceholderText = "Observações Importantes";
            this.txtOBS_IMPORTANTES.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOBS_IMPORTANTES.SelectedText = "";
            this.txtOBS_IMPORTANTES.Size = new System.Drawing.Size(1137, 80);
            this.txtOBS_IMPORTANTES.TabIndex = 1;
            // 
            // gbxDescricao_Atividade
            // 
            this.gbxDescricao_Atividade.BackColor = System.Drawing.Color.Transparent;
            this.gbxDescricao_Atividade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxDescricao_Atividade.BorderColor = System.Drawing.Color.Black;
            this.gbxDescricao_Atividade.BorderRadius = 10;
            this.gbxDescricao_Atividade.Controls.Add(this.txtDESCRICA_ATIVIDADE);
            this.gbxDescricao_Atividade.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxDescricao_Atividade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDescricao_Atividade.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxDescricao_Atividade.ForeColor = System.Drawing.Color.Black;
            this.gbxDescricao_Atividade.Location = new System.Drawing.Point(694, 158);
            this.gbxDescricao_Atividade.Name = "gbxDescricao_Atividade";
            this.gbxDescricao_Atividade.Size = new System.Drawing.Size(472, 232);
            this.gbxDescricao_Atividade.TabIndex = 44;
            this.gbxDescricao_Atividade.TabStop = false;
            this.gbxDescricao_Atividade.Text = "Descrição da Atividade:";
            // 
            // txtDESCRICA_ATIVIDADE
            // 
            this.txtDESCRICA_ATIVIDADE.AcceptsReturn = true;
            this.txtDESCRICA_ATIVIDADE.AcceptsTab = true;
            this.txtDESCRICA_ATIVIDADE.Animated = true;
            this.txtDESCRICA_ATIVIDADE.AutoScroll = true;
            this.txtDESCRICA_ATIVIDADE.BorderRadius = 10;
            this.txtDESCRICA_ATIVIDADE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDESCRICA_ATIVIDADE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDESCRICA_ATIVIDADE.DefaultText = "";
            this.txtDESCRICA_ATIVIDADE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDESCRICA_ATIVIDADE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDESCRICA_ATIVIDADE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDESCRICA_ATIVIDADE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDESCRICA_ATIVIDADE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDESCRICA_ATIVIDADE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDESCRICA_ATIVIDADE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDESCRICA_ATIVIDADE.Location = new System.Drawing.Point(12, 28);
            this.txtDESCRICA_ATIVIDADE.Multiline = true;
            this.txtDESCRICA_ATIVIDADE.Name = "txtDESCRICA_ATIVIDADE";
            this.txtDESCRICA_ATIVIDADE.PlaceholderText = "Descrição Atividade";
            this.txtDESCRICA_ATIVIDADE.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDESCRICA_ATIVIDADE.SelectedText = "";
            this.txtDESCRICA_ATIVIDADE.Size = new System.Drawing.Size(446, 189);
            this.txtDESCRICA_ATIVIDADE.TabIndex = 0;
            // 
            // gbxDadosSolicitacao
            // 
            this.gbxDadosSolicitacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxDadosSolicitacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxDadosSolicitacao.BorderColor = System.Drawing.Color.Black;
            this.gbxDadosSolicitacao.BorderRadius = 10;
            this.gbxDadosSolicitacao.Controls.Add(this.cbxPrioridade);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel18);
            this.gbxDadosSolicitacao.Controls.Add(this.cbxEquipamento);
            this.gbxDadosSolicitacao.Controls.Add(this.cbtnNovoEquipamento);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox4);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox5);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox6);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox3);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox2);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2GroupBox1);
            this.gbxDadosSolicitacao.Controls.Add(this.txtSAI);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel12);
            this.gbxDadosSolicitacao.Controls.Add(this.txtPATRIMONIO);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel11);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel9);
            this.gbxDadosSolicitacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxDadosSolicitacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDadosSolicitacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxDadosSolicitacao.ForeColor = System.Drawing.Color.Black;
            this.gbxDadosSolicitacao.Location = new System.Drawing.Point(3, 158);
            this.gbxDadosSolicitacao.Name = "gbxDadosSolicitacao";
            this.gbxDadosSolicitacao.Size = new System.Drawing.Size(685, 232);
            this.gbxDadosSolicitacao.TabIndex = 43;
            this.gbxDadosSolicitacao.TabStop = false;
            this.gbxDadosSolicitacao.Text = "Dados Solicitação:";
            // 
            // cbxPrioridade
            // 
            this.cbxPrioridade.BackColor = System.Drawing.Color.Transparent;
            this.cbxPrioridade.BorderColor = System.Drawing.Color.Black;
            this.cbxPrioridade.BorderRadius = 10;
            this.cbxPrioridade.DisplayMember = "PRIORIDADE";
            this.cbxPrioridade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioridade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPrioridade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPrioridade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPrioridade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPrioridade.ItemHeight = 30;
            this.cbxPrioridade.Items.AddRange(new object[] {
            "ALTÍSSIMA",
            "ALTA",
            "MÉDIA",
            "BAIXA"});
            this.cbxPrioridade.Location = new System.Drawing.Point(8, 102);
            this.cbxPrioridade.Name = "cbxPrioridade";
            this.cbxPrioridade.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.cbxPrioridade.Size = new System.Drawing.Size(271, 36);
            this.cbxPrioridade.TabIndex = 45;
            this.cbxPrioridade.TabStop = false;
            this.cbxPrioridade.ValueMember = "PRIORIDADE";
            this.cbxPrioridade.Validating += new System.ComponentModel.CancelEventHandler(this.cbxPrioridade_Validating);
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(10, 83);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(64, 15);
            this.guna2HtmlLabel18.TabIndex = 44;
            this.guna2HtmlLabel18.TabStop = false;
            this.guna2HtmlLabel18.Text = "Prioridade:";
            // 
            // cbxEquipamento
            // 
            this.cbxEquipamento.BackColor = System.Drawing.Color.Transparent;
            this.cbxEquipamento.BorderColor = System.Drawing.Color.Black;
            this.cbxEquipamento.BorderRadius = 10;
            this.cbxEquipamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEquipamento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEquipamento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEquipamento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxEquipamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEquipamento.ItemHeight = 30;
            this.cbxEquipamento.Location = new System.Drawing.Point(8, 187);
            this.cbxEquipamento.Name = "cbxEquipamento";
            this.cbxEquipamento.Size = new System.Drawing.Size(628, 36);
            this.cbxEquipamento.TabIndex = 2;
            this.cbxEquipamento.TabStop = false;
            this.cbxEquipamento.Validating += new System.ComponentModel.CancelEventHandler(this.cbxEquipamento_Validating);
            // 
            // cbtnNovoEquipamento
            // 
            this.cbtnNovoEquipamento.Animated = true;
            this.cbtnNovoEquipamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbtnNovoEquipamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbtnNovoEquipamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbtnNovoEquipamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbtnNovoEquipamento.FillColor = System.Drawing.Color.Transparent;
            this.cbtnNovoEquipamento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtnNovoEquipamento.ForeColor = System.Drawing.Color.White;
            this.cbtnNovoEquipamento.Image = ((System.Drawing.Image)(resources.GetObject("cbtnNovoEquipamento.Image")));
            this.cbtnNovoEquipamento.Location = new System.Drawing.Point(642, 187);
            this.cbtnNovoEquipamento.Name = "cbtnNovoEquipamento";
            this.cbtnNovoEquipamento.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnNovoEquipamento.Size = new System.Drawing.Size(30, 36);
            this.cbtnNovoEquipamento.TabIndex = 3;
            this.cbtnNovoEquipamento.TabStop = false;
            this.cbtnNovoEquipamento.Click += new System.EventHandler(this.cbtnNovoEquipamento_Click);
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox4.BorderRadius = 10;
            this.guna2GroupBox4.Controls.Add(this.rbtPLANILHAnsaplica);
            this.guna2GroupBox4.Controls.Add(this.rbtPLANILHAnao);
            this.guna2GroupBox4.Controls.Add(this.rbtPLANILHAsim);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox4.Location = new System.Drawing.Point(452, 129);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(220, 46);
            this.guna2GroupBox4.TabIndex = 9;
            this.guna2GroupBox4.TabStop = false;
            this.guna2GroupBox4.Text = "Planilha Office 365:";
            // 
            // rbtPLANILHAnsaplica
            // 
            this.rbtPLANILHAnsaplica.Animated = true;
            this.rbtPLANILHAnsaplica.AutoSize = true;
            this.rbtPLANILHAnsaplica.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAnsaplica.CheckedState.BorderThickness = 0;
            this.rbtPLANILHAnsaplica.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAnsaplica.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtPLANILHAnsaplica.CheckedState.InnerOffset = -4;
            this.rbtPLANILHAnsaplica.Location = new System.Drawing.Point(121, 24);
            this.rbtPLANILHAnsaplica.Name = "rbtPLANILHAnsaplica";
            this.rbtPLANILHAnsaplica.Size = new System.Drawing.Size(92, 19);
            this.rbtPLANILHAnsaplica.TabIndex = 51;
            this.rbtPLANILHAnsaplica.Text = "N.SE APLICA";
            this.rbtPLANILHAnsaplica.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtPLANILHAnsaplica.UncheckedState.BorderThickness = 2;
            this.rbtPLANILHAnsaplica.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtPLANILHAnsaplica.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtPLANILHAnao
            // 
            this.rbtPLANILHAnao.Animated = true;
            this.rbtPLANILHAnao.AutoSize = true;
            this.rbtPLANILHAnao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAnao.CheckedState.BorderThickness = 0;
            this.rbtPLANILHAnao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAnao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtPLANILHAnao.CheckedState.InnerOffset = -4;
            this.rbtPLANILHAnao.Location = new System.Drawing.Point(64, 25);
            this.rbtPLANILHAnao.Name = "rbtPLANILHAnao";
            this.rbtPLANILHAnao.Size = new System.Drawing.Size(51, 19);
            this.rbtPLANILHAnao.TabIndex = 50;
            this.rbtPLANILHAnao.Text = "NÃO";
            this.rbtPLANILHAnao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtPLANILHAnao.UncheckedState.BorderThickness = 2;
            this.rbtPLANILHAnao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtPLANILHAnao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtPLANILHAsim
            // 
            this.rbtPLANILHAsim.Animated = true;
            this.rbtPLANILHAsim.AutoSize = true;
            this.rbtPLANILHAsim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAsim.CheckedState.BorderThickness = 0;
            this.rbtPLANILHAsim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtPLANILHAsim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtPLANILHAsim.CheckedState.InnerOffset = -4;
            this.rbtPLANILHAsim.Location = new System.Drawing.Point(11, 25);
            this.rbtPLANILHAsim.Name = "rbtPLANILHAsim";
            this.rbtPLANILHAsim.Size = new System.Drawing.Size(45, 19);
            this.rbtPLANILHAsim.TabIndex = 49;
            this.rbtPLANILHAsim.Text = "SIM";
            this.rbtPLANILHAsim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtPLANILHAsim.UncheckedState.BorderThickness = 2;
            this.rbtPLANILHAsim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtPLANILHAsim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox5.BorderRadius = 10;
            this.guna2GroupBox5.Controls.Add(this.rbtBOTAOEMERGENCIAEnao);
            this.guna2GroupBox5.Controls.Add(this.rbtBOTAOEMERGENCIAEsim);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox5.Location = new System.Drawing.Point(452, 78);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(220, 46);
            this.guna2GroupBox5.TabIndex = 8;
            this.guna2GroupBox5.TabStop = false;
            this.guna2GroupBox5.Text = "Botão Emergência:";
            // 
            // rbtBOTAOEMERGENCIAEnao
            // 
            this.rbtBOTAOEMERGENCIAEnao.Animated = true;
            this.rbtBOTAOEMERGENCIAEnao.AutoSize = true;
            this.rbtBOTAOEMERGENCIAEnao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtBOTAOEMERGENCIAEnao.CheckedState.BorderThickness = 0;
            this.rbtBOTAOEMERGENCIAEnao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtBOTAOEMERGENCIAEnao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtBOTAOEMERGENCIAEnao.CheckedState.InnerOffset = -4;
            this.rbtBOTAOEMERGENCIAEnao.Location = new System.Drawing.Point(64, 25);
            this.rbtBOTAOEMERGENCIAEnao.Name = "rbtBOTAOEMERGENCIAEnao";
            this.rbtBOTAOEMERGENCIAEnao.Size = new System.Drawing.Size(51, 19);
            this.rbtBOTAOEMERGENCIAEnao.TabIndex = 50;
            this.rbtBOTAOEMERGENCIAEnao.Text = "NÃO";
            this.rbtBOTAOEMERGENCIAEnao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtBOTAOEMERGENCIAEnao.UncheckedState.BorderThickness = 2;
            this.rbtBOTAOEMERGENCIAEnao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtBOTAOEMERGENCIAEnao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtBOTAOEMERGENCIAEsim
            // 
            this.rbtBOTAOEMERGENCIAEsim.Animated = true;
            this.rbtBOTAOEMERGENCIAEsim.AutoSize = true;
            this.rbtBOTAOEMERGENCIAEsim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtBOTAOEMERGENCIAEsim.CheckedState.BorderThickness = 0;
            this.rbtBOTAOEMERGENCIAEsim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtBOTAOEMERGENCIAEsim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtBOTAOEMERGENCIAEsim.CheckedState.InnerOffset = -4;
            this.rbtBOTAOEMERGENCIAEsim.Location = new System.Drawing.Point(11, 25);
            this.rbtBOTAOEMERGENCIAEsim.Name = "rbtBOTAOEMERGENCIAEsim";
            this.rbtBOTAOEMERGENCIAEsim.Size = new System.Drawing.Size(45, 19);
            this.rbtBOTAOEMERGENCIAEsim.TabIndex = 49;
            this.rbtBOTAOEMERGENCIAEsim.Text = "SIM";
            this.rbtBOTAOEMERGENCIAEsim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtBOTAOEMERGENCIAEsim.UncheckedState.BorderThickness = 2;
            this.rbtBOTAOEMERGENCIAEsim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtBOTAOEMERGENCIAEsim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox6.BorderRadius = 10;
            this.guna2GroupBox6.Controls.Add(this.rbtCNSEnao);
            this.guna2GroupBox6.Controls.Add(this.rbtCNSEsim);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox6.Location = new System.Drawing.Point(452, 28);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.Size = new System.Drawing.Size(220, 46);
            this.guna2GroupBox6.TabIndex = 7;
            this.guna2GroupBox6.TabStop = false;
            this.guna2GroupBox6.Text = "CNS:";
            // 
            // rbtCNSEnao
            // 
            this.rbtCNSEnao.Animated = true;
            this.rbtCNSEnao.AutoSize = true;
            this.rbtCNSEnao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtCNSEnao.CheckedState.BorderThickness = 0;
            this.rbtCNSEnao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtCNSEnao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtCNSEnao.CheckedState.InnerOffset = -4;
            this.rbtCNSEnao.Location = new System.Drawing.Point(64, 25);
            this.rbtCNSEnao.Name = "rbtCNSEnao";
            this.rbtCNSEnao.Size = new System.Drawing.Size(51, 19);
            this.rbtCNSEnao.TabIndex = 50;
            this.rbtCNSEnao.Text = "NÃO";
            this.rbtCNSEnao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtCNSEnao.UncheckedState.BorderThickness = 2;
            this.rbtCNSEnao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtCNSEnao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtCNSEsim
            // 
            this.rbtCNSEsim.Animated = true;
            this.rbtCNSEsim.AutoSize = true;
            this.rbtCNSEsim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtCNSEsim.CheckedState.BorderThickness = 0;
            this.rbtCNSEsim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtCNSEsim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtCNSEsim.CheckedState.InnerOffset = -4;
            this.rbtCNSEsim.Location = new System.Drawing.Point(11, 25);
            this.rbtCNSEsim.Name = "rbtCNSEsim";
            this.rbtCNSEsim.Size = new System.Drawing.Size(45, 19);
            this.rbtCNSEsim.TabIndex = 49;
            this.rbtCNSEsim.Text = "SIM";
            this.rbtCNSEsim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtCNSEsim.UncheckedState.BorderThickness = 2;
            this.rbtCNSEsim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtCNSEsim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.Controls.Add(this.rbtMAINFRAMEnao);
            this.guna2GroupBox3.Controls.Add(this.rbtMAINFRAMEsim);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox3.Location = new System.Drawing.Point(331, 129);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(115, 46);
            this.guna2GroupBox3.TabIndex = 6;
            this.guna2GroupBox3.TabStop = false;
            this.guna2GroupBox3.Text = "Main Frame:";
            // 
            // rbtMAINFRAMEnao
            // 
            this.rbtMAINFRAMEnao.Animated = true;
            this.rbtMAINFRAMEnao.AutoSize = true;
            this.rbtMAINFRAMEnao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMAINFRAMEnao.CheckedState.BorderThickness = 0;
            this.rbtMAINFRAMEnao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMAINFRAMEnao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtMAINFRAMEnao.CheckedState.InnerOffset = -4;
            this.rbtMAINFRAMEnao.Location = new System.Drawing.Point(64, 25);
            this.rbtMAINFRAMEnao.Name = "rbtMAINFRAMEnao";
            this.rbtMAINFRAMEnao.Size = new System.Drawing.Size(51, 19);
            this.rbtMAINFRAMEnao.TabIndex = 50;
            this.rbtMAINFRAMEnao.Text = "NÃO";
            this.rbtMAINFRAMEnao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtMAINFRAMEnao.UncheckedState.BorderThickness = 2;
            this.rbtMAINFRAMEnao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtMAINFRAMEnao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtMAINFRAMEsim
            // 
            this.rbtMAINFRAMEsim.Animated = true;
            this.rbtMAINFRAMEsim.AutoSize = true;
            this.rbtMAINFRAMEsim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMAINFRAMEsim.CheckedState.BorderThickness = 0;
            this.rbtMAINFRAMEsim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtMAINFRAMEsim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtMAINFRAMEsim.CheckedState.InnerOffset = -4;
            this.rbtMAINFRAMEsim.Location = new System.Drawing.Point(11, 25);
            this.rbtMAINFRAMEsim.Name = "rbtMAINFRAMEsim";
            this.rbtMAINFRAMEsim.Size = new System.Drawing.Size(45, 19);
            this.rbtMAINFRAMEsim.TabIndex = 49;
            this.rbtMAINFRAMEsim.Text = "SIM";
            this.rbtMAINFRAMEsim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtMAINFRAMEsim.UncheckedState.BorderThickness = 2;
            this.rbtMAINFRAMEsim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtMAINFRAMEsim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.rbtOFFICE365nao);
            this.guna2GroupBox2.Controls.Add(this.rbtOFFICE365sim);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox2.Location = new System.Drawing.Point(331, 78);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(115, 46);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.TabStop = false;
            this.guna2GroupBox2.Text = "Office 365:";
            // 
            // rbtOFFICE365nao
            // 
            this.rbtOFFICE365nao.Animated = true;
            this.rbtOFFICE365nao.AutoSize = true;
            this.rbtOFFICE365nao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtOFFICE365nao.CheckedState.BorderThickness = 0;
            this.rbtOFFICE365nao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtOFFICE365nao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtOFFICE365nao.CheckedState.InnerOffset = -4;
            this.rbtOFFICE365nao.Location = new System.Drawing.Point(64, 25);
            this.rbtOFFICE365nao.Name = "rbtOFFICE365nao";
            this.rbtOFFICE365nao.Size = new System.Drawing.Size(51, 19);
            this.rbtOFFICE365nao.TabIndex = 50;
            this.rbtOFFICE365nao.Text = "NÃO";
            this.rbtOFFICE365nao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtOFFICE365nao.UncheckedState.BorderThickness = 2;
            this.rbtOFFICE365nao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtOFFICE365nao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtOFFICE365sim
            // 
            this.rbtOFFICE365sim.Animated = true;
            this.rbtOFFICE365sim.AutoSize = true;
            this.rbtOFFICE365sim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtOFFICE365sim.CheckedState.BorderThickness = 0;
            this.rbtOFFICE365sim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtOFFICE365sim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtOFFICE365sim.CheckedState.InnerOffset = -4;
            this.rbtOFFICE365sim.Location = new System.Drawing.Point(11, 25);
            this.rbtOFFICE365sim.Name = "rbtOFFICE365sim";
            this.rbtOFFICE365sim.Size = new System.Drawing.Size(45, 19);
            this.rbtOFFICE365sim.TabIndex = 49;
            this.rbtOFFICE365sim.Text = "SIM";
            this.rbtOFFICE365sim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtOFFICE365sim.UncheckedState.BorderThickness = 2;
            this.rbtOFFICE365sim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtOFFICE365sim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.rbtSDDnao);
            this.guna2GroupBox1.Controls.Add(this.rbtSDDsim);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(331, 28);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(115, 46);
            this.guna2GroupBox1.TabIndex = 4;
            this.guna2GroupBox1.TabStop = false;
            this.guna2GroupBox1.Text = "SSD:";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // rbtSDDnao
            // 
            this.rbtSDDnao.Animated = true;
            this.rbtSDDnao.AutoSize = true;
            this.rbtSDDnao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtSDDnao.CheckedState.BorderThickness = 0;
            this.rbtSDDnao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtSDDnao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtSDDnao.CheckedState.InnerOffset = -4;
            this.rbtSDDnao.Location = new System.Drawing.Point(64, 25);
            this.rbtSDDnao.Name = "rbtSDDnao";
            this.rbtSDDnao.Size = new System.Drawing.Size(51, 19);
            this.rbtSDDnao.TabIndex = 50;
            this.rbtSDDnao.Text = "NÃO";
            this.rbtSDDnao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtSDDnao.UncheckedState.BorderThickness = 2;
            this.rbtSDDnao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtSDDnao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbtSDDsim
            // 
            this.rbtSDDsim.Animated = true;
            this.rbtSDDsim.AutoSize = true;
            this.rbtSDDsim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtSDDsim.CheckedState.BorderThickness = 0;
            this.rbtSDDsim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtSDDsim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtSDDsim.CheckedState.InnerOffset = -4;
            this.rbtSDDsim.Location = new System.Drawing.Point(11, 25);
            this.rbtSDDsim.Name = "rbtSDDsim";
            this.rbtSDDsim.Size = new System.Drawing.Size(45, 19);
            this.rbtSDDsim.TabIndex = 49;
            this.rbtSDDsim.Tag = "";
            this.rbtSDDsim.Text = "SIM";
            this.rbtSDDsim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtSDDsim.UncheckedState.BorderThickness = 2;
            this.rbtSDDsim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtSDDsim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtSDDsim.CheckedChanged += new System.EventHandler(this.rbtSDDsim_CheckedChanged);
            // 
            // txtSAI
            // 
            this.txtSAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "SAI", true));
            this.txtSAI.Location = new System.Drawing.Point(153, 51);
            this.txtSAI.Name = "txtSAI";
            this.txtSAI.Size = new System.Drawing.Size(126, 23);
            this.txtSAI.TabIndex = 1;
            this.txtSAI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSAI_KeyDown);
            this.txtSAI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSAI_KeyPress);
            this.txtSAI.Validating += new System.ComponentModel.CancelEventHandler(this.txtSAI_Validating);
            // 
            // mOVI_RETIRADABindingSource
            // 
            this.mOVI_RETIRADABindingSource.DataMember = "MOVI_RETIRADA";
            this.mOVI_RETIRADABindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(153, 34);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(27, 15);
            this.guna2HtmlLabel12.TabIndex = 42;
            this.guna2HtmlLabel12.TabStop = false;
            this.guna2HtmlLabel12.Text = "SAI:";
            // 
            // txtPATRIMONIO
            // 
            this.txtPATRIMONIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "PATRIMONIO", true));
            this.txtPATRIMONIO.Location = new System.Drawing.Point(10, 52);
            this.txtPATRIMONIO.Name = "txtPATRIMONIO";
            this.txtPATRIMONIO.Size = new System.Drawing.Size(128, 23);
            this.txtPATRIMONIO.TabIndex = 0;
            this.txtPATRIMONIO.TextChanged += new System.EventHandler(this.txtPATRIMONIO_TextChanged);
            this.txtPATRIMONIO.Validating += new System.ComponentModel.CancelEventHandler(this.txtPATRIMONIO_Validating);
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(10, 34);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(102, 15);
            this.guna2HtmlLabel11.TabIndex = 40;
            this.guna2HtmlLabel11.TabStop = false;
            this.guna2HtmlLabel11.Text = "Patrimônio (PAT):";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(8, 166);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(80, 15);
            this.guna2HtmlLabel9.TabIndex = 38;
            this.guna2HtmlLabel9.TabStop = false;
            this.guna2HtmlLabel9.Text = "Equipamento:";
            // 
            // gbxStatus
            // 
            this.gbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxStatus.BorderColor = System.Drawing.Color.Black;
            this.gbxStatus.BorderRadius = 10;
            this.gbxStatus.Controls.Add(this.txtMODALIDADE);
            this.gbxStatus.Controls.Add(this.guna2HtmlLabel1);
            this.gbxStatus.Controls.Add(this.txtSITUACAO);
            this.gbxStatus.Controls.Add(this.guna2HtmlLabel8);
            this.gbxStatus.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxStatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxStatus.ForeColor = System.Drawing.Color.Black;
            this.gbxStatus.Location = new System.Drawing.Point(948, 6);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(218, 146);
            this.gbxStatus.TabIndex = 42;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status:";
            // 
            // txtMODALIDADE
            // 
            this.txtMODALIDADE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtMODALIDADE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMODALIDADE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "MODALIDADE", true));
            this.txtMODALIDADE.Location = new System.Drawing.Point(14, 107);
            this.txtMODALIDADE.Name = "txtMODALIDADE";
            this.txtMODALIDADE.ReadOnly = true;
            this.txtMODALIDADE.Size = new System.Drawing.Size(193, 23);
            this.txtMODALIDADE.TabIndex = 1;
            this.txtMODALIDADE.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 15);
            this.guna2HtmlLabel1.TabIndex = 44;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Modalidade:";
            // 
            // txtSITUACAO
            // 
            this.txtSITUACAO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSITUACAO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "SITUACAO", true));
            this.txtSITUACAO.Location = new System.Drawing.Point(14, 55);
            this.txtSITUACAO.Name = "txtSITUACAO";
            this.txtSITUACAO.ReadOnly = true;
            this.txtSITUACAO.Size = new System.Drawing.Size(193, 23);
            this.txtSITUACAO.TabIndex = 0;
            this.txtSITUACAO.TabStop = false;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(14, 37);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel8.TabIndex = 42;
            this.guna2HtmlLabel8.TabStop = false;
            this.guna2HtmlLabel8.Text = "Situação:";
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxUsuario.BorderColor = System.Drawing.Color.Black;
            this.gbxUsuario.BorderRadius = 10;
            this.gbxUsuario.Controls.Add(this.txtRAMAL_TEL);
            this.gbxUsuario.Controls.Add(this.txtArea);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel10);
            this.gbxUsuario.Controls.Add(this.txtPREDIO_SETOR);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel3);
            this.gbxUsuario.Controls.Add(this.txtNOME_USUARIO);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel7);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel2);
            this.gbxUsuario.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxUsuario.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxUsuario.ForeColor = System.Drawing.Color.Black;
            this.gbxUsuario.Location = new System.Drawing.Point(482, 6);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(460, 146);
            this.gbxUsuario.TabIndex = 38;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Usuário(a):";
            // 
            // txtRAMAL_TEL
            // 
            this.txtRAMAL_TEL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "RAMAL_TEL", true));
            this.txtRAMAL_TEL.Location = new System.Drawing.Point(14, 55);
            this.txtRAMAL_TEL.Name = "txtRAMAL_TEL";
            this.txtRAMAL_TEL.Size = new System.Drawing.Size(134, 23);
            this.txtRAMAL_TEL.TabIndex = 0;
            this.txtRAMAL_TEL.Leave += new System.EventHandler(this.txtRAMAL_TEL_Leave);
            this.txtRAMAL_TEL.Validating += new System.ComponentModel.CancelEventHandler(this.txtRAMAL_TEL_Validating);
            // 
            // txtArea
            // 
            this.txtArea.AcceptsReturn = true;
            this.txtArea.AcceptsTab = true;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "AREA", true));
            this.txtArea.Location = new System.Drawing.Point(420, 104);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(33, 23);
            this.txtArea.TabIndex = 3;
            this.txtArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArea_KeyDown);
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            this.txtArea.Validating += new System.ComponentModel.CancelEventHandler(this.txtArea_Validating);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(420, 86);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(33, 15);
            this.guna2HtmlLabel10.TabIndex = 49;
            this.guna2HtmlLabel10.TabStop = false;
            this.guna2HtmlLabel10.Text = "Área:";
            // 
            // txtPREDIO_SETOR
            // 
            this.txtPREDIO_SETOR.AcceptsReturn = true;
            this.txtPREDIO_SETOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPREDIO_SETOR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "PREDIO_SETOR", true));
            this.txtPREDIO_SETOR.Location = new System.Drawing.Point(14, 104);
            this.txtPREDIO_SETOR.Name = "txtPREDIO_SETOR";
            this.txtPREDIO_SETOR.Size = new System.Drawing.Size(400, 23);
            this.txtPREDIO_SETOR.TabIndex = 2;
            this.txtPREDIO_SETOR.Validating += new System.ComponentModel.CancelEventHandler(this.txtPREDIO_SETOR_Validating);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 15);
            this.guna2HtmlLabel3.TabIndex = 47;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Prédio / Setor:";
            // 
            // txtNOME_USUARIO
            // 
            this.txtNOME_USUARIO.AcceptsReturn = true;
            this.txtNOME_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOME_USUARIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "NOME_USUARIO", true));
            this.txtNOME_USUARIO.Location = new System.Drawing.Point(154, 55);
            this.txtNOME_USUARIO.Name = "txtNOME_USUARIO";
            this.txtNOME_USUARIO.Size = new System.Drawing.Size(299, 23);
            this.txtNOME_USUARIO.TabIndex = 1;
            this.txtNOME_USUARIO.Enter += new System.EventHandler(this.txtNOME_USUARIO_Enter);
            this.txtNOME_USUARIO.Validating += new System.ComponentModel.CancelEventHandler(this.txtNOME_USUARIO_Validating);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(154, 37);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel7.TabIndex = 45;
            this.guna2HtmlLabel7.TabStop = false;
            this.guna2HtmlLabel7.Text = "Nome:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(14, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(106, 15);
            this.guna2HtmlLabel2.TabIndex = 36;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Ramal / Telefone:";
            // 
            // gbxIdentificacao
            // 
            this.gbxIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxIdentificacao.BorderColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.BorderRadius = 10;
            this.gbxIdentificacao.Controls.Add(this.cbtnNovoTecnico);
            this.gbxIdentificacao.Controls.Add(this.txtHoraPrevista);
            this.gbxIdentificacao.Controls.Add(this.txtDATA_PREVISTA);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel15);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel16);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel14);
            this.gbxIdentificacao.Controls.Add(this.cbxTecnicos);
            this.gbxIdentificacao.Controls.Add(this.txtNUMERO_OS);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel13);
            this.gbxIdentificacao.Controls.Add(this.txtHora);
            this.gbxIdentificacao.Controls.Add(this.txtID);
            this.gbxIdentificacao.Controls.Add(this.txtData);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel4);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel6);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel5);
            this.gbxIdentificacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxIdentificacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.Location = new System.Drawing.Point(3, 6);
            this.gbxIdentificacao.Name = "gbxIdentificacao";
            this.gbxIdentificacao.Size = new System.Drawing.Size(473, 146);
            this.gbxIdentificacao.TabIndex = 3;
            this.gbxIdentificacao.TabStop = false;
            this.gbxIdentificacao.Text = "Identificação:";
            // 
            // cbtnNovoTecnico
            // 
            this.cbtnNovoTecnico.Animated = true;
            this.cbtnNovoTecnico.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cbtnNovoTecnico.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cbtnNovoTecnico.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cbtnNovoTecnico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cbtnNovoTecnico.FillColor = System.Drawing.Color.Transparent;
            this.cbtnNovoTecnico.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbtnNovoTecnico.ForeColor = System.Drawing.Color.White;
            this.cbtnNovoTecnico.Image = ((System.Drawing.Image)(resources.GetObject("cbtnNovoTecnico.Image")));
            this.cbtnNovoTecnico.Location = new System.Drawing.Point(430, 104);
            this.cbtnNovoTecnico.Name = "cbtnNovoTecnico";
            this.cbtnNovoTecnico.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cbtnNovoTecnico.Size = new System.Drawing.Size(30, 36);
            this.cbtnNovoTecnico.TabIndex = 4;
            this.cbtnNovoTecnico.TabStop = false;
            this.cbtnNovoTecnico.Click += new System.EventHandler(this.cbtnNovoTecnico_Click);
            // 
            // txtHoraPrevista
            // 
            this.txtHoraPrevista.AcceptsReturn = true;
            this.txtHoraPrevista.AcceptsTab = true;
            this.txtHoraPrevista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoraPrevista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "HORA_PREVISTA", true));
            this.txtHoraPrevista.Location = new System.Drawing.Point(275, 55);
            this.txtHoraPrevista.Name = "txtHoraPrevista";
            this.txtHoraPrevista.Size = new System.Drawing.Size(84, 23);
            this.txtHoraPrevista.TabIndex = 1;
            this.txtHoraPrevista.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoraPrevista_Validating);
            // 
            // txtDATA_PREVISTA
            // 
            this.txtDATA_PREVISTA.AcceptsReturn = true;
            this.txtDATA_PREVISTA.AcceptsTab = true;
            this.txtDATA_PREVISTA.BackColor = System.Drawing.SystemColors.Window;
            this.txtDATA_PREVISTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATA_PREVISTA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "DATA_PREVISTA", true));
            this.txtDATA_PREVISTA.Location = new System.Drawing.Point(185, 55);
            this.txtDATA_PREVISTA.Name = "txtDATA_PREVISTA";
            this.txtDATA_PREVISTA.Size = new System.Drawing.Size(84, 23);
            this.txtDATA_PREVISTA.TabIndex = 0;
            this.txtDATA_PREVISTA.Enter += new System.EventHandler(this.txtDATA_PREVISTA_Enter);
            this.txtDATA_PREVISTA.Leave += new System.EventHandler(this.txtDATA_PREVISTA_Leave);
            this.txtDATA_PREVISTA.Validating += new System.ComponentModel.CancelEventHandler(this.txtDATA_PREVISTA_Validating);
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(275, 37);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel15.TabIndex = 49;
            this.guna2HtmlLabel15.TabStop = false;
            this.guna2HtmlLabel15.Text = "Hora Prevista:";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(185, 37);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel16.TabIndex = 48;
            this.guna2HtmlLabel16.TabStop = false;
            this.guna2HtmlLabel16.Text = "Data Prevista:";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(117, 15);
            this.guna2HtmlLabel14.TabIndex = 47;
            this.guna2HtmlLabel14.TabStop = false;
            this.guna2HtmlLabel14.Text = "Técnico Solicitante:";
            // 
            // cbxTecnicos
            // 
            this.cbxTecnicos.BackColor = System.Drawing.Color.Transparent;
            this.cbxTecnicos.BorderColor = System.Drawing.Color.Black;
            this.cbxTecnicos.BorderRadius = 10;
            this.cbxTecnicos.DisplayMember = "ID";
            this.cbxTecnicos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTecnicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTecnicos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTecnicos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTecnicos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTecnicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTecnicos.ItemHeight = 30;
            this.cbxTecnicos.Location = new System.Drawing.Point(14, 107);
            this.cbxTecnicos.Name = "cbxTecnicos";
            this.cbxTecnicos.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.cbxTecnicos.Size = new System.Drawing.Size(410, 36);
            this.cbxTecnicos.TabIndex = 3;
            this.cbxTecnicos.TabStop = false;
            this.cbxTecnicos.ValueMember = "ID";
            this.cbxTecnicos.SelectedIndexChanged += new System.EventHandler(this.cbxTecnicos_SelectedIndexChanged);
            this.cbxTecnicos.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTecnicos_Validating);
            // 
            // txtNUMERO_OS
            // 
            this.txtNUMERO_OS.AcceptsReturn = true;
            this.txtNUMERO_OS.AcceptsTab = true;
            this.txtNUMERO_OS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNUMERO_OS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "NUMERO_OS", true));
            this.txtNUMERO_OS.Location = new System.Drawing.Point(364, 55);
            this.txtNUMERO_OS.Name = "txtNUMERO_OS";
            this.txtNUMERO_OS.Size = new System.Drawing.Size(96, 23);
            this.txtNUMERO_OS.TabIndex = 2;
            this.txtNUMERO_OS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNUMERO_OS_KeyDown);
            this.txtNUMERO_OS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNUMERO_OS_KeyPress);
            this.txtNUMERO_OS.Leave += new System.EventHandler(this.txtNUMERO_OS_Leave);
            this.txtNUMERO_OS.Validating += new System.ComponentModel.CancelEventHandler(this.txtNUMERO_OS_Validating);
            this.txtNUMERO_OS.Validated += new System.EventHandler(this.txtNUMERO_OS_Validated);
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(364, 37);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(79, 15);
            this.guna2HtmlLabel13.TabIndex = 44;
            this.guna2HtmlLabel13.TabStop = false;
            this.guna2HtmlLabel13.Text = "Número O.S.:";
            // 
            // txtHora
            // 
            this.txtHora.AcceptsReturn = true;
            this.txtHora.AcceptsTab = true;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "HORA", true));
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(126, 55);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(54, 23);
            this.txtHora.TabIndex = 39;
            this.txtHora.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(13, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 23);
            this.txtID.TabIndex = 35;
            this.txtID.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "DATA", true));
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(47, 55);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(75, 23);
            this.txtData.TabIndex = 38;
            this.txtData.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 37);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(16, 15);
            this.guna2HtmlLabel4.TabIndex = 34;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "ID";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(126, 37);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel6.TabIndex = 37;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Hora:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(47, 37);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel5.TabIndex = 36;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Data:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // tmiEfeitos
            // 
            this.tmiEfeitos.Interval = 700;
            this.tmiEfeitos.Tick += new System.EventHandler(this.tmiEfeitos_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eQUIPAMENTOSBindingSource
            // 
            this.eQUIPAMENTOSBindingSource.DataMember = "EQUIPAMENTOS";
            this.eQUIPAMENTOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // tECNICOSBindingSource
            // 
            this.tECNICOSBindingSource.DataMember = "TECNICOS";
            this.tECNICOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager.MOVI_RETIRADATableAdapter = null;
            this.tableAdapterManager.MOVITableAdapter = null;
            this.tableAdapterManager.NUMERACAO_IDTableAdapter = null;
            this.tableAdapterManager.SERVICOSTableAdapter = null;
            this.tableAdapterManager.TECNICOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // mOVI_RETIRADATableAdapter
            // 
            this.mOVI_RETIRADATableAdapter.ClearBeforeFill = true;
            // 
            // tECNICOSTableAdapter
            // 
            this.tECNICOSTableAdapter.ClearBeforeFill = true;
            // 
            // eQUIPAMENTOSTableAdapter
            // 
            this.eQUIPAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // nUMERACAO_IDTableAdapter
            // 
            this.nUMERACAO_IDTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMoviRetirada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1186, 670);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviRetirada";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMoviRetirada";
            this.Activated += new System.EventHandler(this.FrmMoviRetirada_Activated);
            this.Load += new System.EventHandler(this.FrmMoviRetirada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMoviRetirada_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nUMERACAO_IDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.gbxObservacoes_Importantes.ResumeLayout(false);
            this.gbxDescricao_Atividade.ResumeLayout(false);
            this.gbxDadosSolicitacao.ResumeLayout(false);
            this.gbxDadosSolicitacao.PerformLayout();
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.gbxIdentificacao.ResumeLayout(false);
            this.gbxIdentificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private helpdesk01DataSet helpdesk01DataSet;
        private helpdesk01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2GroupBox gbxIdentificacao;
        private TextBox txtHora;
        private TextBox txtID;
        private TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2GroupBox gbxUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private TextBox txtArea;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private TextBox txtPREDIO_SETOR;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private TextBox txtNOME_USUARIO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private BindingSource uSUARIOSBindingSource;
        private helpdesk01DataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private TextBox txtRAMAL_TEL;
        private Timer tmiEfeitos;
        private Guna.UI2.WinForms.Guna2GroupBox gbxStatus;
        private TextBox txtSITUACAO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private TextBox txtMODALIDADE;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private BindingSource mOVI_RETIRADABindingSource;
        private helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxDadosSolicitacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private TextBox txtSAI;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private TextBox txtPATRIMONIO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rbtSDDnao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtSDDsim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2RadioButton rbtMAINFRAMEnao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtMAINFRAMEsim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2RadioButton rbtOFFICE365nao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtOFFICE365sim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2RadioButton rbtPLANILHAnao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtPLANILHAsim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2RadioButton rbtBOTAOEMERGENCIAEnao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtBOTAOEMERGENCIAEsim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private Guna.UI2.WinForms.Guna2RadioButton rbtCNSEnao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtCNSEsim;
        private Guna.UI2.WinForms.Guna2GroupBox gbxDescricao_Atividade;
        private Guna.UI2.WinForms.Guna2GroupBox gbxObservacoes_Importantes;
        private Guna.UI2.WinForms.Guna2RadioButton rbtPLANILHAnsaplica;
        private TextBox txtNUMERO_OS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTecnicos;
        private TextBox txtHoraPrevista;
        private TextBox txtDATA_PREVISTA;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private BindingSource tECNICOSBindingSource;
        private helpdesk01DataSetTableAdapters.TECNICOSTableAdapter tECNICOSTableAdapter;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnNovoTecnico;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnNovoEquipamento;
        private BindingSource eQUIPAMENTOSBindingSource;
        private helpdesk01DataSetTableAdapters.EQUIPAMENTOSTableAdapter eQUIPAMENTOSTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEquipamento;
        private Button btnSalvar;
        private Button btnVoltar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPrioridade;
        private Guna.UI2.WinForms.Guna2TextBox txtDESCRICA_ATIVIDADE;
        private Guna.UI2.WinForms.Guna2TextBox txtOBS_IMPORTANTES;
        private BindingSource nUMERACAO_IDBindingSource;
        private helpdesk01DataSetTableAdapters.NUMERACAO_IDTableAdapter nUMERACAO_IDTableAdapter;
    }
}