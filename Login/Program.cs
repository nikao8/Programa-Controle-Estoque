using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoControleEstoqueCelula;

namespace ProjetoLoginControleEstoque
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLoginControleEstoque formLoginEstoque = new FormLoginControleEstoque();

            DialogResult resultado = DialogResult.None;

            do
            {
                resultado = formLoginEstoque.ShowDialog();
                
                if(resultado == DialogResult.Cancel)
                {
                    return;
                }

            } while (resultado != DialogResult.OK);

            Application.Run(new formControleEstoque());
        }
    }
}
