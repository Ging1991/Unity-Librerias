using UnityEngine;

namespace Ging1991.Animaciones.Ejemplos {

	public class ControlEjemplo : MonoBehaviour {

		void Start() {
			GameObject.Find("Explosion").GetComponent<MotorPrefab>().Animar();
		}

	}

}