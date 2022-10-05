using System;
using System.Collections.Generic;
using System.Windows;
using Business;
using Entity;
using Semana05.ViewModel;

namespace Semana05.View

{
    /// <summary>
    /// Lógica de interacción para ManCategoria.xaml
    /// </summary>
    public partial class ManCategoria : Window
    {
        ManCategoriaViewModel viewModel;
        public ManCategoria()
        {
            InitializeComponent();
            viewModel = new ManCategoriaViewModel();
            this.DataContext = viewModel;
        }

    }
}
