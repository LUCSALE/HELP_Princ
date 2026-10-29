using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMoviPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviPesquisa));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.gbxStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSITUACAO = new System.Windows.Forms.TextBox();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxDadosSolicitacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSAI = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPATRIMONIO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxRetirada = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxTecnico_Atuante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDataRetirada = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxUsuario = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtRAMAL_TEL = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPREDIO_SETOR = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNOME_USUARIO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbxIdentificacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNUMERO_OS = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mOVIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.tECNICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tECNICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TECNICOSTableAdapter();
            this.mOVITableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVITableAdapter();
            this.eQUIPAMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPAMENTOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.EQUIPAMENTOSTableAdapter();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.gbxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.gbxDadosSolicitacao.SuspendLayout();
            this.gbxRetirada.SuspendLayout();
            this.gbxUsuario.SuspendLayout();
            this.gbxIdentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMENTOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel3);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Controls.Add(this.guna2PictureBox2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(687, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(251, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "Movimentações";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(319, 78);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(49, 15);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "(Pesquisa)";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(658, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.TabStop = false;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2PictureBox2.FillColor = System.Drawing.SystemColors.Window;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(13, 10);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.guna2PictureBox2.ShadowDecoration.Enabled = true;
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.button1);
            this.pnlFooter.Controls.Add(this.button2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 741);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(687, 34);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(83, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlGrid.BorderRadius = 10;
            this.pnlGrid.BorderThickness = 1;
            this.pnlGrid.Controls.Add(this.gbxStatus);
            this.pnlGrid.Controls.Add(this.gbxDadosSolicitacao);
            this.pnlGrid.Controls.Add(this.gbxRetirada);
            this.pnlGrid.Controls.Add(this.gbxUsuario);
            this.pnlGrid.Controls.Add(this.gbxIdentificacao);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 114);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(687, 627);
            this.pnlGrid.TabIndex = 4;
            // 
            // gbxStatus
            // 
            this.gbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.gbxStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxStatus.BorderColor = System.Drawing.Color.Black;
            this.gbxStatus.BorderRadius = 10;
            this.gbxStatus.Controls.Add(this.txtSITUACAO);
            this.gbxStatus.Controls.Add(this.guna2HtmlLabel19);
            this.gbxStatus.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxStatus.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxStatus.ForeColor = System.Drawing.Color.Black;
            this.gbxStatus.Location = new System.Drawing.Point(471, 0);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(216, 146);
            this.gbxStatus.TabIndex = 54;
            this.gbxStatus.TabStop = false;
            this.gbxStatus.Text = "Status:";
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
            // mOVI_RETIRADABindingSource
            // 
            this.mOVI_RETIRADABindingSource.DataMember = "MOVI_RETIRADA";
            this.mOVI_RETIRADABindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "helpdesk01DataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(14, 37);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel19.TabIndex = 42;
            this.guna2HtmlLabel19.TabStop = false;
            this.guna2HtmlLabel19.Text = "Situação:";
            // 
            // gbxDadosSolicitacao
            // 
            this.gbxDadosSolicitacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxDadosSolicitacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxDadosSolicitacao.BorderColor = System.Drawing.Color.Black;
            this.gbxDadosSolicitacao.BorderRadius = 10;
            this.gbxDadosSolicitacao.Controls.Add(this.txtSAI);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel12);
            this.gbxDadosSolicitacao.Controls.Add(this.txtPATRIMONIO);
            this.gbxDadosSolicitacao.Controls.Add(this.guna2HtmlLabel17);
            this.gbxDadosSolicitacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxDadosSolicitacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxDadosSolicitacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDadosSolicitacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxDadosSolicitacao.ForeColor = System.Drawing.Color.Black;
            this.gbxDadosSolicitacao.Location = new System.Drawing.Point(0, 292);
            this.gbxDadosSolicitacao.Name = "gbxDadosSolicitacao";
            this.gbxDadosSolicitacao.Size = new System.Drawing.Size(687, 185);
            this.gbxDadosSolicitacao.TabIndex = 52;
            this.gbxDadosSolicitacao.TabStop = false;
            this.gbxDadosSolicitacao.Text = "Dados Solicitação:";
            this.gbxDadosSolicitacao.Click += new System.EventHandler(this.gbxDadosSolicitacao_Click);
            // 
            // txtSAI
            // 
            this.txtSAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "SAI", true));
            this.txtSAI.Location = new System.Drawing.Point(153, 51);
            this.txtSAI.Name = "txtSAI";
            this.txtSAI.Size = new System.Drawing.Size(126, 23);
            this.txtSAI.TabIndex = 1;
            this.txtSAI.Validating += new System.ComponentModel.CancelEventHandler(this.txtSAI_Validating);
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
            this.txtPATRIMONIO.Validating += new System.ComponentModel.CancelEventHandler(this.txtPATRIMONIO_Validating);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(10, 34);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(102, 15);
            this.guna2HtmlLabel17.TabIndex = 40;
            this.guna2HtmlLabel17.TabStop = false;
            this.guna2HtmlLabel17.Text = "Patrimônio (PAT):";
            // 
            // gbxRetirada
            // 
            this.gbxRetirada.BackColor = System.Drawing.Color.Transparent;
            this.gbxRetirada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxRetirada.BorderColor = System.Drawing.Color.Black;
            this.gbxRetirada.BorderRadius = 10;
            this.gbxRetirada.Controls.Add(this.guna2HtmlLabel14);
            this.gbxRetirada.Controls.Add(this.cbxTecnico_Atuante);
            this.gbxRetirada.Controls.Add(this.txtDataRetirada);
            this.gbxRetirada.Controls.Add(this.guna2HtmlLabel5);
            this.gbxRetirada.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxRetirada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxRetirada.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxRetirada.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxRetirada.ForeColor = System.Drawing.Color.Black;
            this.gbxRetirada.Location = new System.Drawing.Point(0, 477);
            this.gbxRetirada.Name = "gbxRetirada";
            this.gbxRetirada.Size = new System.Drawing.Size(687, 150);
            this.gbxRetirada.TabIndex = 51;
            this.gbxRetirada.TabStop = false;
            this.gbxRetirada.Text = "Retirada:";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(101, 15);
            this.guna2HtmlLabel14.TabIndex = 47;
            this.guna2HtmlLabel14.TabStop = false;
            this.guna2HtmlLabel14.Text = "Técnico Atuante:";
            // 
            // cbxTecnico_Atuante
            // 
            this.cbxTecnico_Atuante.BackColor = System.Drawing.Color.Transparent;
            this.cbxTecnico_Atuante.BorderColor = System.Drawing.Color.Black;
            this.cbxTecnico_Atuante.BorderRadius = 10;
            this.cbxTecnico_Atuante.DisplayMember = "TECNICO_ATUANTE";
            this.cbxTecnico_Atuante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTecnico_Atuante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTecnico_Atuante.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTecnico_Atuante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTecnico_Atuante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTecnico_Atuante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTecnico_Atuante.ItemHeight = 30;
            this.cbxTecnico_Atuante.Location = new System.Drawing.Point(14, 104);
            this.cbxTecnico_Atuante.Name = "cbxTecnico_Atuante";
            this.cbxTecnico_Atuante.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.cbxTecnico_Atuante.Size = new System.Drawing.Size(628, 36);
            this.cbxTecnico_Atuante.TabIndex = 2;
            this.cbxTecnico_Atuante.TabStop = false;
            this.cbxTecnico_Atuante.ValueMember = "TECNICO_ATUANTE";
            this.cbxTecnico_Atuante.Validating += new System.ComponentModel.CancelEventHandler(this.cbxTecnico_Atuante_Validating);
            // 
            // txtDataRetirada
            // 
            this.txtDataRetirada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataRetirada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "DATA_RETIRADA", true));
            this.txtDataRetirada.Location = new System.Drawing.Point(14, 55);
            this.txtDataRetirada.Name = "txtDataRetirada";
            this.txtDataRetirada.Size = new System.Drawing.Size(86, 23);
            this.txtDataRetirada.TabIndex = 0;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 37);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel5.TabIndex = 36;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Data Retirada:";
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
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel8);
            this.gbxUsuario.Controls.Add(this.txtNOME_USUARIO);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel9);
            this.gbxUsuario.Controls.Add(this.guna2HtmlLabel11);
            this.gbxUsuario.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxUsuario.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxUsuario.ForeColor = System.Drawing.Color.Black;
            this.gbxUsuario.Location = new System.Drawing.Point(0, 146);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(687, 146);
            this.gbxUsuario.TabIndex = 50;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Usuário:";
            // 
            // txtRAMAL_TEL
            // 
            this.txtRAMAL_TEL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "RAMAL_TEL", true));
            this.txtRAMAL_TEL.Enabled = false;
            this.txtRAMAL_TEL.Location = new System.Drawing.Point(14, 55);
            this.txtRAMAL_TEL.Name = "txtRAMAL_TEL";
            this.txtRAMAL_TEL.Size = new System.Drawing.Size(134, 23);
            this.txtRAMAL_TEL.TabIndex = 0;
            this.txtRAMAL_TEL.TabStop = false;
            // 
            // txtArea
            // 
            this.txtArea.AcceptsReturn = true;
            this.txtArea.AcceptsTab = true;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "AREA", true));
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(427, 104);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(33, 23);
            this.txtArea.TabIndex = 3;
            this.txtArea.TabStop = false;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(427, 86);
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
            this.txtPREDIO_SETOR.Enabled = false;
            this.txtPREDIO_SETOR.Location = new System.Drawing.Point(14, 104);
            this.txtPREDIO_SETOR.Name = "txtPREDIO_SETOR";
            this.txtPREDIO_SETOR.Size = new System.Drawing.Size(410, 23);
            this.txtPREDIO_SETOR.TabIndex = 2;
            this.txtPREDIO_SETOR.TabStop = false;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(87, 15);
            this.guna2HtmlLabel8.TabIndex = 47;
            this.guna2HtmlLabel8.TabStop = false;
            this.guna2HtmlLabel8.Text = "Prédio / Setor:";
            // 
            // txtNOME_USUARIO
            // 
            this.txtNOME_USUARIO.AcceptsReturn = true;
            this.txtNOME_USUARIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNOME_USUARIO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "NOME_USUARIO", true));
            this.txtNOME_USUARIO.Enabled = false;
            this.txtNOME_USUARIO.Location = new System.Drawing.Point(154, 55);
            this.txtNOME_USUARIO.Name = "txtNOME_USUARIO";
            this.txtNOME_USUARIO.Size = new System.Drawing.Size(306, 23);
            this.txtNOME_USUARIO.TabIndex = 1;
            this.txtNOME_USUARIO.TabStop = false;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(154, 37);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel9.TabIndex = 45;
            this.guna2HtmlLabel9.TabStop = false;
            this.guna2HtmlLabel9.Text = "Nome:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(14, 37);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(106, 15);
            this.guna2HtmlLabel11.TabIndex = 36;
            this.guna2HtmlLabel11.TabStop = false;
            this.guna2HtmlLabel11.Text = "Ramal / Telefone:";
            // 
            // gbxIdentificacao
            // 
            this.gbxIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxIdentificacao.BorderColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.BorderRadius = 10;
            this.gbxIdentificacao.Controls.Add(this.guna2ComboBox1);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel1);
            this.gbxIdentificacao.Controls.Add(this.txtNUMERO_OS);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel13);
            this.gbxIdentificacao.Controls.Add(this.txtID);
            this.gbxIdentificacao.Controls.Add(this.txtData);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel4);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel7);
            this.gbxIdentificacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxIdentificacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.Location = new System.Drawing.Point(0, 0);
            this.gbxIdentificacao.Name = "gbxIdentificacao";
            this.gbxIdentificacao.Size = new System.Drawing.Size(472, 146);
            this.gbxIdentificacao.TabIndex = 49;
            this.gbxIdentificacao.TabStop = false;
            this.gbxIdentificacao.Text = "Identificação:";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DisplayMember = "TECNICO_ATUANTE";
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(14, 104);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2ComboBox1.Size = new System.Drawing.Size(451, 36);
            this.guna2ComboBox1.TabIndex = 48;
            this.guna2ComboBox1.TabStop = false;
            this.guna2ComboBox1.ValueMember = "TECNICO_ATUANTE";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 87);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(117, 15);
            this.guna2HtmlLabel1.TabIndex = 47;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Técnico Solicitante:";
            // 
            // txtNUMERO_OS
            // 
            this.txtNUMERO_OS.AcceptsReturn = true;
            this.txtNUMERO_OS.AcceptsTab = true;
            this.txtNUMERO_OS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNUMERO_OS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "NUMERO_OS", true));
            this.txtNUMERO_OS.Enabled = false;
            this.txtNUMERO_OS.Location = new System.Drawing.Point(128, 55);
            this.txtNUMERO_OS.Name = "txtNUMERO_OS";
            this.txtNUMERO_OS.Size = new System.Drawing.Size(96, 23);
            this.txtNUMERO_OS.TabIndex = 2;
            this.txtNUMERO_OS.TabStop = false;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(128, 37);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(79, 15);
            this.guna2HtmlLabel13.TabIndex = 44;
            this.guna2HtmlLabel13.TabStop = false;
            this.guna2HtmlLabel13.Text = "Número O.S.:";
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
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(47, 37);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel7.TabIndex = 36;
            this.guna2HtmlLabel7.TabStop = false;
            this.guna2HtmlLabel7.Text = "Data:";
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
            // mOVIBindingSource
            // 
            this.mOVIBindingSource.DataMember = "MOVI";
            this.mOVIBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // mOVI_RETIRADATableAdapter
            // 
            this.mOVI_RETIRADATableAdapter.ClearBeforeFill = true;
            // 
            // tECNICOSBindingSource
            // 
            this.tECNICOSBindingSource.DataMember = "TECNICOS";
            this.tECNICOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // tECNICOSTableAdapter
            // 
            this.tECNICOSTableAdapter.ClearBeforeFill = true;
            // 
            // mOVITableAdapter
            // 
            this.mOVITableAdapter.ClearBeforeFill = true;
            // 
            // eQUIPAMENTOSBindingSource
            // 
            this.eQUIPAMENTOSBindingSource.DataMember = "EQUIPAMENTOS";
            this.eQUIPAMENTOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // eQUIPAMENTOSTableAdapter
            // 
            this.eQUIPAMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMoviPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(687, 775);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviPesquisa";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMoviPesquisa";
            this.Activated += new System.EventHandler(this.FrmMoviPesquisa_Activated);
            this.Load += new System.EventHandler(this.FrmMoviPesquisa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMoviPesquisa_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.gbxDadosSolicitacao.ResumeLayout(false);
            this.gbxDadosSolicitacao.PerformLayout();
            this.gbxRetirada.ResumeLayout(false);
            this.gbxRetirada.PerformLayout();
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.gbxIdentificacao.ResumeLayout(false);
            this.gbxIdentificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPAMENTOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private helpdesk01DataSet helpdesk01DataSet;
        private Timer tmiEfeitos;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private BindingSource mOVI_RETIRADABindingSource;
        private helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private BindingSource tECNICOSBindingSource;
        private helpdesk01DataSetTableAdapters.TECNICOSTableAdapter tECNICOSTableAdapter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxIdentificacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox txtNUMERO_OS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private TextBox txtID;
        private TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2GroupBox gbxUsuario;
        private TextBox txtRAMAL_TEL;
        private TextBox txtArea;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private TextBox txtPREDIO_SETOR;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private TextBox txtNOME_USUARIO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2GroupBox gbxRetirada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTecnico_Atuante;
        private TextBox txtDataRetirada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private BindingSource mOVIBindingSource;
        private helpdesk01DataSetTableAdapters.MOVITableAdapter mOVITableAdapter;
        private Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2GroupBox gbxDadosSolicitacao;
        private TextBox txtSAI;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private TextBox txtPATRIMONIO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private BindingSource eQUIPAMENTOSBindingSource;
        private helpdesk01DataSetTableAdapters.EQUIPAMENTOSTableAdapter eQUIPAMENTOSTableAdapter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxStatus;
        private TextBox txtSITUACAO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}