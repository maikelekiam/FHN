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
		
		private int? idClub;
		public virtual int? IdClub
		{
			get
			{
				return this.idClub;
			}
			set
			{
				this.idClub = value;
			}
		}
		
		private string domicilio;
		public virtual string Domicilio
		{
			get
			{
				return this.domicilio;
			}
			set
			{
				this.domicilio = value;
			}
		}
		
		private Club club;
		public virtual Club Club
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
		
	}
}
#pragma warning restore 1591
