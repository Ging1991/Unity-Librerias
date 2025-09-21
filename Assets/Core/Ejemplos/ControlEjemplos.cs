using UnityEngine;

namespace Ging1991.Core.Ejemplos {

	public class ControlEjemplos : MonoBehaviour {

		void Start() {
			Estadisticas estadisticas = Estadisticas.Instancia;

			estadisticas.Incrementar("TURNOS");
			Debug.Log($"Turnos {estadisticas.GetValor("TURNOS")}");

			estadisticas.SetValor("CARTAS", 10);
			Debug.Log($"Cartas {estadisticas.GetValor("CARTAS")}");

			estadisticas.ModificarValor("CARTAS", -5);
			Debug.Log($"Cartas {estadisticas.GetValor("CARTAS")}");

			FisicaEjemplo fisicaEjemplo = FisicaEjemplo.Instancia;
			fisicaEjemplo.listador.AgregarElemento("triangulo", "3 angulos");
			Debug.Log($"Listador {fisicaEjemplo.listador.GetLista("3 angulos").Count}");

		}

	}

}