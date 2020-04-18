﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EConfiableBD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EConfiableEntities : DbContext
    {
        public EConfiableEntities()
            : base("name=EConfiableEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
    
        public virtual int Pais_Delete(string pai_codigo)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Delete", pai_codigoParameter);
        }
    
        public virtual int Pais_Insert(string pai_codigo, string pai_nombre, string pai_codigointernacional, Nullable<bool> pai_predeterminado)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            var pai_nombreParameter = pai_nombre != null ?
                new ObjectParameter("pai_nombre", pai_nombre) :
                new ObjectParameter("pai_nombre", typeof(string));
    
            var pai_codigointernacionalParameter = pai_codigointernacional != null ?
                new ObjectParameter("pai_codigointernacional", pai_codigointernacional) :
                new ObjectParameter("pai_codigointernacional", typeof(string));
    
            var pai_predeterminadoParameter = pai_predeterminado.HasValue ?
                new ObjectParameter("pai_predeterminado", pai_predeterminado) :
                new ObjectParameter("pai_predeterminado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Insert", pai_codigoParameter, pai_nombreParameter, pai_codigointernacionalParameter, pai_predeterminadoParameter);
        }
    
        public virtual ObjectResult<Pais_List_Result> Pais_List(string pai_codigo)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Pais_List_Result>("Pais_List", pai_codigoParameter);
        }
    
        public virtual int Pais_Update(string pai_codigo, string pai_nombre, string pai_codigointernacional, Nullable<bool> pai_predeterminado)
        {
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            var pai_nombreParameter = pai_nombre != null ?
                new ObjectParameter("pai_nombre", pai_nombre) :
                new ObjectParameter("pai_nombre", typeof(string));
    
            var pai_codigointernacionalParameter = pai_codigointernacional != null ?
                new ObjectParameter("pai_codigointernacional", pai_codigointernacional) :
                new ObjectParameter("pai_codigointernacional", typeof(string));
    
            var pai_predeterminadoParameter = pai_predeterminado.HasValue ?
                new ObjectParameter("pai_predeterminado", pai_predeterminado) :
                new ObjectParameter("pai_predeterminado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Pais_Update", pai_codigoParameter, pai_nombreParameter, pai_codigointernacionalParameter, pai_predeterminadoParameter);
        }
    
        public virtual int Departamento_Delete(string dep_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Delete", dep_codigoParameter);
        }
    
        public virtual int Departamento_Insert(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            var dep_nombreParameter = dep_nombre != null ?
                new ObjectParameter("dep_nombre", dep_nombre) :
                new ObjectParameter("dep_nombre", typeof(string));
    
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Insert", dep_codigoParameter, dep_nombreParameter, pai_codigoParameter);
        }
    
        public virtual ObjectResult<Departamento_List_Result> Departamento_List(string dep_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Departamento_List_Result>("Departamento_List", dep_codigoParameter);
        }
    
        public virtual int Departamento_Update(string dep_codigo, string dep_nombre, string pai_codigo)
        {
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            var dep_nombreParameter = dep_nombre != null ?
                new ObjectParameter("dep_nombre", dep_nombre) :
                new ObjectParameter("dep_nombre", typeof(string));
    
            var pai_codigoParameter = pai_codigo != null ?
                new ObjectParameter("pai_codigo", pai_codigo) :
                new ObjectParameter("pai_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Departamento_Update", dep_codigoParameter, dep_nombreParameter, pai_codigoParameter);
        }
    
        public virtual int Ciudad_Delete(string ciu_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Delete", ciu_codigoParameter);
        }
    
        public virtual int Ciudad_Insert(string ciu_codigo, string ciu_nombre, Nullable<bool> ciu_predeterminado, Nullable<double> ciu_longitud, Nullable<double> ciu_latitud, string dep_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var ciu_nombreParameter = ciu_nombre != null ?
                new ObjectParameter("ciu_nombre", ciu_nombre) :
                new ObjectParameter("ciu_nombre", typeof(string));
    
            var ciu_predeterminadoParameter = ciu_predeterminado.HasValue ?
                new ObjectParameter("ciu_predeterminado", ciu_predeterminado) :
                new ObjectParameter("ciu_predeterminado", typeof(bool));
    
            var ciu_longitudParameter = ciu_longitud.HasValue ?
                new ObjectParameter("ciu_longitud", ciu_longitud) :
                new ObjectParameter("ciu_longitud", typeof(double));
    
            var ciu_latitudParameter = ciu_latitud.HasValue ?
                new ObjectParameter("ciu_latitud", ciu_latitud) :
                new ObjectParameter("ciu_latitud", typeof(double));
    
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Insert", ciu_codigoParameter, ciu_nombreParameter, ciu_predeterminadoParameter, ciu_longitudParameter, ciu_latitudParameter, dep_codigoParameter);
        }
    
        public virtual ObjectResult<Ciudad_List_Result> Ciudad_List(string ciu_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ciudad_List_Result>("Ciudad_List", ciu_codigoParameter);
        }
    
        public virtual int Ciudad_Update(string ciu_codigo, string ciu_nombre, Nullable<bool> ciu_predeterminado, Nullable<double> ciu_longitud, Nullable<double> ciu_latitud, string dep_codigo)
        {
            var ciu_codigoParameter = ciu_codigo != null ?
                new ObjectParameter("ciu_codigo", ciu_codigo) :
                new ObjectParameter("ciu_codigo", typeof(string));
    
            var ciu_nombreParameter = ciu_nombre != null ?
                new ObjectParameter("ciu_nombre", ciu_nombre) :
                new ObjectParameter("ciu_nombre", typeof(string));
    
            var ciu_predeterminadoParameter = ciu_predeterminado.HasValue ?
                new ObjectParameter("ciu_predeterminado", ciu_predeterminado) :
                new ObjectParameter("ciu_predeterminado", typeof(bool));
    
            var ciu_longitudParameter = ciu_longitud.HasValue ?
                new ObjectParameter("ciu_longitud", ciu_longitud) :
                new ObjectParameter("ciu_longitud", typeof(double));
    
            var ciu_latitudParameter = ciu_latitud.HasValue ?
                new ObjectParameter("ciu_latitud", ciu_latitud) :
                new ObjectParameter("ciu_latitud", typeof(double));
    
            var dep_codigoParameter = dep_codigo != null ?
                new ObjectParameter("dep_codigo", dep_codigo) :
                new ObjectParameter("dep_codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Ciudad_Update", ciu_codigoParameter, ciu_nombreParameter, ciu_predeterminadoParameter, ciu_longitudParameter, ciu_latitudParameter, dep_codigoParameter);
        }
    }
}
