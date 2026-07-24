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
    public partial class FrmEquipamentosList : Form
    {
        public FrmEquipamentosList()
        {
            InitializeComponent();
        }

        private void FrmEquipamentosList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'helpdesk01DataSet.EQUIPAMENTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            
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
            InfoApp.opcao = "Incluir NOVO EQUIPAMENTO";
            FrmEquipamentosForm EquipamentosForm = new FrmEquipamentosForm();
            EquipamentosForm.ShowDialog();

            //Atualiza o GRID
            //
            try
            {
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
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
                InfoPesq.ID = (int)dbgEquipamentos.CurrentRow.Cells[2].Value; // Pega o ID da pesquisa   
                InfoApp.opcao = "Editar DADOS DO EQUIPAMENTO";
                FrmEquipamentosForm EquipamentosForm = new FrmEquipamentosForm();
                EquipamentosForm.ShowDialog();
            }


            if (e.ColumnIndex == 1)
            {
                // EXCLUSÃO DE REGISTRO
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Tem CERTEZA da Exclusão?";
                string caption = "Exclusão do EQUIPAMENTO";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    //define a string de conexao com provedor caminho e nome do banco de dados
                    string strProvider = "Data Source=SQL1003.site4now.net;Initial Catalog=db_ab2460_helpdesk02;Persist Security Info=True;User ID=db_ab2460_helpdesk02_admin;PassWord=Mag160163@";

                    //define a instrução SQL
                    string strSql = "DELETE FROM EQUIPAMENTOS WHERE ID = @ID";

                    try
                    {
                        // Estabelecer a conexão com o banco de dados
                        using (SqlConnection connection = new SqlConnection(strProvider))
                        {
                            connection.Open();

                            // Criar o comando SQL
                            using (SqlCommand command = new SqlCommand(strSql, connection))
                            {
                                command.Parameters.AddWithValue("@ID", (int)dbgEquipamentos.CurrentRow.Cells[2].Value); // Pega o ID da pesquisa   

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
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.eQUIPAMENTOSTableAdapter.Fill(this.helpdesk01DataSet.EQUIPAMENTOS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

