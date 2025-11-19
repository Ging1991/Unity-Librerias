using UnityEngine;

namespace Bounds.Cartas.Persistencia.Test {

	public class Controltest : MonoBehaviour {

		public DatosDeCartas datos;

		void Start() {
			datos.Inicializar();
			Debug.Log(datos.lector.LeerDatos(1).nombre);
			Debug.Log(DatosDeCartas.Instancia.lector.LeerDatos(11).nombre);
		}

	}

}