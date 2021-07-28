using System;
namespace DIO.Cadastro
{
    public class Serie : EntidadeBase
    {
     //Atributos extras
     private Genero Genero { get; set, }
     private string Titulo { get; set; } 
     private string Descricao { get; set; }
     private int Ano { get; set; }
      
    }
}