//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrabajoFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductoCategoria
    {
        public int ProductoCategoriaId { get; set; }
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
