using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMoviList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ToolStripButton btnPesquisarRETIRADA;
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.tbcEstagios = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabRetirada = new System.Windows.Forms.TabPage();
            this.dbgRetirada = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRetiradaEdicao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRegistrarRegistrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRetiradaExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImpressao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnMovimentacao = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECNICO_SOLICITANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMALTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEUSUARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREDIOSETORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATRIMONIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_PREVISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_PREVISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_RETIRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORA_RETIRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECNICO_ATUANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.pnlFooterRetirada = new Guna.UI2.WinForms.Guna2Panel();
            this.mOVIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncluirRETIRADA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabTarefa = new System.Windows.Forms.TabPage();
            this.dbgTarefa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooterTarefa = new Guna.UI2.WinForms.Guna2Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncluirTAREFA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltarTAREFA = new System.Windows.Forms.ToolStripButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.elpGrid = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpTab = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.elpGridTarefa = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tAREFA_BANCADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAREFA_BANCADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TAREFA_BANCADATableAdapter();
            this.tableAdapterManager = new HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager();
            this.btnFiltroRETIRADA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            btnPesquisarRETIRADA = new System.Windows.Forms.ToolStripButton();
            this.pnlHeader.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.tbcEstagios.SuspendLayout();
            this.tabRetirada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgRetirada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.pnlFooterRetirada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingNavigator)).BeginInit();
            this.mOVIBindingNavigator.SuspendLayout();
            this.tabTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTarefa)).BeginInit();
            this.pnlFooterTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFA_BANCADABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1675, 38);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(738, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "Movimentações";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.tbcEstagios);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1675, 903);
            this.pnlGrid.TabIndex = 4;
            // 
            // tbcEstagios
            // 
            this.tbcEstagios.Controls.Add(this.tabRetirada);
            this.tbcEstagios.Controls.Add(this.tabTarefa);
            this.tbcEstagios.Controls.Add(this.tabEntrega);
            this.tbcEstagios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEstagios.ItemSize = new System.Drawing.Size(180, 40);
            this.tbcEstagios.Location = new System.Drawing.Point(0, 0);
            this.tbcEstagios.Name = "tbcEstagios";
            this.tbcEstagios.SelectedIndex = 0;
            this.tbcEstagios.Size = new System.Drawing.Size(1675, 903);
            this.tbcEstagios.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEstagios.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcEstagios.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEstagios.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tbcEstagios.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbcEstagios.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEstagios.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcEstagios.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEstagios.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tbcEstagios.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcEstagios.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbcEstagios.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tbcEstagios.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tbcEstagios.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbcEstagios.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tbcEstagios.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tbcEstagios.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tbcEstagios.TabIndex = 0;
            this.tbcEstagios.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcEstagios.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tbcEstagios.SelectedIndexChanged += new System.EventHandler(this.tbcEstagios_SelectedIndexChanged);
            // 
            // tabRetirada
            // 
            this.tabRetirada.AutoScroll = true;
            this.tabRetirada.Controls.Add(this.dbgRetirada);
            this.tabRetirada.Controls.Add(this.pnlFooterRetirada);
            this.tabRetirada.ImageKey = "(nenhum/a)";
            this.tabRetirada.Location = new System.Drawing.Point(4, 44);
            this.tabRetirada.Name = "tabRetirada";
            this.tabRetirada.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetirada.Size = new System.Drawing.Size(1667, 855);
            this.tabRetirada.TabIndex = 0;
            this.tabRetirada.Text = "Retirada de Equipamento";
            this.tabRetirada.UseVisualStyleBackColor = true;
            // 
            // dbgRetirada
            // 
            this.dbgRetirada.AllowUserToAddRows = false;
            this.dbgRetirada.AllowUserToDeleteRows = false;
            this.dbgRetirada.AllowUserToOrderColumns = true;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dbgRetirada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.dbgRetirada.AutoGenerateColumns = false;
            this.dbgRetirada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dbgRetirada.ColumnHeadersHeight = 30;
            this.dbgRetirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgRetirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnRetiradaEdicao,
            this.btnRegistrarRegistrar,
            this.btnRetiradaExcluir,
            this.btnImpressao,
            this.btnMovimentacao,
            this.iDDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.hORADataGridViewTextBoxColumn,
            this.TECNICO_SOLICITANTE,
            this.NUMERO_OS,
            this.rAMALTELDataGridViewTextBoxColumn,
            this.nOMEUSUARIODataGridViewTextBoxColumn,
            this.pREDIOSETORDataGridViewTextBoxColumn,
            this.MODALIDADE,
            this.SITUACAO,
            this.PATRIMONIO,
            this.SAI,
            this.DATA_PREVISTA,
            this.HORA_PREVISTA,
            this.DATA_RETIRADA,
            this.HORA_RETIRADA,
            this.TECNICO_ATUANTE,
            this.ORIGEM});
            this.dbgRetirada.DataSource = this.mOVI_RETIRADABindingSource;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgRetirada.DefaultCellStyle = dataGridViewCellStyle62;
            this.dbgRetirada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgRetirada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dbgRetirada.Location = new System.Drawing.Point(3, 3);
            this.dbgRetirada.MultiSelect = false;
            this.dbgRetirada.Name = "dbgRetirada";
            this.dbgRetirada.ReadOnly = true;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dbgRetirada.RowHeadersVisible = false;
            dataGridViewCellStyle64.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle64.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dbgRetirada.RowTemplate.DividerHeight = 2;
            this.dbgRetirada.Size = new System.Drawing.Size(1661, 823);
            this.dbgRetirada.TabIndex = 5;
            this.dbgRetirada.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightBlue;
            this.dbgRetirada.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dbgRetirada.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dbgRetirada.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dbgRetirada.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dbgRetirada.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dbgRetirada.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dbgRetirada.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dbgRetirada.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.dbgRetirada.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dbgRetirada.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgRetirada.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dbgRetirada.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgRetirada.ThemeStyle.HeaderStyle.Height = 30;
            this.dbgRetirada.ThemeStyle.ReadOnly = true;
            this.dbgRetirada.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.dbgRetirada.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dbgRetirada.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgRetirada.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dbgRetirada.ThemeStyle.RowsStyle.Height = 22;
            this.dbgRetirada.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dbgRetirada.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dbgRetirada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgRetirada_CellContentClick);
            this.dbgRetirada.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dbgRetirada_CellFormatting);
            this.dbgRetirada.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dbgRetirada_CellPainting);
            this.dbgRetirada.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dbgRetirada_RowPrePaint);
            // 
            // btnRetiradaEdicao
            // 
            this.btnRetiradaEdicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle59.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle59.NullValue")));
            this.btnRetiradaEdicao.DefaultCellStyle = dataGridViewCellStyle59;
            this.btnRetiradaEdicao.HeaderText = "Editar:";
            this.btnRetiradaEdicao.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiradaEdicao.Image")));
            this.btnRetiradaEdicao.Name = "btnRetiradaEdicao";
            this.btnRetiradaEdicao.ReadOnly = true;
            this.btnRetiradaEdicao.Width = 51;
            // 
            // btnRegistrarRegistrar
            // 
            this.btnRegistrarRegistrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnRegistrarRegistrar.HeaderText = "Baixar:";
            this.btnRegistrarRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarRegistrar.Image")));
            this.btnRegistrarRegistrar.Name = "btnRegistrarRegistrar";
            this.btnRegistrarRegistrar.ReadOnly = true;
            this.btnRegistrarRegistrar.Width = 53;
            // 
            // btnRetiradaExcluir
            // 
            this.btnRetiradaExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnRetiradaExcluir.HeaderText = "Excluir:";
            this.btnRetiradaExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiradaExcluir.Image")));
            this.btnRetiradaExcluir.Name = "btnRetiradaExcluir";
            this.btnRetiradaExcluir.ReadOnly = true;
            this.btnRetiradaExcluir.Width = 55;
            // 
            // btnImpressao
            // 
            this.btnImpressao.HeaderText = "Impressão:";
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.ReadOnly = true;
            this.btnImpressao.Visible = false;
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnMovimentacao.HeaderText = "Movimentação:";
            this.btnMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentacao.Image")));
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.ReadOnly = true;
            this.btnMovimentacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnMovimentacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnMovimentacao.Visible = false;
            this.btnMovimentacao.Width = 105;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID:";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "Data:";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.ReadOnly = true;
            this.dATADataGridViewTextBoxColumn.Width = 66;
            // 
            // hORADataGridViewTextBoxColumn
            // 
            this.hORADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hORADataGridViewTextBoxColumn.DataPropertyName = "HORA";
            this.hORADataGridViewTextBoxColumn.HeaderText = "Hora:";
            this.hORADataGridViewTextBoxColumn.Name = "hORADataGridViewTextBoxColumn";
            this.hORADataGridViewTextBoxColumn.ReadOnly = true;
            this.hORADataGridViewTextBoxColumn.Width = 66;
            // 
            // TECNICO_SOLICITANTE
            // 
            this.TECNICO_SOLICITANTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TECNICO_SOLICITANTE.DataPropertyName = "TECNICO_SOLICITANTE";
            this.TECNICO_SOLICITANTE.HeaderText = "Técnico Solicitante:";
            this.TECNICO_SOLICITANTE.Name = "TECNICO_SOLICITANTE";
            this.TECNICO_SOLICITANTE.ReadOnly = true;
            this.TECNICO_SOLICITANTE.Width = 134;
            // 
            // NUMERO_OS
            // 
            this.NUMERO_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NUMERO_OS.DataPropertyName = "NUMERO_OS";
            this.NUMERO_OS.HeaderText = "Número O.S.:";
            this.NUMERO_OS.Name = "NUMERO_OS";
            this.NUMERO_OS.ReadOnly = true;
            this.NUMERO_OS.Width = 104;
            // 
            // rAMALTELDataGridViewTextBoxColumn
            // 
            this.rAMALTELDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.rAMALTELDataGridViewTextBoxColumn.DataPropertyName = "RAMAL_TEL";
            this.rAMALTELDataGridViewTextBoxColumn.HeaderText = "Ramal / Tel.:";
            this.rAMALTELDataGridViewTextBoxColumn.Name = "rAMALTELDataGridViewTextBoxColumn";
            this.rAMALTELDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMALTELDataGridViewTextBoxColumn.Width = 102;
            // 
            // nOMEUSUARIODataGridViewTextBoxColumn
            // 
            this.nOMEUSUARIODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nOMEUSUARIODataGridViewTextBoxColumn.DataPropertyName = "NOME_USUARIO";
            this.nOMEUSUARIODataGridViewTextBoxColumn.HeaderText = "Usuário:";
            this.nOMEUSUARIODataGridViewTextBoxColumn.Name = "nOMEUSUARIODataGridViewTextBoxColumn";
            this.nOMEUSUARIODataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMEUSUARIODataGridViewTextBoxColumn.Width = 79;
            // 
            // pREDIOSETORDataGridViewTextBoxColumn
            // 
            this.pREDIOSETORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pREDIOSETORDataGridViewTextBoxColumn.DataPropertyName = "PREDIO_SETOR";
            this.pREDIOSETORDataGridViewTextBoxColumn.HeaderText = "Prédio / Setor:";
            this.pREDIOSETORDataGridViewTextBoxColumn.Name = "pREDIOSETORDataGridViewTextBoxColumn";
            this.pREDIOSETORDataGridViewTextBoxColumn.ReadOnly = true;
            this.pREDIOSETORDataGridViewTextBoxColumn.Width = 109;
            // 
            // MODALIDADE
            // 
            this.MODALIDADE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MODALIDADE.DataPropertyName = "MODALIDADE";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MODALIDADE.DefaultCellStyle = dataGridViewCellStyle60;
            this.MODALIDADE.HeaderText = "Modalidade:";
            this.MODALIDADE.Name = "MODALIDADE";
            this.MODALIDADE.ReadOnly = true;
            this.MODALIDADE.Width = 98;
            // 
            // SITUACAO
            // 
            this.SITUACAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SITUACAO.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SITUACAO.DefaultCellStyle = dataGridViewCellStyle61;
            this.SITUACAO.HeaderText = "Situação:";
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Width = 85;
            // 
            // PATRIMONIO
            // 
            this.PATRIMONIO.DataPropertyName = "PATRIMONIO";
            this.PATRIMONIO.HeaderText = "Patrimonio:";
            this.PATRIMONIO.Name = "PATRIMONIO";
            this.PATRIMONIO.ReadOnly = true;
            // 
            // SAI
            // 
            this.SAI.DataPropertyName = "SAI";
            this.SAI.HeaderText = "SAI.:";
            this.SAI.Name = "SAI";
            this.SAI.ReadOnly = true;
            // 
            // DATA_PREVISTA
            // 
            this.DATA_PREVISTA.DataPropertyName = "DATA_PREVISTA";
            this.DATA_PREVISTA.HeaderText = "Data Prevista:";
            this.DATA_PREVISTA.Name = "DATA_PREVISTA";
            this.DATA_PREVISTA.ReadOnly = true;
            // 
            // HORA_PREVISTA
            // 
            this.HORA_PREVISTA.DataPropertyName = "HORA_PREVISTA";
            this.HORA_PREVISTA.HeaderText = "Hora Prevista:";
            this.HORA_PREVISTA.Name = "HORA_PREVISTA";
            this.HORA_PREVISTA.ReadOnly = true;
            // 
            // DATA_RETIRADA
            // 
            this.DATA_RETIRADA.DataPropertyName = "DATA_RETIRADA";
            this.DATA_RETIRADA.HeaderText = "Data da Retirada:";
            this.DATA_RETIRADA.Name = "DATA_RETIRADA";
            this.DATA_RETIRADA.ReadOnly = true;
            // 
            // HORA_RETIRADA
            // 
            this.HORA_RETIRADA.DataPropertyName = "HORA_RETIRADA";
            this.HORA_RETIRADA.HeaderText = "Hora da Retirada:";
            this.HORA_RETIRADA.Name = "HORA_RETIRADA";
            this.HORA_RETIRADA.ReadOnly = true;
            // 
            // TECNICO_ATUANTE
            // 
            this.TECNICO_ATUANTE.DataPropertyName = "TECNICO_ATUANTE";
            this.TECNICO_ATUANTE.HeaderText = "Técnico Atuante:";
            this.TECNICO_ATUANTE.Name = "TECNICO_ATUANTE";
            this.TECNICO_ATUANTE.ReadOnly = true;
            // 
            // ORIGEM
            // 
            this.ORIGEM.DataPropertyName = "ORIGEM";
            this.ORIGEM.HeaderText = "Origem";
            this.ORIGEM.Name = "ORIGEM";
            this.ORIGEM.ReadOnly = true;
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
            // pnlFooterRetirada
            // 
            this.pnlFooterRetirada.Controls.Add(this.mOVIBindingNavigator);
            this.pnlFooterRetirada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterRetirada.Location = new System.Drawing.Point(3, 826);
            this.pnlFooterRetirada.Name = "pnlFooterRetirada";
            this.pnlFooterRetirada.Size = new System.Drawing.Size(1661, 26);
            this.pnlFooterRetirada.TabIndex = 4;
            // 
            // mOVIBindingNavigator
            // 
            this.mOVIBindingNavigator.AddNewItem = null;
            this.mOVIBindingNavigator.BackColor = System.Drawing.Color.DarkGray;
            this.mOVIBindingNavigator.BindingSource = this.mOVI_RETIRADABindingSource;
            this.mOVIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mOVIBindingNavigator.DeleteItem = null;
            this.mOVIBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mOVIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.toolStripSeparator1,
            this.btnIncluirRETIRADA,
            this.toolStripSeparator7,
            this.btnFiltroRETIRADA,
            this.toolStripSeparator2,
            btnPesquisarRETIRADA,
            this.toolStripSeparator8,
            this.toolStripButton2});
            this.mOVIBindingNavigator.Location = new System.Drawing.Point(0, 1);
            this.mOVIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mOVIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mOVIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mOVIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mOVIBindingNavigator.Name = "mOVIBindingNavigator";
            this.mOVIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mOVIBindingNavigator.Size = new System.Drawing.Size(1661, 25);
            this.mOVIBindingNavigator.TabIndex = 7;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorSeparator.ForeColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorSeparator1.ForeColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.BackColor = System.Drawing.Color.LightGray;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnIncluirRETIRADA
            // 
            this.btnIncluirRETIRADA.BackColor = System.Drawing.Color.LightGray;
            this.btnIncluirRETIRADA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnIncluirRETIRADA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnIncluirRETIRADA.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirRETIRADA.Image")));
            this.btnIncluirRETIRADA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirRETIRADA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluirRETIRADA.Name = "btnIncluirRETIRADA";
            this.btnIncluirRETIRADA.Size = new System.Drawing.Size(247, 22);
            this.btnIncluirRETIRADA.Text = "Registrar: RETIRADA DE EQUIPAMENTO";
            this.btnIncluirRETIRADA.ToolTipText = "Registrar: RETIRADA DE EQUIPAMENTO";
            this.btnIncluirRETIRADA.Click += new System.EventHandler(this.btnIncluirRETIRADA_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.ToolTipText = "Voltar...";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // tabTarefa
            // 
            this.tabTarefa.Controls.Add(this.dbgTarefa);
            this.tabTarefa.Controls.Add(this.pnlFooterTarefa);
            this.tabTarefa.Controls.Add(this.guna2PictureBox2);
            this.tabTarefa.Location = new System.Drawing.Point(4, 44);
            this.tabTarefa.Name = "tabTarefa";
            this.tabTarefa.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefa.Size = new System.Drawing.Size(1667, 855);
            this.tabTarefa.TabIndex = 1;
            this.tabTarefa.Text = "Tarefa Bancada";
            this.tabTarefa.UseVisualStyleBackColor = true;
            // 
            // dbgTarefa
            // 
            this.dbgTarefa.AllowUserToAddRows = false;
            this.dbgTarefa.AllowUserToDeleteRows = false;
            this.dbgTarefa.AllowUserToOrderColumns = true;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dbgTarefa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dbgTarefa.AutoGenerateColumns = false;
            this.dbgTarefa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle50.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dbgTarefa.ColumnHeadersHeight = 30;
            this.dbgTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgTarefa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4,
            this.dataGridViewImageColumn5,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dbgTarefa.DataSource = this.tAREFA_BANCADABindingSource;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgTarefa.DefaultCellStyle = dataGridViewCellStyle54;
            this.dbgTarefa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgTarefa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dbgTarefa.Location = new System.Drawing.Point(3, 3);
            this.dbgTarefa.MultiSelect = false;
            this.dbgTarefa.Name = "dbgTarefa";
            this.dbgTarefa.ReadOnly = true;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.RowHeadersDefaultCellStyle = dataGridViewCellStyle55;
            this.dbgTarefa.RowHeadersVisible = false;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.dbgTarefa.RowTemplate.DividerHeight = 2;
            this.dbgTarefa.Size = new System.Drawing.Size(1661, 823);
            this.dbgTarefa.TabIndex = 6;
            this.dbgTarefa.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.dbgTarefa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dbgTarefa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dbgTarefa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dbgTarefa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dbgTarefa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dbgTarefa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dbgTarefa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dbgTarefa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            this.dbgTarefa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dbgTarefa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgTarefa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dbgTarefa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgTarefa.ThemeStyle.HeaderStyle.Height = 30;
            this.dbgTarefa.ThemeStyle.ReadOnly = true;
            this.dbgTarefa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.dbgTarefa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dbgTarefa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbgTarefa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dbgTarefa.ThemeStyle.RowsStyle.Height = 22;
            this.dbgTarefa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.dbgTarefa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle51.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle51.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle51;
            this.dataGridViewImageColumn1.HeaderText = "Editar:";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 51;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn2.HeaderText = "Baixar:";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 53;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn3.HeaderText = "Excluir:";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 55;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Impressão:";
            this.dataGridViewImageColumn4.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn4.Image")));
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Visible = false;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn5.HeaderText = "Movimentação:";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn5.Visible = false;
            this.dataGridViewImageColumn5.Width = 105;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATA";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HORA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TECNICO_SOLICITANTE";
            this.dataGridViewTextBoxColumn4.HeaderText = "Técnico Solicitante:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 134;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NUMERO_OS";
            this.dataGridViewTextBoxColumn5.HeaderText = "Número O.S.:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 104;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RAMAL_TEL";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ramal / Tel.:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 102;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NOME_USUARIO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Usuário:";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 79;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PREDIO_SETOR";
            this.dataGridViewTextBoxColumn8.HeaderText = "Prédio / Setor:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 109;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MODALIDADE";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle52;
            this.dataGridViewTextBoxColumn9.HeaderText = "Modalidade:";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 98;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle53;
            this.dataGridViewTextBoxColumn10.HeaderText = "Situação:";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PATRIMONIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Patrimonio:";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SAI";
            this.dataGridViewTextBoxColumn12.HeaderText = "SAI.:";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DATA_PREVISTA";
            this.dataGridViewTextBoxColumn13.HeaderText = "Data Prevista:";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HORA_PREVISTA";
            this.dataGridViewTextBoxColumn14.HeaderText = "Hora Prevista:";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "DATA_RETIRADA";
            this.dataGridViewTextBoxColumn15.HeaderText = "Data da Retirada:";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "HORA_RETIRADA";
            this.dataGridViewTextBoxColumn16.HeaderText = "Hora da Retirada:";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TECNICO_ATUANTE";
            this.dataGridViewTextBoxColumn17.HeaderText = "Técnico Atuante:";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ORIGEM";
            this.dataGridViewTextBoxColumn18.HeaderText = "Origem";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // pnlFooterTarefa
            // 
            this.pnlFooterTarefa.Controls.Add(this.bindingNavigator1);
            this.pnlFooterTarefa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterTarefa.Location = new System.Drawing.Point(3, 826);
            this.pnlFooterTarefa.Name = "pnlFooterTarefa";
            this.pnlFooterTarefa.Size = new System.Drawing.Size(1661, 26);
            this.pnlFooterTarefa.TabIndex = 5;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.DarkGray;
            this.bindingNavigator1.BindingSource = this.mOVI_RETIRADABindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.btnIncluirTAREFA,
            this.toolStripSeparator6,
            this.btnVoltarTAREFA});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 1);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1661, 25);
            this.bindingNavigator1.TabIndex = 8;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Mover primeiro";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover anterior";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover próximo";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Mover último";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnIncluirTAREFA
            // 
            this.btnIncluirTAREFA.BackColor = System.Drawing.Color.LightGray;
            this.btnIncluirTAREFA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirTAREFA.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIncluirTAREFA.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirTAREFA.Image")));
            this.btnIncluirTAREFA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirTAREFA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluirTAREFA.Name = "btnIncluirTAREFA";
            this.btnIncluirTAREFA.Size = new System.Drawing.Size(185, 22);
            this.btnIncluirTAREFA.Text = "Registrar: TAREFA BANCADA";
            this.btnIncluirTAREFA.ToolTipText = "Registrar: TAREFA BANCADA";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnVoltarTAREFA
            // 
            this.btnVoltarTAREFA.BackColor = System.Drawing.Color.LightGray;
            this.btnVoltarTAREFA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVoltarTAREFA.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnVoltarTAREFA.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarTAREFA.Image")));
            this.btnVoltarTAREFA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVoltarTAREFA.Name = "btnVoltarTAREFA";
            this.btnVoltarTAREFA.Size = new System.Drawing.Size(23, 22);
            this.btnVoltarTAREFA.ToolTipText = "Voltar...";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(6, 6);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(16, 16);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // tabEntrega
            // 
            this.tabEntrega.Controls.Add(this.guna2PictureBox3);
            this.tabEntrega.Location = new System.Drawing.Point(4, 44);
            this.tabEntrega.Name = "tabEntrega";
            this.tabEntrega.Size = new System.Drawing.Size(1667, 855);
            this.tabEntrega.TabIndex = 2;
            this.tabEntrega.Text = "Entrega de Equipamento";
            this.tabEntrega.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(16, 16);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // elpGrid
            // 
            this.elpGrid.BorderRadius = 10;
            this.elpGrid.TargetControl = this.dbgRetirada;
            // 
            // elpTab
            // 
            this.elpTab.BorderRadius = 10;
            this.elpTab.TargetControl = this.tbcEstagios;
            // 
            // mOVI_RETIRADATableAdapter
            // 
            this.mOVI_RETIRADATableAdapter.ClearBeforeFill = true;
            // 
            // elpGridTarefa
            // 
            this.elpGridTarefa.BorderRadius = 10;
            this.elpGridTarefa.TargetControl = this.dbgTarefa;
            // 
            // tAREFA_BANCADABindingSource
            // 
            this.tAREFA_BANCADABindingSource.DataMember = "TAREFA_BANCADA";
            this.tAREFA_BANCADABindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // tAREFA_BANCADATableAdapter
            // 
            this.tAREFA_BANCADATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager.MOVI_RETIRADATableAdapter = this.mOVI_RETIRADATableAdapter;
            this.tableAdapterManager.MOVITableAdapter = null;
            this.tableAdapterManager.NUMERACAO_IDTableAdapter = null;
            this.tableAdapterManager.SERVICOSTableAdapter = null;
            this.tableAdapterManager.TAREFA_BANCADATableAdapter = this.tAREFA_BANCADATableAdapter;
            this.tableAdapterManager.TECNICOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // btnFiltroRETIRADA
            // 
            this.btnFiltroRETIRADA.BackColor = System.Drawing.Color.LightGray;
            this.btnFiltroRETIRADA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnFiltroRETIRADA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnFiltroRETIRADA.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroRETIRADA.Image")));
            this.btnFiltroRETIRADA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroRETIRADA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltroRETIRADA.Name = "btnFiltroRETIRADA";
            this.btnFiltroRETIRADA.Size = new System.Drawing.Size(73, 22);
            this.btnFiltroRETIRADA.Text = "FILTRAR";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPesquisarRETIRADA
            // 
            btnPesquisarRETIRADA.BackColor = System.Drawing.Color.LightGray;
            btnPesquisarRETIRADA.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            btnPesquisarRETIRADA.ForeColor = System.Drawing.Color.RoyalBlue;
            btnPesquisarRETIRADA.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarRETIRADA.Image")));
            btnPesquisarRETIRADA.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPesquisarRETIRADA.Name = "btnPesquisarRETIRADA";
            btnPesquisarRETIRADA.Size = new System.Drawing.Size(92, 22);
            btnPesquisarRETIRADA.Text = "PESQUISAR";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // FrmMoviList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1675, 943);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviList";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Text = "FrmMoviList";
            this.Load += new System.EventHandler(this.FrmMoviList_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.tbcEstagios.ResumeLayout(false);
            this.tabRetirada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgRetirada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.pnlFooterRetirada.ResumeLayout(false);
            this.pnlFooterRetirada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingNavigator)).EndInit();
            this.mOVIBindingNavigator.ResumeLayout(false);
            this.mOVIBindingNavigator.PerformLayout();
            this.tabTarefa.ResumeLayout(false);
            this.tabTarefa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTarefa)).EndInit();
            this.pnlFooterTarefa.ResumeLayout(false);
            this.pnlFooterTarefa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFA_BANCADABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private helpdesk01DataSet helpdesk01DataSet;
        private Guna.UI2.WinForms.Guna2TabControl tbcEstagios;
        private TabPage tabRetirada;
        private TabPage tabTarefa;
        private TabPage tabEntrega;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel pnlFooterRetirada;
        private BindingNavigator mOVIBindingNavigator;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnIncluirRETIRADA;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton2;
        private Guna.UI2.WinForms.Guna2DataGridView dbgRetirada;
        private DataGridViewTextBoxColumn sITUACAODataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Elipse elpGrid;
        private Guna.UI2.WinForms.Guna2Elipse elpTab;
        private BindingSource mOVI_RETIRADABindingSource;
        private helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private DataGridViewImageColumn btnRetiradaEdicao;
        private DataGridViewImageColumn btnRegistrarRegistrar;
        private DataGridViewImageColumn btnRetiradaExcluir;
        private DataGridViewImageColumn btnImpressao;
        private DataGridViewImageColumn btnMovimentacao;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hORADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TECNICO_SOLICITANTE;
        private DataGridViewTextBoxColumn NUMERO_OS;
        private DataGridViewTextBoxColumn rAMALTELDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nOMEUSUARIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pREDIOSETORDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn MODALIDADE;
        private DataGridViewTextBoxColumn SITUACAO;
        private DataGridViewTextBoxColumn PATRIMONIO;
        private DataGridViewTextBoxColumn SAI;
        private DataGridViewTextBoxColumn DATA_PREVISTA;
        private DataGridViewTextBoxColumn HORA_PREVISTA;
        private DataGridViewTextBoxColumn DATA_RETIRADA;
        private DataGridViewTextBoxColumn HORA_RETIRADA;
        private DataGridViewTextBoxColumn TECNICO_ATUANTE;
        private DataGridViewTextBoxColumn ORIGEM;
        private Guna.UI2.WinForms.Guna2Panel pnlFooterTarefa;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnIncluirTAREFA;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnVoltarTAREFA;
        private Guna.UI2.WinForms.Guna2DataGridView dbgTarefa;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewImageColumn dataGridViewImageColumn4;
        private DataGridViewImageColumn dataGridViewImageColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private Guna.UI2.WinForms.Guna2Elipse elpGridTarefa;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private BindingSource tAREFA_BANCADABindingSource;
        private helpdesk01DataSetTableAdapters.TAREFA_BANCADATableAdapter tAREFA_BANCADATableAdapter;
        private helpdesk01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton btnFiltroRETIRADA;
        private ToolStripSeparator toolStripSeparator8;
    }
}