using UnityEngine.SceneManagement;
using UnityEngine;
using Ging1991.Persistencia.Direcciones;
using Ging1991.Dialogos;
using Ging1991.Persistencia.Lectores.Demandas;
using System.Globalization;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Tutorial {

	public class TutorialControl : MonoBehaviour {
		/*
				private LectorDialogo lector;
				private ProveedorImagenPersonaje proveedorPersonaje;
				private ProveedorImagenPersonaje proveedorMiniatura;
				private Configuracion configuracion;
				public GameObject miniaturaOBJ;
				public GameObject personajeClaseOBJ;

				public GameObject cartaEjemplo1, cartaEjemplo2, cartaEjemplo3;
				public GameObject dialogoOBJ;
				public GameObject personajesOBJ;

				void Start() {
					configuracion = new Configuracion();
					lector = new LectorDialogo("TUTORIAL", configuracion.LeerCapituloLeccion());
					proveedorPersonaje = new ProveedorImagenPersonaje(new DireccionRecursos("PERSONAJES"));
					proveedorMiniatura = new ProveedorImagenPersonaje(new DireccionRecursos("MINIATURAS"));
					miniaturaOBJ.GetComponent<Miniatura>().Inicializar(proveedorMiniatura);
					cartaEjemplo1.GetComponent<CartaFisica>().ColocarBocaAbajo();
					cartaEjemplo2.GetComponent<CartaFisica>().ColocarBocaAbajo();
					cartaEjemplo3.GetComponent<CartaFisica>().ColocarBocaAbajo();
				}


				private void SetImagenCarta(string posicion, string cartaID) {
					if (posicion == "1") {
						cartaEjemplo1.GetComponent<CartaFisica>().ColocarBocaArriba();
						cartaEjemplo1.GetComponentInChildren<CartaFrente>().Inicializar(int.Parse(cartaID));
					}
					if (posicion == "2") {
						cartaEjemplo2.GetComponent<CartaFisica>().ColocarBocaArriba();
						cartaEjemplo2.GetComponentInChildren<CartaFrente>().Inicializar(int.Parse(cartaID));
					}
					if (posicion == "3") {
						cartaEjemplo3.GetComponent<CartaFisica>().ColocarBocaArriba();
						cartaEjemplo3.GetComponentInChildren<CartaFrente>().Inicializar(int.Parse(cartaID));
					}
				}


				void FixedUpdate() {
					if (Input.GetKeyUp(KeyCode.Space))
						BotonSiguiente();
				}


				public void BotonSiguiente() {

					string comando = lector.Siguiente();
					if (comando != null) {
						if (comando == "CREAR_PERSONAJE") {
							CrearPersonaje(lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_IMG") {
							SetImagen(lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_CARTA_IMG") {
							SetImagenCarta(lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_POSICION") {
							SetPosicion(lector.Siguiente(), lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_MINIATURA") {
							SetMiniatura(lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "SET_PERSONAJE_ESCALA") {
							SetEscala(lector.Siguiente(), lector.Siguiente());
							BotonSiguiente();
							return;
						}

						if (comando == "DUELO") {
							JugarDuelo(lector.Siguiente(), lector.Siguiente(), lector.Siguiente(), lector.Siguiente(),
									lector.Siguiente(), lector.Siguiente(), lector.Siguiente(), lector.Siguiente());
						}

						if (comando == "FINAL") {
							configuracion.GuardarCapituloHistoria(1);
							ControlEscena.GetInstancia().CambiarEscena_menu();
						}

						dialogoOBJ.GetComponent<Dialogo>().textoOBJ.SetTexto(comando);
					}
				}


				public void IrMenu() {
					SceneManager.LoadScene("Menu");
				}


				public void IrVideo() {
					string videoId = "RI69hhCVYIc";
					Application.OpenURL("https://www.youtube.com/watch?v=" + videoId);
				}


				public void SaltarLeccion() {
					configuracion.GuardarCapituloLeccion(configuracion.LeerCapituloLeccion() + 1);
					SceneManager.LoadScene("TUTORIAL");
				}


				private void CrearPersonaje(string nombre) {
					GameObject instancia = Instantiate(personajeClaseOBJ);
					instancia.name = nombre;
					instancia.transform.SetParent(personajesOBJ.transform);
					instancia.transform.localPosition = new Vector3(0, 0, 0);
					instancia.transform.localScale = new Vector3(1, 1, 1);
					instancia.GetComponent<Ging1991.Dialogos.Personaje>().Inicializar(proveedorPersonaje);
				}


				private void SetMiniatura(string nombre) {
					miniaturaOBJ.GetComponent<Miniatura>().SetImagen(nombre);
				}


				private void SetImagen(string nombre, string imagen) {
					TraerPersonaje(nombre).SetImagen(imagen);
				}


				private void SetPosicion(string nombre, string posX, string posY) {
					TraerPersonaje(nombre).SetPosicion(int.Parse(posX), int.Parse(posY));
				}


				private Ging1991.Dialogos.Personaje TraerPersonaje(string nombre) {
					return GameObject.Find(nombre).GetComponent<Ging1991.Dialogos.Personaje>();
				}


				private void SetEscala(string nombre, string escala) {
					float escalaValor = float.Parse(escala, CultureInfo.InvariantCulture);
					TraerPersonaje(nombre).gameObject.transform.localScale = new Vector3(escalaValor, escalaValor, 1);
				}


				public void JugarDuelo(string nombre1, string miniatura1, string LP1, string nombreMazo1,
						string nombre2, string miniatura2, string LP2, string nombreMazo2) {

					GlobalDuelo parametros = GlobalDuelo.GetInstancia();
					parametros.modo = "TUTORIAL";
					parametros.dueloModo = DueloConstantes.Modo.TUTORIAL;
					parametros.jugadorLP1 = int.Parse(LP1);
					parametros.jugadorLP2 = int.Parse(LP2);
					parametros.jugadorNombre1 = nombre1;
					parametros.jugadorNombre2 = nombre2;
					parametros.jugadorMiniatura1 = miniatura1;
					parametros.jugadorMiniatura2 = miniatura2;

					Global.Mazo mazo1 = new MazoTutorial(nombreMazo1);
					Global.Mazo mazo2 = new MazoTutorial(nombreMazo2);

					parametros.mazo1 = mazo1.cartas;
					parametros.mazo2 = mazo2.cartas;
					parametros.mazoVacio1 = mazo1.principalVacio;
					parametros.mazoVacio2 = mazo2.principalVacio;
					parametros.protector1 = mazo1.protector;
					parametros.protector2 = mazo2.protector;

					ControlEscena escena = ControlEscena.GetInstancia();
					escena.CambiarEscena_duelo();
				}


				private class ProveedorImagenPersonaje : LectorPorDemandaImagen, IProveedorImagen {

					public ProveedorImagenPersonaje(Direccion direccionCarpeta) : base(direccionCarpeta, TipoLector.RECURSOS) { }

					public Sprite GetImagen(string nombre) {
						return Leer(nombre);
					}

				}

		*/
	}

}