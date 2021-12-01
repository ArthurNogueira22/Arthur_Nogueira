using meSalva.DAL;
using meSalva.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meSalva.BLL
{
    class LoginBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "tbl_Login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}' and cpf='{login.Cpf}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }
    }
}
