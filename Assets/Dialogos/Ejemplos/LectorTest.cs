using Ging1991.Persistencia.Lectores;

namespace Ging1991.Dialogos.Persistencia {

	public class LectorTest<AccionTest> : LectorGenerico<GrupoAcciones<AccionTest>> {

		public LectorTest(string direccion) : base(direccion, TipoLector.RECURSOS) { }

	}

}