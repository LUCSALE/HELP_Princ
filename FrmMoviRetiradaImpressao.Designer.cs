using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMoviRetiradaImpressao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviRetiradaImpressao));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEMail = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.gbxIdentificacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHoraPrevista = new System.Windows.Forms.TextBox();
            this.txtDATA_PREVISTA = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNUMERO_OS = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.tECNICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tECNICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TECNICOSTableAdapter();
            this.tmiProgressBar = new System.Windows.Forms.Timer(this.components);
            this.prgCarregamento = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.gbxIdentificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel3);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Controls.Add(this.guna2PictureBox2);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(999, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(471, 64);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "(Impressão)";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(966, 10);
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
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(349, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "Retirada de Equipamento";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.btnEMail);
            this.pnlFooter.Controls.Add(this.btnVoltar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 678);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(999, 36);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // btnEMail
            // 
            this.btnEMail.Image = ((System.Drawing.Image)(resources.GetObject("btnEMail.Image")));
            this.btnEMail.Location = new System.Drawing.Point(13, 6);
            this.btnEMail.Name = "btnEMail";
            this.btnEMail.Size = new System.Drawing.Size(75, 23);
            this.btnEMail.TabIndex = 4;
            this.btnEMail.UseVisualStyleBackColor = true;
            this.btnEMail.Click += new System.EventHandler(this.btnEMail_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(94, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            // pnlGrid
            // 
            this.pnlGrid.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlGrid.BorderRadius = 10;
            this.pnlGrid.BorderThickness = 1;
            this.pnlGrid.Controls.Add(this.prgCarregamento);
            this.pnlGrid.Controls.Add(this.pdfViewer1);
            this.pnlGrid.Controls.Add(this.gbxIdentificacao);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 114);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(999, 564);
            this.pnlGrid.TabIndex = 4;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 149);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(999, 415);
            this.pdfViewer1.TabIndex = 53;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // gbxIdentificacao
            // 
            this.gbxIdentificacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxIdentificacao.BorderColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.BorderRadius = 10;
            this.gbxIdentificacao.Controls.Add(this.textBox1);
            this.gbxIdentificacao.Controls.Add(this.txtHoraPrevista);
            this.gbxIdentificacao.Controls.Add(this.txtDATA_PREVISTA);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel15);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel16);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel1);
            this.gbxIdentificacao.Controls.Add(this.txtNUMERO_OS);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel13);
            this.gbxIdentificacao.Controls.Add(this.txtHora);
            this.gbxIdentificacao.Controls.Add(this.txtID);
            this.gbxIdentificacao.Controls.Add(this.txtData);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel4);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel2);
            this.gbxIdentificacao.Controls.Add(this.guna2HtmlLabel7);
            this.gbxIdentificacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxIdentificacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxIdentificacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxIdentificacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxIdentificacao.ForeColor = System.Drawing.Color.Black;
            this.gbxIdentificacao.Location = new System.Drawing.Point(0, 0);
            this.gbxIdentificacao.Name = "gbxIdentificacao";
            this.gbxIdentificacao.Size = new System.Drawing.Size(999, 149);
            this.gbxIdentificacao.TabIndex = 50;
            this.gbxIdentificacao.TabStop = false;
            this.gbxIdentificacao.Text = "Identificação:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "TECNICO_SOLICITANTE", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(14, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 23);
            this.textBox1.TabIndex = 50;
            this.textBox1.TabStop = false;
            // 
            // txtHoraPrevista
            // 
            this.txtHoraPrevista.AcceptsReturn = true;
            this.txtHoraPrevista.AcceptsTab = true;
            this.txtHoraPrevista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoraPrevista.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "HORA_PREVISTA", true));
            this.txtHoraPrevista.Enabled = false;
            this.txtHoraPrevista.Location = new System.Drawing.Point(275, 55);
            this.txtHoraPrevista.Name = "txtHoraPrevista";
            this.txtHoraPrevista.Size = new System.Drawing.Size(84, 23);
            this.txtHoraPrevista.TabIndex = 1;
            this.txtHoraPrevista.TabStop = false;
            // 
            // txtDATA_PREVISTA
            // 
            this.txtDATA_PREVISTA.AcceptsReturn = true;
            this.txtDATA_PREVISTA.AcceptsTab = true;
            this.txtDATA_PREVISTA.BackColor = System.Drawing.SystemColors.Window;
            this.txtDATA_PREVISTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATA_PREVISTA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "DATA_PREVISTA", true));
            this.txtDATA_PREVISTA.Enabled = false;
            this.txtDATA_PREVISTA.Location = new System.Drawing.Point(185, 55);
            this.txtDATA_PREVISTA.Name = "txtDATA_PREVISTA";
            this.txtDATA_PREVISTA.Size = new System.Drawing.Size(84, 23);
            this.txtDATA_PREVISTA.TabIndex = 0;
            this.txtDATA_PREVISTA.TabStop = false;
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
            this.txtNUMERO_OS.Location = new System.Drawing.Point(364, 55);
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
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(126, 37);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Hora:";
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
            // prgCarregamento
            // 
            this.prgCarregamento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.prgCarregamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prgCarregamento.ForeColor = System.Drawing.Color.White;
            this.prgCarregamento.Location = new System.Drawing.Point(389, 272);
            this.prgCarregamento.Minimum = 0;
            this.prgCarregamento.Name = "prgCarregamento";
            this.prgCarregamento.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.prgCarregamento.Size = new System.Drawing.Size(130, 130);
            this.prgCarregamento.TabIndex = 54;
            // 
            // FrmMoviRetiradaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(999, 714);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviRetiradaImpressao";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMoviRetiradaImpressao";
            this.Activated += new System.EventHandler(this.FrmMoviRetiradaImpressao_Activated);
            this.Load += new System.EventHandler(this.FrmMoviRetiradaImpressao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMoviRetiradaImpressao_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.gbxIdentificacao.ResumeLayout(false);
            this.gbxIdentificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tECNICOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
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
        private Button btnVoltar;
        private Guna.UI2.WinForms.Guna2GroupBox gbxIdentificacao;
        private TextBox textBox1;
        private TextBox txtHoraPrevista;
        private TextBox txtDATA_PREVISTA;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private TextBox txtNUMERO_OS;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private TextBox txtHora;
        private TextBox txtID;
        private TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private Button btnEMail;
        private Timer tmiProgressBar;
        private Guna.UI2.WinForms.Guna2CircleProgressBar prgCarregamento;
    }
}