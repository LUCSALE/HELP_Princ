using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMoviRetiradaUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviRetiradaUpdate));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.mOVI_RETIRADABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpdesk01DataSet = new HELP_Princ.helpdesk01DataSet();
            this.pnlGrid = new Guna.UI2.WinForms.Guna2Panel();
            this.gbxModalidade = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rtbSimples = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rtbTarefa_Bancada = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbtAgendamento = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmiEfeitos = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mOVI_RETIRADATableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter();
            this.tECNICOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tECNICOSTableAdapter = new HELP_Princ.helpdesk01DataSetTableAdapters.TECNICOSTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).BeginInit();
            this.pnlGrid.SuspendLayout();
            this.gbxModalidade.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(364, 92);
            this.pnlHeader.TabIndex = 0;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(157, 70);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(331, 10);
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
            this.lblTitulo.Location = new System.Drawing.Point(32, 43);
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
            this.pnlFooter.Controls.Add(this.button1);
            this.pnlFooter.Controls.Add(this.button2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 213);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(364, 36);
            this.pnlFooter.TabIndex = 3;
            this.pnlFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFooter_Paint);
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
            this.pnlGrid.Location = new System.Drawing.Point(0, 94);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(364, 119);
            this.pnlGrid.TabIndex = 4;
            // 
            // gbxModalidade
            // 
            this.gbxModalidade.BackColor = System.Drawing.Color.Transparent;
            this.gbxModalidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gbxModalidade.BorderColor = System.Drawing.Color.Black;
            this.gbxModalidade.BorderRadius = 10;
            this.gbxModalidade.Controls.Add(this.guna2GroupBox1);
            this.gbxModalidade.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbxModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxModalidade.FillColor = System.Drawing.Color.WhiteSmoke;
            this.gbxModalidade.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.gbxModalidade.ForeColor = System.Drawing.Color.Black;
            this.gbxModalidade.Location = new System.Drawing.Point(0, 0);
            this.gbxModalidade.Name = "gbxModalidade";
            this.gbxModalidade.Size = new System.Drawing.Size(364, 119);
            this.gbxModalidade.TabIndex = 43;
            this.gbxModalidade.TabStop = false;
            this.gbxModalidade.Text = "Modalidade:";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.rtbSimples);
            this.guna2GroupBox1.Controls.Add(this.rtbTarefa_Bancada);
            this.guna2GroupBox1.Controls.Add(this.rbtAgendamento);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 31);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(338, 66);
            this.guna2GroupBox1.TabIndex = 46;
            this.guna2GroupBox1.TabStop = false;
            this.guna2GroupBox1.Text = "Salvar como ???";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
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
            this.rtbSimples.Location = new System.Drawing.Point(219, 32);
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
            // rtbTarefa_Bancada
            // 
            this.rtbTarefa_Bancada.Animated = true;
            this.rtbTarefa_Bancada.AutoSize = true;
            this.rtbTarefa_Bancada.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbTarefa_Bancada.CheckedState.BorderThickness = 0;
            this.rtbTarefa_Bancada.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rtbTarefa_Bancada.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rtbTarefa_Bancada.CheckedState.InnerOffset = -4;
            this.rtbTarefa_Bancada.Location = new System.Drawing.Point(3, 32);
            this.rtbTarefa_Bancada.Name = "rtbTarefa_Bancada";
            this.rtbTarefa_Bancada.Size = new System.Drawing.Size(104, 19);
            this.rtbTarefa_Bancada.TabIndex = 51;
            this.rtbTarefa_Bancada.Text = "Tarefa Bancada";
            this.rtbTarefa_Bancada.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rtbTarefa_Bancada.UncheckedState.BorderThickness = 2;
            this.rtbTarefa_Bancada.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rtbTarefa_Bancada.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rtbTarefa_Bancada.Click += new System.EventHandler(this.rtbSubstituicao_Click);
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
            this.rbtAgendamento.Location = new System.Drawing.Point(112, 32);
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
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(88, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(13, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmMoviRetiradaUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(364, 249);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMoviRetiradaUpdate";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMoviRetiradaUpdate";
            this.Activated += new System.EventHandler(this.FrmMoviRetiradaUpdate_Activated);
            this.Load += new System.EventHandler(this.FrmMoviRetiradaUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMoviRetiradaUpdate_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mOVI_RETIRADABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpdesk01DataSet)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.gbxModalidade.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private BindingSource mOVI_RETIRADABindingSource;
        private helpdesk01DataSetTableAdapters.MOVI_RETIRADATableAdapter mOVI_RETIRADATableAdapter;
        private Guna.UI2.WinForms.Guna2GroupBox gbxModalidade;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rbtAgendamento;
        private ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2RadioButton rtbSimples;
        private Guna.UI2.WinForms.Guna2RadioButton rtbTarefa_Bancada;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private BindingSource tECNICOSBindingSource;
        private helpdesk01DataSetTableAdapters.TECNICOSTableAdapter tECNICOSTableAdapter;
        private Button button1;
        private Button button2;
    }
}