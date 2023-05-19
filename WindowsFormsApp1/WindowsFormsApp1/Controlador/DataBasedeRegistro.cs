using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Prueba
    {

        PruebaBaseDatosDataContext bd = new PruebaBaseDatosDataContext();

        public void Registrar(Administrador objadmin)
        {
            bd.Administrador.InsertOnSubmit(objadmin);
            bd.SubmitChanges();
        }
    }
}