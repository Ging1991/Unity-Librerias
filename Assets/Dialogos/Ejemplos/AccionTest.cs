using System;
using Ging1991.Dialogos.Persistencia;

namespace Ging1991.Dialogos.Test {

	[Serializable]
	public class AccionTest : IAccionEspecial {

		public string tipo;
		public string texto;
		public string textoDebug;

		public AccionEstandar GetAccionEstandar() {
			AccionEstandar accion = new() {
				tipo = tipo,
				texto = texto
			};
			return accion;
		}

	}

}