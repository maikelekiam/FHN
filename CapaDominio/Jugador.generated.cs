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
using CapaDominio;

namespace CapaDominio	
{
	public partial class Jugador
	{
		private int idJugador;
		public virtual int IdJugador
		{
			get
			{
				return this.idJugador;
			}
			set
			{
				this.idJugador = value;
			}
		}
		
		private string nombre;
		public virtual string Nombre
		{
			get
			{
				return this.nombre;
			}
			set
			{
				this.nombre = value;
			}
		}
		
		private string apellido;
		public virtual string Apellido
		{
			get
			{
				return this.apellido;
			}
			set
			{
				this.apellido = value;
			}
		}
		
		private DateTime? fechaNacimiento;
		public virtual DateTime? FechaNacimiento
		{
			get
			{
				return this.fechaNacimiento;
			}
			set
			{
				this.fechaNacimiento = value;
			}
		}
		
		private string tipo;
		public virtual string Tipo
		{
			get
			{
				return this.tipo;
			}
			set
			{
				this.tipo = value;
			}
		}
		
		private string telefono;
		public virtual string Telefono
		{
			get
			{
				return this.telefono;
			}
			set
			{
				this.telefono = value;
			}
		}
		
		private string sector;
		public virtual string Sector
		{
			get
			{
				return this.sector;
			}
			set
			{
				this.sector = value;
			}
		}
		
		private string ficha;
		public virtual string Ficha
		{
			get
			{
				return this.ficha;
			}
			set
			{
				this.ficha = value;
			}
		}
		
		private string email;
		public virtual string Email
		{
			get
			{
				return this.email;
			}
			set
			{
				this.email = value;
			}
		}
		
		private string documento;
		public virtual string Documento
		{
			get
			{
				return this.documento;
			}
			set
			{
				this.documento = value;
			}
		}
		
		private int? club;
		public virtual int? Club
		{
			get
			{
				return this.club;
			}
			set
			{
				this.club = value;
			}
		}
		
		private string celular;
		public virtual string Celular
		{
			get
			{
				return this.celular;
			}
			set
			{
				this.celular = value;
			}
		}
		
		private Club club1;
		public virtual Club Club1
		{
			get
			{
				return this.club1;
			}
			set
			{
				this.club1 = value;
			}
		}
		
	}
}
#pragma warning restore 1591
