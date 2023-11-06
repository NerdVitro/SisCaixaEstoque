using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Banco
{
    public class BncValidarLogin
    {
        public bool ValidarLogin(string parLogin, string parSenha)
        {
			try
			{
				return true;
			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
