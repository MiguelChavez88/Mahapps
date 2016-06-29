using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using PruebaNavegacion.Views;


namespace PruebaNavegacion.ViewModels
{
    class MainWindowViewModel:ViewModelBase
    {
        private readonly Action<UserControl> _navigateToView;
        private Editar _editarView;
        public RelayCommand NewMatch { get; set; }

        public MainWindowViewModel(Action<UserControl> navigateToView)
        {
            this._navigateToView = navigateToView;
            Initializate();
            NewMatch = new RelayCommand(_ => navigateToView(_editarView));
        }

        private void Initializate()
        {
            _editarView = new Editar();
        }
    }
}
