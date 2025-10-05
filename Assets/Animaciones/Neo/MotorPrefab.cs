using System.Collections.Generic;
using UnityEngine;

namespace Ging1991.Animaciones.Neo {

	public class MotorPrefab : MonoBehaviour {

		public List<AnimacionBase> animaciones;

		public void Animar() {
			if (animaciones == null || animaciones.Count == 0)
				return;

			foreach (var anim in animaciones) {
				if (anim == null)
					continue;
				anim.AnimacionDirecta();
			}
		}

	}
	
}