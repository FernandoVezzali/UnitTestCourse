using System;

namespace Domain.AuthorizedTransaction
{
    public class ExternalAuthorization : IExternalAuthorization
    {
        public bool IsAuthorized()
        {
            // Faz de conta que estamos acessando o banco de dados, 
            // uma API ou qualquer recurso fora do escopo de teste unitário.
            throw new NotImplementedException();
        }
    }
}
