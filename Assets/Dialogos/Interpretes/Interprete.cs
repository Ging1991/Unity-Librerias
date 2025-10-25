using Ging1991.Dialogos.Persistencia;
using Ging1991.Interfaces;
using Ging1991.Relojes;
using UnityEngine;

namespace Ging1991.Dialogos.Interpretes {

	public abstract class Interprete<T> : MonoBehaviour, IEjecutable where T : IAccionEspecial {

		public TextoSecuencial textoSecuencial;
		public bool secuenciandoTexto;

		public void Ejecutar() {
			secuenciandoTexto = false;
		}

		public void InterpretarAccion(T accion) {
			AccionEstandar estandar = accion.GetAccionEstandar();
			if (estandar != null) {
				InterpretarAccionEstandar(estandar);
			}
			else {
				InterpretarAccionEspecial(accion);
			}
		}


		private void InterpretarAccionEstandar(AccionEstandar accion) {
			if (accion.tipo == "MOSTRAR_TEXTO") {
				textoSecuencial.SetTexto(accion.texto, accion: this);
				secuenciandoTexto = true;
			}
		}


		public abstract void InterpretarAccionEspecial(T accion);


		public void MostrarTextoCompleto() {
			textoSecuencial.MostrarTextoCompleto();
		}


	}

}