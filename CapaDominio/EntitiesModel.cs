﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using CapaDominio;

namespace CapaDominio	
{
	public partial class ModeloDeDominio : OpenAccessContext, IModeloDeDominioUnitOfWork
	{
		private static string connectionStringName = @"Conn";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");
		
		public ModeloDeDominio()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public ModeloDeDominio(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public ModeloDeDominio(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public ModeloDeDominio(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public ModeloDeDominio(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Jugador> Jugadors 
		{
			get
			{
				return this.GetAll<Jugador>();
			}
		}
		
		public IQueryable<Club> Clubs 
		{
			get
			{
				return this.GetAll<Club>();
			}
		}
		
		public IQueryable<Usuario> Usuarios 
		{
			get
			{
				return this.GetAll<Usuario>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MsSql";
			backend.ProviderName = "System.Data.SqlClient";
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of ModeloDeDominio.
		/// </summary>
		/// <param name="config">The BackendConfiguration of ModeloDeDominio.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IModeloDeDominioUnitOfWork : IUnitOfWork
	{
		IQueryable<Jugador> Jugadors
		{
			get;
		}
		IQueryable<Club> Clubs
		{
			get;
		}
		IQueryable<Usuario> Usuarios
		{
			get;
		}
	}
}
#pragma warning restore 1591
