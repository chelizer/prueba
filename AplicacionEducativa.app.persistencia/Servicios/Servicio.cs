using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEducativa.app.persistencia.Entidades;
namespace AplicacionEducativa.app.persistencia.Servicios
{
    public class Servicio : IServicio, IDisposable
    {
   

        public void Dispose() {

         }


              public Materia consultar(){
               int idmateria=1;
                   using (var context = new dbContext())
            {
                var materia = context.materia
          .Where(w => w.id == idmateria)
         .FirstOrDefault();
                var a = "";

                             Console.WriteLine("aca está y funciona  "+materia.id+" grupo académico "+materia.GrupoAcademico);

                return materia;
            }



              }

    }
       


}


