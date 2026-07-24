namespace HELP_Princ
{
    partial class FrmServicosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicosForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.gbxAtivacao = new Guna.UI2.WinForms.Guna2GroupBox();
            this.aTIVO2ComboBox = new System.Windows.Forms.ComboBox();
            this.sERVICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.txtDATA_DES = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDESCRCAO_SERVICO = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sERVICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.SERVICOSTableAdapter();
            this.tableAdapterManager = new HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.gbxAtivacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.SuspendLayout();
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
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.guna2ControlBox3);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.LightGray;
            this.pnlHeader.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1156, 87);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.BorderRadius = 10;
            this.lblLogo.Image = ((System.Drawing.Image)(resources.GetObject("lblLogo.Image")));
            this.lblLogo.ImageRotate = 0F;
            this.lblLogo.Location = new System.Drawing.Point(12, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(64, 64);
            this.lblLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblLogo.TabIndex = 5;
            this.lblLogo.TabStop = false;
            this.lblLogo.UseTransparentBackground = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(425, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(3, 2);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = null;
            this.lblTitulo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.Animated = true;
            this.guna2ControlBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Silver;
            this.guna2ControlBox3.BorderRadius = 10;
            this.guna2ControlBox3.BorderThickness = 1;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1098, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox3.TabIndex = 3;
            this.guna2ControlBox3.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Silver;
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.BorderThickness = 1;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1127, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.bindingNavigator1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.FillColor2 = System.Drawing.Color.LightGray;
            this.pnlFooter.Location = new System.Drawing.Point(0, 426);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1156, 26);
            this.pnlFooter.TabIndex = 4;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.toolStripSeparator,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1156, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.DarkGray;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.ToolTipText = "Voltar...";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.gbxAtivacao);
            this.pnlForm.Controls.Add(this.txtDESCRCAO_SERVICO);
            this.pnlForm.Controls.Add(this.guna2HtmlLabel1);
            this.pnlForm.Controls.Add(this.txtHora);
            this.pnlForm.Controls.Add(this.txtID);
            this.pnlForm.Controls.Add(this.txtData);
            this.pnlForm.Controls.Add(this.guna2HtmlLabel4);
            this.pnlForm.Controls.Add(this.guna2HtmlLabel6);
            this.pnlForm.Controls.Add(this.guna2HtmlLabel5);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.FillColor = System.Drawing.Color.LightGray;
            this.pnlForm.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlForm.Location = new System.Drawing.Point(0, 87);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1156, 339);
            this.pnlForm.TabIndex = 5;
            // 
            // gbxAtivacao
            // 
            this.gbxAtivacao.BackColor = System.Drawing.Color.Transparent;
            this.gbxAtivacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxAtivacao.BorderColor = System.Drawing.Color.Black;
            this.gbxAtivacao.BorderRadius = 10;
            this.gbxAtivacao.Controls.Add(this.aTIVO2ComboBox);
            this.gbxAtivacao.Controls.Add(this.txtDATA_DES);
            this.gbxAtivacao.Controls.Add(this.guna2HtmlLabel9);
            this.gbxAtivacao.Controls.Add(this.guna2HtmlLabel7);
            this.gbxAtivacao.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxAtivacao.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxAtivacao.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxAtivacao.ForeColor = System.Drawing.Color.Black;
            this.gbxAtivacao.Location = new System.Drawing.Point(12, 184);
            this.gbxAtivacao.Name = "gbxAtivacao";
            this.gbxAtivacao.Size = new System.Drawing.Size(245, 98);
            this.gbxAtivacao.TabIndex = 36;
            this.gbxAtivacao.Text = "Ativação";
            // 
            // aTIVO2ComboBox
            // 
            this.aTIVO2ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "ATIVO2", true));
            this.aTIVO2ComboBox.FormattingEnabled = true;
            this.aTIVO2ComboBox.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.aTIVO2ComboBox.Location = new System.Drawing.Point(13, 51);
            this.aTIVO2ComboBox.Name = "aTIVO2ComboBox";
            this.aTIVO2ComboBox.Size = new System.Drawing.Size(108, 23);
            this.aTIVO2ComboBox.TabIndex = 0;
            this.aTIVO2ComboBox.TabStop = false;
            this.aTIVO2ComboBox.SelectedIndexChanged += new System.EventHandler(this.aTIVO2ComboBox_SelectedIndexChanged);
            // 
            // sERVICOSBindingSource
            // 
            this.sERVICOSBindingSource.DataMember = "SERVICOS";
            this.sERVICOSBindingSource.DataSource = this.helpdesk01DataSet;
            this.sERVICOSBindingSource.CurrentChanged += new System.EventHandler(this.sERVICOSBindingSource_CurrentChanged);
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "helpdesk01DataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDATA_DES
            // 
            this.txtDATA_DES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATA_DES.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "DATA_DES", true));
            this.txtDATA_DES.Location = new System.Drawing.Point(127, 51);
            this.txtDATA_DES.Name = "txtDATA_DES";
            this.txtDATA_DES.Size = new System.Drawing.Size(104, 23);
            this.txtDATA_DES.TabIndex = 1;
            this.txtDATA_DES.Enter += new System.EventHandler(this.txtDATA_DES_Enter);
            this.txtDATA_DES.Leave += new System.EventHandler(this.txtDATA_DES_Leave);
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(127, 34);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(109, 15);
            this.guna2HtmlLabel9.TabIndex = 38;
            this.guna2HtmlLabel9.TabStop = false;
            this.guna2HtmlLabel9.Text = "Data Desativação:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(13, 34);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(110, 15);
            this.guna2HtmlLabel7.TabIndex = 37;
            this.guna2HtmlLabel7.TabStop = false;
            this.guna2HtmlLabel7.Text = "Ativo (SIM / NÃO):";
            // 
            // txtDESCRCAO_SERVICO
            // 
            this.txtDESCRCAO_SERVICO.AcceptsReturn = true;
            this.txtDESCRCAO_SERVICO.AcceptsTab = true;
            this.txtDESCRCAO_SERVICO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDESCRCAO_SERVICO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "DESCRICAO_SERVICO", true));
            this.txtDESCRCAO_SERVICO.Location = new System.Drawing.Point(12, 159);
            this.txtDESCRCAO_SERVICO.Name = "txtDESCRCAO_SERVICO";
            this.txtDESCRCAO_SERVICO.Size = new System.Drawing.Size(635, 20);
            this.txtDESCRCAO_SERVICO.TabIndex = 0;
            this.txtDESCRCAO_SERVICO.Enter += new System.EventHandler(this.txtDESCRCAO_SERVICO_Enter);
            this.txtDESCRCAO_SERVICO.Leave += new System.EventHandler(this.txtDESCRCAO_SERVICO_Leave);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 141);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(121, 15);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Descrição / Serviço:";
            // 
            // txtHora
            // 
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "HORA", true));
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(12, 115);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(54, 20);
            this.txtHora.TabIndex = 27;
            this.txtHora.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "ID", true));
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(12, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(30, 20);
            this.txtID.TabIndex = 23;
            this.txtID.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sERVICOSBindingSource, "DATA", true));
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(12, 71);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(67, 20);
            this.txtData.TabIndex = 26;
            this.txtData.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 9);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(16, 15);
            this.guna2HtmlLabel4.TabIndex = 22;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "ID";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(12, 97);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel6.TabIndex = 25;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Hora:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 53);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Data:";
            // 
            // sERVICOSTableAdapter
            // 
            this.sERVICOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager.MOVI_RETIRADATableAdapter = null;
            this.tableAdapterManager.MOVITableAdapter = null;
            this.tableAdapterManager.SERVICOSTableAdapter = this.sERVICOSTableAdapter;
            this.tableAdapterManager.TECNICOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // FrmServicosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1156, 452);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmServicosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmServicosForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLogo)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.gbxAtivacao.ResumeLayout(false);
            this.gbxAtivacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlForm;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlFooter;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlHeader;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox lblLogo;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TextBox txtID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtData;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.TextBox txtDESCRCAO_SERVICO;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox gbxAtivacao;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private System.Windows.Forms.TextBox txtDATA_DES;
        private helpdesk01DataSet helpdesk01DataSet;
        private System.Windows.Forms.BindingSource sERVICOSBindingSource;
        private helpdesk01DataSetTableAdapters.SERVICOSTableAdapter sERVICOSTableAdapter;
        private helpdesk01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox aTIVO2ComboBox;
    }
}