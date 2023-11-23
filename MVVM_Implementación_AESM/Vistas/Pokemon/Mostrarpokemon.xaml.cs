using MVVM_Implementación_AESM.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Implementación_AESM.Vistas.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mostrarpokemon : ContentPage
    {
        public Mostrarpokemon()
        {
            InitializeComponent();
            BindingContext = new VMmostrarpokemon(Navigation);
        }
    }
}