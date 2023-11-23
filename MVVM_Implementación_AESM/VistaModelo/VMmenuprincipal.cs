﻿using MVVM_Implementación_AESM.Modelo;
using MVVM_Implementación_AESM.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementación_AESM.VistaModelo
{
    class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listapaginas { get; set; }
        #endregion
        #region CONTRUCTOR
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPaginas();
        }
        #endregion
        #region OBJETOS
      
        #endregion
        #region PROCESOS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }
        public void MostrarPaginas()
        {
            listapaginas = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Pagina= "Entry, datepicker, picker, label, navegación",
                    Icono="https://i.ibb.co/DCPJDtC/charmander.png"
                },
                new Mmenuprincipal
                {
                    Pagina= "CollectionView sin enlace a Base de Datos",
                    Icono="https://i.ibb.co/fr0yd5N/charmaleon.png"
                },
                new Mmenuprincipal
                {
                    Pagina= "Crud pokemon",
                    Icono="https://i.ibb.co/vsL5PNj/ico-old-006-1.png"
                },
            };

        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;
            if(pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new pagina1());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if(pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
            
        }
        #endregion
        #region COMANDOS
        //public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand Sumarcommand => new Command(Sumar);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
