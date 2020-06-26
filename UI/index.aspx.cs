using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoMVCB0207.DTO;
using ProjetoMVCB0207.BLL;

namespace ProjetoMVCB0207.UI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChecarBeneficio_Click(object sender, EventArgs e)
        {

            try
            {

                TblClienteB0207DTO clientedto = new TblClienteB0207DTO();
                TblClienteB0207BLL clientebll = new TblClienteB0207BLL();

                clientedto._nome_cliente = txtNomeB0207.Text;
                clientedto._cpf_cliente = txtCpfB0207.Text;
                clientedto._nome_mae = txtNomeMaeB0207.Text;

                bool resultado = clientebll.consultarBeneficio(clientedto);

                if (resultado)
                {
                    lblResposta.Style.Add("color", "blue");
                    lblResposta.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    lblResposta.Style.Add("color", "red");
                    lblResposta.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }

            }
            catch (Exception ex)
            {
                lblResposta.Style.Add("color", "red");
                lblResposta.Text = ex.Message;
            }
        }
    }
}