using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_Princ
{
    public partial class FrmMoviList : Form
    {
        public FrmMoviList()
        {
            InitializeComponent();
        }

        private void FrmMoviList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.MOVI_RETIRADA'. Você pode movê-la ou removê-la conforme necessário.
            this.mOVI_RETIRADATableAdapter.Fill(this.helpdesk01DataSet.MOVI_RETIRADA);
            
           

            // Ajuste do GRID - Espaçamento , cores e estilo das células
            dbgRetirada.BackgroundColor = Color.White;      // Cor do “espaço” entre células     
            dbgRetirada.GridColor = Color.White;      // Remove borda padrão     
            dbgRetirada.CellBorderStyle = DataGridViewCellBorderStyle.Single;      // Espaçamento visual
            dbgRetirada.RowTemplate.Height = 45;      // Estilo das células     
            dbgRetirada.DefaultCellStyle.BackColor = Color.LightBlue;
            dbgRetirada.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;      // Margem interna do texto
            dbgRetirada.DefaultCellStyle.Padding =         new Padding(5);

            // Ajuste do GRID - Ativa SCROLL horizontal
            dbgRetirada.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
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

        private void mOVIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluirRETIRADA_Click(object sender, EventArgs e)
        {
            

        }

        private void btnIncluirRETIRADA_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            InfoApp.opcao = "Incluir RETIRADA DE EQUIPAMENTO";
            FrmMoviRetirada MoviRetirada = new FrmMoviRetirada();
            MoviRetirada.ShowDialog();
            this.Enabled = true;

            //Atualiza o GRID
            //
            try
            {
                this.mOVI_RETIRADATableAdapter.Fill(this.helpdesk01DataSet.MOVI_RETIRADA);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbgRetirada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Editar o registro
                // 
                //InfoPesq.ID = (int)dbgRetirada.CurrentRow.Cells[4].Value; // Pega o ID da pesquisa   
                //InfoApp.opcao = "Editar RETIRADA DE EQUIPAMENTO";
                //FrmMoviRetirada MoviRetirada = new FrmMoviRetirada();
                //MoviRetirada.ShowDialog();

                if (dbgRetirada.CurrentRow.Cells[13].Value.ToString().Trim() == "CONCLUÍDO")
                {
                    MessageBox.Show("RETIRADA DA MÁQUINA:CONCLUÍDO, não é possível EDITAR !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    // Editar o registro
                    // 
                    InfoPesq.ID = (int)dbgRetirada.CurrentRow.Cells[4].Value; // Pega o ID da pesquisa   
                    InfoApp.opcao = "Editar RETIRADA DE EQUIPAMENTO";
                    FrmMoviRetirada MoviRetirada = new FrmMoviRetirada();
                    MoviRetirada.ShowDialog();
                }
            }

            if (e.ColumnIndex == 1)
            {
                if (dbgRetirada.CurrentRow.Cells[13].Value.ToString().Trim() == "CONCLUÍDO")
                {
                    MessageBox.Show("RETIRADA DA MÁQUINA:CONCLUÍDO, não é possível BAIXAR !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    // BAIXA do registro
                    // 
                    InfoPesq.ID = (int)dbgRetirada.CurrentRow.Cells[4].Value; // Pega o ID da pesquisa   
                    InfoApp.opcao = "Baixa RETIRADA DE EQUIPAMENTO";
                    FrmMoviRetiradaBaixa MoviRetiradaBaixa = new FrmMoviRetiradaBaixa();
                    MoviRetiradaBaixa.ShowDialog();

                    

                }
            }

            if (e.ColumnIndex == 2)
            {
                if (dbgRetirada.CurrentRow.Cells[13].Value.ToString().Trim() == "CONCLUÍDO")
                {
                    MessageBox.Show("RETIRADA DA MÁQUINA:CONCLUÍDO, não é possível IMPRIMIR !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    // IMPRESSÃO do registro
                    //
                    InfoWork.strWork = "MOVIRETIRADA_LIST";
                    InfoPesq.ID = (int)dbgRetirada.CurrentRow.Cells[4].Value; // Pega o ID da pesquisa
                    FrmMoviRetiradaImpressao MoviRetiradaImpressao = new FrmMoviRetiradaImpressao();
                    MoviRetiradaImpressao.ShowDialog();
                }
            }

            if (e.ColumnIndex == 20)
            {
                if (dbgRetirada.CurrentRow.Cells[13].Value.ToString().Trim() == "CONCLUÍDO")
                {
                    MessageBox.Show("Registro CONCLUÍDO, não é possível EXCLUÍR !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    // EXCLUSÃO DE REGISTRO (movi)
                    // Initializes the variables to pass to the MessageBox.Show method.
                    string message = "Tem CERTEZA da Exclusão?";
                    string caption = "Exclusão da RETIRADA DO EQUIPAMENTO";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {

                        //define a string de conexao com provedor caminho e nome do banco de dados
                        string strProvider = "Data Source=SQL1003.site4now.net;Initial Catalog=db_ab2460_helpdesk02;Persist Security Info=True;User ID=db_ab2460_helpdesk02_admin;PassWord=Mag160163@";

                        //define a instrução SQL
                        string strSql = "DELETE FROM MOVI_RETIRADA WHERE ID = @ID";

                        try
                        {
                            // Estabelecer a conexão com o banco de dados
                            using (SqlConnection connection = new SqlConnection(strProvider))
                            {
                                connection.Open();

                                // Criar o comando SQL
                                using (SqlCommand command = new SqlCommand(strSql, connection))
                                {
                                    command.Parameters.AddWithValue("@ID", (int)dbgRetirada.CurrentRow.Cells[4].Value); // Pega o ID da pesquisa   

                                    // Executar o comando SQL
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Exclusão Bem Sucedida !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum registro encontrado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex.Message);
                        }
                    }
                }
            }
            
            //Atualiza o GRID
            //
            try
            {
                this.mOVI_RETIRADATableAdapter.Fill(this.helpdesk01DataSet.MOVI_RETIRADA);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dbgRetirada_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
           

           
        }

        private void dbgRetirada_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void dbgRetirada_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           


        }

        private void tbcEstagios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

