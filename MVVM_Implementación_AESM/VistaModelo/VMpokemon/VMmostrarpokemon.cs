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
        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        #endregion
        #region CONTRUCTOR
        public VMmostrarpokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
      
        #endregion
        #region PROCESOS
      
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
