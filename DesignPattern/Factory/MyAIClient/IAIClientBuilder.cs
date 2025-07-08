using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Help.DesignPattern.Factory.MyAIClient
{
    public interface IAIClientBuilder<TClient, TConfiguracao>
    {
        TClient Client { get; }
        TConfiguracao Configuration { get; }
    }

  
    public class AIClientBuilder<TClient,TConfiguracao> : IAIClientBuilder<TClient, TConfiguracao>
       
    {
        public TClient Client { get; private set; }
        public TConfiguracao Configuration { get; private set; }
        public AIClientBuilder(TClient client, TConfiguracao configuration)
        {
            Client = client;
            Configuration = configuration;
        }
    }

    public interface IAIClientFactoryBuilderWithConfiguration<TConfiguracao>
    {
       public IAIClientBuilder<TClient, TConfiguracao> RegistrationClient<TClient>(TConfiguracao configuration) where TClient : new(); 
    }


    public class AIClientFactoryBuilderWithConfiguration<TConfiguracao> : IAIClientFactoryBuilderWithConfiguration<TConfiguracao>
    {
        public AIClientFactoryBuilderWithConfiguration(string teste)         {
        }

        public IAIClientBuilder<TClient, TConfiguracao> RegistrationClient<TClient>(TConfiguracao configuration) where TClient : new()
        {
            // Simulando "criação" e configuração do cliente
            TClient cliente = new();

            // recebe os dados via reflexão (simplesmente para exemplo)
            if (cliente is AIClient ia && configuration is MyAIOptions op)
            {
                ia.NomeModelo = op.NomeModelo;
                ia
                    .Temperatura = op.Temperatura;
            }
            if (cliente is OutroClienteDeIA outro && configuration is OutrasOpcoesDeIA cfg)
            {
                outro.Endpoint = cfg.Endpoint;
                outro.ApiKey = cfg.ApiKey;
            }
            return new AIClientBuilder<TClient, TConfiguracao>(cliente, configuration);
        }

    }

}

