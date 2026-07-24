using System;
using System.Drawing; // Necessário para Color
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

using System.Diagnostics.Eventing.Reader;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Texts;

using System.Net;
using System.Net.Mail;
using System.IO;


namespace HELP_Princ
{
    public partial class FrmMoviRetiradaImpressao : Form
    {
        public FrmMoviRetiradaImpressao()
        {
            InitializeComponent();

            this.AutoScroll = true; // Habilita a barra de rolagem automática
        }


        private void FrmMoviRetiradaImpressao_Load(object sender, EventArgs e)
        {
            tmiEfeitos.Start();

            // Execute a consulta: MOVI_RETIRADA
            try
            {
                this.mOVI_RETIRADATableAdapter.FillByID(this.helpdesk01DataSet.MOVI_RETIRADA, InfoPesq.ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao CONSULTAR (SELECT): MOVI_RETIRADA: " + ex.Message);
                this.Close();
            }

            fcnDesativaCampos();
            fcnGeraPDF();
            fcnImpressao();

        }


        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dbgTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {


        }

        private void dbgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {


        }

        private void txtNOME_USUARIO_Enter(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtESTAGIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmiEfeitos_Tick(object sender, EventArgs e)
        {
            // Alterna entre Vermelho e a cor SlateGray
            lblTitulo.ForeColor = (lblTitulo.ForeColor == Color.SlateGray) ? Color.Red : Color.SlateGray;


            // Opcional: Alternar a visibilidade em vez da cor
            // label1.Visible = !label1.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void txtRAMAL_TEL_Leave(object sender, EventArgs e)
        {

        }

        private void FrmMoviRetiradaImpressao_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }


        private void rbtSDDsim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRAMAL_TEL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtNOME_USUARIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtPREDIO_SETOR_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtArea_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtPATRIMONIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPATRIMONIO_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtSAI_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbxEquipamento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void txtDESCRICA_ATIVIDADE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbtnNovoEquipamento_Click(object sender, EventArgs e)
        {

        }


        private void FrmMoviRetiradaImpressao_Activated(object sender, EventArgs e)
        {

        }

        private void txtDATA_PREVISTA_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSAI_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDESCRICA_ATIVIDADE_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            InfoWork.MoviRetiradaUpdate = "N";

        }

        private void rbtAgendamento_Click(object sender, EventArgs e)
        {

        }

        private void rtbSimples_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rtbSimples_Click(object sender, EventArgs e)
        {

        }

        private void rtbSubstituicao_Click(object sender, EventArgs e)
        {

        }

        private void rbtManutencao_Click(object sender, EventArgs e)
        {

        }

        private void cbtnNovoTecnico_Click(object sender, EventArgs e)
        {

        }

        private void fcnDesativaCampos()
        {

            foreach (Control c in this.gbxIdentificacao.Controls)
            {
                if (c is TextBox)
                {
                    c.Enabled = false; // Desativa o campo  
                }
            }

        }

        private void btnImpressao_Click(object sender, EventArgs e)
        {
            fcnImpressao();
            //this.Close();
        }

        private void fcnImpressao()
        {
            this.pdfViewer1.LoadFromFile(@"C:\Windows\Temp\TAREFA_BANCADA.pdf");

        }

        private void fcnGeraPDF()
        {

            // 1. Carrega o documento
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"E:\DESENVOL_WEB\HELP_Princ\modelo_pdf\MODELO_TAREFA_BANCADA.pdf");

            // Carrega a imagem
            PdfImage logo = PdfImage.FromFile(@"E:\DESENVOL_WEB\HELP_Princ\Imagens\Assinaturas\ass_Luciano.png");

            // 2. Percorre as páginas
            foreach (PdfPageBase page in doc.Pages)
            {
                // Cria o substituidor para a página atual
                PdfTextReplacer replacer = new PdfTextReplacer(page);

                // Substitui todo o texto correspondente - Cabeçalho
                replacer.ReplaceAllText("{numero_os}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("NUMERO_OS").Trim());
                replacer.ReplaceAllText("{SITUACAO}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("SITUACAO").Trim());

                // Primeira Linha: substitui os campos 
                replacer.ReplaceAllText("{ID}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<int>("ID").ToString());
                replacer.ReplaceAllText("{DATA}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<DateTime>("DATA").ToString("dd/MM/yyyy"));
                replacer.ReplaceAllText("{HORA}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<TimeSpan>("HORA").ToString(@"hh\:mm"));
                replacer.ReplaceAllText("{DATA_P}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<DateTime>("DATA_PREVISTA").ToString("dd/MM/yyyy"));
                replacer.ReplaceAllText("{HORA_P}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<TimeSpan>("HORA_PREVISTA").ToString(@"hh\:mm"));
                replacer.ReplaceAllText("{TECNICO_SOLICITANTE}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("TECNICO_SOLICITANTE").Trim());

                // Segunda Linha: substitui os campos 
                replacer.ReplaceAllText("{RAMAL}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("RAMAL_TEL").Trim());
                replacer.ReplaceAllText("{NOME_USUARIO}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("NOME_USUARIO").Trim());
                replacer.ReplaceAllText("{PREDIO_SETOR}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("PREDIO_SETOR").Trim());
                replacer.ReplaceAllText("{AREA}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("AREA").Trim());


                // Terceira Linha: substitui os campos 
                replacer.ReplaceAllText("{PATRIMONIO}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("PATRIMONIO").Trim());
                replacer.ReplaceAllText("{SAI}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("SAI").Trim());
                replacer.ReplaceAllText("{PRIORIDADE}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("PRIORIDADE").Trim());
                replacer.ReplaceAllText("{EQUIPAMENTO}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("EQUIPAMENTO").Trim());

                replacer.ReplaceAllText("{SSD}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("SSD").Trim());
                replacer.ReplaceAllText("{OFFI}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("OFFICE_365").Trim());
                replacer.ReplaceAllText("{MAIN}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("MAINFRAME").Trim());


                replacer.ReplaceAllText("{CNS}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("CNS").Trim());
                replacer.ReplaceAllText("{BOT}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("BOTAO_EMERGENCIA").Trim());
                replacer.ReplaceAllText("{PLA}", helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("OFFICE_365_PLAN").Trim());


                //Impressão MANUAL dos campos MEMO´S
                string obsImportantes = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("OBS_IMPORTANTES") ?? "";
                string Descrica_Atividade = helpdesk01DataSet.MOVI_RETIRADA.Rows[0].Field<string>("DESCRICA_ATIVIDADE") ?? "";
                PdfFont cabecalho = new PdfFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold);
                page.Canvas.DrawString(Descrica_Atividade, cabecalho, PdfBrushes.Black, new RectangleF(38, 540, 520, 710));
                page.Canvas.DrawString(obsImportantes, cabecalho, PdfBrushes.Black, new RectangleF(38, 660, 520, 820));

                // Insere a imagem
                page.Canvas.DrawImage(logo, 36, 745, 450, 100);

            }

            // 3. Salva o resultado em .PDF e .HTML
            doc.SaveToFile(@"C:\Windows\Temp\TAREFA_BANCADA.pdf");
            doc.SaveToFile(@"C:\Windows\Temp\TAREFA_BANCADA_HTML.html", FileFormat.HTML);

            doc.Close();





            //PdfDocument pdf = new PdfDocument();
            //PdfPageBase pagina = pdf.Pages.Add();

            //float y = 40;

            //// Título
            //PdfFont titulo = new PdfFont(PdfFontFamily.Helvetica, 30 , PdfFontStyle.Bold);
            //pagina.Canvas.DrawString("T A R E F A  B A N C A D A", titulo,
            //                         PdfBrushes.Black, 180, y);

            //y += 40;

            //// Cabeçalhos
            //PdfFont cabecalho = new PdfFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold);

            //pagina.Canvas.DrawString("Código", cabecalho, PdfBrushes.Black, 20, y);
            //pagina.Canvas.DrawString("Nome", cabecalho, PdfBrushes.Black, 90, y);
            //pagina.Canvas.DrawString("Cidade", cabecalho, PdfBrushes.Black, 300, y);

            //y += 20;

            //// Linha separadora
            //pagina.Canvas.DrawLine(
            //    new PdfPen(Color.Black, 1),
            //    20, y, 550, y);

            //y += 10;


            //pdf.SaveToFile(@"C:\Windows\Temp\MOVI_RETIRADA.pdf");
            //pdf.Close();
        }

        private void btnEMail_Click(object sender, EventArgs e)
        {
            fcnEnviaEmailTexto();
            //fcnEnviaEmailHTML();
            
        }

        private void fcnEnviaEmailTexto()
        {
            try
            {
                MailMessage email = new MailMessage();

                email.From = new MailAddress("luciano.ale@santacasasp.org.br");
                email.To.Add("helpdesk@santacasasp.org.br");
                email.Subject = "Teste Incial - TAREFA BANCADA - Versão: 1.12 (Assinatura)";
                email.Body = "Este e-mail foi enviado pelo APP HELP_Princ.";
                email.IsBodyHtml = false;

                // Anexo (opcional)
                email.Attachments.Add(new Attachment(@"C:\Windows\Temp\TAREFA_BANCADA.pdf"));

                SmtpClient smtp = new SmtpClient("smtp.santacasasp.org.br", 587);
                smtp.Credentials = new NetworkCredential(
                    "luciano.ale@santacasasp.org.br",
                    "Mag160163@"
                );
                smtp.EnableSsl = false;

                smtp.Send(email);

                MessageBox.Show("E-mail enviado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail:\n" + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }


        }



        private void fcnEnviaEmailHTML()
        {
            try
            {
                MailMessage email = new MailMessage();

                email.From = new MailAddress("luciano@lucsale.com.br");
                email.To.Add("luciano@lucsale.com.br");
                email.Subject = "Teste Incial - TAREFA BANCADA - Versão: 1.10 (HTML)";

                if (File.Exists(@"C:\Windows\Temp\TAREFA_BANCADA_HTML.html"))
                {
                    email.Body = File.ReadAllText(@"C:\Windows\Temp\TAREFA_BANCADA_HTML.html");
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado.");
                }
                
                email.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("mail.lucsale.com.br", 587);
                smtp.Credentials = new NetworkCredential(
                    "luciano@lucsale.com.br",
                    "Mag160163@"
                );
                smtp.EnableSsl = false;

                smtp.Send(email);

                MessageBox.Show("E-mail enviado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar o e-mail:\n" + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}




 
