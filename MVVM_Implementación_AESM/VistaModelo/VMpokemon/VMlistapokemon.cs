using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementación_AESM.Modelo;
using MVVM_Implementación_AESM.Vistas.Pokemon;
using MVVM_Implementación_AESM.Datos;
using System.Collections.ObjectModel;

namespace MVVM_Implementación_AESM.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        
        ObservableCollection<Mpokemon> _Listapokemon;
        #endregion
        #region CONTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrardetallespokemon(Mpokemon mpokemon)
        {
            await Navigation.PushAsync(new Mostrarpokemon(mpokemon));
        }
        public async Task Mostrarpokemon()
        {
            var function = new Dpokemon();
            Listapokemon = await function.MostrarPokemones();
        }
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand Mostrardetallespokemoncommand => new Command<Mpokemon>(async (p) => await Mostrardetallespokemon(p));
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
