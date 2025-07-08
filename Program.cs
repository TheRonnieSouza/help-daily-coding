using Help.DesignPattern.Factory.MyAIClient;

namespace Help
{
    public class Program
    {
        public static void Main()
        {

            // Exemplo Desing pattern Factory - uso do AIClientFactoryBuilderWithConfiguration
            var builder = new AIClientFactoryBuilderWithConfiguration<MyAIOptions>("");

            var clienteBuilder = builder.AddMeuCliente(new MyAIOptions
            {
                NomeModelo = "gpt-fake",
                Temperatura = 0.9
            });

            // Usando o cliente registrado
            clienteBuilder.Client.Executar();

            var builder2 = new AIClientFactoryBuilderWithConfiguration<OutrasOpcoesDeIA>("");
            var cliente2 = builder2.AddOutroCliente(new OutrasOpcoesDeIA
            {
                Endpoint = "https://fake.endpoint.ai",
                ApiKey = "12345-abcde"
            });
            cliente2.Client.Chamar();
        }

    }
}
