#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
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

namespace CapaDominio	
{
	public partial class Usuario
	{
		private int idUsuario;
		public virtual int IdUsuario
		{
			get
			{
				return this.idUsuario;
			}
			set
			{
				this.idUsuario = value;
			}
		}
		
		private string usuario1;
		public virtual string Usuario1
		{
			get
			{
				return this.usuario1;
			}
			set
			{
				this.usuario1 = value;
			}
		}
		
		private string password;
		public virtual string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}
		
		private int nivel;
		public virtual int Nivel
		{
			get
			{
				return this.nivel;
			}
			set
			{
				this.nivel = value;
			}
		}
		
	}
}
#pragma warning restore 1591
