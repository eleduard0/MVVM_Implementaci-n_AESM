using System;
using System.Collections.Generic;
using System.Text;
using MVVM_Implementación_AESM.Modelo;
using MVVM_Implementación_AESM.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using Firebase.Database;

namespace MVVM_Implementación_AESM.Datos
{
    public class Dpokemon
    {
        public async Task InsertarPokemon(Mpokemon parametros)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = parametros.Colorfondo,
                    Colorpoder = parametros.Colorpoder,
                    Icono = parametros.Icono,
                    Nombre = parametros.Nombre,
                    NroOrden = parametros.NroOrden,
                    Poder = parametros.Poder
                });
        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemones()
        {
            /* return (await Cconexion.firebase
                 .Child("Pokemon")
                 .OnceAsync<Mpokemon>())
                 .Select(item => new Mpokemon 
                 {
                     Idpokemon = item.Key,
                     Nombre = item.Object.Nombre,
                     Colorfondo = item.Object.Colorfondo,
                     Colorpoder = item.Object.Colorpoder,
                     Icono = item.Object.Icono,
                     NroOrden = item.Object.NroOrden,
                     Poder = item.Object.Poder
                 }).ToList(); */
            var data = await Task.Run(()=> Cconexion.firebase
                 .Child("Pokemon")
                 .AsObservable<Mpokemon>()
                 .AsObservableCollection());
            return data;
        }
        public async Task EliminarPokemon(Mpokemon nroOrden)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .Child(nroOrden.NroOrden)
                .DeleteAsync();
        }
        public async Task EditarPokemon(Mpokemon pokemon)
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .Child(pokemon.Idpokemon)
                .PutAsync(pokemon);
        }
    }
}
