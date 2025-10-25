using Ging1991.Persistencia.Lectores;

namespace Ging1991.Dialogos.Persistencia {

	public class LectorAcciones<T> : LectorGenerico<GrupoAcciones<T>> where T : AccionEstandar {

		public LectorAcciones(string direccion) : base(direccion, TipoLector.RECURSOS) { }

	}

}