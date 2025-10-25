using System.Collections.Generic;
using Ging1991.Dialogos.Interpretes;
using Ging1991.Dialogos.Persistencia;
using Ging1991.Relojes;
using UnityEngine;

namespace Ging1991.Dialogos {

	public abstract class Dialogo<T> : MonoBehaviour, IEjecutable where T : IAccionEspecial {

		public PantallaTactil pantallaTactil;
		public Interprete<T> interprete;
		private List<T> acciones;
		private int indice;

		public void Inicializar(List<T> acciones) {
			this.acciones = acciones;
			pantallaTactil.Inicializar(this);
			indice = 0;
		}

		public void Ejecutar() {
			if (interprete.secuenciandoTexto) {
				interprete.MostrarTextoCompleto();
			}
			else {
				if (acciones.Count > indice) {
					interprete.InterpretarAccion(acciones[indice]);
					indice++;
				}
			}
		}

	}

}