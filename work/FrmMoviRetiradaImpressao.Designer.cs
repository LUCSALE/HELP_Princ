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
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.gbxModalidade = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbxRetirada = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbtnNovoTecnico = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxTecnico_Atuante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHoraRetirada = new System.Windows.Forms.TextBox();
            this.txtDataRetirada = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtbSimples = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rtbSubstituicao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtManutencao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtAgendamento = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.tECNICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tECNICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TECNICOSTableAdapter();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.gbxModalidade.SuspendLayout();
            this.gbxRetirada.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(533, 112);
            this.pnlHeader.TabIndex = 0;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(241, 64);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "(Atualizar)";
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(504, 5);
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
            this.lblTitulo.Location = new System.Drawing.Point(116, 37);
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
            this.pnlFooter.Controls.Add(this.btnVoltar);
            this.pnlFooter.Controls.Add(this.btnSalvar);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 378);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(533, 62);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Animated = true;
            this.btnVoltar.AnimatedGIF = true;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BorderRadius = 4;
            this.btnVoltar.BorderThickness = 1;
            this.btnVoltar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVoltar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVoltar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnVoltar.FocusedColor = System.Drawing.Color.DarkGray;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.IndicateFocus = true;
            this.btnVoltar.Location = new System.Drawing.Point(36, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.BorderRadius = 4;
            this.btnVoltar.ShadowDecoration.Enabled = true;
            this.btnVoltar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnVoltar.Size = new System.Drawing.Size(34, 36);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Animated = true;
            this.btnSalvar.AnimatedGIF = true;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BorderRadius = 4;
            this.btnSalvar.BorderThickness = 1;
            this.btnSalvar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalvar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalvar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.FocusedColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.IndicateFocus = true;
            this.btnSalvar.Location = new System.Drawing.Point(3, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.BorderRadius = 4;
            this.btnSalvar.ShadowDecoration.Enabled = true;
            this.btnSalvar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.btnSalvar.Size = new System.Drawing.Size(34, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.pnlGrid.Controls.Add(this.gbxModalidade);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 114);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(533, 264);
            this.pnlGrid.TabIndex = 4;
            // 
            // gbxModalidade
            // 
            this.gbxModalidade.BackColor = System.Drawing.Color.Transparent;
            this.gbxModalidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxModalidade.BorderColor = System.Drawing.Color.Black;
            this.gbxModalidade.BorderRadius = 10;
            this.gbxModalidade.Controls.Add(this.gbxRetirada);
            this.gbxModalidade.Controls.Add(this.guna2GroupBox1);
            this.gbxModalidade.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxModalidade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxModalidade.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxModalidade.ForeColor = System.Drawing.Color.Black;
            this.gbxModalidade.Location = new System.Drawing.Point(0, 0);
            this.gbxModalidade.Name = "gbxModalidade";
            this.gbxModalidade.Size = new System.Drawing.Size(533, 264);
            this.gbxModalidade.TabIndex = 43;
            this.gbxModalidade.TabStop = false;
            this.gbxModalidade.Text = "Modalidade:";
            // 
            // gbxRetirada
            // 
            this.gbxRetirada.BackColor = System.Drawing.Color.Transparent;
            this.gbxRetirada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxRetirada.BorderColor = System.Drawing.Color.Black;
            this.gbxRetirada.BorderRadius = 10;
            this.gbxRetirada.Controls.Add(this.cbtnNovoTecnico);
            this.gbxRetirada.Controls.Add(this.guna2HtmlLabel14);
            this.gbxRetirada.Controls.Add(this.cbxTecnico_Atuante);
            this.gbxRetirada.Controls.Add(this.txtHoraRetirada);
            this.gbxRetirada.Controls.Add(this.txtDataRetirada);
            this.gbxRetirada.Controls.Add(this.guna2HtmlLabel6);
            this.gbxRetirada.Controls.Add(this.guna2HtmlLabel5);
            this.gbxRetirada.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxRetirada.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxRetirada.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxRetirada.ForeColor = System.Drawing.Color.Black;
            this.gbxRetirada.Location = new System.Drawing.Point(13, 100);
            this.gbxRetirada.Name = "gbxRetirada";
            this.gbxRetirada.Size = new System.Drawing.Size(498, 146);
            this.gbxRetirada.TabIndex = 47;
            this.gbxRetirada.TabStop = false;
            this.gbxRetirada.Text = "Retirada:";
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
            this.cbxTecnico_Atuante.Size = new System.Drawing.Size(410, 36);
            this.cbxTecnico_Atuante.TabIndex = 2;
            this.cbxTecnico_Atuante.TabStop = false;
            this.cbxTecnico_Atuante.ValueMember = "TECNICO_ATUANTE";
            // 
            // txtHoraRetirada
            // 
            this.txtHoraRetirada.AcceptsReturn = true;
            this.txtHoraRetirada.AcceptsTab = true;
            this.txtHoraRetirada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoraRetirada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mOVI_RETIRADABindingSource, "HORA_RETIRADA", true));
            this.txtHoraRetirada.Location = new System.Drawing.Point(109, 55);
            this.txtHoraRetirada.Name = "txtHoraRetirada";
            this.txtHoraRetirada.Size = new System.Drawing.Size(86, 23);
            this.txtHoraRetirada.TabIndex = 1;
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
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(109, 37);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(86, 15);
            this.guna2HtmlLabel6.TabIndex = 37;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Hora Retirada:";
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
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.rtbSimples);
            this.guna2GroupBox1.Controls.Add(this.rtbSubstituicao);
            this.guna2GroupBox1.Controls.Add(this.rbtManutencao);
            this.guna2GroupBox1.Controls.Add(this.rbtAgendamento);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(498, 63);
            this.guna2GroupBox1.TabIndex = 46;
            this.guna2GroupBox1.TabStop = false;
            this.guna2GroupBox1.Text = "Salvar como ???";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(216, 41);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel2.TabIndex = 54;
            this.guna2HtmlLabel2.Text = "(Tarefa Bancada)";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(118, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel1.TabIndex = 53;
            this.guna2HtmlLabel1.Text = "(Tarefa Bancada)";
            // 
            // rtbSimples
            // 
            this.rtbSimples.Animated = true;
            this.rtbSimples.AutoSize = true;
            this.rtbSimples.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSimples.CheckedState.BorderThickness = 0;
            this.rtbSimples.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSimples.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rtbSimples.CheckedState.InnerOffset = -4;
            this.rtbSimples.Location = new System.Drawing.Point(382, 24);
            this.rtbSimples.Name = "rtbSimples";
            this.rtbSimples.Size = new System.Drawing.Size(112, 19);
            this.rtbSimples.TabIndex = 52;
            this.rtbSimples.Text = "Simples Retirada";
            this.rtbSimples.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rtbSimples.UncheckedState.BorderThickness = 2;
            this.rtbSimples.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rtbSimples.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rtbSimples.CheckedChanged += new System.EventHandler(this.rtbSimples_CheckedChanged);
            this.rtbSimples.Click += new System.EventHandler(this.rtbSimples_Click);
            // 
            // rtbSubstituicao
            // 
            this.rtbSubstituicao.Animated = true;
            this.rtbSubstituicao.AutoSize = true;
            this.rtbSubstituicao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSubstituicao.CheckedState.BorderThickness = 0;
            this.rtbSubstituicao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbSubstituicao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rtbSubstituicao.CheckedState.InnerOffset = -4;
            this.rtbSubstituicao.Location = new System.Drawing.Point(216, 24);
            this.rtbSubstituicao.Name = "rtbSubstituicao";
            this.rtbSubstituicao.Size = new System.Drawing.Size(160, 19);
            this.rtbSubstituicao.TabIndex = 51;
            this.rtbSubstituicao.Text = "Substituição / Preparaçao";
            this.rtbSubstituicao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rtbSubstituicao.UncheckedState.BorderThickness = 2;
            this.rtbSubstituicao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rtbSubstituicao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rtbSubstituicao.Click += new System.EventHandler(this.rtbSubstituicao_Click);
            // 
            // rbtManutencao
            // 
            this.rbtManutencao.Animated = true;
            this.rbtManutencao.AutoSize = true;
            this.rbtManutencao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtManutencao.CheckedState.BorderThickness = 0;
            this.rbtManutencao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtManutencao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtManutencao.CheckedState.InnerOffset = -4;
            this.rbtManutencao.Location = new System.Drawing.Point(118, 24);
            this.rbtManutencao.Name = "rbtManutencao";
            this.rbtManutencao.Size = new System.Drawing.Size(92, 19);
            this.rbtManutencao.TabIndex = 50;
            this.rbtManutencao.Text = "Manutenção";
            this.rbtManutencao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtManutencao.UncheckedState.BorderThickness = 2;
            this.rbtManutencao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtManutencao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtManutencao.Click += new System.EventHandler(this.rbtManutencao_Click);
            // 
            // rbtAgendamento
            // 
            this.rbtAgendamento.Animated = true;
            this.rbtAgendamento.AutoSize = true;
            this.rbtAgendamento.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtAgendamento.CheckedState.BorderThickness = 0;
            this.rbtAgendamento.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbtAgendamento.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbtAgendamento.CheckedState.InnerOffset = -4;
            this.rbtAgendamento.Location = new System.Drawing.Point(11, 25);
            this.rbtAgendamento.Name = "rbtAgendamento";
            this.rbtAgendamento.Size = new System.Drawing.Size(101, 19);
            this.rbtAgendamento.TabIndex = 49;
            this.rbtAgendamento.Tag = "";
            this.rbtAgendamento.Text = "Agendamento";
            this.rbtAgendamento.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbtAgendamento.UncheckedState.BorderThickness = 2;
            this.rbtAgendamento.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbtAgendamento.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbtAgendamento.CheckedChanged += new System.EventHandler(this.rbtSDDsim_CheckedChanged);
            this.rbtAgendamento.Click += new System.EventHandler(this.rbtAgendamento_Click);
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
            // FrmMoviRetiradaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(533, 440);
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
            this.gbxModalidade.ResumeLayout(false);
            this.gbxRetirada.ResumeLayout(false);
            this.gbxRetirada.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private BindingSource mOVI_RETIRADABindingSource;
        private helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxModalidade;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rbtManutencao;
        private Guna.UI2.WinForms.Guna2RadioButton rbtAgendamento;
        private ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2RadioButton rtbSimples;
        private Guna.UI2.WinForms.Guna2RadioButton rtbSubstituicao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GroupBox gbxRetirada;
        private Guna.UI2.WinForms.Guna2CircleButton cbtnNovoTecnico;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTecnico_Atuante;
        private TextBox txtHoraRetirada;
        private TextBox txtDataRetirada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private BindingSource tECNICOSBindingSource;
        private helpdesk01DataSetTableAdapters.TECNICOSTableAdapter tECNICOSTableAdapter;
    }
}