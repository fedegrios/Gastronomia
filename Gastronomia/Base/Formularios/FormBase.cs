using System;
using System.Windows.Forms;
using Gastronomia.Base.Helpers;

namespace Gastronomia.Base.Formularios
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();

            this.ForeColor = Paleta.ClaroPrimario;
        }


        public virtual void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }
        }

        // Limpia los controles.
        public void LimpiarControles(object obj)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Clear();
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Clear();
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Value = ((NumericUpDown)ctrol).Minimum;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Clear();
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Clear();
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Value = ((NumericUpDown)ctrol).Minimum;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Value = DateTime.Now;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
        }

        // Activa o Desactiva los controles.
        public void ActivarControles(object obj, bool estado)
        {
            if (obj is Form)
            {
                foreach (var ctrol in ((Form)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Button)
                    {
                        ((Button)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
            else if (obj is Panel)
            {
                foreach (var ctrol in ((Panel)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Button)
                    {
                        ((Button)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
            else if (obj is UserControl)
            {
                foreach (var ctrol in ((UserControl)obj).Controls)
                {
                    if (ctrol is TextBox)
                    {
                        ((TextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is RichTextBox)
                    {
                        ((RichTextBox)ctrol).Enabled = estado;
                    }
                    else if (ctrol is NumericUpDown)
                    {
                        ((NumericUpDown)ctrol).Enabled = estado;
                    }
                    else if (ctrol is DateTimePicker)
                    {
                        ((DateTimePicker)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Button)
                    {
                        ((Button)ctrol).Enabled = estado;
                    }
                    else if (ctrol is Panel)
                    {
                        LimpiarControles(ctrol);
                    }
                }
            }
        }

        // Cambia el color del control al recibir el foco
        public void ColorAlRecibirFoco(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Paleta.ClaroSecundario;
            }
            else if (sender is RichTextBox)
            {
                ((RichTextBox)sender).BackColor = Paleta.ClaroSecundario;
            }
        }

        // Cambia el color del control al perder el foco
        public void ColorAlPerderFoco(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = Paleta.ClaroPrimario;
            }
            else if (sender is RichTextBox)
            {
                ((RichTextBox)sender).BackColor = Paleta.ClaroPrimario;
            }
        }
    }
}
