using SisCaixaEstoque.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisCaixaEstoque.Classes
{
    public class ValidacaoLogin
    {
		public string Mensagem { get; set; } = string.Empty;

        public bool Validar(string parLogin, string parSenha)
        {
			try
			{
				Mensagem = string.Empty;

                if (string.IsNullOrEmpty(parLogin))
				{
					Mensagem += "Login não informado";
                }
                if (string.IsNullOrEmpty(parSenha))
                {
                    Mensagem += Mensagem.Contains('\n') ? "": "\n";
                    Mensagem += "Senha não informado";
                }
                if (string.IsNullOrEmpty(Mensagem))
                {
                    if (!BncValidarLogin.ValidarLogin(parLogin, parSenha))
                    {
                        Mensagem += "Login ou Senha Incorreto";
                    }
                }
                return string.IsNullOrEmpty(Mensagem);
            }
			catch (Exception)
			{
				throw;
			}
        }
        
        public static NivelAcesso GetNivelAcesso(string parLogin, string parSenha)
        {
            try
            {
                return (NivelAcesso)BncValidarLogin.GetNivelAcesso(parLogin, parSenha);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void SalvarNomeEmArquivoTemporario(bool realizar,string nome)
        {
            if (realizar)
            {
                string caminhoArquivo = Path.Combine(Path.GetTempPath(), ConstantesSistema.NomeArquivoSalvarUsuario);
                File.WriteAllText(caminhoArquivo, nome);
            }
        }
        public static string LerNomeDoArquivoTemporario()
        {
            string caminhoArquivo = Path.Combine(Path.GetTempPath(), ConstantesSistema.NomeArquivoSalvarUsuario);
            if (File.Exists(caminhoArquivo))
            {
                return File.ReadAllText(caminhoArquivo);
            }
            return string.Empty;
        }

        public enum NivelAcesso
        {
            NenhumAcesso,
            AcessoVenda,
            AcessoCadastro,
            AcessoTotal
        }
    }
}
