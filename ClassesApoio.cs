using System;
//namespace dicdesenvol
namespace HELP_Princ
{


    public static class InfoApp
    {
        private static string m_local = "";
        public static string local
        {
            get { return m_local; }
            set { m_local = value; }
        }

        private static string m_sistema = "";
        public static string sistema
        {
            get { return m_sistema; }
            set { m_sistema = value; }
        }

        private static string m_dirfoto = "";
        public static string dirfoto
        {
            get { return m_dirfoto; }
            set { m_dirfoto = value; }
        }

        private static string m_versao = "";
        public static string versao
        {
            get { return m_versao; }
            set { m_versao = value; }
        }

        private static string m_opcao = "";
        public static string opcao
        {
            get { return m_opcao; }
            set { m_opcao = value; }
        }

        private static string m_nome_entidade = "";
        public static string nome_entidade
        {
            get { return m_nome_entidade; }
            set { m_nome_entidade = value; }
        }
    }

    public static class InfoSenha
    {
        private static string m_Senha = "";
        public static string Senha
        {
            get { return m_Senha; }
            set { m_Senha = value; }
        }

        private static string m_SalvaSenha = "";
        public static string SalvaSenha
        {
            get { return m_SalvaSenha; }
            set { m_SalvaSenha = value; }
        }

        private static bool m_Logado = false;
        public static bool Logado
        {
            get { return m_Logado; }
            set { m_Logado = value; }
        }

        private static string m_Usuario = "";
        public static string Usuario
        {
            get { return m_Usuario; }
            set { m_Usuario = value; }
        }


        //public string Usuario { get; set; }
    }


    public static class InfoPesq
    {
        private static int m_ID = 0;
        public static int ID
        {
            get { return m_ID; }
            set { m_ID = value; }
        }

    }

    public static class InfoWork
    {
        private static string m_strWork = "";
        public static string strWork
        {   
            get { return m_strWork; }
            set { m_strWork = value; }
        }

        private static string m_strWork_b = "";
        public static string strWork_b
        {
            get { return m_strWork_b; }
            set { m_strWork_b = value; }
        }

        private static string m_MoviRetiradaUpdate = "";
        public static string MoviRetiradaUpdate
        {
            get { return m_MoviRetiradaUpdate; }
            set { m_MoviRetiradaUpdate = value; }
        }

        private static string m_MoviRetiradaModalidade = "";
        public static string MoviRetiradaModalidade
        {
            get { return m_MoviRetiradaModalidade; }
            set { m_MoviRetiradaModalidade = value; }
        }

        private static string m_Estagio = "";
        public static string Estagio
        {
            get { return m_Estagio; }
            set { m_Estagio = value; }
        }

        private static string m_TecnicoAtuante = "";
        public static string TecnicoAtuante
        {
            get { return m_TecnicoAtuante; }
            set { m_TecnicoAtuante = value; }
        }

        private static string m_DataRetirada = "";
        public static string DataRetirada
        {
            get { return m_DataRetirada; }
            set { m_DataRetirada = value; }
        }

        private static string m_HoraRetirada = "";
        public static string HoraRetirada
        {
            get { return m_HoraRetirada; }
            set { m_HoraRetirada = value; }
        }

    }


    

}