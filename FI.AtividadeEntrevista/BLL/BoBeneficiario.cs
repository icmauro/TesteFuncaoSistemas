using FI.AtividadeEntrevista.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        /// 

        readonly DAL.DaoBeneficiario beneficiarioDAL = new DAL.DaoBeneficiario();

        public long Incluir(DML.Beneficiario beneficiario)
        {
            return beneficiarioDAL.Incluir(beneficiario);
        }

        /// <summary>
        /// Altera um cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public void Alterar(DML.Cliente cliente)
        {
            DAL.DaoBeneficiario cli = new DAL.DaoBeneficiario();
            cli.Alterar(cliente);
        }

        /// <summary>
        /// Consulta o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        //public DML.Cliente Consultar(long id)
        //{
        //    DAL.DaoBeneficiario cli = new DAL.DaoBeneficiario();
        //    return cli.Consultar(id);
        //}

        /// <summary>
        /// Excluir o cliente pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoBeneficiario cli = new DAL.DaoBeneficiario();
            cli.Excluir(id);
        }

        /// <summary>
        /// Lista os clientes
        /// </summary>
        //public List<DML.Beneficiario> Listar()
        //{
        //    DAL.DaoBeneficiario cli = new DAL.DaoBeneficiario();
        //    return cli.Listar();
        //}

        /// <summary>
        /// Lista os clientes
        /// </summary>
        public List<DML.Beneficiario> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, long IdCliente, out int qtd)
        {
            return beneficiarioDAL.Pesquisa(iniciarEm,  quantidade, campoOrdenacao, crescente, IdCliente, out qtd);
        }

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF)
        {
            return beneficiarioDAL.VerificarExistencia(CPF);
        }

    }
}
