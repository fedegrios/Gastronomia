using System.Windows.Forms;

namespace Gastronomia.Base.Helpers
{
    public static class Mjs
    {
        public static bool Error(string txt)
        {
            return DialogResult.Yes == MessageBox.Show(txt, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool Preguntar(string txt)
        {
            return DialogResult.Yes == MessageBox.Show(txt, @"Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static bool Alerta(string txt)
        {
            return DialogResult.Yes == MessageBox.Show(txt, @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Informacion(string txt)
        {
            return DialogResult.Yes == MessageBox.Show(txt, @"Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
