using System.Collections.Generic;

namespace Drink.Dados
{
    public static class CatalogosSistema
    {
        public static List<string> Categorias { get; } = new List<string>
        {
            "Bebidas",
            "Frutas",
            "Alimentos",
            "Descartáveis",
            "Limpeza",
            "Outros"
        };

        public static List<string> Unidades { get; } = new List<string>
        {
            "Unidade",
            "Kg",
            "g",
            "L",
            "ml",
            "Garrafa",
            "Caixa",
            "Pacote"
        };

        public static List<string> StatusEvento { get; } = new List<string>
        {
            "Em montagem",
            "Separado",
            "Encerrado"
        };

        public static List<string> StatusRetorno { get; } = new List<string>
        {
            "Pendente",
            "Retorno Parcial",
            "Retornado",
            "Consumido"
        };
    }
}
