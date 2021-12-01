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
    class UsuarioBLL
    {
        Conexao conexao = new Conexao();
        string tabela = "tbl_usuario";

        public void Inserir(UsuarioDTO usuarioDTO)
        {
            string inserir = $"insert into {tabela} values(null,'{usuarioDTO.Nome}','{usuarioDTO.Cpf}','{usuarioDTO.Email}','{usuarioDTO.Senha}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(UsuarioDTO usuarioDTO)
        {
            string alterar = $"update {tabela} set nome = '{usuarioDTO.Nome}', '{usuarioDTO.Email}', '{usuarioDTO.Senha}' where CPF = '{usuarioDTO.Cpf}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(UsuarioDTO usuarioDTO)
        {
            string excluir = $"delete from {tabela} where CPF = '{usuarioDTO.Cpf}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
