namespace Help
{
    public static class TypeOf
    {
        
        public static void CriarEExecutarExportador(Type tipoExportador) {
            if (!typeof(IExportador).IsAssignableFrom(tipoExportador)) {
                Console.WriteLine($"Erro: {tipoExportador.Name} não implementa IExportador.");
                return;
            }
            var instancia = Activator.CreateInstance(tipoExportador) as IExportador;
            string result = instancia?.Exportar();            
        }
        public interface IExportador {
            string Exportar();
        }
        public class ExportadorPdf : IExportador {
            public string Exportar() => "Exportando em PDF...";
        }

        public class ExportadorCsv : IExportador {
            public string Exportar() => "Exportando em CSV...";
        }

        public static void DebugTypeOf()
        {
            Type tipo = typeof(Produto);

            Console.WriteLine($"Propriedades da classe {tipo.Name}:");

            foreach (var prop in tipo.GetProperties())
            {
                string content = $"- {prop.Name} ({prop.PropertyType.Name}) -  ";
                Console.WriteLine(content);
            }
        }
    }
    class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    

}
