using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEducativa.app.persistencia.Entidades;

namespace  AplicacionEducativa.app.persistencia.Servicios
{
    public interface IServicio
    {



        //   public IEnumerable<Profesor> guardar();


        public Materia consultar();
    }
}
