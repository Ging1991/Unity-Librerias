using System.Collections.Generic;
using Ging1991.Dialogos;
using Ging1991.Dialogos.Persistencia;
using Ging1991.Dialogos.Test;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Ging1991.Persistencia.Tests {

	public class ControlTest : MonoBehaviour {

		public Dialogo<AccionTest> dialogo;

		void Start() {
			string direccion = new DireccionRecursos("datos", "dialogo").Generar();
			LectorTest<AccionTest> lector = new LectorTest<AccionTest>(direccion);
			GrupoAcciones<AccionTest> grupo = lector.Leer();
			List<IAccionEspecial> lista = new List<IAccionEspecial>();
			foreach (var accion in grupo.lista) {
				lista.Add(accion);
			}
			dialogo.Inicializar(grupo.lista);
		}

		public class Imaginador : IGetImagen {
			public Sprite GetImagen(string nombre) {
				return null;
			}
		}

	}
}