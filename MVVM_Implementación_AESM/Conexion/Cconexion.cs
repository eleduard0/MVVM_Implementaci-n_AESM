using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_Implementación_AESM.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmaesm-default-rtdb.firebaseio.com/");
    }
}
    