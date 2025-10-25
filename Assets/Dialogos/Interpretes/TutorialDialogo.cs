using Ging1991.Dialogos;
using Ging1991.Interfaces;
using Ging1991.Relojes;
using UnityEngine;

namespace Bounds.Tutorial {

	public class TutorialDialogo : MonoBehaviour, IEjecutable {

		public GameObject texto;
		public static TutorialDialogo instancia;
		public GameObject botonSiguiente;

		void Awake() {
			if (instancia == null)
				instancia = this;
		}

		public void mostrar(string contenido) {
			botonSiguiente.SetActive(false);
			texto.GetComponent<TextoSecuencial>().SetTexto(contenido, this);
		}

		public void Ejecutar() {
			botonSiguiente.SetActive(true);
		}

	}

}