using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AplicacionEducativa.app.dominio.Repositorio;
namespace AplicacionEducativa.app.vista.controlador;
using System;
public class IndexModel : PageModel
{
   private readonly IRepositorio repositorio;
   [BindProperty]
public int Age { get; set; }
[BindProperty]
public decimal Money { get; set; }
   public string CODIGO;
    public string  COD_DEPARTAMENTO;

     public string  COD_RUBRO_PAGO;

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger,IRepositorio repositorio)
    {
        this.repositorio=repositorio;
        _logger = logger;
    }

    public void OnGet()
    {
        Console.WriteLine("entra aca");
repositorio.consultar();
    }

[HttpPost]
    public void Edit(){

 Console.WriteLine("si mi amigo");




    }
    
     public IActionResult OnPost()
    {

         Console.WriteLine("si señor");
    return Page();
    }
    
}
