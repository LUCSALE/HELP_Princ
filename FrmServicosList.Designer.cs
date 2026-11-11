using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmServicosList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicosList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.dbgServicos = new System.Windows.Forms.DataGridView();
            this.btnEdicao = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExclusao = new System.Windows.Forms.DataGridViewImageColumn();
            this.ATIVO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.helpdesk01DataSet = new HELP_Princ.HelpdeskDataSet();
            this.sERVICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICOSTableAdapter = new HELP_Princ.HelpdeskDataSetTableAdapters.SERVICOSTableAdapter();
            this.tableAdapterManager = new HELP_Princ.HelpdeskDataSetTableAdapters.TableAdapterManager();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAOSERVICODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTIVODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORADESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1675, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SlateGray;
            this.lblTitulo.Location = new System.Drawing.Point(785, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = false;
            this.lblTitulo.Text = "Serviços";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.bindingNavigator1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 917);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1675, 26);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.sERVICOSBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1675, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(146, 22);
            this.bindingNavigatorAddNewItem.Text = "Incluir NOVO SERVIÇO";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dbgServicos);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 59);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1675, 858);
            this.pnlGrid.TabIndex = 4;
            // 
            // dbgServicos
            // 
            this.dbgServicos.AllowUserToAddRows = false;
            this.dbgServicos.AllowUserToDeleteRows = false;
            this.dbgServicos.AllowUserToOrderColumns = true;
            this.dbgServicos.AutoGenerateColumns = false;
            this.dbgServicos.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbgServicos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dbgServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEdicao,
            this.btnExclusao,
            this.ATIVO2,
            this.iDDataGridViewTextBoxColumn,
            this.dATADataGridViewTextBoxColumn,
            this.hORADataGridViewTextBoxColumn,
            this.dESCRICAOSERVICODataGridViewTextBoxColumn,
            this.aTIVODataGridViewTextBoxColumn,
            this.dATADESDataGridViewTextBoxColumn,
            this.hORADESDataGridViewTextBoxColumn});
            this.dbgServicos.DataSource = this.sERVICOSBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbgServicos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dbgServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgServicos.Location = new System.Drawing.Point(0, 0);
            this.dbgServicos.Name = "dbgServicos";
            this.dbgServicos.ReadOnly = true;
            this.dbgServicos.Size = new System.Drawing.Size(1675, 858);
            this.dbgServicos.TabIndex = 0;
            this.dbgServicos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbgTecnicos_CellContentClick);
            // 
            // btnEdicao
            // 
            this.btnEdicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnEdicao.HeaderText = "";
            this.btnEdicao.Image = ((System.Drawing.Image)(resources.GetObject("btnEdicao.Image")));
            this.btnEdicao.Name = "btnEdicao";
            this.btnEdicao.ReadOnly = true;
            this.btnEdicao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdicao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdicao.Width = 19;
            // 
            // btnExclusao
            // 
            this.btnExclusao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.btnExclusao.HeaderText = "";
            this.btnExclusao.Image = ((System.Drawing.Image)(resources.GetObject("btnExclusao.Image")));
            this.btnExclusao.Name = "btnExclusao";
            this.btnExclusao.ReadOnly = true;
            this.btnExclusao.Width = 5;
            // 
            // ATIVO2
            // 
            this.ATIVO2.DataPropertyName = "ATIVO2";
            this.ATIVO2.HeaderText = "Ativo:";
            this.ATIVO2.Name = "ATIVO2";
            this.ATIVO2.ReadOnly = true;
            this.ATIVO2.Width = 50;
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "HelpdeskDataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICOSBindingSource
            // 
            this.sERVICOSBindingSource.DataMember = "SERVICOS";
            this.sERVICOSBindingSource.DataSource = this.helpdesk01DataSet;
            // 
            // sERVICOSTableAdapter
            // 
            this.sERVICOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPAMENTOSTableAdapter = null;
            this.tableAdapterManager.SERVICOSTableAdapter = this.sERVICOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.HelpdeskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATADataGridViewTextBoxColumn
            // 
            this.dATADataGridViewTextBoxColumn.DataPropertyName = "DATA";
            this.dATADataGridViewTextBoxColumn.HeaderText = "DATA";
            this.dATADataGridViewTextBoxColumn.Name = "dATADataGridViewTextBoxColumn";
            this.dATADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORADataGridViewTextBoxColumn
            // 
            this.hORADataGridViewTextBoxColumn.DataPropertyName = "HORA";
            this.hORADataGridViewTextBoxColumn.HeaderText = "HORA";
            this.hORADataGridViewTextBoxColumn.Name = "hORADataGridViewTextBoxColumn";
            this.hORADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCRICAOSERVICODataGridViewTextBoxColumn
            // 
            this.dESCRICAOSERVICODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO_SERVICO";
            this.dESCRICAOSERVICODataGridViewTextBoxColumn.HeaderText = "DESCRICAO_SERVICO";
            this.dESCRICAOSERVICODataGridViewTextBoxColumn.Name = "dESCRICAOSERVICODataGridViewTextBoxColumn";
            this.dESCRICAOSERVICODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTIVODataGridViewTextBoxColumn
            // 
            this.aTIVODataGridViewTextBoxColumn.DataPropertyName = "ATIVO";
            this.aTIVODataGridViewTextBoxColumn.HeaderText = "ATIVO";
            this.aTIVODataGridViewTextBoxColumn.Name = "aTIVODataGridViewTextBoxColumn";
            this.aTIVODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATADESDataGridViewTextBoxColumn
            // 
            this.dATADESDataGridViewTextBoxColumn.DataPropertyName = "DATA_DES";
            this.dATADESDataGridViewTextBoxColumn.HeaderText = "DATA_DES";
            this.dATADESDataGridViewTextBoxColumn.Name = "dATADESDataGridViewTextBoxColumn";
            this.dATADESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hORADESDataGridViewTextBoxColumn
            // 
            this.hORADESDataGridViewTextBoxColumn.DataPropertyName = "HORA_DES";
            this.hORADESDataGridViewTextBoxColumn.HeaderText = "HORA_DES";
            this.hORADESDataGridViewTextBoxColumn.Name = "hORADESDataGridViewTextBoxColumn";
            this.hORADESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmServicosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1675, 943);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServicosList";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Text = "FrmServicosList";
            this.Load += new System.EventHandler(this.FrmServicosList_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2Panel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlGrid;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private DataGridView dbgServicos;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private DataGridViewImageColumn btnEdicao;
        private DataGridViewImageColumn btnExclusao;
        private DataGridViewTextBoxColumn ATIVO2;
        private HelpdeskDataSet helpdesk01DataSet;
        private BindingSource sERVICOSBindingSource;
        private HelpdeskDataSetTableAdapters.SERVICOSTableAdapter sERVICOSTableAdapter;
        private HelpdeskDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hORADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dESCRICAOSERVICODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aTIVODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dATADESDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hORADESDataGridViewTextBoxColumn;
    }
}