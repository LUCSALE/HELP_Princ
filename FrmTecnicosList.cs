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
    public partial class FrmTecnicosList : Form
    {
        public FrmTecnicosList()
        {
            InitializeComponent();
        }

        private void FrmTecnicosList_Load(object sender, EventArgs e)
        {
            // Ajuste do GRID - Espaçamento , cores e estilo das células
            dbgTecnicos.BackgroundColor = Color.White;      // Cor do “espaço” entre células     
            dbgTecnicos.GridColor = Color.White;      // Remove borda padrão     
            dbgTecnicos.CellBorderStyle = DataGridViewCellBorderStyle.Single;      // Espaçamento visual
            dbgTecnicos.RowTemplate.Height = 35;      // Estilo das células     
            dbgTecnicos.DefaultCellStyle.BackColor = Color.LightBlue;
            dbgTecnicos.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;      // Margem interna do texto
            dbgTecnicos.DefaultCellStyle.Padding = new Padding(5);

            // Ajuste do GRID - Ativa SCROLL horizontal
            dbgTecnicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.TECNICOS'. Você pode movê-la ou removê-la conforme necessário.
            this.tECNICOSTableAdapter.Fill(this.helpdesk01DataSet.TECNICOS);


        }

        private void pnlFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            InfoApp.opcao = "Incluir NOVO TÉCNICO";
            FrmTecnicosForm TecnicosForm = new FrmTecnicosForm();
            TecnicosForm.ShowDialog();

            //Atualiza o GRID
            //
            try
            {
                this.tECNICOSTableAdapter.Fill(this.helpdesk01DataSet.TECNICOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dbgTecnicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Editar o registro
                // 
                InfoPesq.ID = (int)dbgTecnicos.CurrentRow.Cells[2].Value; // Pega o ID da pesquisa   
                InfoApp.opcao = "Editar DADOS DO TÉCNICO";
                FrmTecnicosForm TecnicosForm = new FrmTecnicosForm();
                TecnicosForm.ShowDialog();
            }


            if (e.ColumnIndex == 1)
            {
                // EXCLUSÃO DE REGISTRO
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Tem CERTEZA da Exclusão?";
                string caption = "Exclusão do TÉCNICO";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    //define a string de conexao com provedor caminho e nome do banco de dados
                    string strProvider = "Data Source=SQL1003.site4now.net;Initial Catalog=db_ab2460_helpdesk02;Persist Security Info=True;User ID=db_ab2460_helpdesk02_admin;PassWord=Mag160163@";

                    //define a instrução SQL
                    string strSql = "DELETE FROM TECNICOS WHERE ID = @ID";

                    try
                    {
                        // Estabelecer a conexão com o banco de dados
                        using (SqlConnection connection = new SqlConnection(strProvider))
                        {
                            connection.Open();

                            // Criar o comando SQL
                            using (SqlCommand command = new SqlCommand(strSql, connection))
                            {
                                command.Parameters.AddWithValue("@ID", (int)dbgTecnicos.CurrentRow.Cells[2].Value); // Pega o ID da pesquisa   

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

            //Atualiza o GRID
            //
            try
            {
                this.tECNICOSTableAdapter.Fill(this.helpdesk01DataSet.TECNICOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}

