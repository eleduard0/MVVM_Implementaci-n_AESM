using MVVM_Implementación_AESM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementación_AESM.Modelo;

namespace MVVM_Implementación_AESM.VistaModelo
{
    class VMPage2 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONTRUCTOR
        public VMPage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre= "Frank",
                    Imagen="https://i.ibb.co/jJz0Z99/letra-f.png"
                },
                new Musuarios
                {
                    Nombre= "Juan",
                    Imagen="https://i.ibb.co/HVLvrQ3/letra-j.png"
                },
                new Musuarios
                {
                    Nombre= "Carlos",
                    Imagen="https://i.ibb.co/THfNk0L/letra-c.png"
                },
            };
          
        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Has seleccionado a: ", parametros.Nombre, "Ok");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand Sumarcommand => new Command(Sumar);
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
