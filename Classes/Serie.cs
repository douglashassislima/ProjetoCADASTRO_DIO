using System;
namespace DIO.Cadastro
{
    public class Serie : EntidadeBase
    {
     //Atributos extras
     private Genero Genero { get; set; }
     private string Titulo { get; set; } 
     private string Descricao { get; set; }
     private int Ano { get; set; }

     //Métodos

     public Serie(int id, Genero genero, string titulo, string descricao, int ano)
     {
         this.Id = id;
         this.Genero = genero;
         this.Titulo = titulo;
         this.Titulo = titulo;
         this.Descricao = descricao;
         this.Ano = ano;
     }

     public override string ToString ()
     {
         string retorno = "";
        retorno += "Genero: " + this.Genero + Environment.NewLine;
        retorno += "Titulo: " + this.Titulo + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
        return retorno;     
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        internal int retornaId()
        {
            return this.Id;
        }
    }
}