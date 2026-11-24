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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblModalidade = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.elpGrid = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dbgRetirada = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRetiradaEdicao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRegistrarRegistrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFreeze = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRetiradaExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImpressao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnMovimentacao = new System.Windows.Forms.DataGridViewImageColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSINATURA = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.aSSINATURA_MOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdeskDataSet = new HELP_Princ.HelpdeskDataSet();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.elpTab = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpGridTarefa = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dbgTarefa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFreeze_Tarefa_Bancada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.tAREFA_BANCADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.tbcEstagios = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabRetirada = new System.Windows.Forms.TabPage();
            this.tabTarefa = new System.Windows.Forms.TabPage();
            this.pnlFooterTarefa = new Guna.UI2.WinForms.Guna2Panel();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncluirTAREFA = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVoltarTAREFA = new System.Windows.Forms.ToolStripButton();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabEntrega = new System.Windows.Forms.TabPage();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.elpPesquisar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tAREFA_BANCADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TAREFA_BANCADATableAdapter();
            this.tableAdapterManager = new HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager();
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.HelpdeskDataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.aSSINATURA_MOVI_RETIRADATableAdapter = new HELP_Princ.HelpdeskDataSetTableAdapters.ASSINATURA_MOVI_RETIRADATableAdapter();
            this.tableAdapterManager1 = new HELP_Princ.HelpdeskDataSetTableAdapters.TableAdapterManager();
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
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgRetirada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSINATURA_MOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdeskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFA_BANCADABindingSource)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.tbcEstagios.SuspendLayout();
            this.tabRetirada.SuspendLayout();
            this.tabTarefa.SuspendLayout();
            this.pnlFooterTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.tabEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingNavigator)).BeginInit();
            this.mOVIBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.SlateGray;
            this.pnlHeader.BorderRadius = 10;
            this.pnlHeader.BorderThickness = 1;
            this.pnlHeader.Controls.Add(this.lblModalidade);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1675, 38);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblModalidade
            // 
            this.lblModalidade.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModalidade.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblModalidade.Location = new System.Drawing.Point(1477, 11);
            this.lblModalidade.Name = "lblModalidade";
            this.lblModalidade.Size = new System.Drawing.Size(138, 15);
            this.lblModalidade.TabIndex = 1;
            this.lblModalidade.TabStop = false;
            this.lblModalidade.Text = "Modalidade: PESQUISA";
            this.lblModalidade.TextChanged += new System.EventHandler(this.lblModalidade_TextChanged);
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
            this.lblTitulo.TextChanged += new System.EventHandler(this.lblTitulo_TextChanged);
            // 
            // elpGrid
            // 
            this.elpGrid.BorderRadius = 10;
            this.elpGrid.TargetControl = this.dbgRetirada;
            // 
            // dbgRetirada
            // 
            this.dbgRetirada.AllowUserToAddRows = false;
            this.dbgRetirada.AllowUserToDeleteRows = false;
            this.dbgRetirada.AllowUserToOrderColumns = true;
            dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.dbgRetirada.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle69;
            this.dbgRetirada.AutoGenerateColumns = false;
            this.dbgRetirada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dbgRetirada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dbgRetirada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle70.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle70;
            this.dbgRetirada.ColumnHeadersHeight = 30;
            this.dbgRetirada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgRetirada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnRetiradaEdicao,
            this.btnRegistrarRegistrar,
            this.btnFreeze,
            this.btnRetiradaExcluir,
            this.btnImpressao,
            this.btnMovimentacao,
            this.iDDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.hORADataGridViewTextBoxColumn,
            this.ASSINATURA,
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
            this.dbgRetirada.DataSource = this.aSSINATURA_MOVI_RETIRADABindingSource;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle75.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle75.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgRetirada.DefaultCellStyle = dataGridViewCellStyle75;
            this.dbgRetirada.Dock = System.Windows.Forms.DockStyle.Top;
            this.dbgRetirada.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.dbgRetirada.Location = new System.Drawing.Point(3, 3);
            this.dbgRetirada.MultiSelect = false;
            this.dbgRetirada.Name = "dbgRetirada";
            this.dbgRetirada.ReadOnly = true;
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle76.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle76.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle76.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle76.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowHeadersDefaultCellStyle = dataGridViewCellStyle76;
            this.dbgRetirada.RowHeadersVisible = false;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgRetirada.RowsDefaultCellStyle = dataGridViewCellStyle77;
            this.dbgRetirada.RowTemplate.DividerHeight = 2;
            this.dbgRetirada.RowTemplate.Height = 80;
            this.dbgRetirada.Size = new System.Drawing.Size(1661, 780);
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
            this.dbgRetirada.ThemeStyle.RowsStyle.Height = 80;
            this.dbgRetirada.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.dbgRetirada.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dbgRetirada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgRetirada_CellContentClick);
            // 
            // btnRetiradaEdicao
            // 
            this.btnRetiradaEdicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle71.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle71.NullValue")));
            this.btnRetiradaEdicao.DefaultCellStyle = dataGridViewCellStyle71;
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
            // btnFreeze
            // 
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle72.NullValue = false;
            this.btnFreeze.DefaultCellStyle = dataGridViewCellStyle72;
            this.btnFreeze.HeaderText = "Freeze:";
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.ReadOnly = true;
            this.btnFreeze.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnFreeze.Width = 56;
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
            this.btnImpressao.Width = 72;
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
            // ASSINATURA
            // 
            this.ASSINATURA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ASSINATURA.DataPropertyName = "ASSINATURA";
            this.ASSINATURA.HeaderText = "Técnico Solicitante:";
            this.ASSINATURA.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ASSINATURA.Name = "ASSINATURA";
            this.ASSINATURA.ReadOnly = true;
            this.ASSINATURA.Width = 115;
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
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.MODALIDADE.DefaultCellStyle = dataGridViewCellStyle73;
            this.MODALIDADE.HeaderText = "Modalidade:";
            this.MODALIDADE.Name = "MODALIDADE";
            this.MODALIDADE.ReadOnly = true;
            this.MODALIDADE.Width = 98;
            // 
            // SITUACAO
            // 
            this.SITUACAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SITUACAO.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SITUACAO.DefaultCellStyle = dataGridViewCellStyle74;
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
            this.PATRIMONIO.Width = 92;
            // 
            // SAI
            // 
            this.SAI.DataPropertyName = "SAI";
            this.SAI.HeaderText = "SAI.:";
            this.SAI.Name = "SAI";
            this.SAI.ReadOnly = true;
            this.SAI.Width = 63;
            // 
            // DATA_PREVISTA
            // 
            this.DATA_PREVISTA.DataPropertyName = "DATA_PREVISTA";
            this.DATA_PREVISTA.HeaderText = "Data Prevista:";
            this.DATA_PREVISTA.Name = "DATA_PREVISTA";
            this.DATA_PREVISTA.ReadOnly = true;
            this.DATA_PREVISTA.Width = 107;
            // 
            // HORA_PREVISTA
            // 
            this.HORA_PREVISTA.DataPropertyName = "HORA_PREVISTA";
            this.HORA_PREVISTA.HeaderText = "Hora Prevista:";
            this.HORA_PREVISTA.Name = "HORA_PREVISTA";
            this.HORA_PREVISTA.ReadOnly = true;
            this.HORA_PREVISTA.Width = 107;
            // 
            // DATA_RETIRADA
            // 
            this.DATA_RETIRADA.DataPropertyName = "DATA_RETIRADA";
            this.DATA_RETIRADA.HeaderText = "Data da Retirada:";
            this.DATA_RETIRADA.Name = "DATA_RETIRADA";
            this.DATA_RETIRADA.ReadOnly = true;
            this.DATA_RETIRADA.Width = 124;
            // 
            // HORA_RETIRADA
            // 
            this.HORA_RETIRADA.DataPropertyName = "HORA_RETIRADA";
            this.HORA_RETIRADA.HeaderText = "Hora da Retirada:";
            this.HORA_RETIRADA.Name = "HORA_RETIRADA";
            this.HORA_RETIRADA.ReadOnly = true;
            this.HORA_RETIRADA.Width = 124;
            // 
            // TECNICO_ATUANTE
            // 
            this.TECNICO_ATUANTE.DataPropertyName = "TECNICO_ATUANTE";
            this.TECNICO_ATUANTE.HeaderText = "Técnico Atuante:";
            this.TECNICO_ATUANTE.Name = "TECNICO_ATUANTE";
            this.TECNICO_ATUANTE.ReadOnly = true;
            this.TECNICO_ATUANTE.Width = 122;
            // 
            // ORIGEM
            // 
            this.ORIGEM.DataPropertyName = "ORIGEM";
            this.ORIGEM.HeaderText = "Origem";
            this.ORIGEM.Name = "ORIGEM";
            this.ORIGEM.ReadOnly = true;
            this.ORIGEM.Width = 73;
            // 
            // aSSINATURA_MOVI_RETIRADABindingSource
            // 
            this.aSSINATURA_MOVI_RETIRADABindingSource.DataMember = "ASSINATURA_MOVI_RETIRADA";
            this.aSSINATURA_MOVI_RETIRADABindingSource.DataSource = this.helpdeskDataSet;
            // 
            // helpdeskDataSet
            // 
            this.helpdeskDataSet.DataSetName = "HelpdeskDataSet";
            this.helpdeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVI_RETIRADABindingSource
            // 
            this.mOVI_RETIRADABindingSource.DataMember = "MOVI_RETIRADA";
            this.mOVI_RETIRADABindingSource.DataSource = this.helpdeskDataSet;
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "helpdesk01DataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // elpTab
            // 
            this.elpTab.BorderRadius = 10;
            // 
            // elpGridTarefa
            // 
            this.elpGridTarefa.BorderRadius = 10;
            this.elpGridTarefa.TargetControl = this.dbgTarefa;
            // 
            // dbgTarefa
            // 
            this.dbgTarefa.AllowUserToAddRows = false;
            this.dbgTarefa.AllowUserToDeleteRows = false;
            this.dbgTarefa.AllowUserToOrderColumns = true;
            dataGridViewCellStyle78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.dbgTarefa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle78;
            this.dbgTarefa.AutoGenerateColumns = false;
            this.dbgTarefa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(194)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle79.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.dbgTarefa.ColumnHeadersHeight = 30;
            this.dbgTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dbgTarefa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.btnFreeze_Tarefa_Bancada,
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
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle83.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle83.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle83.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle83.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgTarefa.DefaultCellStyle = dataGridViewCellStyle83;
            this.dbgTarefa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgTarefa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.dbgTarefa.Location = new System.Drawing.Point(3, 3);
            this.dbgTarefa.MultiSelect = false;
            this.dbgTarefa.Name = "dbgTarefa";
            this.dbgTarefa.ReadOnly = true;
            dataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle84.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle84.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle84.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.RowHeadersDefaultCellStyle = dataGridViewCellStyle84;
            this.dbgTarefa.RowHeadersVisible = false;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle85.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgTarefa.RowsDefaultCellStyle = dataGridViewCellStyle85;
            this.dbgTarefa.RowTemplate.DividerHeight = 2;
            this.dbgTarefa.Size = new System.Drawing.Size(1661, 782);
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
            this.dbgTarefa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgTarefa_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle80.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle80.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle80;
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
            // btnFreeze_Tarefa_Bancada
            // 
            this.btnFreeze_Tarefa_Bancada.HeaderText = "Freeze:";
            this.btnFreeze_Tarefa_Bancada.Name = "btnFreeze_Tarefa_Bancada";
            this.btnFreeze_Tarefa_Bancada.ReadOnly = true;
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
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle81;
            this.dataGridViewTextBoxColumn9.HeaderText = "Modalidade:";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 98;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SITUACAO";
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle82;
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
            // tAREFA_BANCADABindingSource
            // 
            this.tAREFA_BANCADABindingSource.DataMember = "TAREFA_BANCADA";
            this.tAREFA_BANCADABindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.tbcEstagios);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGrid.Location = new System.Drawing.Point(0, 40);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1675, 862);
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
            this.tbcEstagios.Size = new System.Drawing.Size(1675, 862);
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
            this.tbcEstagios.TabIndex = 9;
            this.tbcEstagios.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbcEstagios.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabRetirada
            // 
            this.tabRetirada.AutoScroll = true;
            this.tabRetirada.Controls.Add(this.mOVIBindingNavigator);
            this.tabRetirada.Controls.Add(this.dbgRetirada);
            this.tabRetirada.ImageKey = "(nenhum/a)";
            this.tabRetirada.Location = new System.Drawing.Point(4, 44);
            this.tabRetirada.Name = "tabRetirada";
            this.tabRetirada.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetirada.Size = new System.Drawing.Size(1667, 814);
            this.tabRetirada.TabIndex = 0;
            this.tabRetirada.Text = "Retirada de Equipamento";
            this.tabRetirada.UseVisualStyleBackColor = true;
            // 
            // tabTarefa
            // 
            this.tabTarefa.Controls.Add(this.dbgTarefa);
            this.tabTarefa.Controls.Add(this.pnlFooterTarefa);
            this.tabTarefa.Controls.Add(this.guna2PictureBox2);
            this.tabTarefa.Location = new System.Drawing.Point(4, 44);
            this.tabTarefa.Name = "tabTarefa";
            this.tabTarefa.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarefa.Size = new System.Drawing.Size(1667, 814);
            this.tabTarefa.TabIndex = 1;
            this.tabTarefa.Text = "Tarefa Bancada";
            this.tabTarefa.UseVisualStyleBackColor = true;
            // 
            // pnlFooterTarefa
            // 
            this.pnlFooterTarefa.Controls.Add(this.bindingNavigator2);
            this.pnlFooterTarefa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooterTarefa.Location = new System.Drawing.Point(3, 785);
            this.pnlFooterTarefa.Name = "pnlFooterTarefa";
            this.pnlFooterTarefa.Size = new System.Drawing.Size(1661, 26);
            this.pnlFooterTarefa.TabIndex = 5;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.Color.DarkGray;
            this.bindingNavigator2.BindingSource = this.mOVI_RETIRADABindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel2;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator11,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator12,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator13,
            this.btnIncluirTAREFA,
            this.toolStripSeparator14,
            this.btnVoltarTAREFA});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 1);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton8;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton11;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton10;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton9;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(1661, 25);
            this.bindingNavigator2.TabIndex = 8;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.LightGray;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "de {0}";
            this.toolStripLabel2.ToolTipText = "Número total de itens";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Mover primeiro";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Mover anterior";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator11.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Posição";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator12.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Mover próximo";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.BackColor = System.Drawing.Color.LightGray;
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.ForeColor = System.Drawing.Color.DarkOrange;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Mover último";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator13.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.BackColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator14.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
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
            this.tabEntrega.Size = new System.Drawing.Size(1667, 814);
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
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.SlateGray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnPesquisar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 902);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1675, 41);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPesquisar.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(0, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(1675, 39);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            // 
            // elpPesquisar
            // 
            this.elpPesquisar.BorderRadius = 20;
            this.elpPesquisar.TargetControl = this.btnPesquisar;
            // 
            // tAREFA_BANCADATableAdapter
            // 
            this.tAREFA_BANCADATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager.MOVI_RETIRADATableAdapter = null;
            this.tableAdapterManager.MOVITableAdapter = null;
            this.tableAdapterManager.NUMERACAO_IDTableAdapter = null;
            this.tableAdapterManager.SERVICOSTableAdapter = null;
            this.tableAdapterManager.TAREFA_BANCADATableAdapter = this.tAREFA_BANCADATableAdapter;
            this.tableAdapterManager.TECNICOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // tmiEfeitos
            // 
            this.tmiEfeitos.Interval = 700;
            this.tmiEfeitos.Tick += new System.EventHandler(this.tmiEfeitos_Tick);
            // 
            // mOVI_RETIRADATableAdapter
            // 
            this.mOVI_RETIRADATableAdapter.ClearBeforeFill = true;
            // 
            // aSSINATURA_MOVI_RETIRADATableAdapter
            // 
            this.aSSINATURA_MOVI_RETIRADATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager1.MOVI_RETIRADATableAdapter = this.mOVI_RETIRADATableAdapter;
            this.tableAdapterManager1.NUMERACAO_IDTableAdapter = null;
            this.tableAdapterManager1.SERVICOSTableAdapter = null;
            this.tableAdapterManager1.TAREFA_BANCADATableAdapter = null;
            this.tableAdapterManager1.TECNICOSTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = HELP_Princ.HelpdeskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USUARIOSTableAdapter = null;
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
            this.toolStripSeparator8,
            this.toolStripButton2});
            this.mOVIBindingNavigator.Location = new System.Drawing.Point(3, 786);
            this.mOVIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mOVIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mOVIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mOVIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mOVIBindingNavigator.Name = "mOVIBindingNavigator";
            this.mOVIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mOVIBindingNavigator.Size = new System.Drawing.Size(1661, 25);
            this.mOVIBindingNavigator.TabIndex = 10;
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
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
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
            // FrmMoviList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1675, 943);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviList";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Text = "FrmMoviList";
            this.Activated += new System.EventHandler(this.FrmMoviList_Activated);
            this.Load += new System.EventHandler(this.FrmMoviList_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgRetirada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSINATURA_MOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdeskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAREFA_BANCADABindingSource)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.tbcEstagios.ResumeLayout(false);
            this.tabRetirada.ResumeLayout(false);
            this.tabRetirada.PerformLayout();
            this.tabTarefa.ResumeLayout(false);
            this.tabTarefa.PerformLayout();
            this.pnlFooterTarefa.ResumeLayout(false);
            this.pnlFooterTarefa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.tabEntrega.ResumeLayout(false);
            this.tabEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mOVIBindingNavigator)).EndInit();
            this.mOVIBindingNavigator.ResumeLayout(false);
            this.mOVIBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private helpdesk01DataSet helpdesk01DataSet;
        private DataGridViewTextBoxColumn sITUACAODataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Elipse elpGrid;
        private Guna.UI2.WinForms.Guna2Elipse elpTab;
        private BindingSource mOVI_RETIRADABindingSource;
        private Guna.UI2.WinForms.Guna2Elipse elpGridTarefa;
        private BindingSource tAREFA_BANCADABindingSource;
        private helpdesk01DataSetTableAdapters.TAREFA_BANCADATableAdapter tAREFA_BANCADATableAdapter;
        private helpdesk01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private Guna.UI2.WinForms.Guna2TabControl tbcEstagios;
        private TabPage tabRetirada;
        private Guna.UI2.WinForms.Guna2DataGridView dbgRetirada;
        private TabPage tabTarefa;
        private Guna.UI2.WinForms.Guna2DataGridView dbgTarefa;
        private Guna.UI2.WinForms.Guna2Panel pnlFooterTarefa;
        private BindingNavigator bindingNavigator2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton8;
        private ToolStripButton toolStripButton9;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButton10;
        private ToolStripButton toolStripButton11;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripButton btnIncluirTAREFA;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripButton btnVoltarTAREFA;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private TabPage tabEntrega;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Elipse elpPesquisar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblModalidade;
        private Timer tmiEfeitos;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewCheckBoxColumn btnFreeze_Tarefa_Bancada;
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
        private HelpdeskDataSet helpdeskDataSet;
        private HelpdeskDataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private BindingSource aSSINATURA_MOVI_RETIRADABindingSource;
        private HelpdeskDataSetTableAdapters.ASSINATURA_MOVI_RETIRADATableAdapter aSSINATURA_MOVI_RETIRADATableAdapter;
        private HelpdeskDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private DataGridViewImageColumn btnRetiradaEdicao;
        private DataGridViewImageColumn btnRegistrarRegistrar;
        private DataGridViewCheckBoxColumn btnFreeze;
        private DataGridViewImageColumn btnRetiradaExcluir;
        private DataGridViewImageColumn btnImpressao;
        private DataGridViewImageColumn btnMovimentacao;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hORADataGridViewTextBoxColumn;
        private DataGridViewImageColumn ASSINATURA;
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
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton2;
    }
}