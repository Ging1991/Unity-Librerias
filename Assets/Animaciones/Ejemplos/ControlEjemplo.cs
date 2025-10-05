using Ging1991.Animaciones.Neo;
using UnityEngine;

public class ControlEjemplo : MonoBehaviour {

	void Start() {
		GameObject.Find("Explosion").GetComponent<MotorPrefab>().Animar();
	}

}