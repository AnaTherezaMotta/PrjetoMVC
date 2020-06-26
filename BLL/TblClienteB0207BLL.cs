using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoMVCB0207.BLL
{
    public class TblClienteB0207BLL
    {
        private DALMVC conexao;

        public Boolean consultarBeneficio(TblClienteB0207DTO user)
        {
            conexao = new DALMVC();

            string sql = $@"SELECT * FROM tbl_clienteB38 
              WHERE `nome_cliente`='{user._nome_cliente}'
              AND `cpf_cliente`='{user._cpf_cliente}'
              AND `nome_mae`='{user._nome_mae}'";

            DataTable resultado = conexao.executarConsulta(sql);

            return resultado.Rows.Count == 1;
        }
    }
}