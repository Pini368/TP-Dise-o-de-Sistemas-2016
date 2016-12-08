﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEntidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TPDiseñoEntities : DbContext
    {
        public TPDiseñoEntities()
            : base("name=TPDiseñoEntities")
        {
        }
    
        public virtual DbSet<Bloque> Bloque { get; set; }
        public virtual DbSet<Candidato> Candidato { get; set; }
        public virtual DbSet<Competencia> Competencia { get; set; }
        public virtual DbSet<Consultor> Consultor { get; set; }
        public virtual DbSet<Cuestionario> Cuestionario { get; set; }
        public virtual DbSet<Estado_Cuestionario> Estado_Cuestionario { get; set; }
        public virtual DbSet<Evaluacion> Evaluacion { get; set; }
        public virtual DbSet<Factor> Factor { get; set; }
        public virtual DbSet<ItemBloque> ItemBloque { get; set; }
        public virtual DbSet<LDAP> LDAP { get; set; }
        public virtual DbSet<LogProcesos> LogProcesos { get; set; }
        public virtual DbSet<OpcionRespuesta> OpcionRespuesta { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<Puesto> Puesto { get; set; }
        public virtual DbSet<Puntaje_Requerido> Puntaje_Requerido { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<TablaDeParametros> TablaDeParametros { get; set; }
        public virtual DbSet<ValorRespuesta> ValorRespuesta { get; set; }
    
        public virtual ObjectResult<Nullable<int>> spObtenerUltimoIDPuestoCN(Nullable<int> codigoPuesto, string nombre)
        {
            var codigoPuestoParameter = codigoPuesto.HasValue ?
                new ObjectParameter("codigoPuesto", codigoPuesto) :
                new ObjectParameter("codigoPuesto", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spObtenerUltimoIDPuestoCN", codigoPuestoParameter, nombreParameter);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CDatos.EvaluacionMap());

            modelBuilder.Configurations.Add(new CDatos.CandidatoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
