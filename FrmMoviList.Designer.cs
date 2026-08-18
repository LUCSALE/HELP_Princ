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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.tbcEstagios = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabRetirada = new System.Windows.Forms.TabPage();
            this.dbgRetirada = new Guna.UI2.WinForms.Guna2DataGridView();
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
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.elpGrid = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpTab = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.btnRetiradaEdicao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRegistrarRegistrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImpressao = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.btnRetiradaExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1156, 38);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(523, 3);
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
            this.pnlGrid.Size = new System.Drawing.Size(1156, 472);
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
            this.tbcEstagios.Size = new System.Drawing.Size(1156, 472);
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
            this.tabRetirada.Controls.Add(this.dbgRetirada);
            this.tabRetirada.Controls.Add(this.pnlFooterRetirada);
            this.tabRetirada.ImageKey = "(nenhum/a)";
            this.tabRetirada.Location = new System.Drawing.Point(4, 44);
            this.tabRetirada.Name = "tabRetirada";
            this.tabRetirada.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetirada.Size = new System.Drawing.Size(1148, 424);
            this.tabRetirada.TabIndex = 0;
            this.tabRetirada.Text = "Retirada de Equipamento";
            this.tabRetirada.UseVisualStyleBackColor = true;
            // 
            // dbgRetirada
            // 
            this.dbgRetirada.AllowUserToAddRows = false;
            this.dbgRetirada.AllowUserToDeleteRows = false;
            this.dbgRetirada.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dbgRetirada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dbgRetirada.AutoGenerateColumns = false;
            this.dbgRetirada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dbgRetirada.ColumnHeadersHeight = 30;
            this.dbgRetirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgRetirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnRetiradaEdicao,
            this.btnRegistrarRegistrar,
            this.btnImpressao,
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
            this.btnRetiradaExcluir,
            this.Column1});
            this.dbgRetirada.DataSource = this.mOVI_RETIRADABindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgRetirada.DefaultCellStyle = dataGridViewCellStyle6;
            this.dbgRetirada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgRetirada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dbgRetirada.Location = new System.Drawing.Point(3, 3);
            this.dbgRetirada.MultiSelect = false;
            this.dbgRetirada.Name = "dbgRetirada";
            this.dbgRetirada.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dbgRetirada.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dbgRetirada.RowTemplate.DividerHeight = 2;
            this.dbgRetirada.Size = new System.Drawing.Size(1142, 392);
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
            this.pnlFooterRetirada.Location = new System.Drawing.Point(3, 395);
            this.pnlFooterRetirada.Name = "pnlFooterRetirada";
            this.pnlFooterRetirada.Size = new System.Drawing.Size(1142, 26);
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
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.mOVIBindingNavigator.Location = new System.Drawing.Point(0, 1);
            this.mOVIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mOVIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mOVIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mOVIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mOVIBindingNavigator.Name = "mOVIBindingNavigator";
            this.mOVIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mOVIBindingNavigator.Size = new System.Drawing.Size(1142, 25);
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
            this.btnIncluirRETIRADA.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnIncluirRETIRADA.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirRETIRADA.Image")));
            this.btnIncluirRETIRADA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirRETIRADA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncluirRETIRADA.Name = "btnIncluirRETIRADA";
            this.btnIncluirRETIRADA.Size = new System.Drawing.Size(232, 22);
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
            this.tabTarefa.Controls.Add(this.guna2PictureBox2);
            this.tabTarefa.Location = new System.Drawing.Point(4, 44);
            this.tabTarefa.Name = "tabTarefa";
            this.tabTarefa.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefa.Size = new System.Drawing.Size(1148, 424);
            this.tabTarefa.TabIndex = 1;
            this.tabTarefa.Text = "Tarefa Bancada";
            this.tabTarefa.UseVisualStyleBackColor = true;
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
            this.tabEntrega.Size = new System.Drawing.Size(1148, 424);
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
            // btnRetiradaEdicao
            // 
            this.btnRetiradaEdicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.btnRetiradaEdicao.DefaultCellStyle = dataGridViewCellStyle3;
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
            // btnImpressao
            // 
            this.btnImpressao.HeaderText = "Impressão:";
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.ReadOnly = true;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MODALIDADE.DefaultCellStyle = dataGridViewCellStyle4;
            this.MODALIDADE.HeaderText = "Modalidade:";
            this.MODALIDADE.Name = "MODALIDADE";
            this.MODALIDADE.ReadOnly = true;
            this.MODALIDADE.Width = 98;
            // 
            // SITUACAO
            // 
            this.SITUACAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SITUACAO.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SITUACAO.DefaultCellStyle = dataGridViewCellStyle5;
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
            // btnRetiradaExcluir
            // 
            this.btnRetiradaExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.btnRetiradaExcluir.HeaderText = "Excluir ?";
            this.btnRetiradaExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnRetiradaExcluir.Image")));
            this.btnRetiradaExcluir.Name = "btnRetiradaExcluir";
            this.btnRetiradaExcluir.ReadOnly = true;
            this.btnRetiradaExcluir.Width = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FrmMoviList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1156, 512);
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
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
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
        private DataGridViewImageColumn btnImpressao;
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
        private DataGridViewImageColumn btnRetiradaExcluir;
        private DataGridViewImageColumn Column1;
    }
}