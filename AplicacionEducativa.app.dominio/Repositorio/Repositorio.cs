using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEducativa.app.persistencia.Entidades;
using AplicacionEducativa.app.persistencia.Servicios;

namespace AplicacionEducativa.app.dominio.Repositorio
{
    public class Repositorio : IRepositorio, IDisposable
    {
   
   private readonly IServicio servicio;

        public void Dispose() {

         }
      public Repositorio(IServicio servicio){

        this.servicio=servicio;
      }

        public void  guardar()
        {
         var a ="";
        Console.WriteLine("entra aca también");
  // servicio.guardar();
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

              public Materia consultar(){
         
           return this.servicio.consultar();
                
              }

    }
       


}


