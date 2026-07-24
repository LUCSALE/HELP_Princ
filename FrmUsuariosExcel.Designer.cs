namespace HELP_Princ
{
    partial class FrmUsuariosExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosExcel));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlForm = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblMensagem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtArquivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPèsquisar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.tableAdapterManager = new HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager();
            this.uSUARIOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.USUARIOSTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblLogo)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
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
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.guna2ControlBox3);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.LightGray;
            this.pnlHeader.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(591, 87);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(82, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(445, 28);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Importação EXCEL";
            this.lblTitulo.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(533, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox3.TabIndex = 3;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(562, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderRadius = 10;
            this.pnlFooter.BorderThickness = 1;
            this.pnlFooter.Controls.Add(this.bindingNavigator1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFooter.FillColor2 = System.Drawing.Color.LightGray;
            this.pnlFooter.Location = new System.Drawing.Point(0, 306);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(591, 26);
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
            this.bindingNavigator1.Size = new System.Drawing.Size(591, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripButton.Text = "Importar EXCEL";
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
            this.pnlForm.Controls.Add(this.textBox1);
            this.pnlForm.Controls.Add(this.lblMensagem);
            this.pnlForm.Controls.Add(this.txtArquivo);
            this.pnlForm.Controls.Add(this.btnPèsquisar);
            this.pnlForm.Controls.Add(this.guna2HtmlLabel4);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.FillColor = System.Drawing.Color.LightGray;
            this.pnlForm.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlForm.Location = new System.Drawing.Point(0, 87);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(591, 219);
            this.pnlForm.TabIndex = 5;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = false;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(0, 191);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(591, 28);
            this.lblMensagem.TabIndex = 26;
            this.lblMensagem.Text = "Importando PLANILHA - Por Favor AGUARDE ...";
            this.lblMensagem.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Animated = true;
            this.txtArquivo.AutoRoundedCorners = true;
            this.txtArquivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArquivo.DefaultText = "";
            this.txtArquivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArquivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArquivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArquivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArquivo.Enabled = false;
            this.txtArquivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArquivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.txtArquivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArquivo.Location = new System.Drawing.Point(5, 27);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.PlaceholderText = "";
            this.txtArquivo.SelectedText = "";
            this.txtArquivo.Size = new System.Drawing.Size(582, 28);
            this.txtArquivo.TabIndex = 25;
            this.txtArquivo.TabStop = false;
            // 
            // btnPèsquisar
            // 
            this.btnPèsquisar.Animated = true;
            this.btnPèsquisar.AutoRoundedCorners = true;
            this.btnPèsquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPèsquisar.BorderColor = System.Drawing.Color.LightGray;
            this.btnPèsquisar.BorderThickness = 1;
            this.btnPèsquisar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnPèsquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPèsquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPèsquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPèsquisar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPèsquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPèsquisar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPèsquisar.FillColor2 = System.Drawing.Color.LightGray;
            this.btnPèsquisar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnPèsquisar.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPèsquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPèsquisar.Image")));
            this.btnPèsquisar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPèsquisar.IndicateFocus = true;
            this.btnPèsquisar.Location = new System.Drawing.Point(5, 61);
            this.btnPèsquisar.Name = "btnPèsquisar";
            this.btnPèsquisar.Size = new System.Drawing.Size(582, 26);
            this.btnPèsquisar.TabIndex = 24;
            this.btnPèsquisar.Text = "Pesquisar...";
            this.btnPèsquisar.UseTransparentBackground = true;
            this.btnPèsquisar.Click += new System.EventHandler(this.btnPèsquisar_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.DarkGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(3, 6);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel4.TabIndex = 23;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "Arquivo:";
            // 
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.helpdesk01DataSet;
            this.uSUARIOSBindingSource.CurrentChanged += new System.EventHandler(this.sERVICOSBindingSource_CurrentChanged);
            // 
            // helpdesk01DataSet
            // 
            this.helpdesk01DataSet.DataSetName = "helpdesk01DataSet";
            this.helpdesk01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SERVICOSTableAdapter = null;
            this.tableAdapterManager.TECNICOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HELP_Princ.helpdesk01DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = this.uSUARIOSTableAdapter;
            // 
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "NOME_USUARIO", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(5, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 20);
            this.textBox1.TabIndex = 27;
            // 
            // FrmUsuariosExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(591, 332);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUsuariosExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUsuariosExcel_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
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
        private Guna.UI2.WinForms.Guna2PictureBox lblLogo;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private helpdesk01DataSet helpdesk01DataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private helpdesk01DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnPèsquisar;
        private Guna.UI2.WinForms.Guna2TextBox txtArquivo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitulo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMensagem;
        private helpdesk01DataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}