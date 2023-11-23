using MVVM_Implementación_AESM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementación_AESM.VistaModelo
{
    public class VMpagina1 : BaseViewModel
    {
        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        DateTime _Fecha;
        string _Resultadofecha;
        #endregion
        #region CONTRUCTOR
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
            Fecha= DateTime.Now;
        }
        #endregion
        #region OBJETOS
        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue( ref _TipoUsuario, value);}
        }
        public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetProperty(ref _TipoUsuario , value);
                TipoUsuario= _TipoUsuario;
            }
        }

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
        public DateTime Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value);
                _Resultadofecha = _Fecha.ToString("dd/MM/yyyy");
            }
        }
        public string ResultadoFecha
        {
            get { return _Resultadofecha; }
            set { SetValue(ref _Resultadofecha, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Navegarpagina2()
        {
            await Navigation.PushAsync(new Page2());
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void Sumar()
        {
            double n1 = 0;
            double n2 = 0;
            double r = 0;

            n1 = Convert.ToDouble(N1);
            n2 = Convert.ToDouble(N2);
            r = Convert.ToDouble(R);

            r = n1 + n2;
            R = r.ToString();
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand PNavegarpagina2command => new Command(async () => await Navegarpagina2());
        public ICommand Sumarcommand => new Command(Sumar);
        #endregion
    }
}
