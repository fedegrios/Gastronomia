﻿using Gastronomia.Base.Formularios;

namespace Gastronomia
{
    public partial class Principal : FormBase
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            new FormConsulta().ShowDialog();
        }
    }
}
