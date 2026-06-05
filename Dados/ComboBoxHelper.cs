using System.Collections.Generic;
using System.Windows.Forms;

namespace Drink.Dados
{
    public static class ComboBoxHelper
    {
        public static void Preencher(ComboBox combo, IEnumerable<string> itens, bool limparSelecao = true)
        {
            combo.Items.Clear();

            foreach (var item in itens)
                combo.Items.Add(item);

            if (limparSelecao)
                combo.SelectedIndex = -1;
        }
    }
}