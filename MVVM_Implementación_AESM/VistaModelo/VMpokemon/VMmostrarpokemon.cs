using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementación_AESM.Modelo;
using MVVM_Implementación_AESM.Datos;
using MVVM_Implementación_AESM.Vistas.Pokemon;

namespace MVVM_Implementación_AESM.VistaModelo.VMpokemon
{
    internal class VMmostrarpokemon : BaseViewModel
    {
        Dpokemon dpokemon = new Dpokemon();
        #region VARIABLES
        public Mpokemon recibirParametros { get; set; }
        public Mpokemon _mpokemon;
        private string _NroOrden;

        #endregion
        #region CONTRUCTOR
        public VMmostrarpokemon(INavigation navigation, Mpokemon traerParametros)
        {
            Navigation = navigation;
            recibirParametros= traerParametros;
        }
        #endregion
        #region OBJETOS
        public string NroOrden
        {
            get { return recibirParametros.NroOrden ; }
            set { _ = recibirParametros.NroOrden;  }
        }
        public Mpokemon mpokemon
        {
            get { return _mpokemon; }
            set
            {
                SetValue(ref _mpokemon, value);
                OnpropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
      
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public async Task EliminarPokemon()
        {
            await dpokemon.EliminarPokemon(NroOrden);
            await App.Current.MainPage.Navigation.PushAsync(new Listapokemon());
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand DeleteCommand => new Command(async () => await EliminarPokemon());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        /*public ICommand DeleteCommand { get { return new RelayCommand(EliminarPokemon); } }*/
        #endregion
    }
}
