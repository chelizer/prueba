using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEducativa.app.servicios.Servicios
{
    public class Servicio : IServicio, IDisposable
    {


        public void Dispose() { }
      

        public void  guardar()
        {
         var a ="";
        Console.WriteLine("entra aca también también");

            /*
            public IEnumerable<Profesor> guardar()
            {
                using (var context = new AppDBContext())
                {


                    IEnumerable<Profesor> profesor = context.Profesor.ToList();

                    return profesor;
                }
            */
            //   var profesor = new Profesor();

            // AppDBContext.Profesor.ToList();
            //  profesor.Nombre = "Alfredo";
            //  AppDBContext.Add(profesor);
            //  AppDBContext.SaveChanges();


        }

      
    }
       


}


