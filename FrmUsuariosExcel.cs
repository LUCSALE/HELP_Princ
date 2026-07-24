using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Spire.Xls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MessageBox = System.Windows.MessageBox;

namespace HELP_Princ
{
    public partial class FrmUsuariosExcel : Form
    {
        public FrmUsuariosExcel()
        {
            InitializeComponent();
        }

        private void FrmUsuariosExcel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.USUARIOS'. Você pode movê-la ou removê-la conforme necessário.
            //this.uSUARIOSTableAdapter.Fill(this.helpdesk01DataSet.USUARIOS);
            //this.uSUARIOSTableAdapter.FillByID(this.helpdesk01DataSet.USUARIOS,1);
            //this.uSUARIOSTableAdapter.USUARIOSInsert("02/04/2026", "10:22", "9999", "XXX", "YYY", "SIM", "WWW");
            //this.uSUARIOSTableAdapter.USUARIOSDelete(4);
            //this.uSUARIOSTableAdapter.USUARIOSDelete(5);
            //this.uSUARIOSTableAdapter.USUARIOSUpdate("Roberto", 3);        
            
            lblMensagem.Visible = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            lblMensagem.Visible = true;

            // Create a Workbook object
            Workbook wb = new Workbook();

            // Load an Excel document
            ////wb.LoadFromFile(strArquivo);
            wb.LoadFromFile("E:\\DESENVOL_WEB\\Portal HELP_DESK\\Planilha_Controle\\SISDESK012023.xlsm");

            // Get a specific sheet
            Worksheet sheet = wb.Worksheets[0];

            // Retrieve headers
            for (int row = 2; row <= sheet.LastRow; row++)
            {
                DateTime DataAtual = DateTime.Now;
                string DataFormat = DataAtual.ToString("dd/MM/yyyy");
                string HoraFormat = DataAtual.ToString("HH:mm:ss");
                string strNome_Usuario = sheet.Range[row, 6].Value?.ToString() ?? string.Empty;
                string strRamal = sheet.Range[row, 7].Value?.ToString() ?? string.Empty;
                string strPredio_Setor = sheet.Range[row, 8].Value?.ToString() ?? string.Empty;

                this.uSUARIOSTableAdapter.USUARIOSInsert(DataFormat, HoraFormat, strRamal.ToUpper(), strNome_Usuario.ToUpper(), strPredio_Setor.ToUpper(), "SIM", "-> IMPORTADO EM: " + DataFormat);
            }
            MessageBox.Show("Dados importados com sucesso!", "Informação", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Information);
            
            
            this.Close();

            //try
            //{
            //    this.Validate();
            //    this.sERVICOSBindingSource.EndEdit();
            //    this.sERVICOSTableAdapter.Update(this.helpdesk01DataSet);
            //    MessageBox.Show("Dados salvos com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro ao Salvar: " + ex.Message);
            //}


        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByIDToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void sERVICOSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aTIVO2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPèsquisar_Click(object sender, EventArgs e)
        {
            string strArquivo;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Arquivo EXCEL|*.xlsm|Arquivo EXCEL|*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strArquivo = openFileDialog1.FileName;
                txtArquivo.Text = strArquivo;

                // Processar o arquivo
            }

        }
    }
}
