
using System;
using System.ComponentModel.DataAnnotations;

namespace AplicacionEducativa.app.persistencia.Entidades{
    public class Materia{
       [Key]
        public int id {get;set;} 
        public string GrupoAcademico{get;set;} 
    
    }
}