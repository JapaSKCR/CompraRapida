using System.Collections.Generic;
using System.Linq;

namespace CompraRapida.Dominio.Entities
{
    public abstract class Entity
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }

        public abstract void Validate();

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
    }
}
