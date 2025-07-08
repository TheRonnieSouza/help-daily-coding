namespace Help.DesignPattern.Factory.MyAIClient
{
    public class AIClient
    {
        public string NomeModelo { get; set; }
        public double Temperatura { get; set; }

        public void Executar()
        {
            Console.WriteLine($"Executando modelo: {NomeModelo} com temperatura: {Temperatura}");
        }
    }

    public class  MyAIOptions
    {

        public string NomeModelo { get; set; }
        public double Temperatura { get; set; }
    }

    public class OutroClienteDeIA
    {
        public string Endpoint { get; set; }
        public string ApiKey { get; set; }

        public void Chamar()
        {
            Console.WriteLine($"Chamando endpoint: {Endpoint} com API Key: {ApiKey}");
        }
    }

    public class OutrasOpcoesDeIA
    {
        public string Endpoint { get; set; }
        public string ApiKey { get; set; }
    }

}
