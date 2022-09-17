
using System.Data;
using System;
using System.ComponentModel.DataAnnotations;
namespace AplicacionEducativa.app.persistencia.Entidades{
    public class Alumno{
        [Key]
        public int id {get;set;} 
        public string nombre{get;set;} 

        public string apellido{get;set;} 
         public Materia materia{get;set;} 
    }
}