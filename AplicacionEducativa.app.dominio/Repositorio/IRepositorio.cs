using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionEducativa.app.persistencia.Entidades;
namespace  AplicacionEducativa.app.dominio.Repositorio
{
    public interface IRepositorio
    {



        //   public IEnumerable<Profesor> guardar();
        public  void guardar();


        public Materia consultar();
    }
}
