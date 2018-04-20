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
	public partial class Club
	{
		private int idClub;
		public virtual int IdClub
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
		
		private string nombreInstitucional;
		public virtual string NombreInstitucional
		{
			get
			{
				return this.nombreInstitucional;
			}
			set
			{
				this.nombreInstitucional = value;
			}
		}
		
		private string personeriaJuridica;
		public virtual string PersoneriaJuridica
		{
			get
			{
				return this.personeriaJuridica;
			}
			set
			{
				this.personeriaJuridica = value;
			}
		}
		
		private string anioAfiliacion;
		public virtual string AnioAfiliacion
		{
			get
			{
				return this.anioAfiliacion;
			}
			set
			{
				this.anioAfiliacion = value;
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
		
		private string idInterno;
		public virtual string IdInterno
		{
			get
			{
				return this.idInterno;
			}
			set
			{
				this.idInterno = value;
			}
		}
		
		private string telefonoSede;
		public virtual string TelefonoSede
		{
			get
			{
				return this.telefonoSede;
			}
			set
			{
				this.telefonoSede = value;
			}
		}
		
		private string telefonoCampoJuego;
		public virtual string TelefonoCampoJuego
		{
			get
			{
				return this.telefonoCampoJuego;
			}
			set
			{
				this.telefonoCampoJuego = value;
			}
		}
		
		private string numeroCuil;
		public virtual string NumeroCuil
		{
			get
			{
				return this.numeroCuil;
			}
			set
			{
				this.numeroCuil = value;
			}
		}
		
		private string emailCampoJuego;
		public virtual string EmailCampoJuego
		{
			get
			{
				return this.emailCampoJuego;
			}
			set
			{
				this.emailCampoJuego = value;
			}
		}
		
		private string emailAlternativo;
		public virtual string EmailAlternativo
		{
			get
			{
				return this.emailAlternativo;
			}
			set
			{
				this.emailAlternativo = value;
			}
		}
		
		private string domicilioSede;
		public virtual string DomicilioSede
		{
			get
			{
				return this.domicilioSede;
			}
			set
			{
				this.domicilioSede = value;
			}
		}
		
		private string domicilioCampoJuego;
		public virtual string DomicilioCampoJuego
		{
			get
			{
				return this.domicilioCampoJuego;
			}
			set
			{
				this.domicilioCampoJuego = value;
			}
		}
		
		private string coloresOficiales;
		public virtual string ColoresOficiales
		{
			get
			{
				return this.coloresOficiales;
			}
			set
			{
				this.coloresOficiales = value;
			}
		}
		
		private string coloresAlternativos;
		public virtual string ColoresAlternativos
		{
			get
			{
				return this.coloresAlternativos;
			}
			set
			{
				this.coloresAlternativos = value;
			}
		}
		
		private string nombreCorto;
		public virtual string NombreCorto
		{
			get
			{
				return this.nombreCorto;
			}
			set
			{
				this.nombreCorto = value;
			}
		}
		
		private IList<Jugador> jugadors = new List<Jugador>();
		public virtual IList<Jugador> Jugadors
		{
			get
			{
				return this.jugadors;
			}
		}
		
	}
}
#pragma warning restore 1591
