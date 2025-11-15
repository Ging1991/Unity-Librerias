using UnityEngine;

namespace Ging1991.Idiomas.Test {

	public class IdiomaTest : MonoBehaviour {

		public IdiomaFactory idiomaFactory;

		void Start() {
			Debug.Log(idiomaFactory.GetIdiomaClases().GetTraduccion("HECHIZO"));
			Debug.Log(idiomaFactory.GetIdiomaPerfecciones().GetTraduccion("EVOLUCION"));
			Debug.Log(idiomaFactory.GetIdiomaTipos().GetTraduccion("PLANTA"));
			Debug.Log(idiomaFactory.GetIdiomaClases().GetTraduccion("HECHIZO1"));
		}
	}

}