using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_Princ
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();

            
        }

        private void FormShow(Form frm)
        {
            MessageBox.Show(FrmMenuPrincipal.ActiveForm.Size.ToString(), "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();


        }

        public void AtualizaVersao()
        {

            lblVersao.Text = "Versão: " + InfoApp.versao;

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show(FrmMenuPrincipal.ActiveForm.Size.ToString(), "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Atualiza DADOS da aplicação
            lblSistema.Text = InfoApp.sistema;
            AtualizaVersao();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMenuPrincipal_Load_1(object sender, EventArgs e)
        {
            // Atualiza DADOS da aplicação
            InfoApp.sistema = "HELP_Princ";
            AtualizaVersao();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTecnicos_Click_1(object sender, EventArgs e)
        {
            FormShow(new FrmTecnicosList());
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FormShow(new FrmServicosList());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormShow(new FrmUsuariosList());
        }

        private void btnMovimentacoes_Click(object sender, EventArgs e)
        {
            FormShow(new FrmMoviList());
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            FormShow(new FrmEquipamentosList());
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou aqui !!!", "Teste", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
        }

        private void FrmMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
