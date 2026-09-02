using System.Drawing;
using System.Windows.Forms;

namespace HELP_Princ
{
    partial class FrmMenuPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlLateral = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlLateralHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCopy = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblVersao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlBotoes = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnIndicadores = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnConsultaDinamica = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnEquipamentos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnQUICKMOVI = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnServicos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSair = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnMovimentacoes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTecnicos = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSistema = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlForm = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlLateral.SuspendLayout();
            this.pnlLateralHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.pnlLateralHeader);
            this.pnlLateral.Controls.Add(this.pnlBotoes);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.FillColor = System.Drawing.Color.LightGray;
            this.pnlLateral.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(243, 1080);
            this.pnlLateral.TabIndex = 1;
            // 
            // pnlLateralHeader
            // 
            this.pnlLateralHeader.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLateralHeader.BorderThickness = 1;
            this.pnlLateralHeader.Controls.Add(this.guna2PictureBox3);
            this.pnlLateralHeader.Controls.Add(this.guna2HtmlLabel2);
            this.pnlLateralHeader.Controls.Add(this.guna2HtmlLabel1);
            this.pnlLateralHeader.Controls.Add(this.lblCopy);
            this.pnlLateralHeader.Controls.Add(this.lblVersao);
            this.pnlLateralHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLateralHeader.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLateralHeader.FillColor2 = System.Drawing.Color.LightGray;
            this.pnlLateralHeader.Location = new System.Drawing.Point(0, 1028);
            this.pnlLateralHeader.Name = "pnlLateralHeader";
            this.pnlLateralHeader.Size = new System.Drawing.Size(243, 52);
            this.pnlLateralHeader.TabIndex = 12;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.AutoRoundedCorners = true;
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BorderRadius = 13;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(3, 5);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Padding = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox3.Size = new System.Drawing.Size(38, 29);
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(76, 26);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(105, 17);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Copyright Ⓒ 2026";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(81, 26);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 17);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Versão: 0.00.000";
            // 
            // lblCopy
            // 
            this.lblCopy.BackColor = System.Drawing.Color.Transparent;
            this.lblCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(76, 22);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(105, 17);
            this.lblCopy.TabIndex = 1;
            this.lblCopy.Text = "Copyright Ⓒ 2026";
            // 
            // lblVersao
            // 
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(81, 3);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(95, 17);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão: 0.00.000";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.Transparent;
            this.pnlBotoes.Controls.Add(this.guna2GradientButton1);
            this.pnlBotoes.Controls.Add(this.btnIndicadores);
            this.pnlBotoes.Controls.Add(this.btnConsultaDinamica);
            this.pnlBotoes.Controls.Add(this.guna2Separator2);
            this.pnlBotoes.Controls.Add(this.guna2Separator1);
            this.pnlBotoes.Controls.Add(this.btnEquipamentos);
            this.pnlBotoes.Controls.Add(this.btnQUICKMOVI);
            this.pnlBotoes.Controls.Add(this.btnUsuarios);
            this.pnlBotoes.Controls.Add(this.btnServicos);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnMovimentacoes);
            this.pnlBotoes.Controls.Add(this.btnTecnicos);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 181);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(243, 367);
            this.pnlBotoes.TabIndex = 11;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.LightGray;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.LightGray;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.IndicateFocus = true;
            this.guna2GradientButton1.Location = new System.Drawing.Point(-1, 290);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(243, 33);
            this.guna2GradientButton1.TabIndex = 13;
            this.guna2GradientButton1.Text = "Gestão PAINEL";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // btnIndicadores
            // 
            this.btnIndicadores.Animated = true;
            this.btnIndicadores.AutoRoundedCorners = true;
            this.btnIndicadores.BorderColor = System.Drawing.Color.LightGray;
            this.btnIndicadores.BorderThickness = 1;
            this.btnIndicadores.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnIndicadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIndicadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIndicadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIndicadores.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIndicadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIndicadores.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnIndicadores.FillColor2 = System.Drawing.Color.LightGray;
            this.btnIndicadores.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnIndicadores.ForeColor = System.Drawing.Color.SlateGray;
            this.btnIndicadores.Image = ((System.Drawing.Image)(resources.GetObject("btnIndicadores.Image")));
            this.btnIndicadores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIndicadores.IndicateFocus = true;
            this.btnIndicadores.Location = new System.Drawing.Point(-1, 254);
            this.btnIndicadores.Name = "btnIndicadores";
            this.btnIndicadores.Size = new System.Drawing.Size(243, 33);
            this.btnIndicadores.TabIndex = 12;
            this.btnIndicadores.Text = "Indicadores";
            this.btnIndicadores.UseTransparentBackground = true;
            // 
            // btnConsultaDinamica
            // 
            this.btnConsultaDinamica.Animated = true;
            this.btnConsultaDinamica.AutoRoundedCorners = true;
            this.btnConsultaDinamica.BorderColor = System.Drawing.Color.LightGray;
            this.btnConsultaDinamica.BorderThickness = 1;
            this.btnConsultaDinamica.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnConsultaDinamica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaDinamica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConsultaDinamica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaDinamica.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConsultaDinamica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConsultaDinamica.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultaDinamica.FillColor2 = System.Drawing.Color.LightGray;
            this.btnConsultaDinamica.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnConsultaDinamica.ForeColor = System.Drawing.Color.SlateGray;
            this.btnConsultaDinamica.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaDinamica.Image")));
            this.btnConsultaDinamica.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConsultaDinamica.IndicateFocus = true;
            this.btnConsultaDinamica.Location = new System.Drawing.Point(-1, 219);
            this.btnConsultaDinamica.Name = "btnConsultaDinamica";
            this.btnConsultaDinamica.Size = new System.Drawing.Size(243, 33);
            this.btnConsultaDinamica.TabIndex = 11;
            this.btnConsultaDinamica.Text = "Consulta Dinamica";
            this.btnConsultaDinamica.UseTransparentBackground = true;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator2.Location = new System.Drawing.Point(2, 321);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(240, 10);
            this.guna2Separator2.TabIndex = 10;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 137);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(240, 10);
            this.guna2Separator1.TabIndex = 9;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.Animated = true;
            this.btnEquipamentos.AnimatedGIF = true;
            this.btnEquipamentos.AutoRoundedCorners = true;
            this.btnEquipamentos.BorderColor = System.Drawing.Color.LightGray;
            this.btnEquipamentos.BorderThickness = 1;
            this.btnEquipamentos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnEquipamentos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEquipamentos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEquipamentos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquipamentos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEquipamentos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEquipamentos.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnEquipamentos.FillColor2 = System.Drawing.Color.LightGray;
            this.btnEquipamentos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnEquipamentos.ForeColor = System.Drawing.Color.SlateGray;
            this.btnEquipamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamentos.Image")));
            this.btnEquipamentos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEquipamentos.IndicateFocus = true;
            this.btnEquipamentos.Location = new System.Drawing.Point(0, 102);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(243, 33);
            this.btnEquipamentos.TabIndex = 8;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.UseTransparentBackground = true;
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // btnQUICKMOVI
            // 
            this.btnQUICKMOVI.Animated = true;
            this.btnQUICKMOVI.AutoRoundedCorners = true;
            this.btnQUICKMOVI.BorderColor = System.Drawing.Color.LightGray;
            this.btnQUICKMOVI.BorderThickness = 1;
            this.btnQUICKMOVI.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnQUICKMOVI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQUICKMOVI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQUICKMOVI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQUICKMOVI.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQUICKMOVI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQUICKMOVI.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnQUICKMOVI.FillColor2 = System.Drawing.Color.LightGray;
            this.btnQUICKMOVI.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnQUICKMOVI.ForeColor = System.Drawing.Color.SlateGray;
            this.btnQUICKMOVI.Image = ((System.Drawing.Image)(resources.GetObject("btnQUICKMOVI.Image")));
            this.btnQUICKMOVI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQUICKMOVI.IndicateFocus = true;
            this.btnQUICKMOVI.Location = new System.Drawing.Point(0, 184);
            this.btnQUICKMOVI.Name = "btnQUICKMOVI";
            this.btnQUICKMOVI.Size = new System.Drawing.Size(243, 33);
            this.btnQUICKMOVI.TabIndex = 7;
            this.btnQUICKMOVI.Text = "QUICK MOVI";
            this.btnQUICKMOVI.UseTransparentBackground = true;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.AnimatedGIF = true;
            this.btnUsuarios.AutoRoundedCorners = true;
            this.btnUsuarios.BorderColor = System.Drawing.Color.LightGray;
            this.btnUsuarios.BorderThickness = 1;
            this.btnUsuarios.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnUsuarios.FillColor2 = System.Drawing.Color.LightGray;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnUsuarios.ForeColor = System.Drawing.Color.SlateGray;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.IndicateFocus = true;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 68);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(243, 33);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.UseTransparentBackground = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Animated = true;
            this.btnServicos.AnimatedGIF = true;
            this.btnServicos.AutoRoundedCorners = true;
            this.btnServicos.BorderColor = System.Drawing.Color.LightGray;
            this.btnServicos.BorderThickness = 1;
            this.btnServicos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnServicos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServicos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServicos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServicos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServicos.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnServicos.FillColor2 = System.Drawing.Color.LightGray;
            this.btnServicos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnServicos.ForeColor = System.Drawing.Color.SlateGray;
            this.btnServicos.Image = ((System.Drawing.Image)(resources.GetObject("btnServicos.Image")));
            this.btnServicos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnServicos.IndicateFocus = true;
            this.btnServicos.Location = new System.Drawing.Point(0, 34);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(243, 33);
            this.btnServicos.TabIndex = 5;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseTransparentBackground = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Animated = true;
            this.btnSair.AutoRoundedCorners = true;
            this.btnSair.BorderColor = System.Drawing.Color.LightGray;
            this.btnSair.BorderThickness = 1;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FillColor2 = System.Drawing.Color.LightGray;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnSair.ForeColor = System.Drawing.Color.SlateGray;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSair.IndicateFocus = true;
            this.btnSair.Location = new System.Drawing.Point(0, 334);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(243, 33);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseTransparentBackground = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.Animated = true;
            this.btnMovimentacoes.AutoRoundedCorners = true;
            this.btnMovimentacoes.BorderColor = System.Drawing.Color.LightGray;
            this.btnMovimentacoes.BorderThickness = 1;
            this.btnMovimentacoes.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnMovimentacoes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMovimentacoes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMovimentacoes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovimentacoes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMovimentacoes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMovimentacoes.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovimentacoes.FillColor2 = System.Drawing.Color.LightGray;
            this.btnMovimentacoes.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnMovimentacoes.ForeColor = System.Drawing.Color.SlateGray;
            this.btnMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentacoes.Image")));
            this.btnMovimentacoes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMovimentacoes.IndicateFocus = true;
            this.btnMovimentacoes.Location = new System.Drawing.Point(0, 149);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Size = new System.Drawing.Size(243, 33);
            this.btnMovimentacoes.TabIndex = 1;
            this.btnMovimentacoes.Text = "Movimentações";
            this.btnMovimentacoes.UseTransparentBackground = true;
            this.btnMovimentacoes.Click += new System.EventHandler(this.btnMovimentacoes_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.Animated = true;
            this.btnTecnicos.AnimatedGIF = true;
            this.btnTecnicos.AutoRoundedCorners = true;
            this.btnTecnicos.BorderColor = System.Drawing.Color.LightGray;
            this.btnTecnicos.BorderThickness = 1;
            this.btnTecnicos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnTecnicos.DefaultAutoSize = true;
            this.btnTecnicos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTecnicos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTecnicos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTecnicos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTecnicos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTecnicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTecnicos.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTecnicos.FillColor2 = System.Drawing.Color.LightGray;
            this.btnTecnicos.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnTecnicos.ForeColor = System.Drawing.Color.SlateGray;
            this.btnTecnicos.Image = ((System.Drawing.Image)(resources.GetObject("btnTecnicos.Image")));
            this.btnTecnicos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTecnicos.IndicateFocus = true;
            this.btnTecnicos.Location = new System.Drawing.Point(0, 0);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(243, 33);
            this.btnTecnicos.TabIndex = 0;
            this.btnTecnicos.Text = "Técnicos";
            this.btnTecnicos.UseTransparentBackground = true;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.guna2PictureBox1);
            this.pnlLogo.Controls.Add(this.guna2PictureBox2);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(243, 181);
            this.pnlLogo.TabIndex = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(99, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(140, 64);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Padding = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox2.Size = new System.Drawing.Size(243, 181);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 11;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.guna2ControlBox2);
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel4);
            this.pnlHeader.Controls.Add(this.guna2HtmlLabel3);
            this.pnlHeader.Controls.Add(this.lblSistema);
            this.pnlHeader.Controls.Add(this.guna2ControlBox3);
            this.pnlHeader.Controls.Add(this.guna2ControlBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.LightGray;
            this.pnlHeader.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlHeader.Location = new System.Drawing.Point(243, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1677, 87);
            this.pnlHeader.TabIndex = 2;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(704, 53);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(255, 23);
            this.guna2HtmlLabel4.TabIndex = 6;
            this.guna2HtmlLabel4.Text = "Movimentação de Equipamentos";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bauhaus 93", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(73, 6);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(1516, 75);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "HELP-DESK \r\n";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSistema
            // 
            this.lblSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblSistema.Font = new System.Drawing.Font("Arial", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.Location = new System.Drawing.Point(2, 27);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Padding = new System.Windows.Forms.Padding(10);
            this.lblSistema.Size = new System.Drawing.Size(67, 32);
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = "HELP_Princ";
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(1595, 3);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(1648, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.FillColor = System.Drawing.Color.LightGray;
            this.pnlForm.Font = new System.Drawing.Font("Berlin Sans FB Demi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForm.Location = new System.Drawing.Point(243, 87);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1677, 1070);
            this.pnlForm.TabIndex = 14;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox2.BorderColor = System.Drawing.Color.Silver;
            this.guna2ControlBox2.BorderRadius = 10;
            this.guna2ControlBox2.BorderThickness = 1;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.LightGray;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1622, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 25);
            this.guna2ControlBox2.TabIndex = 7;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load_1);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMenuPrincipal_Paint);
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateralHeader.ResumeLayout(false);
            this.pnlLateralHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLateral;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel pnlBotoes;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlLateralHeader;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlForm;
        private Guna.UI2.WinForms.Guna2GradientButton btnTecnicos;
        private Guna.UI2.WinForms.Guna2GradientButton btnMovimentacoes;
        private Guna.UI2.WinForms.Guna2GradientButton btnSair;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblVersao;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCopy;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnServicos;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsuarios;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSistema;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2GradientButton btnQUICKMOVI;
        private Guna.UI2.WinForms.Guna2GradientButton btnEquipamentos;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2GradientButton btnIndicadores;
        private Guna.UI2.WinForms.Guna2GradientButton btnConsultaDinamica;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}