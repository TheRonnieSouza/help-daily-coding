using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.DesignPattern.Factory.MyAIClient
{
    public static class ClientBuilderExtension
    {
        public static IAIClientBuilder<AIClient, MyAIOptions> AddMeuCliente<TBuilder>(
         this TBuilder builder, MyAIOptions configuracao)
         where TBuilder : IAIClientFactoryBuilderWithConfiguration<MyAIOptions>
        {
            return builder.RegistrationClient<AIClient>(configuracao);
        }
        public static IAIClientBuilder<OutroClienteDeIA, OutrasOpcoesDeIA> AddOutroCliente<TBuilder>(
       this TBuilder builder, OutrasOpcoesDeIA configuracao)
       where TBuilder : IAIClientFactoryBuilderWithConfiguration<OutrasOpcoesDeIA>
        {
            return builder.RegistrationClient<OutroClienteDeIA>(configuracao);
        }
    }
}
